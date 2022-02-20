using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class ListaNegra
    {
        [Key]
        public int nId { get; set; }
        public string cDni { get; set; }
        public string cRuc { get; set; }
        public string cRazon { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Cliente cliente { get; set; }
        public Empresa empresa { get; set; }
    }
}
