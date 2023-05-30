using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOS.Sessao;
using FilmesAPI.Models;
using FilmesAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SessaoController : Controller
    {
        private SessaoServices _sessaoService;

        public SessaoController(SessaoServices sessaoService)
        {
            _sessaoService = sessaoService;
        }

        [HttpPost]
        public IActionResult AdicionaSessao([FromBody] CreateSessaoDto sessaoDto)
        {
            ReadSessaoDto sessao = _sessaoService.AdicionaSessao(sessaoDto);            
            return CreatedAtAction(nameof(RecuperaSessaoPorId), new { Id = sessao.Id }, sessao);
        }

         [HttpGet]
        public IEnumerable<ReadSessaoDto> RecuperaSessao()
        {
            return _sessaoService.RecuperaSessao();
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessaoPorId(int id)
        {
            ReadSessaoDto sessao = _sessaoService.RecuperaSessaoPorId(id);
            if (sessao != null)
                return Ok(sessao);
            return NotFound();
        }
    }
}
