using BestMovies.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BestMovies.DB
{
    public class BestMoviesDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public BestMoviesDBContext() : base(@"server=(localdb)\MSSQLLocalDB;database=BestMovies")
        {
        }
    }
}