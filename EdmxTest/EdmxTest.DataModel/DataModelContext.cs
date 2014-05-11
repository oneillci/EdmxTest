using System;
using System.Data.Entity;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class DataModelContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DataModelContext()
        {

        }

        public DataModelContext(string connectionString) : base(connectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<DataModelContext>(new DataModelContextInitializer());
        }
    }
}
