using Microsoft.AspNetCore.Identity;

namespace WebApplication_Final_35
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public DateTime BirthDate { get; set; }

    }
}
