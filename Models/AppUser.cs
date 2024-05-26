using Microsoft.AspNetCore.Identity;

namespace ARD.Models
{
    public class AppUser:IdentityUser
    {

        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Nickname { get; set;}
    }
}