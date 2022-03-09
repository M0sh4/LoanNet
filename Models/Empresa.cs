using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Empresa
    {
        public int nIdUsu { get; set; }
        [Key]
        [StringLength(11)]
        public string cRuc { get; set; }
        public string cNombre { get; set; }
        public string cRazonSocial { get; set; }
        [StringLength(9)]
        public string cTelefono { get; set; }
        public string cFoto { get; set; }
        public DateTime dtFechaReg { get; set; }
        public List<Empleado> empleados { get; set; }
        public List<TipoPrestamo> tiposPrestamos { get; set; }
        public Usuario usuario { get; set; }
        [InverseProperty(nameof(Documento.empresa))]
        public List<Documento> documentos { get; set; }
        [InverseProperty(nameof(Recomendado.empresa))]
        public List<Recomendado> recomendados { get; set; }
        [InverseProperty(nameof(ListaNegra.empresa))]
        public List<ListaNegra> listasNegras { get; set; }
    }
}
