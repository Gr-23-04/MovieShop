using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MovieShop.Models;

namespace MovieShop.Data
{


    public class MovieShopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public MovieShopDbContext(DbContextOptions<MovieShopDbContext> options)
            : base(options)
        {
        }

    }

}
