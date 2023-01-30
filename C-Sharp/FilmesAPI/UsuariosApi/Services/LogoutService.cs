using FluentResults;
using Microsoft.AspNetCore.Identity;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class LogoutService
    {
        private SignInManager<CustomIdentityUser> _signinManager;

        public LogoutService(SignInManager<CustomIdentityUser> signinManager)
        {
            _signinManager = signinManager;
        }

        public Result DeslogaUsuario()
        {
            var resutIdentity = _signinManager.SignOutAsync();
            if (resutIdentity.IsCompletedSuccessfully) return Result.Ok();
            return Result.Fail("Logout Falhou");
        }
    }
}
