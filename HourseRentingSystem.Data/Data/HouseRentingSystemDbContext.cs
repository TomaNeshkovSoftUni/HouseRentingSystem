using HouseRentingSystem.Data.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseRentingSystem.Data.Data
{
    public class HouseRentingSystemDbContext : IdentityDbContext<ApplicationUser>
    {
        public HouseRentingSystemDbContext(DbContextOptions<HouseRentingSystemDbContext> options)
            : base(options)
        {

        }

        public DbSet<House> Houses { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Agent> Agents { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
