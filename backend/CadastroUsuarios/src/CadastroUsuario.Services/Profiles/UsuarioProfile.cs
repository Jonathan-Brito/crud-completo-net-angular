using AutoMapper;
using CadastroUsuario.Domain.DTOs;
using CadastroUsuarios.Domain.Entities;

namespace CadastroUsuario.Services.Profiles;

public class UsuarioProfile : Profile
{
    public UsuarioProfile()
    {
        CreateMap<UsuarioDTO, Usuario>().ReverseMap();
        CreateMap<UsuarioUpdateDTO, Usuario>().ReverseMap();
    }
}
