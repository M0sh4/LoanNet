using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Prestamo
    {
       [Key]
       public int nId { get; set; }
       public string cDni { get; set; }
       public string cRuc { get; set; }
       public double nMonto { get; set; }
       public DateTime dtFechaIni { get; set; }
       public DateTime dtFechaFin { get; set; }
       public Boolean cEstado { get; set; }
       public int nIdTipoPrestamo { get; set; }
       public Cliente cliente { get; set; }
       public TipoPrestamo tipoPrestamo { get; set; }
       public List<Pago> pagos { get; set; }
    }
}
