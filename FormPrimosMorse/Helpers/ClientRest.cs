using Newtonsoft.Json;
using System;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace FormPrimosMorse.Helpers
{
    /// <summary>
    /// CLASE QUE CONTIENE FUNCIONALIDADES PARA CONECTAR A SERIVICIOS API REST QUE PERMITEN REALIZAR 
    /// SOLICITUDES HTTP, MANEJAR ERRORES DE CONEXION Y SEREALIZAR/DESERIALIZAR OBJETOS JSON 
    /// </summary>
    public sealed class ClientRest
    {
        private static readonly int TimeOut;
        private static readonly int TotalAttempts;

        private static readonly HttpClient ClienteBackend = null;

        private readonly HttpClient Cliente = null;

        private static readonly Newtonsoft.Json.JsonSerializer Serializer = new JsonSerializer();
        /// <summary>
        /// INICIALIZA LOS VALORES TIMEOUT, TOTALATTEMPTS Y CREA LA INSTANCIA HTTPCLIENT (link para conectar la api)
        /// </summary>
        static ClientRest()
        {
            if (!int.TryParse(SettingClassHelper.Value("timeout"), out TimeOut))
            {
                TimeOut = 5;
            }

            if (!int.TryParse(SettingClassHelper.Value("maxAttempts"), out TotalAttempts))
            {
                TotalAttempts = 3;
            }

            ClienteBackend = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7014"),
                Timeout = TimeSpan.FromMinutes(3)
            };
        }
        /// <summary>
        /// INICIALIZA UNA INSTANCIA CLIENTREST CON EL CLIENTE HTTP PARA REALIZAR LA CONSULTA API DESEADA
        /// (se guarda la consulta de la api que se desea llamar)
        /// </summary>
        /// <param name="baseAPI"></param>
        public ClientRest(BaseAPI baseAPI)
        {
            switch (baseAPI)
            {
                case BaseAPI.Backend:
                    Cliente = ClienteBackend;
                    break;
            }
        }
        /// <summary>
        /// ENVIA UNA SOLICITUD HTTP AL SERVIDOR ESPECIFICADO EN URL USANDO EL METODO HTTP GUARDADO EN EL METHOD
        /// Y POROCESA LA RESPUESTA OBTENIDA DEL SERVIDOR
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="U"></typeparam>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T GetResponse<T, U>(HttpMethod method, string url, U obj)
        {
            var request = new HttpRequestMessage(method, url);

            request.Content = CreateHttpContent<U>(obj);

            HttpResponseMessage response = null;

            int currentRetry = 1;

            for (; ; )
            {
                try
                {
                    response = AsyncSupport.RunSync<HttpResponseMessage>(() => Cliente.SendAsync(request));

                    if (response.StatusCode == HttpStatusCode.BadRequest || response.StatusCode == HttpStatusCode.NotFound || response.StatusCode == HttpStatusCode.Unauthorized)
                    {
                        break;
                    }
                    response.EnsureSuccessStatusCode();
                    break;
                }
                catch (Exception)
                {
                    currentRetry++;
                    if (currentRetry > TotalAttempts)
                    {
                        throw;
                    }
                }
                Thread.Sleep(500);
            }

            response.EnsureSuccessStatusCode();

            using (Stream s = AsyncSupport.RunSync<Stream>(() => response.Content.ReadAsStreamAsync()))
            using (StreamReader sr = new StreamReader(s))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                return Serializer.Deserialize<T>(reader);
            }
        }

        /// <summary>
        /// SE ENCARGA DE TRANSFORMAR LOS DATOS EN FORMATO JSON
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="content"></param>
        /// <returns></returns>
        private HttpContent CreateHttpContent<T>(T content)
        {
            var json = JsonConvert.SerializeObject(content);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
    /// <summary>
    /// ENUMERADO
    /// </summary>
    public enum BaseAPI
    {
        Backend
    }
}


