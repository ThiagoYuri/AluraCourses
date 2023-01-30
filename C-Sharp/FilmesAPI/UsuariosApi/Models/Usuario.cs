using System;
using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Models
{
    public class Usuario
    {               
        public int Id { get; set; }       
        public string Username { get; set; }
       
        public string Email { get; set; }
        
        public DateTime DateNacimento { get; set; }

    }
}
