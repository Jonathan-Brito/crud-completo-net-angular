namespace CadastroUsuario.Domain.DTOs;

public class UsuarioUpdateDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string SobreNome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
}
