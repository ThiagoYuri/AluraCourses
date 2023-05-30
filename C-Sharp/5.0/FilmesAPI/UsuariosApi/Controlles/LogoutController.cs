using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Services;

namespace UsuariosApi.Controlles
{
    [ApiController]
    [Route("{controller}")]
    public class LogoutController : Controller
    {
        private LogoutService _logoutService;

        public LogoutController(LogoutService logoutService)
        {
            _logoutService = logoutService;
        }
        [HttpPost]
        public IActionResult DeslogaUsuario()
        {
            Result result = _logoutService.DeslogaUsuario();
            if (result.IsFailed) return Unauthorized(result.Errors);
            return Ok(result.Successes);
        }
    }
}
