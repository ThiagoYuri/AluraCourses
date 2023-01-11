using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {
        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;

        public CadastroService(IMapper mapper, UserManager<IdentityUser<int>> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }

        public Result CadastroUsuario(CreateUsuarioDto createDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            var result = _userManager.CreateAsync(usuarioIdentity,createDto.Password);
            if (result.Result.Succeeded)
                return Result.Ok();
            else
                return Result.Fail("Falha ao cadastrar usuário");

        }
    }
}
