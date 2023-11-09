global using Microsoft.EntityFrameworkCore;
using SolutionStrips.DOMAIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionStrips.DATA.Context
{
    public class SolutionStripsContext : DbContext
    {
        public SolutionStripsContext(DbContextOptions<SolutionStripsContext> options) : base(options) { }

        public DbSet<Auteur> Auteurs { get; set; } // Use a getter method here
        public DbSet<Strip> Strips { get; set; } // Use a getter method here





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
