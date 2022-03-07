using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class DocumentoService : IDocumentoService
    {
        private readonly MyDbContext _dbContext;
        public DocumentoService(MyDbContext dbContext){
            _dbContext = dbContext;
        }
        public async Task<Documento> ActualizarDocumento(Documento documento)
        {
            try
            {
                Documento resDoc = _dbContext.Documentos.Update(documento).Entity;
                await _dbContext.SaveChangesAsync();
                return resDoc;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarDocumento(int nId)
        {
            try
            {
                Documento documento = _dbContext.Documentos.Find(nId);
                _dbContext.Documentos.Remove(documento);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Documento>> ObtenerDocumentosxRuc(string cRuc)
        {
            try
            {
                List<Documento> listDocumentos = await _dbContext.Documentos.Where(doc => doc.cRuc == cRuc).ToListAsync();
                return listDocumentos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Documento>> ObtenerDocumentosxRucxDni(string cRuc, string cDni)
        {
            try
            {
                List<Documento> listDocumentos = await _dbContext.Documentos.Where(doc => doc.cRuc == cRuc && doc.cDni == cDni).ToListAsync();
                return listDocumentos;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Documento> RegistrarDocumento(Documento documento)
        {
            try
            {
                Documento resDoc = _dbContext.Documentos.Add(documento).Entity;
                await _dbContext.SaveChangesAsync();
                return resDoc;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
