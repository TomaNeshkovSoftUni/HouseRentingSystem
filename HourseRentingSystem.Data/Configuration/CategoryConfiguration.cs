using Microsoft.VisualStudio.Services.Oidc;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using HouseRentingSystem.Data.Data.Entities;

namespace HouseRentingSystem.Data.Configuration
{
    public class CategoryConfiguration
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasData(SeedCategories());
        }

        private IEnumerable<Category> SeedCategories()
        {
            return new Category[]
            {
                new Category { Id = 1, Name = "Cottage" },
                new Category { Id = 2, Name = "Single-Family" },
                new Category { Id = 3, Name = "Duplex" },
                new Category { Id = 4, Name = "Townhouse" },
                new Category { Id = 5, Name = "Apartment" }
            };
        }
    }
}
