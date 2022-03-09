using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoService _empleadoService;
        public EmpleadoController(IEmpleadoService empleadoService)
        {
            _empleadoService = empleadoService;
        }
        [HttpPost]
        public ActionResult RegistrarEmpleado(Empleado empleado)
        {
            Empleado emp = _empleadoService.RegistrarEmpleado(empleado).Result;
            if (emp.cRuc != "FOUND")
            {
                return Ok(emp);
            }
            else
            {
                return BadRequest("El empleado ya se encuentra registrado.");
            }
        }
        [HttpPost]
        public ActionResult ActualizarEmpleado(Empleado empleado)
        {
            Empleado emp = _empleadoService.ActualizarEmpleado(empleado).Result;
            if (emp.cRuc != "NOTFOUND")
            {
                return Ok(emp);
            }
            else
            {
                return BadRequest("No se ha encontrado al empleado.");
            }
        }
        [HttpGet]
        public ActionResult ObtenerEmpleadosxRuc(string cRuc)
        {
            return Ok(_empleadoService.ObtenerEmpleadosxRuc(cRuc));
        }
        [HttpPost]
        public ActionResult EliminarEmpleado(string cDni)
        {
            _empleadoService.EliminarEmpleado(cDni);
            return Ok();
        }
        [HttpPost]
        public ActionResult EliminarLogEmpleado(string cDni)
        {
            _empleadoService.EliminarLogEmpleado(cDni);
            return Ok();
        }
    }
}
