using System;
using System.Data.Entity;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class DataModelContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        public DataModelContext(ConnectionStringType connectionStringType)
        {
            if (connectionStringType == ConnectionStringType.Normal)
                Database.SetInitializer<DataModelContext>(new DataModelContextInitializer());
        }

        public DataModelContext(ConnectionStringType connectionStringType, string connectionString) : base(connectionString)
        {
            if (connectionStringType == ConnectionStringType.Normal)
                Database.SetInitializer<DataModelContext>(new DataModelContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
        }
    }
}
