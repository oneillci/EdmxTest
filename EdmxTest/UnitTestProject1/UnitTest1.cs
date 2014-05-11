using System;
using System.Linq;
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
            var context = DataModelContextFactory.CreateContext();

            var first = context.Teams.First();

            Assert.AreEqual(1, first.Id);
        }
    }
}
