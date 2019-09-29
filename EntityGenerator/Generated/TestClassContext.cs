using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityGenerator
{
    public class TestClassContext : DbContext
    {
        public TestClassContext() : base("TestDb")
        {
            Database.SetInitializer<TestClassContext>(new CreateDatabaseIfNotExists<TestClassContext>());
        }

        public DbSet<TestClass> TestClasss { get; set; }
    }

}