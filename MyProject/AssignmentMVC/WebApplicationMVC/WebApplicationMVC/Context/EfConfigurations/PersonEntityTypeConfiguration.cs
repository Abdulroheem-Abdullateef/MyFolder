using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVC.Entities;

namespace WebApplicationMVC.Context.EfConfigurations
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Persons");
            builder.Property(s => s.Id)
                .HasColumnType("int").IsRequired();
            builder.HasIndex(s => s.Email).IsUnique();
            builder.HasMany(s => s.CityPersons).WithOne(s => s.Person)
                .HasForeignKey(s => s.PersonId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
