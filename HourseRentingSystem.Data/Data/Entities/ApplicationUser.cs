using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRentingSystem.Data.Data.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public List<House> Houses { get; set; }
    }
}
