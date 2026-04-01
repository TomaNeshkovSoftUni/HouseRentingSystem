using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using HouseRentingSystem.Data.Data;
using HouseRentingSystem.Data.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configuration
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder
              .HasOne(h => h.Category)
              .WithMany(c => c.Houses)
              .HasForeignKey(h => h.CategoryId)
              .OnDelete(DeleteBehavior.Restrict);
            builder
                .HasOne(h => h.Agent)
                .WithMany(a => a.ManagedHouses)
                .HasForeignKey(h => h.AgentId)
                .OnDelete(DeleteBehavior.Restrict);
            builder.HasData(SeedHouses());
        }

        public IEnumerable<House> SeedHouses()
        {
            return new House[]
            {
                //new House
                //{
                //    Id = 1,
                //    Title = "Hristo house",
                //    Address = "Shar planiina 27",
                //    Description = "Fat",
                //    ImageUrl = "https://nivel.bg/wp-content/uploads/2019/09/Shar-planina-2.jpg",
                //    PricePerMonth = 100.00M,
                //    CategoryId = 1,
                //    AgentId = 1
                //},

                //new House
                //{
                //    Id = 2,
                //    Title = "Softuni BUDITEL Mladost",
                //    Address = "Bul. Aleksandyr Malinov 78",
                //    Description = "Daskalo",
                //    ImageUrl = "https://buditel.softuni.bg/wp-content/uploads/elementor/thumbs/IMG_0388-scaled-2-e1683035514550-q5vhxykej9cf1dmtu5osg2dohi4um9vtxe1quq2nj4.jpg",
                //    PricePerMonth = 150.00M,
                //    CategoryId = 2,
                //    AgentId = 1
                //},

                //new House
                //{
                //    Id = 3,
                //    Title = "Elmo party club",
                //    Address = "Pirotska 139",
                //    Description = "Party time",
                //    ImageUrl = "https://clubcheta.com/wp-content/uploads/2023/02/%D0%95%D0%BB%D0%BC%D0%BE-2-580x387.jpg",
                //    PricePerMonth = 50.00M,
                //    CategoryId = 3,
                //    AgentId = 2
                //}
            };
        }
    }
}
