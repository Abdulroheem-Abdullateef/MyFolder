using LearningManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningManagementSystem.Context.EfConfiguration
{
    public class DepartmentEntityTypeConfiguration : IEntityTypeConfiguration<Department>
    {


        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            


        }
    }
}
