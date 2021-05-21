using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace weatherAPIProject.Models
{
    public class CityContext : DbContext
    {

        public CityContext() : base()
        {

        }
        public CityContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }

    }
    
}
