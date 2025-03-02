using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    public class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {

        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary).HasColumnType("decimal(18,2)");

            builder.Property(I => I.Bouns).HasColumnType("decimal(18,2)");
            builder.HasOne(I=>I.ManageDepartment).WithOne(D=>D.Manager).HasForeignKey<Department>(D=>D.MangerId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
