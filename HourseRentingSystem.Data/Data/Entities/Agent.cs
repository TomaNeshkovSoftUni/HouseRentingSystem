using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static HouseRentingSystem.Data.Data.DataConstants.Agent;

namespace HouseRentingSystem.Data.Data.Entities
{
    public class Agent
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        public IdentityUser User { get; init; } = null!;

        public IEnumerable<House> Houses { get; init; } = new List<House>();
    }
}
