using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPIdemo.DataAccessLayer
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            OptionsBuilder.UseSqlServer("server=DESKTOP-1FS4KAI\\SQLEXPRESS;database=BootcampApiDB;integrated security=true;");

        }

        public DbSet<Employee> employees { get; set; }
    }
}
