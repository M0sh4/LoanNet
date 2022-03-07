using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PrestamoController : ControllerBase
    {
        private readonly IPrestamoService _prestamoService;
        public PrestamoController(IPrestamoService prestamoService)
        {
            _prestamoService = prestamoService;
        }
        [HttpPost]
        public ActionResult RegistrarPrestamo(Prestamo prestamo)
        {
            return Ok(_prestamoService.RegistrarPrestamo(prestamo));
        }
        [HttpPut]
        public ActionResult ActualizarPrestamo(Prestamo prestamo)
        {
            return Ok(_prestamoService.ActualizarPrestamo(prestamo));
        }
        [HttpGet]
        public ActionResult ObtenerPrestamosxRuc(string cRuc)
        {
            return Ok(_prestamoService.ObtenerPrestamosxRuc(cRuc));
        }
        [HttpGet]
        public ActionResult ObtenerPrestamoxDni(string cDni)
        {
            return Ok(_prestamoService.ObtenerPrestamoxDni(cDni));
        }
        [HttpGet]
        public ActionResult ObtenerPrestamoxRucxDni(string cRuc, string cDni)
        {
            return Ok(_prestamoService.ObtenerPrestamoxRucxDni(cRuc, cDni));
        }
        [HttpPost]
        public ActionResult EliminarLogPrestamo(int nId)
        {
            _prestamoService.EliminarLogPrestamo(nId);
            return Ok();
        }
    }
}
