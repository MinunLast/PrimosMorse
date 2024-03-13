using Microsoft.Extensions.Configuration;
using System.IO;

namespace FormPrimosMorse.Helpers
{
    /// <summary>
    /// ACCEDE A LA CONFIGURACION DE LA APLICACION UTILIZANDO METODOS ESTATICOS (appsettings.json - variables del entrono)
    /// </summary>
    public static class SettingClassHelper
    {
        private static readonly IConfigurationRoot Configuration = null;
        /// <summary>
        /// CARGA LA CONFIGURACION DE LA APLICACION DESDE EL ARCHIVO APPSETTINGS Y LAS VARIABLES DEL ENTRONO
        /// COMBINANDOLAS EN UNA CONFIGURACION FINAL ALMACENADAS EN CONFIUGRACION
        /// </summary>
        static SettingClassHelper()
        {
            var builder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables();

            Configuration = builder.Build();
        }
        /// <summary>
        /// PROPORCIONA LA FORMA DE ACCEDER A VALORES ESPECIFICOS DE CONFIGURACION UTILIZANDO CLAVES
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string Value(string key)
        {
            return Configuration[key];
        }
        /// <summary>
        /// OBTIENE UNA CADENA DE CONEXION DE LA CONFIGURACION 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetConnectionString(string key)
        {
            return Configuration.GetConnectionString(key);
        }
    }
}