using System.ComponentModel.DataAnnotations;

namespace Authentication.Api.Model
{
    public class ConfirmEmailModel
    {
        [Required(ErrorMessage = "Token is required")]
        public string Token { get; set; }
    }
}
