using AutoMapper;
using FilmesAPI.Data.DTOS;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile:Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto,Filme>();
            CreateMap<UpdateFilmeDto,Filme>();
        }
    }
}
