using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOS.Gerente;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController : Controller
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public GerenteController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente([FromBody]CreateGerenteDto dto)
        {
            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaGerentePorId), new { Id = gerente.Id }, gerente);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentePorId(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(cinema => cinema.Id == id);
            if (gerente != null)
            {
                ReadGerenteDto cinemaDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(cinemaDto);
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaGerente(int id)
        {
            Gerente gerente = _context.Gerentes.FirstOrDefault(x => x.Id == id);
            if (gerente is null)
            {
                return NotFound();
            }
            else
            {
                _context.Remove(gerente);
                _context.SaveChanges();
                return NoContent();
            }
        }
    }
}
