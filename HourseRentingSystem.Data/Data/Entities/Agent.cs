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
        [Key]
        public int Id { get; init; }

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        public ApplicationUser User { get; init; } = null!;

        public IEnumerable<House> ManagedHouses { get; init; } = new List<House>();
    }
}
