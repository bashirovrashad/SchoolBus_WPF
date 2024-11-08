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
    internal class Ride_Config : IEntityTypeConfiguration<Ride>
    {
        public void Configure(EntityTypeBuilder<Ride> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Starting_Address).IsRequired();
            builder.Property(x => x.Ending_Address).IsRequired();
            builder.HasIndex(x => x.Name).IsUnique();
        }
    }
}
