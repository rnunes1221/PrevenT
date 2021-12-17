using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PreventWebMVC.Models;

namespace PreventWebMVC.Data
{
    public class PreventWebMVCContext : DbContext
    {
        public PreventWebMVCContext(DbContextOptions<PreventWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computer { get; set; }
        public DbSet<Prev> Prev { get; set; }
        public DbSet <Login> Login { get; set; }


    }
}
