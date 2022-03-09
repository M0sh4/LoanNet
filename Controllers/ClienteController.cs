using LoanNet.Models;
using LoanNet.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteService _clienteService;

        public ClienteController( IClienteService cliente)
        {
            _clienteService = cliente;
        }

        [HttpGet]
        public ActionResult ObtenerClientes()
        {
            return Ok(_clienteService.ObtenerClientes());
        }

        [HttpPost]
        public ActionResult RegistrarCliente(Cliente cliente)
        {
            Cliente resCliente = _clienteService.RegistrarCliente(cliente).Result;
            if (!resCliente.cDni.Equals("FOUND"))
            {
                return Ok(resCliente);
            }
            else
            {
                return StatusCode(StatusCodes.Status502BadGateway, "El cliente ya se encuentra registrado.") ;
            }
        }

        [HttpPost]
        public ActionResult ActualizarCliente(Cliente cliente)
        {
            Cliente resCliente = _clienteService.ActualizarCliente(cliente).Result;
            if (!resCliente.cDni.Equals("NOTFOUND"))
            {
                return Ok(resCliente);
            }
            else
            {
                return StatusCode(StatusCodes.Status502BadGateway, "No se ha encontrado al cliente.");
            }
        }
    }
}
