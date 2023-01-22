using System.ComponentModel.DataAnnotations;

namespace UsuariosApi.Requests
{
    public class SolicitaResetRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
