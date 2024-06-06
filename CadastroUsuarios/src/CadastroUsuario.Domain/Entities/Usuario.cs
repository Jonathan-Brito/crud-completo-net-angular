using CadastroUsuario.Domain.DTOs;

namespace CadastroUsuarios.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public void Update(UsuarioDTO dto, int id)
    {
        Id = id;
        Nome = dto.Nome;
        SobreNome = dto.SobreNome;
        Email = dto.Email;
        Senha = dto.Senha;
    }
}
