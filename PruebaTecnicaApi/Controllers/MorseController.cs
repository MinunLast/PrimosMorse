using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaApi.Contratos.Request;
using PruebaTecnicaApi.Contratos.Responses;
using PruebaTecnicaServices.Interfaz;

namespace PruebaTecnicaApi.Controllers
{
    /// <summary>
    /// CONTIENE LOS METODOS PostDecodificado Y PostCodificado UTILIZADOS EN EL FORMCODIGOMORSE, RECIBEN COMO PARAMETRO LO QUE SE LE INGRESA AL FORM, 
    /// CONSULTA CON LOS SERIVCIOS Y RETORNAN EL RESULTADO
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class MorseController : ControllerBase
    {
        private readonly IMorse _MorseServices;
        public MorseController(IMorse morseServicies)
        {
            _MorseServices = morseServicies;
        }
        /// <summary>
        /// LLAMA AL METODO DECODIFICARMORSE EN SERVICIOS
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("decodificado")]
        public IActionResult PostDecodificado(MorseDecodificadoRequest request)
        {
            var result = _MorseServices.DecodificarMorse(request.TextoCodificado);
            return Ok(new MorseDecodificadoResponses { TextoDecodificado = result});
        }
        /// <summary>
        /// LLAMA AL METODO CODIFICARMORSE EN SERVICIOS
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("codificar")]
        public IActionResult PostCodificado(MorseCodificadoRequest request)
        {
            var result = _MorseServices.CodificarAMorse(request.TextoDecodificado);
            return Ok(new MorseCodificadoResponses { TextoCodificado = result });
        }
    }
}
