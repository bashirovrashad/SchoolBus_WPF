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
    internal class Car_Config : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);   
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Number).IsRequired();           
            builder.HasIndex(x => x.Number).IsUnique();
          
           

            builder.HasOne(c => c.Driver).WithOne(d => d.Car).HasForeignKey<Driver>(d=>d.CarId);
            builder.HasMany(c => c.Students).WithOne(s => s.Car).HasForeignKey(s=>s.CarId);


        }
    }
}
