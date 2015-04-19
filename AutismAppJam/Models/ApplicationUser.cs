using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutismAppJam.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string DisplayName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }

        public bool MbtiTestCompleted { get; set; }

    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : 
            base("DefaultConnection")
        {
        }
    }
}
