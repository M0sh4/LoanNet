using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Documento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nId { get; set; }
        [ForeignKey(nameof(cliente)), Column(Order = 0)]
        public string cDni { get; set; }
        [ForeignKey(nameof(empresa)), Column(Order = 0)]
        public string cRuc { get; set; }
        public string cNombre { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Cliente cliente { get; set; }
        public Empresa empresa { get; set; }
    }
}
