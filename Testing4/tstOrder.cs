using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrder
    {
        string OrderStatuss = "Delivered";
        string OrderPricee = "1";
        string OrderDatee = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        public void OrderStatusPropertyOK()

        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "Delivered";
            AnOrder.OrderStatus = TestData;
            Assert.AreEqual(AnOrder.OrderStatus, TestData);

        }
        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void BookIdPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.BookId = TestData;
            Assert.AreEqual(AnOrder.BookId, TestData);
        }
        public void OrderDatePropertyOK()
        {
            clsOrder Anorder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            Anorder.OrderDate = TestData;
            Assert.AreEqual(Anorder.OrderDate, TestData);

        }
        [TestMethod]
        public void OrderPricePropertyOK()
        {

            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderPrice = TestData;
            Assert.AreEqual(AnOrder.OrderPrice, TestData);

        }
        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderId = 3;
            Found = AnOrder.Find(OrderId);
            Assert.IsTrue(Found);


        }
        [TestMethod]
        public void TestOrderIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 3;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.CustomerId != 2)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestBookIdFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 3;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.BookId != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderDate()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderDate != Convert.ToDateTime("15/08/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderPrice()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 3;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderPrice != 2.0000)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestOrderStatusFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 2;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderStatus != "delivered")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void OrderPriceNoMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice;
            TestOrderPrice = -1;
            string OrderPricee = TestOrderPrice.ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceNoMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice;
            TestOrderPrice = 0;
            string OrderPricee = TestOrderPrice.ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceNoMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice;
            TestOrderPrice = 1;
            string OrderPricee = TestOrderPrice.ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceNoMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice;
            TestOrderPrice = 2147483646;
            string OrderPricee = TestOrderPrice.ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceNoMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice;
            TestOrderPrice = 2147483647;
            string OrderPricee = TestOrderPrice.ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");

        }
        /*************************************** ASK TO THE TUTOR ***********************************************************/
        [TestMethod]
        public void OrderPriceNoMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            int TestOrderPrice = 2147483647;
            //TestOrderPrice = 2147483648;
            string OrderPricee = (TestOrderPrice + 1).ToString();
            Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void OrderPriceNoMid()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderPrice = "1073741823";
            Error = Anorder.Valid(OrderPrice, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string OrderDatee = TestDate.ToString();
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateNoMinLessOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDatee = TestDate.ToString();
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");


        }
        [TestMethod]
        public void OrderDateNoMin()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string OrderDatee = TestDate.ToString();
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void OrderDateNoMinPlusOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string OrderDatee = TestDate.ToString();
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrdeDateExtremeMax()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string OrderDatee = TestDate.ToString();
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderStatusNoMinLessOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "";
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void OrderStatusNoMin()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "a";
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusNoMinPlusOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "aa";
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusNoMaxLessOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "";
            OrderStatuss = OrderStatuss.PadRight(49, 'a');
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void OrderStatusNoMax()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "";
            OrderStatuss = OrderStatuss.PadRight(50, 'a');
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void OrderStatusNoMaxPlusOne()
        {
            clsOrder Anorder = new clsOrder();
            String Error = "";
            string OrderStatuss = "";
            OrderStatuss = OrderStatuss.PadRight(51, 'a');
            Error = Anorder.Valid(OrderPricee, OrderStatuss, OrderDatee);
            Assert.AreNotEqual(Error, "");

        }

    }
}
