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
                Cliente resCli = _dbContext.Clientes.Update(cliente).Entity;
                await _dbContext.SaveChangesAsync();
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
                _dbContext.Clientes.Add(cliente);
                await _dbContext.SaveChangesAsync();
                return cliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
