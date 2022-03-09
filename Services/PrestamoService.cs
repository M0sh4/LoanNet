using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class PrestamoService: IPrestamoService
    {
        private readonly MyDbContext _dbContext;
        public PrestamoService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Prestamo> ActualizarPrestamo(Prestamo prestamo)
        {
            try
            {
                Prestamo resPre = _dbContext.Prestamos.Update(prestamo).Entity;
                await _dbContext.SaveChangesAsync();
                return resPre;
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogPrestamo(int nId)
        {
            try
            {
                Prestamo prestamo = _dbContext.Prestamos.Find(nId);
                prestamo.cEstado = "0";
                _dbContext.Prestamos.Update(prestamo);
                await _dbContext.SaveChangesAsync();
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Prestamo>> ObtenerPrestamosxRuc(string cRuc)
        {
            try
            {
                return await _dbContext.Prestamos.Where(pre => pre.cRuc == cRuc).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Prestamo>> ObtenerPrestamoxDni(string cDni)
        {
            try
            {
                return await _dbContext.Prestamos.Where(pre => pre.cDni == cDni).ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Prestamo>> ObtenerPrestamoxRucxDni(string cRuc, string cDni)
        {
            try
            {
                return await _dbContext.Prestamos.Where(pre => pre.cDni == cDni && pre.cRuc == cRuc && pre.cEstado != "0").ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Prestamo> RegistrarPrestamo(Prestamo prestamo)
        {

            try
            {
                prestamo.cEstado = "1";
                Prestamo resPre = _dbContext.Prestamos.Add(prestamo).Entity;
                await _dbContext.SaveChangesAsync();
                return resPre;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
