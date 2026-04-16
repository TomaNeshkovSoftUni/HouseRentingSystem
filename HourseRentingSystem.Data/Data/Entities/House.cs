using HouseRentingSystem.Data.Data;
using HouseRentingSystem.Data.Data.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static HouseRentingSystem.Data.Data.DataConstants.House;

namespace HouseRentingSystem.Data.Data.Entities
{
    public class House
    {
        [Key]
        public int Id { get; init; }

        [MaxLength(TitleMaxLength)]
        [MinLength(10)]
        [Required]
        public string Title { get; set; } = null!;

        [MaxLength(DescriptionMaxLength)]
        [MinLength(30)]
        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        [Range(0,2000)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PricePerMonth { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Agent))]
        public string AgentId { get; set; }
        public ApplicationUser Agent { get; set; } = null!;
        public string? RenterId { get; set; }
        public ApplicationUser? Renter { get; set; }
    }
}
