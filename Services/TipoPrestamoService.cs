using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class TipoPrestamoService : ITipoPrestamoService
    {
        private readonly MyDbContext _dbContext;
        public TipoPrestamoService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<TipoPrestamo> ActualizarTipoPrestamo(TipoPrestamo tipoPrestamo)
        {
            try
            {
                TipoPrestamo resTP = _dbContext.Tipos_Prestamos.Update(tipoPrestamo).Entity;
                await _dbContext.SaveChangesAsync();
                return resTP;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogTipoPrestamo(string nId)
        {
            try
            {
                TipoPrestamo tipoPrestamo = _dbContext.Tipos_Prestamos.Find(nId);
                tipoPrestamo.bEstado = false;
                _dbContext.Tipos_Prestamos.Update(tipoPrestamo);
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<TipoPrestamo>> ObtenerTipoPrestamoxRuc(string cRuc)
        {
            try
            {
                List<TipoPrestamo> listTP = await _dbContext.Tipos_Prestamos.Where(tp => tp.cRuc == cRuc && tp.bEstado == true).ToListAsync();
                return listTP;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<TipoPrestamo> RegistrarTipoPrestamo(TipoPrestamo tipoPrestamo)
        {
            try
            {
                tipoPrestamo.dtFechaReg = DateTime.Now;
                tipoPrestamo.bEstado = true;
                TipoPrestamo resTp = _dbContext.Tipos_Prestamos.Add(tipoPrestamo).Entity;
                await _dbContext.SaveChangesAsync();
                return resTp;
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
