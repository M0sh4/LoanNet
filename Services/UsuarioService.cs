using LoanNet.Models;
using System;
using System.Threading.Tasks;

namespace LoanNet.Services.UsuarioService
{
    public class UsuarioService : IUsuarioService
    {
        private readonly MyDbContext _dbContext;
        public UsuarioService(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Usuario> ActualizarUsuario(Usuario usuario)
        {
            try
            {
                Usuario resUsu = _dbContext.Usuarios.Update(usuario).Entity;
                await _dbContext.SaveChangesAsync();
                return resUsu;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> ObtenerUsuarioxId(int id)
        {
            try
            {
                Usuario resUsu = await _dbContext.Usuarios.FindAsync(id);
                return resUsu;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Usuario> RegistrarUsuario(Usuario usuario)
        {
            try
            {
                Usuario resUsu = _dbContext.Add(usuario).Entity;
                await _dbContext.SaveChangesAsync();
                return resUsu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
