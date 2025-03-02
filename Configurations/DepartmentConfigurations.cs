using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Name).HasColumnType("varchar(50)");

            builder.Property(D => D.HiringDate).HasDefaultValueSql("getdate()");

            builder.Property(D => D.Id).UseIdentityColumn(1, 1);
      
            builder.HasMany(D=>D.Instructors).WithOne(I=>I.Depart).HasForeignKey(I => I.DepartmentId).OnDelete(DeleteBehavior.Restrict).IsRequired(false); 
        }
    }
}
