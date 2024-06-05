using CadastroUsuario.Domain.DTOs;
using CadastroUsuarios.Domain.Entities;

namespace CadastroUsuario.Domain.Interfaces.Services;

public interface IUsuarioService
{
    Task<IEnumerable<Usuario>> GetAsync();
    Task<UsuarioDTO> GetByIdAsync(int id);
    Task<Usuario> Login(string email, string senha);

    Task CreateAsync(UsuarioDTO usuario);
    Task UpdateAsync(UsuarioDTO usuario, int id);
    Task RemoveAsync(int id);
}
