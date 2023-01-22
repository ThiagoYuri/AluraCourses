using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;
using UsuariosApi.Requests;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;
        private EmailService _emailService;
        private RoleManager<IdentityRole<int>> _roleManager;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager, EmailService emailService, RoleManager<IdentityRole<int>> roleManager)
        {
            _mapper = mapper;
            _userManager = userManager;
            _emailService = emailService;
            _roleManager = roleManager;
        }

        public Result CadastroUsuario(CreateUsuarioDto createDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> result = _userManager.CreateAsync(usuarioIdentity,createDto.Password);
                     
            if (result.Result.Succeeded)
            {
                var createRoleResult = _roleManager.CreateAsync(new IdentityRole<int>("admin")).Result;
                var usuarioRoleResult = _userManager.AddToRoleAsync(usuarioIdentity, "admin").Result;

                var code = _userManager.GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;
                var encodedCode = HttpUtility.UrlEncode(code);
                _emailService.EnviarEmail(
                    new[] {usuarioIdentity.Email},
                    "Link de Ativação", 
                    usuarioIdentity.Id, 
                    encodedCode
                    );
                return Result.Ok().WithSuccess(code);
            }
            else
                return Result.Fail("Falha ao cadastrar usuário");

        }

        public Result CadastroUsuario(AtivaContaRequest request)
        {
            var identityUser = _userManager
                .Users
                .FirstOrDefault(u => u.Id == request.UsuarioId);
            var identityResult = _userManager
                .ConfirmEmailAsync(identityUser, request.CodigoDeAtivacao).Result;
            if (identityResult.Succeeded)
            {
                return Result.Ok();
            }
            else
                return Result.Fail("Falha ao altenticar email");
        }
       
    }
}
