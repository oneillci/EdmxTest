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
            Database.SetInitializer<DataModelContext>(new DataModelContextInitializer());
        }

        public DataModelContext(string connectionString) : base(connectionString)
        {
            Database.SetInitializer<DataModelContext>(new DataModelContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
