using LoanNet.Models;
using System;
using System.Linq;
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
                Usuario fUsu = _dbContext.Usuarios.Where(usu => usu.cUsuario == usuario.cUsuario).FirstOrDefault();
                Usuario resUsu = new Usuario();
                if (fUsu == null)
                {
                    resUsu = _dbContext.Usuarios.Update(usuario).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resUsu.cUsuario = "FOUND";
                }
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
                Usuario fUsu = _dbContext.Usuarios.Where(usu => usu.cUsuario == usuario.cUsuario).FirstOrDefault();
                Usuario resUsu = new Usuario();
                if (fUsu == null)
                {
                    resUsu = _dbContext.Add(usuario).Entity;
                    await _dbContext.SaveChangesAsync();
                }
                else
                {
                    resUsu.cUsuario = "FOUND";
                }
                return resUsu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
