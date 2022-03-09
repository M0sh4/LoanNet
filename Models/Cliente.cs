using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoanNet.Models
{
    public class Cliente
    {
        public Usuario usuario { get; set; }
        public List<Prestamo> prestamos { get; set; }
        [InverseProperty(nameof(Documento.cliente))]
        public List<Documento> documentos { get; set; }
        [InverseProperty(nameof(Recomendado.cliente))]
        public List<Recomendado> recomendados { get; set; }
        [InverseProperty(nameof(Recomendado.clienteRec))]
        public List<Recomendado> recomendadosREC { get; set; }
        [InverseProperty(nameof(ListaNegra.cliente))]
        public List<ListaNegra> listasNegras { get; set; }
        public int nIdUsu { get; set; }
        [Key]
        [StringLength(8)]
        public string cDni { get; set; }
        public string cNombres { get; set; }
        public string cApellidos { get; set; }
        [StringLength(9)]
        public string cTelefono { get; set; }
        public string cDireccion { get; set; }
        public string cCorreo { get; set; }
        public string cFoto { get; set; }
        public DateTime dtFechaReg { get; set; }
    }
}
