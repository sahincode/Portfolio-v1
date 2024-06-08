using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portfolio.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Surname).IsRequired().HasMaxLength(200);
            builder.Property(c => c.ImageUrl).IsRequired().HasMaxLength(100);
            builder.Property(c => c.GitHub).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Insta).IsRequired().HasMaxLength(200);
            builder.Property(c => c.LinkedIn).IsRequired().HasMaxLength(200);
            builder.Property(c => c.Facebook).IsRequired().HasMaxLength(200);
        }
    }
}
