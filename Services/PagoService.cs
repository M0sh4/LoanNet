using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class PagoService : IPagoService
    {
        private readonly MyDbContext _dbContext;
        public PagoService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Pago> ActualizarPago(Pago pago)
        {
            try
            {
                Pago fPago = _dbContext.Pagos.AsNoTracking().Where(p => p.nId == pago.nId).FirstOrDefault();
                pago.nIdPrestamo = fPago.nIdPrestamo;
                pago.dtFecha = fPago.dtFecha;
                pago.bEstado = true;
                Pago resPago = _dbContext.Pagos.Update(pago).Entity;
                await _dbContext.SaveChangesAsync();
                return resPago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogPago(int nId)
        {
            try
            {
                Pago pago = _dbContext.Pagos.Find(nId);
                pago.bEstado = false;
                _dbContext.Update(pago);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Pago>> ObtenerPagosxPrestamo(int nIdPrestamo)
        {
            try
            {
                return await _dbContext.Pagos.Where(pago => pago.nIdPrestamo == nIdPrestamo && pago.bEstado == true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Pago> RegistrarPago(Pago pago)
        {
            try
            {
                pago.dtFecha = DateTime.Now;
                pago.bEstado = true;
                Prestamo prestamo = _dbContext.Prestamos.Find(pago.nIdPrestamo);
                Pago resPago = new Pago();
                if (prestamo != null)
                {
                    resPago = _dbContext.Pagos.Add(pago).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resPago.nIdPrestamo = 0;
                }
                return resPago;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
