using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IPagoService
    {
        Task<Pago> RegistrarPago(Pago pago);
        Task<Pago> ActualizarPago(Pago pago);
        Task<List<Pago>> ObtenerPagosxPrestamo(int nIdPrestamo);
        void EliminarLogPago(int nId);
    }
}
