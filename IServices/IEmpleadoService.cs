using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IEmpleadoService
    {
        Task<Empleado> RegistrarEmpleado(Empleado empleado);
        Task<Empleado> ActualizarEmpleado(Empleado empleado);
        Task<List<Empleado>> ObtenerEmpleadosxRuc(string cRuc);
        void EliminarEmpleado(string cDni);
        void EliminarLogEmpleado(string cDni);
    }
}
