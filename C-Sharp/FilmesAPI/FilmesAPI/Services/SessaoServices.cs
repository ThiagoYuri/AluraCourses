using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOS.Sessao;
using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Services
{
    public class SessaoServices
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public SessaoServices(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadSessaoDto AdicionaSessao(CreateSessaoDto sessaoDto)
        {
            Sessao sessao = _mapper.Map<Sessao>(sessaoDto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();
            return _mapper.Map<ReadSessaoDto>(sessao);
        }

        public IEnumerable<ReadSessaoDto> RecuperaSessao()
        {
            return _mapper.Map<List<ReadSessaoDto>>(_context.Sessoes);
        }

        public ReadSessaoDto RecuperaSessaoPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao => sessao.Id == id);          
            ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
            return _mapper.Map<ReadSessaoDto>(sessaoDto);           
        }
    }
}
