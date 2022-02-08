using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordManager.Models;

namespace PasswordManager.DataAcces
{
    public class PasswordManagerDbContext:DbContext
    {
        public PasswordManagerDbContext():base("PasswordManagerDB")
        {
            
        }

        public DbSet<Passwords> Passwords { get; set; }
    }
}
