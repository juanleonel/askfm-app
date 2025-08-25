using Microsoft.AspNetCore.Identity;

namespace askfm.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string? LastName { get; set; }
        public string? Location { get; set; }
        public string? Image { get; set; }
    }
}


