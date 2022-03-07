using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecomendadoController : ControllerBase
    {
        private readonly IRecomendadoService _recomendadoService;
        public RecomendadoController(IRecomendadoService recomendadoService)
        {
            _recomendadoService = recomendadoService;
        }
        [HttpPost]
        public ActionResult RegistrarRecomendado(Recomendado recomendado)
        {
            return Ok(_recomendadoService.RegistrarRecomendado(recomendado));
        }
        [HttpPost]
        public ActionResult ActualizarRecomendado(Recomendado recomendado)
        {
            return Ok(_recomendadoService.ActualizarRecomendado(recomendado));
        }
        [HttpGet]
        public ActionResult ObtenerRecomendadosxRuc(string cRuc)
        {
            return Ok(_recomendadoService.ObtenerRecomendadosxRuc(cRuc));
        }
        [HttpPost]
        public ActionResult EliminarLogRecomendado(int nId)
        {
            _recomendadoService.EliminarLogRecomendado(nId);
            return Ok();
        }
    }
}
