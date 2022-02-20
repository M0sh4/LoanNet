using System;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class Empleado
    {
        public int nIdUsu { get; set; }
        [Key]
        [StringLength(8)]
        public string cDni { get; set; }
        public string cNombre { get; set; }
        public string cApellidos { get; set; }
        public String cRuc { get; set; }
        public Empresa empresa { get; set; }
        public string cFoto { get; set; }
        [StringLength(9)]
        public string cTelefono { get; set; }
        public Boolean bEstado { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Usuario usuario { get; set; }
    }
}
