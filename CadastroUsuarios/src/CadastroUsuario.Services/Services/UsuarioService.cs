using AutoMapper;
using CadastroUsuario.Domain.DTOs;
using CadastroUsuario.Domain.Interfaces.Repositories;
using CadastroUsuario.Domain.Interfaces.Services;
using CadastroUsuarios.Domain.Entities;

namespace CadastroUsuario.Services.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _repository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task CreateAsync(UsuarioDTO usuario)
    {
        if(usuario != null)
        {
            var usuarioMap = _mapper.Map<Usuario>(usuario);
            await _repository.CreateAsync(usuarioMap);
        }
        else
        {
            throw new ArgumentNullException();
        }
    }
    
    public async Task UpdateAsync(UsuarioDTO usuario, int id)
    {
        var usuarioExiste = await _repository.GetById(id);
        
        if (usuarioExiste != null)
        {
            usuarioExiste.Update(usuario, id);
            await _repository.UpdateAsync(usuarioExiste);
        }
        else
        {
            throw new ArgumentNullException();
        }
    }
    
    public async Task RemoveAsync(int id)
    {
        if (id != null)
        {
            var usuario = await _repository.GetById(id);
            await _repository.DeleteAsync(usuario);
        }
        else
        {
            throw new ArgumentNullException();
        }
    }

    public async Task<IEnumerable<Usuario>> GetAsync()
    {
        return await _repository.Get();
    }

    public async Task<UsuarioDTO> GetByIdAsync(int id)
    {
        var usuario = await _repository.GetById(id);
        var usuarioMap = _mapper.Map<UsuarioDTO>(usuario);

        return usuarioMap;
    }

    public async Task<Usuario> Login(string email, string senha)
    {
        return await _repository.Login(email, senha);
    }
}
