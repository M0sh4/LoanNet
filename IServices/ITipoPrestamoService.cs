using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface ITipoPrestamoService
    {
        Task<TipoPrestamo> RegistrarTipoPrestamo(TipoPrestamo tipoPrestamo);
        Task<TipoPrestamo> ActualizarTipoPrestamo(TipoPrestamo tipoPrestamo);
        Task<List<TipoPrestamo>> ObtenerTipoPrestamoxRuc(string cRuc);
        void EliminarLogTipoPrestamo(string nId);

    }
}
