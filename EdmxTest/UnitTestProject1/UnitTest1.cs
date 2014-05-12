using System;
using System.Linq;
using Edmx.DataModel.Resources;
using EdmxTest.DataModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var context = DataModelContextFactory.CreateContext(ConnectionStringType.Normal);

            var first = context.Teams.First();

            Assert.AreEqual(1, first.Id);
        }

        [TestMethod]
        public void Test_EdmxHelper()
        {
            var helper = new EdmxHelper();

            helper.WriteEdmxComponents();
        }
    }
}
