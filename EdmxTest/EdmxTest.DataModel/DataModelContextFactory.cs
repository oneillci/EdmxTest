using System;
using System.Data.Entity.Core.EntityClient;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class DataModelContextFactory
    {

        public DataModelContext CreateContext()
        {
            var entityBuilder = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = "data source=.;Initial catalog=EdmxTest; Integrated Security=true;",
                Metadata = @"res://*/AdventureWorksModel.csdl|
                             res://*/AdventureWorksModel.ssdl|
                             res://*/AdventureWorksModel.msl"
            };


            // Set the provider-specific connection string.

            // Set the Metadata location.
            Console.WriteLine(entityBuilder.ToString());
            var context = new DataModelContext();
            return context;
        }
    }
}
