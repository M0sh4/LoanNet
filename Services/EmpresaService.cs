using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class EmpresaService : IEmpresaService
    {
        private readonly MyDbContext _dbContext;
        public EmpresaService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Empresa> ActualizarEmpresa(Empresa empresa)
        {
            try
            {
                Empresa resEmpresa = _dbContext.Empresas.Update(empresa).Entity;
                await _dbContext.SaveChangesAsync();
                return resEmpresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Empresa>> ObtenerEmpresas()
        {
            try
            {
                return _dbContext.Empresas.ToListAsync();
            }catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Empresa> ObtenerEmpresaxId(int id)
        {
            try
            {
                Empresa empresa = await _dbContext.Empresas.FindAsync(id);
                return empresa;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Empresa> RegistrarEmpresa(Empresa empresa)
        {
            try
            {
                empresa.dtFechaReg = DateTime.Now;
                Empresa resEmp = _dbContext.Empresas.Add(empresa).Entity;
                await _dbContext.SaveChangesAsync();
                return resEmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
