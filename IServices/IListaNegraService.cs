using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IListaNegraService
    {
        Task<ListaNegra> RegistrarListaNegra(ListaNegra listaNegra);
        Task<ListaNegra> ActualizarListaNegra(ListaNegra listaNegra);
        Task<List<ListaNegra>> ObtenerListaNegraxRuc(string cRuc);
        void EliminarLogListaNegra(int nId);
    }
}
