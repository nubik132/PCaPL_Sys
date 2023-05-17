using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаб26Console
{
    class ApplicationContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AUDIT204_1\\SQLEXPRESS;Database=Buses;Trusted_Connection=True;TrustServerCertificate=True;");
        }

    }
}
