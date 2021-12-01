using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PetCinemaDAL.Entities;

namespace PetCinemaDAL.EF
{
    public class PetCinemaContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public PetCinemaContext(DbContextOptions<PetCinemaContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
