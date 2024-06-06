using CadastroUsuario.Domain.DTOs;
using CadastroUsuario.Domain.Interfaces.Repositories;
using CadastroUsuario.Domain.Interfaces.Services;
using CadastroUsuarios.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CadastroUsuario.Services.TokenConfiguration;

namespace CadastroUsuarios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        private readonly IUsuarioService _service;

        public LoginController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UsuarioLoginDTO usuario)
        {
            var user = await _service.Login(usuario.Email, usuario.Senha);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            user.Senha = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
