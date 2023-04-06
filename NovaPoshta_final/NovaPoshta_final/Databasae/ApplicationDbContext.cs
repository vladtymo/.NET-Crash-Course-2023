using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NovaPoshta_final.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta_final.Databasae
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=NovaPoshta_Db;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PostOffice>().Property(x => x.PostNumber).IsRequired();


            modelBuilder.Entity<PostOffice>().HasMany(x => x.Employees)
                                             .WithOne(x => x.PostOffice)
                                             .HasForeignKey(x => x.PostOfficeId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Client>().HasMany(x => x.Parcels)
                                         .WithOne(x => x.Client)
                                         .HasForeignKey(x => x.ClientId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Client>().Ignore(x => x.Parcels).HasMany(x => x.Parcels)
                                         .WithOne(x => x.Addressee)
                                         .HasForeignKey(x => x.AddresseeId).OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<PostOffice> Offices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
