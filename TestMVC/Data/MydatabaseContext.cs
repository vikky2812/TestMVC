
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestMVC.Models;

namespace TestMVC.Data
{
    public class MydatabaseContext : DbContext
    {
        public MydatabaseContext(DbContextOptions<MydatabaseContext> options)
            : base(options)
        {

        }
        public DbSet<Course> Course { get; set; }
    }
}
