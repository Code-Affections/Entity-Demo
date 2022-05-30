using Microsoft.EntityFrameworkCore;
using SampleEntityDemo.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityDemo.db
{
    public class StudentDbContext: DbContext
    {
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Address> Addresses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ZABCD_DB;Trusted_Connection=True;");
        }

    }
}
