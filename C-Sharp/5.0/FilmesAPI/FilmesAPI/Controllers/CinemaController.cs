using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Models;
using FilmesAPI.Services;
using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private CinemaServices _cinemaService;
        public CinemaController(CinemaServices cinemaService)
        {
            _cinemaService = cinemaService;
        }


        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            ReadCinemaDto cinema = _cinemaService.AdcionarCinema(cinemaDto);
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpGet]
        public IActionResult RecuperaCinema([FromQuery] string nomeDoFilme)
        {
            List<ReadCinemaDto> cinemas = _cinemaService.RecuperaCinema(nomeDoFilme);           
            return Ok(cinemas);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            ReadCinemaDto cinema = _cinemaService.RecuperaCinemasPorId(id);
            if (cinema != null)
                return Ok(cinema);
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Result result = _cinemaService.AtualizaCinema(id, cinemaDto);
            if (result.IsFailed)
                return NotFound();          
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Result result = _cinemaService.DeletaCinema(id);
            if (result.IsFailed)
                return NotFound();
            return NoContent();
        }

    }
}
