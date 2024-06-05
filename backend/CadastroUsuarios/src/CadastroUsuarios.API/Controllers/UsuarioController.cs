using CadastroUsuario.Domain.DTOs;
using CadastroUsuario.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuarios.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Create(UsuarioDTO dto)
        {
            try
            {
                await _service.CreateAsync(dto);
                return Ok(dto);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(UsuarioDTO dto, int id)
        {
            try
            {
                await _service.UpdateAsync(dto, id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.RemoveAsync(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Get()
        {
            try
            {
                var usuarios = await _service.GetAsync();
                return Ok(usuarios);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
