using LoanNet.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LoanNet.IServices
{
    public interface IDocumentoService
    {
        Task<Documento> RegistrarDocumento(Documento documento);
        Task<Documento> ActualizarDocumento(Documento documento);
        void EliminarDocumento(int nId);
        Task<List<Documento>> ObtenerDocumentosxRuc(string cRuc);
        Task<List<Documento>> ObtenerDocumentosxRucxDni(string cRuc, string cDni);

    }
}
