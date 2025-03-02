using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {

       public void Configure(EntityTypeBuilder<Student> builder)
        {
           builder.Property(S => S.Address).HasDefaultValue("Cairo");
            builder.Property(S => S.FName).HasColumnType("varchar(50)");

            builder.Property(S => S.LName).HasColumnType("varchar(50)");

        }

    }
}
