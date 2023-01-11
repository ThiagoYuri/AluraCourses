using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controlles
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController : Controller
    {
        private CadastroService _cadastroServices;

        public CadastroController(CadastroService cadastroServices)
        {
            _cadastroServices = cadastroServices;
        }

        [HttpPost]
        public IActionResult CadastraUsuario(CreateUsuarioDto createDto)
        {            
            Result resultado = _cadastroServices.CadastroUsuario(createDto);
            if (resultado.IsFailed) return StatusCode(500);
            return Ok();
        }
    }
}
