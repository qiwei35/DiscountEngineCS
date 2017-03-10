using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Avengers;

namespace OrderTrackerTestProject
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void TestAddRedDress()
        {
            Product redDress = ProductCatalog.GetProduct("redDress");

            Order myOrder = new Order();
            myOrder.Add(redDress, 2);

            Assert.AreEqual(redDress, myOrder.Items[0].Product);

        }

        public void TestTotalQuantity()
        {
            Product redDress = ProductCatalog.GetProduct("redDress");
            Product blueDress = ProductCatalog.GetProduct("blueDress");

            Order myOrder = new Order();
            myOrder.Add(redDress, 2);
            myOrder.Add(blueDress, 5);

            Assert.AreEqual(7, myOrder.TotalQty);

        }
    }
}
