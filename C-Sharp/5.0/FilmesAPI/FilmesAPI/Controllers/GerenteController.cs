using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOS.Gerente;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : Controller
    {
        private GerenteServices _gerenteService;

        public GerenteController(GerenteServices gerenteService)
        {
            _gerenteService = gerenteService;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            ReadGerenteDto readDto = _gerenteService.AdicionaGerente(dto);
            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = readDto.Id }, readDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            ReadGerenteDto readDto = _gerenteService.RecuperaGerentesPorId(id);
            if (readDto == null) return NotFound();
            return Ok(readDto);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            Result resultado = _gerenteService.DeleteGerente(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
