using MailAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailAPI.DataAccess
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-D8VO00IR; database=MailAPIDb; integrated security=true;");
        }

        public DbSet<User> User { get; set; }
    }
}
