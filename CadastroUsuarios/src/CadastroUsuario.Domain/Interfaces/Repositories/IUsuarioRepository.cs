using CadastroUsuarios.Domain.Entities;

namespace CadastroUsuario.Domain.Interfaces.Repositories;

public interface IUsuarioRepository : IBaseRepository<Usuario>
{
    Task<Usuario> Login(string email, string senha);
}
