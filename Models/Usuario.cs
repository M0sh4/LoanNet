using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class Usuario
    {
        [Key]
        public int nId { get; set; }
        public string cUsuario { get; set; }
        public string cContrasena { get; set; }
        public string cTipoUsuario { get; set; }
        public List<Cliente> clientes { get; set; }
        public List<Empleado> empleados { get; set; }
        public List<Empresa> empresas { get; set; }
    }
}
