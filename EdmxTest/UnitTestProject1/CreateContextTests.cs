using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using EdmxTest.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CreateContextTests
    {
        [TestMethod]
        public void CreateContext_WithNormalConnectionString()
        {
            var context = DataModelContextFactory.CreateContext(ConnectionStringType.Normal);

            var first = context.Teams.First();

            Assert.AreEqual(1, first.Id);
        }

        [TestMethod]
        public void CreateContext_WithEdmxConnectionString()
        {
            Assembly.Load("Edmx.DataModel.Resources");
            var context = DataModelContextFactory.CreateContext(ConnectionStringType.Edmx);

            var first = context.Teams.First();

            Assert.AreEqual(1, first.Id);
        }

    }
}
