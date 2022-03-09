using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ListaNegraController : ControllerBase
    {
        private readonly IListaNegraService _listaNegraService;
        public ListaNegraController(IListaNegraService listaNegraService)
        {
            _listaNegraService = listaNegraService;
        }
        [HttpPost]
        public ActionResult RegistrarListaNegra(ListaNegra listaNegra)
        {
            ListaNegra ln = _listaNegraService.RegistrarListaNegra(listaNegra).Result;
            if (!ln.cDni.Equals("FOUND"))
            {
                return Ok(ln);
            }
            else
            {
                return BadRequest("El cliente ya se encuentra en la lista negra.");
            }
        }
        [HttpPost]
        public ActionResult ActualizarListaNegra(ListaNegra listaNegra)
        {
            return Ok(_listaNegraService.ActualizarListaNegra(listaNegra));
        }
        [HttpGet]
        public ActionResult ObtenerListaNegraxRuc(string cRuc)
        {
            return Ok(_listaNegraService.ObtenerListaNegraxRuc(cRuc));
        }
        [HttpPost]
        public ActionResult EliminarLogListaNegra(int nId)
        {
            _listaNegraService.EliminarLogListaNegra(nId);
            return Ok();
        }
    }
}
