using HouseRentingSystem.Data.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HouseRentingSystem.Data.Configuration;

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
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new HouseConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
