using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cristea_Irinel_Lab5.Models;

namespace Cristea_Irinel_Lab5.Data
{
    public class Cristea_Irinel_Lab5Context : DbContext
    {
        public Cristea_Irinel_Lab5Context (DbContextOptions<Cristea_Irinel_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Cristea_Irinel_Lab5.Models.Book> Book { get; set; }

        public DbSet<Cristea_Irinel_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Cristea_Irinel_Lab5.Models.Category> Category { get; set; }
    }
}
