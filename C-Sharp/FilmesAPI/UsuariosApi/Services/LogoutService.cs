using FluentResults;
using Microsoft.AspNetCore.Identity;

namespace UsuariosApi.Services
{
    public class LogoutService
    {
        private SignInManager<IdentityUser<int>> _signinManager;

        public LogoutService(SignInManager<IdentityUser<int>> signinManager)
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
