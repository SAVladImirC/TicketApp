using Domain.Domain;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
#nullable disable
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime Dob { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
