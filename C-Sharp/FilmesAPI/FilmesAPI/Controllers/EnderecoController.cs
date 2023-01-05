using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private EnderecoServices _enderecoService;
        public EnderecoController(EnderecoServices enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpPost]
        public IActionResult AdicionaEndereco([FromBody] CreateEnderecoDto enderecoDto)
        {
            ReadEnderecoDto endereco = _enderecoService.AdicionaEndereco(enderecoDto);
           
            return CreatedAtAction(nameof(RecuperaEnderecoPorId), new { Id = endereco.Id }, endereco);
        }

        [HttpGet]
        public IEnumerable<ReadEnderecoDto> RecuperaEndereco()
        {
            List<ReadEnderecoDto> endereco = _enderecoService.RecuperaEndereco();
            return endereco;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaEnderecoPorId(int id)
        {
            ReadEnderecoDto endereco = _enderecoService.RecuperaEnderecoPorId(id);
            if (endereco != null)
                return Ok(endereco);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaEndereco(int id, [FromBody] UpdateCinemaDto enderecoDto)
        {
            Result endereco = _enderecoService.AtualizaEndereco(id, enderecoDto);
            if (endereco.IsFailed)
                return NotFound();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaEndereco(int id)
        {
            Result endereco = _enderecoService.DeletaEndereco(id);
            if (endereco.IsFailed)
                return NotFound();
            return NoContent();           
        }

    }
}
