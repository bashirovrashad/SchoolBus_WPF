using ClassLibrary_Models.Entities_.Concretes_;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Data_Access.Contexts_
{
    internal class SchoolBusDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string aaa = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SchoolBusDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
          
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(aaa);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Class_> Class_s { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Ride> Rides { get; set; }
        public virtual DbSet<Student> Students { get; set; }

    }
}
