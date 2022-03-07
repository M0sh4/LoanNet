using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IRecomendadoService
    {
        Task<Recomendado> RegistrarRecomendado(Recomendado recomendado);
        Task<Recomendado> ActualizarRecomendado(Recomendado recomendado);
        Task<List<Recomendado>> ObtenerRecomendadosxRuc(string cRuc);
        void EliminarLogRecomendado(int nId);
    }
}
