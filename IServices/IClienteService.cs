using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public interface IClienteService
    {
        Task<List<Cliente>> ObtenerClientes();
        //Task<List<Cliente>> ObtenerClixEmp();
        Task<Cliente> RegistrarCliente(Cliente cliente);
        Task<Cliente> ActualizarCliente(Cliente cliente);
    }
}
