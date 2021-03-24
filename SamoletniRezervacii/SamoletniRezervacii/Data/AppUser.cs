using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamoletniRezervacii.Data
{
    public class AppUser:IdentityUser
    {
        public AppUser()
        {
            this.Id = Guid.NewGuid().ToString(); 
            
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Egn { get; set; }
        public string Address { get; set; }
        public string UserRole { get; set; }

    }
}
