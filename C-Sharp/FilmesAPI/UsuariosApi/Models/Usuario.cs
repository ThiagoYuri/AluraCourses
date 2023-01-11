using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Models
{
    public class Usuario
    {
        [Key]
        [Required]        
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }
   
    }
}
