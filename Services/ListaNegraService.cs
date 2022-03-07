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
                ListaNegra resLN = _dbContext.Listas_Negras.Update(listaNegra).Entity;
                await _dbContext.SaveChangesAsync();
                return resLN;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarListaNegra(int nId)
        {
            try
            {
                ListaNegra listaNegra = _dbContext.Listas_Negras.Find(nId);
                _dbContext.Listas_Negras.Remove(listaNegra);
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
                List<ListaNegra> listLN = await _dbContext.Listas_Negras.Where(ln => ln.cRuc == cRuc).ToListAsync();
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
                ListaNegra resLN = _dbContext.Listas_Negras.Add(listaNegra).Entity;
                await _dbContext.SaveChangesAsync();
                return resLN;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
