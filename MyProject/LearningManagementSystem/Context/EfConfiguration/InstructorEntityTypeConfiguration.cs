using LearningManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Context.EfConfiguration
{
    public class InstructorEntityTypeConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.ToTable("Instructors");
            builder.HasIndex(s => s.Email).IsUnique();
            builder.HasIndex(s => s.PhoneNumber).IsUnique();

            



        }
    }
}
