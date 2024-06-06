using CadastroUsuario.Domain.Interfaces.Repositories;
using CadastroUsuario.InfraData.Repositories;
using CadastroUsuarios.Contexts;
using CadastroUsuarios.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastroUsuario_.Repositories;

public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
{
    private readonly SqlServerContext _context;
    public UsuarioRepository(SqlServerContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Usuario> Login(string email, string senha)
    {
        return await _context.Set<Usuario>().Where(u =>
            u.Email == email && u.Senha == senha).FirstOrDefaultAsync();
    }
}
