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
            return Ok(_listaNegraService.RegistrarListaNegra(listaNegra));
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
        [HttpDelete]
        public ActionResult EliminarListaNegra(int nId)
        {
            _listaNegraService.EliminarListaNegra(nId);
            return Ok();
        }
    }
}
