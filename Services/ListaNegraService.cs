using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class ListaNegraService : IListaNegraService
    {
        private readonly MyDbContext _dbContext;
        public ListaNegraService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<ListaNegra> ActualizarListaNegra(ListaNegra listaNegra)
        {
            try
            {
                ListaNegra fListaNegra = _dbContext.Listas_Negras.AsNoTracking().Where(ln => ln.nId == listaNegra.nId).FirstOrDefault();
                fListaNegra.cRazon = listaNegra.cRazon;
                ListaNegra resLN = _dbContext.Listas_Negras.Update(fListaNegra).Entity;
                await _dbContext.SaveChangesAsync();
                return resLN;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogListaNegra(int nId)
        {
            try
            {
                ListaNegra listaNegra = _dbContext.Listas_Negras.Find(nId);
                listaNegra.bEstado = false;
                _dbContext.Listas_Negras.Update(listaNegra);
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<ListaNegra>> ObtenerListaNegraxRuc(string cRuc)
        {
            try
            {
                List<ListaNegra> listLN = await _dbContext.Listas_Negras.Where(ln => ln.cRuc == cRuc && ln.bEstado == true).ToListAsync();
                return listLN;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ListaNegra> RegistrarListaNegra(ListaNegra listaNegra)
        {
            try
            {
                listaNegra.dtFechaReg = DateTime.Now;
                listaNegra.bEstado = true;
                ListaNegra fLN = _dbContext.Listas_Negras.Where(ln => ln.cDni == listaNegra.cDni).FirstOrDefault();
                ListaNegra resLN = new ListaNegra();
                if (fLN == null)
                {
                    resLN = _dbContext.Listas_Negras.Add(listaNegra).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resLN.cDni = "FOUND";
                }
                return resLN;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
