using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoanNet.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DocumentoController : ControllerBase
    {
        private readonly IDocumentoService _documentoService;
        public DocumentoController(IDocumentoService documentoService)
        {
            _documentoService = documentoService;
        }
        [HttpPost]
        public ActionResult RegistrarDocumento(Documento documento)
        {
            return Ok(_documentoService.RegistrarDocumento(documento));
        }
        [HttpPost]
        public ActionResult ActualizarDocumento(Documento documento)
        {
            return Ok(_documentoService.ActualizarDocumento(documento));
        }
        [HttpDelete]
        public ActionResult EliminarDocumento(int nId)
        {
            _documentoService.EliminarDocumento(nId);
            return Ok();
        }
        [HttpGet]
        public ActionResult ObtenerDocumentosxRuc(string cRuc)
        {
            return Ok(_documentoService.ObtenerDocumentosxRuc(cRuc));
        }
        [HttpGet]
        public ActionResult ObtenerDocumentosxRucxDni(string cRuc, string cDni)
        {
            return Ok(_documentoService.ObtenerDocumentosxRucxDni(cRuc,cDni));
        }
    }
}
