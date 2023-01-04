using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; private set; }

        [Required(ErrorMessage ="O campo titulo é obrigatorio")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="O campo diretor e obrigatorio")]
        public string Diretor { get; set; }
        [StringLength(30 ,ErrorMessage = "O genero não pode passar de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1,600,ErrorMessage ="A duração deve ter no minimo 1 e no maximo 600 minutos")]        
        public int Duracao { get; set; }
        public int ClassificacaoEtaria { get; set; }

        [JsonIgnore]
        public virtual List<Sessao> Sessoes { get; set; }

    }
}
