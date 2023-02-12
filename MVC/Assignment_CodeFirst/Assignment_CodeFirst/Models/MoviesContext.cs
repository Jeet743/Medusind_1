using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment_CodeFirst.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext():base("name=Movies")
        {

        }

        public DbSet<Movies> Movie { get; set; }

    }
}