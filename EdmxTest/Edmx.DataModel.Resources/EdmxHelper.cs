using System;
using System.IO;
using System.Linq;
using System.Xml;
using EdmxTest.DataModel;

namespace Edmx.DataModel.Resources
{
    public class EdmxHelper
    {
        public void WriteEdmxComponents()
        {
            using (var context = DataModelContextFactory.CreateContext(ConnectionStringType.Normal))
            {               
                using (var stream = new MemoryStream())
                using (var writer = XmlWriter.Create(stream))
                {
                    System.Data.Entity.Infrastructure.EdmxWriter.WriteEdmx(context, writer);
                    WriteComponent(stream, "Conceptual", "", "EdmxTest.csdl");
                } 
            }
        }
  
        private void WriteComponent(MemoryStream stream, string nodeToFind, string subNode, string fileName)
        {
            stream.Seek(0, SeekOrigin.Begin);

            
            var reader = XmlReader.Create(stream);

            var item = from node in reader.De
        }
    }
}
