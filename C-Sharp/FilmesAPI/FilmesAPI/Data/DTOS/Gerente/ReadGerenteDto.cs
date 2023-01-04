using FilmesAPI.Models;
using System.Collections.Generic;


namespace FilmesAPI.Data.DTOS.Gerente
{
    public class ReadGerenteDto
    {
        public string Nome { get; set; }
        public object Cinemas { get; set; }
    }
}
