using System;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class Documento
    {
        [Key]
        public int nId { get; set; }
        public string cDni { get; set; }
        public string cRuc { get; set; }
        public string cNombre { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Boolean bEstado { get; set; }
        public Cliente cliente { get; set; }
        public Empresa empresa { get; set; }
    }
}
