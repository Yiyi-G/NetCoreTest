using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreLibrary.Data
{
    public class TestCoreDBContext:DbContext
    {
        public TestCoreDBContext(DbContextOptions<TestCoreDBContext> options):base(options)
        { 
            
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Tickt> Tickts { get; set; }
    }
}
