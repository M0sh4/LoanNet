using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Pago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nId { get; set; }
        public int nIdPrestamo { get; set; }
        public double nMonto { get; set; }
        public DateTime dtFecha { get; set; }
        public Boolean bEstado { get; set; }
        public Prestamo prestamo { get; set; }

    }
}
