using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TipoPrestamoController : ControllerBase
    {
        private readonly ITipoPrestamoService _tipoPrestamoService;
        public TipoPrestamoController(ITipoPrestamoService tipoPrestamoService)
        {
            _tipoPrestamoService = tipoPrestamoService;
        }
        [HttpPost]
        public ActionResult RegistrarTipoPrestamo(TipoPrestamo tipoPrestamo)
        {
            return Ok(_tipoPrestamoService.RegistrarTipoPrestamo(tipoPrestamo));
        }
        [HttpPut]
        public ActionResult ActualizarTipoPrestamo(TipoPrestamo tipoPrestamo)
        {
            return Ok(_tipoPrestamoService.ActualizarTipoPrestamo(tipoPrestamo));
        }
        [HttpGet]
        public ActionResult ObtenerTipoPrestamoxRuc(string cRuc)
        {
            return Ok(_tipoPrestamoService.ObtenerTipoPrestamoxRuc(cRuc));
        }
        [HttpPost]
        public ActionResult EliminarLogTipoPrestamo(string nId)
        {
            _tipoPrestamoService.EliminarLogTipoPrestamo(nId);
            return Ok();
        }
    }
}
