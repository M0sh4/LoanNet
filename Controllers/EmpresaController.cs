using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        [HttpPost]
        public ActionResult RegistrarEmpresa(Empresa empresa)
        {
            return Ok(_empresaService.RegistrarEmpresa(empresa));
        }
        [HttpPost]
        public ActionResult ActualizarEmpresa(Empresa empresa)
        {
            return Ok(_empresaService.ActualizarEmpresa(empresa));
        }
        [HttpGet]
        public ActionResult ObtenerEmpresas()
        {
            return Ok(_empresaService.ObtenerEmpresas());
        }
        [HttpGet]
        public ActionResult ObtenerEmpresaxId(int id)
        {
            return Ok(_empresaService.ObtenerEmpresaxId(id));
        }
        [HttpGet]
        public ActionResult ObtenerClientesxEmpresa(string cRuc)
        {
            return Ok(_empresaService.ObtenerClientesxEmpresa(cRuc));
        }
    }
}
