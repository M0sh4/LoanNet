using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IPrestamoService
    {
        Task<Prestamo> RegistrarPrestamo(Prestamo prestamo);
        Task<Prestamo> ActualizarPrestamo(Prestamo prestamo);
        Task<List<Prestamo>> ObtenerPrestamosxRuc(string cRuc);
        Task<List<Prestamo>> ObtenerPrestamoxDni(string cDni);
        Task<List<Prestamo>> ObtenerPrestamoxRucxDni(string cRuc, string cDni);
        void EliminarLogPrestamo(int nId);
    }
}
