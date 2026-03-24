using HouseRentingSystem.Data.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static HouseRentingSystem.Data.Data.DataConstants.Category;
namespace HouseRentingSystem.Data.Data.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }
        public IEnumerable<House> Houses { get; init; } = new List<House>();
    }
}
