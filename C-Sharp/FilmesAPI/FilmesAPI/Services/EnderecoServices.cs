using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Services
{
    public class EnderecoServices
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public EnderecoServices(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadEnderecoDto AdicionaEndereco(CreateEnderecoDto enderecoDto)
        {
            Endereco endereco = _mapper.Map<Endereco>(enderecoDto);
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();
            return _mapper.Map<ReadEnderecoDto>(endereco);
        }

        public List<ReadEnderecoDto> RecuperaEndereco()
        {
            return _mapper.Map<List<ReadEnderecoDto>>(_context.Enderecos);
        }

        public ReadEnderecoDto RecuperaEnderecoPorId(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);    
            ReadEnderecoDto cinemaDto = _mapper.Map<ReadEnderecoDto>(endereco);
            return _mapper.Map<ReadEnderecoDto>(endereco);
        }

        public Result AtualizaEndereco(int id, UpdateCinemaDto enderecoDto)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)            
                return Result.Fail("Endereco não encontrado");
            
            _mapper.Map(enderecoDto, endereco);
            _context.SaveChanges();
            return Result.Ok();
        }

        public Result DeletaEndereco(int id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == id);
            if (endereco == null)
                return Result.Fail("Endereco não encontrado");
            _context.Remove(endereco);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
