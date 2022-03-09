using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class RecomendadoService: IRecomendadoService
    {
        private readonly MyDbContext _dbContext;
        public RecomendadoService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Recomendado> ActualizarRecomendado(Recomendado recomendado)
        {
            try
            {
                Recomendado resRec = _dbContext.Recomendados.Update(recomendado).Entity;
                await _dbContext.SaveChangesAsync();
                return resRec;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogRecomendado(int nId)
        {
            try
            {
                Recomendado recomendado = _dbContext.Recomendados.Find(nId);
                recomendado.bEstado = false;
                _dbContext.Recomendados.Update(recomendado);
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Recomendado>> ObtenerRecomendadosxRuc(string cRuc)
        {
            try
            {
                return await _dbContext.Recomendados.Where(rec => rec.cRuc == cRuc && rec.bEstado == true).ToListAsync();
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Recomendado> RegistrarRecomendado(Recomendado recomendado)
        {
            try
            {
                recomendado.dtFechaReg = DateTime.Now;
                recomendado.bEstado = true;
                Recomendado fRec = _dbContext.Recomendados.Where(rec=> rec.cRuc == recomendado.cRuc && rec.cDniRec == recomendado.cDniRec).FirstOrDefault();
                Recomendado resRec = new Recomendado();
                if (fRec != null)
                {
                    resRec = _dbContext.Recomendados.Add(recomendado).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resRec.cDniRec = "FOUND";
                }
                return resRec;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
