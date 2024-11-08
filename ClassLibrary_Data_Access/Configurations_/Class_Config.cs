using ClassLibrary_Models.Entities_.Concretes_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Data_Access.Configurations_
{
    internal class Class_Config : IEntityTypeConfiguration<Class_>
    {
        public void Configure(EntityTypeBuilder<Class_> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();

            builder.HasMany(c=>c.Students).WithOne(s=>s.Class_).HasForeignKey(s=>s.Class_Id);
        }
    }
}
