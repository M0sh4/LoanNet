using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _pagoService;
        public PagoController(IPagoService pagoService)
        {
            _pagoService = pagoService;
        }
        [HttpPost]
        public ActionResult RegistrarPago(Pago pago)
        {
            Pago resPago = _pagoService.RegistrarPago(pago).Result;
            if (resPago.nIdPrestamo != 0)
            {
                return Ok(resPago);
            }
            else
            {
                return BadRequest("El prestamo no ha sido encontrado.");
            }
        }
        [HttpPut]
        public ActionResult ActualizarPago(Pago pago)
        {
            return Ok(_pagoService.ActualizarPago(pago));
        }
        [HttpGet]
        public ActionResult ObtenerPagosxPrestamo(int nIdPrestamo)
        {
            return Ok(_pagoService.ObtenerPagosxPrestamo(nIdPrestamo));
        }
        [HttpPost]
        public ActionResult EliminarLogPago(int nId)
        {
            _pagoService.EliminarLogPago(nId);
            return Ok();
        }

    }
}
