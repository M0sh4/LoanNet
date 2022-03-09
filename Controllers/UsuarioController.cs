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
            Usuario usu = _usuarioService.RegistrarUsuario(usuario).Result;
            if (!usu.cUsuario.Equals("FOUND"))
            {
                return Ok(usu);
            }
            else
            {
                return BadRequest("El nombre de usuario ya ha sido registrado.");
            }
        }
        [HttpPost]
        public ActionResult ActualizarUsuario(Usuario usuario)
        {
            Usuario usu = _usuarioService.ActualizarUsuario(usuario).Result;
            if (!usu.cUsuario.Equals("FOUND"))
            {
                return Ok(usu);
            }
            else
            {
                return BadRequest("El nombre de usuario ya ha sido registrado.");
            }
        }
    }
}
