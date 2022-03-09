using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class ListaNegra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nId { get; set; }
        public string cDni { get; set; }
        public string cRuc { get; set; }
        public string cRazon { get; set; }
        public DateTime dtFechaReg { get; set; }
        public bool bEstado { get; set; }
        [ForeignKey(nameof(Cliente.listasNegras)), Column(Order = 0)]
        public Cliente cliente { get; set; }
        [ForeignKey(nameof(Empresa.listasNegras)), Column(Order = 1)]
        public Empresa empresa { get; set; }
    }
}
