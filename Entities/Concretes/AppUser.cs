using Microsoft.AspNetCore.Identity;

namespace Entities.Concretes
{
    public class AppUser:IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
    }
}
