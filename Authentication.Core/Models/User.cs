using Microsoft.AspNetCore.Identity;

namespace Authentication.Core.Models
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
