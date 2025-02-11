using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MovieAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAPI.Persistence.Context
{
    public class MovieContext : DbContext
    {
        //public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            //base.OnConfiguring(optionsBuilder);
            string connectionString = "Host=localhost;Database=MovieAPI;Username=postgres;Password=12345;Port=5432;TrustServerCertificate=true;";//integrated Security=true
           // optionsBuilder.UseNpgsql(connectionString);
            opt.UseNpgsql(connectionString);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
