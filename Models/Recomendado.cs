using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class Recomendado
    {
        [Key]
        public int nId { get; set; }
        public string cDni { get; set; }
        public string cDniRec { get; set; }
        public string cRuc { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Boolean bEstado { get; set; }
        public Cliente cliente { get; set; }
        public Cliente clienteRec { get; set; }
        public Empresa empresa { get; set; }
    }
}
