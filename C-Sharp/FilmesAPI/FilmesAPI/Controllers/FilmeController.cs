using FilmesAPI.Data;
using FilmesAPI.Models;
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
        private FilmeContext _context;

        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarFilme([FromBody]Filme filme)
        {
            _context.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperarFilmePorId), new { Id = filme.Id }, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return _context.Filmes;
        }


        [HttpGet("{id}")]
        public IActionResult RecuperarFilmePorId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if(filme is not null)
            {
                return Ok(filme);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarFilme(int id, [FromBody]Filme filmeNovo)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if(filme is null)
            {
                return NotFound();
            }
            else
            {
                filme.Titulo = filmeNovo.Titulo;
                filme.Genero = filmeNovo.Genero;
                filme.Diretor = filmeNovo.Diretor;
                filme.Duracao = filmeNovo.Duracao;
                _context.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
            if (filme is null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(filme);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
