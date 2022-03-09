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
                Empresa emp = _dbContext.Empresas.AsNoTracking().Where(wEmp => wEmp.cRuc == empresa.cRuc).FirstOrDefault();
                Empresa resEmpresa = new Empresa();
                if (emp != null)
                {
                    resEmpresa = _dbContext.Empresas.Update(empresa).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resEmpresa.cRuc = "NOTFOUND";
                }
                return resEmpresa;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Cliente>> ObtenerClientesxEmpresa(string cRuc)
        {
            try
            {
                List<Cliente> list = await _dbContext.Prestamos.Join(_dbContext.Clientes, p => p.cDni, c => c.cDni, (p, c) => c).ToListAsync();
                return list;
            }catch(Exception ex)
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
                Empresa emp = _dbContext.Empresas.Find(empresa.cRuc);
                Empresa resEmp = new Empresa();
                if (emp == null)
                {
                    resEmp = _dbContext.Empresas.Add(empresa).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resEmp.cRuc = "FOUND";
                }
                return resEmp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
