using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamoletniRezervacii.Data
{
    public class AppRole:IdentityRole
    {
        public AppRole()
        {
            this.Id = Guid.NewGuid().ToString();
            this.CreateOn = DateTime.UtcNow;
        }
        public DateTime CreateOn { get; set; }
    }
}
