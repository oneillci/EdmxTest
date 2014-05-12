using System;
using System.Data.Entity.Core.EntityClient;
using System.Linq;

namespace EdmxTest.DataModel
{
    public class DataModelContextFactory
    {
        public static DataModelContext CreateContext(ConnectionStringType connectionStringType)
        {
            var connString = @"Data Source=CIARANW8\SQLEXPRESS;Initial catalog=EdmxTest; Integrated Security=True; MultipleActiveResultSets=True";

            var entityBuilder = new EntityConnectionStringBuilder()
            {
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = connString,
                Metadata = @"res://*/Edmx.DataModel.Resources.EdmxTest.csdl|res://*/Edmx.DataModel.Resources.EdmxTest.ssdl|res://*/Edmx.DataModel.Resources.EdmxTest.msl"
            };

            if (connectionStringType == ConnectionStringType.Edmx)
            {
                connString = entityBuilder.ToString();                
            }
            var context = new DataModelContext(connString);
            return context;
        }
    }

    public enum ConnectionStringType
    {
        Normal,
        Edmx
    }
}
