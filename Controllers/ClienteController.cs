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
            return Ok(_clienteService.RegistrarCliente(cliente));
        }

        [HttpPost]
        public ActionResult ActualizarCliente(Cliente cliente)
        {
            return Ok(_clienteService.ActualizarCliente(cliente));
        }
    }
}
