using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
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
                    WriteComponent(stream, "ConceptualModels", "Schema", "EdmxTest.csdl");
                    WriteComponent(stream, "Mappings", "Mapping", "EdmxTest.csdl");
                    WriteComponent(stream, "StorageModels", "Schema", "EdmxTest.csdl");
                } 
            }
        }
  
        private void WriteComponent(MemoryStream stream, string nodeToFind, string subNode, string fileName)
        {
            stream.Seek(0, SeekOrigin.Begin);
            var document = XDocument.Load(stream);
           
            var content = (from node in document.Descendants().Where(x => x.Name.LocalName.Equals("Runtime", StringComparison.OrdinalIgnoreCase))
                                                .Descendants().Where(x => x.Name.LocalName.Equals(nodeToFind, StringComparison.OrdinalIgnoreCase))
                                                .Descendants().Where(x => x.Name.LocalName.Equals(subNode, StringComparison.OrdinalIgnoreCase))
                           select node).FirstOrDefault();

            if (content != null)
            {
                using (var xwriter = XmlWriter.Create(fileName, new XmlWriterSettings() { Indent = true }))
                {
                    content.WriteTo(xwriter);
                }
            }
        }
    }
}
