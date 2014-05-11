using System;
using System.Data.Entity.Core.EntityClient;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class DataModelContextFactory
    {
        public static DataModelContext CreateContext()
        {
            var connString = @"Data Source=CIARANW8\SQLEXPRESS;Initial catalog=EdmxTest; Integrated Security=True; MultipleActiveResultSets=True";

            var entityBuilder = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = connString,
                Metadata = @"res://*/AdventureWorksModel.csdl|
                             res://*/AdventureWorksModel.ssdl|
                             res://*/AdventureWorksModel.msl"
            };

            var connectionString = entityBuilder.ToString();
            var context = new DataModelContext(connString);
            return context;
        }
    }
}
