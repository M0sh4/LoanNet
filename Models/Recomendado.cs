using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Recomendado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int nId { get; set; }
        public string cDni { get; set; }
        public string cDniRec { get; set; }
        public string cRuc { get; set; }
        public DateTime dtFechaReg { get; set; }
        public Boolean bEstado { get; set; }
        [ForeignKey(nameof(Cliente.recomendados)), Column(Order = 0)]
        public Cliente cliente { get; set; }
        [ForeignKey(nameof(Cliente.recomendadosREC)), Column(Order = 1)]
        public Cliente clienteRec { get; set; }
        [ForeignKey(nameof(Empresa.recomendados)), Column(Order = 2)]
        public Empresa empresa { get; set; }
    }
}
