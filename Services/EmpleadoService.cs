using LoanNet.IServices;
using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class EmpleadoService : IEmpleadoService
    {
        private readonly MyDbContext _dbContext;
        public EmpleadoService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Empleado> ActualizarEmpleado(Empleado empleado)
        {
            try
            {
                Empleado fEmp = _dbContext.Empleados.AsNoTracking().Where(emp => emp.cDni == empleado.cDni).FirstOrDefault();
                Empleado emp = new Empleado();
                if (fEmp != null)
                {
                    emp = _dbContext.Empleados.Update(empleado).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    emp.cDni = "NOTFOUND";
                }
                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarEmpleado(string cDni)
        {
            try
            {
                Empleado empleado = new Empleado() { cDni = cDni};
                _dbContext.Empleados.Attach(empleado);
                _dbContext.Empleados.Remove(empleado);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async void EliminarLogEmpleado(string cDni)
        {
            try
            {
                Empleado empleado = _dbContext.Empleados.Find(cDni);
                empleado.bEstado = false;
                _dbContext.Empleados.Update(empleado);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Empleado>> ObtenerEmpleadosxRuc(string cRuc)
        {
            try
            {
                List<Empleado> list = await _dbContext.Empleados.Where(e => e.cRuc == cRuc && e.bEstado == true).ToListAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Empleado> RegistrarEmpleado(Empleado empleado)
        {
            try
            {
                empleado.dtFechaReg = DateTime.Now;
                empleado.bEstado = true;
                Empleado fEmp = _dbContext.Empleados.Find(empleado.cDni);
                Empleado emp = new Empleado();
                if (fEmp == null)
                {
                    emp = _dbContext.Empleados.Add(empleado).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    emp.cDni = "FOUND";
                }
                return emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
