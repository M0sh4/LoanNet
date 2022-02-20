using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoanNet.Models
{
    public class TipoPrestamo
    {
        public int nPorcentaje { get; set; }
        public string cRuc { get; set; }
        [Key]
        public int nId { get; set; }
        public string cNombre { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Boolean bEstado { get; set; }
        public List<Prestamo> prestamos { get; set; }
        public Empresa empresa { get; set; }
    }
}
