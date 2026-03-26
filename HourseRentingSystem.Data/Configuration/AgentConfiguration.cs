using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HouseRentingSystem.Data.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HouseRentingSystem.Data.Configuration
{
    internal class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            // builder.HasData(SeedAgents());
        }

        public IEnumerable<Agent> SeedAgents()
        {
            return new Agent[]
            {
                new Agent
                {
                    Id = 1,
                    PhoneNumber = "0888888888",
                    UserId = "1"
                },

                new Agent
                {
                    Id = 2,
                    PhoneNumber = "0812345678",
                    UserId = "1"
                }

            };
        }
    }
}
