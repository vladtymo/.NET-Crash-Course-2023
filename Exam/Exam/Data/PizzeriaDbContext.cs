using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Entities;
using System.Windows.Input;

namespace Exam.Data
{
    internal class PizzeriaDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<PizzaIngredient> PizzaIngredients { get; set; }

        public PizzeriaDbContext()
        {
           this.Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Pizzeria;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PizzaIngredient>().HasData(new[]
            {
                new PizzaIngredient { PizzaId = 1, IngredientId = 1 },
                new PizzaIngredient { PizzaId = 1, IngredientId = 2 },
                new PizzaIngredient { PizzaId = 1, IngredientId = 3 },
                new PizzaIngredient { PizzaId = 1, IngredientId = 4 },
            });
            modelBuilder.Entity<Ingredient>().HasData(new[]
            {
                new Ingredient() { Id = 1, Name = "Dough", Price = 0.99m },
                new Ingredient() { Id = 2, Name = "Tomato Sause", Price = 0.49m },
                new Ingredient() { Id = 3, Name = "Cheese", Price = 1.49m },
                new Ingredient() { Id = 4, Name = "Tomato", Price = 0.74m },
            });
            modelBuilder.Entity<Pizza>().HasData(new[]
            {
                new Pizza() { Id = 1, Name = "Margarita", Price = 0.99m }
            });

            modelBuilder.Entity<PizzaIngredient>().HasKey(pi => new {pi.PizzaId, pi.IngredientId });

            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Pizza)
                .WithMany(p => p.PizzaIngredients)
                .HasForeignKey(pi => pi.PizzaId);

            modelBuilder.Entity<PizzaIngredient>()
                .HasOne(pi => pi.Ingredient)
                .WithMany(i => i.PizzaIngredients)
                .HasForeignKey(pi => pi.IngredientId);

            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() { Id = 1, UserName = "root", Password = "1111", isAdmin = true, Email = "root@gmail.com", Phone = "+1 (111) 1111" },
                new User() { Id = 2, UserName = "user", Password = "1111", isAdmin = false, Email = "user@gmail.com", Phone = "+1 (111) 1111" },
            });
        }

    }
}
