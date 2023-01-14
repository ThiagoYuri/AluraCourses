using FluentResults;
using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Requests;
using UsuariosApi.Services;

namespace UsuariosApi.Controlles
{
    [ApiController]
    [Route("{controller}")] 
    public class LoginController : Controller
    {
        private LoginService _loginService;

        public LoginController(LoginService loginService )
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult LogarUsuario(LoginRequest loginRequest)
        {
            Result result = _loginService.LogaUsuario(loginRequest);
            if(result.IsFailed) return Unauthorized(result.Errors);
            return Ok(result.Successes);
        }
    }
}
