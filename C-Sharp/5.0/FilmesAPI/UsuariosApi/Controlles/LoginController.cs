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

        [HttpPost("/solicita-reset")]
        public IActionResult SolicitaResetSenhaUsuario(SolicitaResetRequest request)
        {
            Result result = _loginService.SolicitaResetSenhaUsuario(request);
            if (result.IsFailed) return Unauthorized(result.Errors);
            return Ok(result.Successes);
        }


        [HttpPost("/efetua-reset")]
        public IActionResult SolicitaResetSenhaUsuario(EfetuaResetRequest request)
        {
            Result result = _loginService.ResetSenhaUsuario(request);
            if (result.IsFailed) return Unauthorized(result.Errors);
            return Ok(result.Successes);
        }
    }
}
