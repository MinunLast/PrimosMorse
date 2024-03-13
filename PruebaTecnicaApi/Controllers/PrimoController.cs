using Microsoft.AspNetCore.Mvc;
using PruebaTecnicaApi.Contratos.Request;
using PruebaTecnicaApi.Contratos.Responses;
using PruebaTecnicaServices.Interfaz;

namespace PruebaTecnicaApi.Controllers
{
    /// <summary>
    /// CONTIENE LOS METODOS PostEsPrimo Y GetListaPrimos UTILIZADOS EN EL FORMNUMEROPRIMO, RECIBEN COMO PARAMETRO LO QUE SE LE INGRESA AL FORM, 
    /// CONSULTA CON LOS SERIVCIOS Y RETORNAN EL RESULTADO
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PrimoController : ControllerBase
    {
        private readonly IPrimo _PrimoServicies;

        public PrimoController(IPrimo primoServices)
        {
            _PrimoServicies = primoServices;
        }
        /// <summary>
        /// LLAMA AL METODO EsPrimo DE SERVICIOS
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("esprimo")]
        public IActionResult PostEsPrimo(EsPrimoRequest request) 
        {
            var result = _PrimoServicies.EsPrimo(request.Numero);
            return Ok(new EsPrimoResponses {EsPrimo=result});
        }
        /// <summary>
        /// LLAMA AL METODO CalcularNumerosPrimos DE SERVICIOS (no requiere parametro)
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("listaprimos")]
        public IActionResult GetListaPrimos()
        {
            var result = _PrimoServicies.CalcularNumerosPrimos();
            return Ok(new ListaPrimosResponses {Valores=result});
        }
    }
}
