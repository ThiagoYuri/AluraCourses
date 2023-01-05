using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : Controller
    {
        private FilmeServices _filmeService;
        public FilmeController(FilmeServices filmeService)
        {
            _filmeService = filmeService;
        }


        [HttpPost]
        public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
        {
            ReadFilmeDto filme = _filmeService.AdcionarFilme(filmeDto);
            return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IActionResult RecuperarFilmes([FromQuery] int? classificacaoEtaria = null)
        {
            List<ReadFilmeDto> filmes = _filmeService.RecuperarFilmes(classificacaoEtaria);
            if(filmes != null)
                return Ok(filmes);
            return NotFound();
        }


        [HttpGet("{id}")]
        public IActionResult RecuperaFilmesPorId(int id)
        {
            ReadFilmeDto filme = _filmeService.RecuperarFilmesPorId(id);
            if (filme != null)
                return Ok(filme);

            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilme(int id, [FromBody]UpdateFilmeDto filmeDto)
        {
            Result updated = _filmeService.AtualizarFilme(id, filmeDto);
            if(updated.IsFailed)
                return NoContent();
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Result removed = _filmeService.DeletaFilme(id);
            if (removed.IsFailed)
                return NoContent();
            return NotFound();
        }
    }
}
