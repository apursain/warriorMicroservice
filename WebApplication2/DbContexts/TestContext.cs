using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Model;

namespace WebApplication2.DbContexts
{
    public class TestContext : DbContext
    {
        
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
        }
        public DbSet<Test> lstTests { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().HasData(
                new Test
                {
                    Id = 1,
                    Name = "test1",
                    description="test1 description",
                },
                new Test
                {
                    Id = 2,
                    Name = "test2",
                    description = "test2 description",
                }
            );
        }
    }

}
