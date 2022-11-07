using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configuration
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Message> Message { get; set; }
        public DbSet<ApplicationUser> ApplicationUser  { get; set; }

        public string GetConectionString()
        {
            return "Data Source=DESKTOP-L7AOOA8\\SQLEXPRESS;Initial Catalog=API_DDD_2022;Integrated Security=False;User ID=rubem;Password=";
        }
    }
}
