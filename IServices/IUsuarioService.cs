using System.Threading.Tasks;
using LoanNet.Models;

namespace LoanNet.Services.UsuarioService
{
    public interface IUsuarioService
    {
        Task<Usuario> RegistrarUsuario(Usuario usuario);
        Task<Usuario> ActualizarUsuario(Usuario usuario);
        Task<Usuario> ObtenerUsuarioxId(int id);
    }
}
