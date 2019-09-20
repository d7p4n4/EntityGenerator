using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityGenerator
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("PersonDb")
        {
            Database.SetInitializer<PersonContext>(new CreateDatabaseIfNotExists<PersonContext>());
        }

        public DbSet<PersonBase> PersonBases { get; set; }
    }

}
