using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Cotizador.Api.Models;
using Cotizador.Api.DTO;
namespace Cotizador.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotizadorController : ControllerBase
    {
        [HttpPost]
        [Route("Cotizador")]
        public async Task<IActionResult> Calcular([FromBody] DatosCotizadorDTO cotizadordto)
        {
            if (cotizadordto.Monto>=200 && cotizadordto.Monto<=100000)
            {
                var interes = cotizadordto.Monto * 0.005 * cotizadordto.Plazo;
                var montorecibir = cotizadordto.Monto + interes;
                var cotizador = new CotizadorDTO
                {
                    Monto = cotizadordto.Monto,
                    Plazo = cotizadordto.Plazo,
                    TasaInteres = 0.005,
                    Periodo = "Diario",
                    Interes = interes,
                    MontoRecibir = montorecibir,
                    Msj = "No existe Error"
                };
                return StatusCode(StatusCodes.Status200OK, cotizador);
            }
            else
            {
                var cotizador = new CotizadorDTO
                {
                    Msj = "El monto ingresado es incorrecto"
                };
                return StatusCode(StatusCodes.Status200OK, cotizador);
            }
            
        }
       
       
    }
}
