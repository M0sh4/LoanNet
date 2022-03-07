using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IEmpresaService
    {
        Task<Empresa> RegistrarEmpresa(Empresa empresa);
        Task<Empresa> ActualizarEmpresa(Empresa empresa);
        Task<List<Empresa>> ObtenerEmpresas();
        Task<Empresa> ObtenerEmpresaxId(int id);
    }
}
