using LoanNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanNet.Services
{
    public class ClienteService : IClienteService
    {
        private readonly MyDbContext _dbContext;
        
        public ClienteService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cliente> ActualizarCliente(Cliente cliente)
        {
            try
            {
                Cliente fCliente = _dbContext.Clientes.AsNoTracking().Where(cli => cli.cDni == cliente.cDni).FirstOrDefault();
                Cliente resCli = new Cliente();
                if (fCliente != null)
                {
                    resCli = _dbContext.Clientes.Update(cliente).Entity;
                    
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resCli.cDni = "NOTFOUND";
                }
                return resCli;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<List<Cliente>> ObtenerClientes()
        {
            try
            {
                return _dbContext.Clientes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Cliente> RegistrarCliente(Cliente cliente)
        {
            try
            {
                cliente.dtFechaReg = DateTime.Now;
                Cliente sCliente = _dbContext.Clientes.Find(cliente.cDni);
                Cliente resCliente = new Cliente();
                if (sCliente.cDni == null)
                {
                    resCliente = _dbContext.Clientes.Add(cliente).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resCliente.cDni = "FOUND";
                }
                return resCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
