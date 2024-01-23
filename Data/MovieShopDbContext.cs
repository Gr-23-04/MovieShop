using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MovieShop.Models;

namespace MovieShop.Data
{


    public class MovieShopDbContext : DbContext
    {

        public MovieShopDbContext() { } 
        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderRow> OrderRows { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MovieShopDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        //}
    }


}
