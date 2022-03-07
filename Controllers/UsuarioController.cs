using LoanNet.Models;
using LoanNet.Services.UsuarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        [HttpGet]
        public ActionResult ObtenerUsuarioxId(int id)
        {
            return Ok(_usuarioService.ObtenerUsuarioxId(id));
        }
        [HttpPost]
        public ActionResult RegistrarUsuario(Usuario usuario)
        {
            return Ok(_usuarioService.RegistrarUsuario(usuario));
        }
        [HttpPost]
        public ActionResult ActualizarUsuario(Usuario usuario)
        {
            return Ok(_usuarioService.ActualizarUsuario(usuario));
        }
    }
}
