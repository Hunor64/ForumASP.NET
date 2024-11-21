using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity;

namespace ForumASP.NET.Models
{
    public class User : IdentityUser
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Password {  get; set; }

    }
}
