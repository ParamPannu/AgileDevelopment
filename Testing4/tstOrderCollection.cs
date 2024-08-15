using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.BookId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderPrice = 1;
            TestItem.OrderStatus = "delivered";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }
        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.BookId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderPrice = 1;
            TestOrder.OrderStatus = "delivered";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);

        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderId = 1;
            TestItem.CustomerId = 1;
            TestItem.BookId = 1;
            TestItem.OrderDate = DateTime.Now;
            TestItem.OrderPrice = 1;
            TestItem.OrderStatus = "delivered";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.BookId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderPrice = 1;
            TestOrder.OrderStatus = "delivered";
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.BookId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderPrice = 1;
            TestOrder.OrderStatus = "delivered";
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            TestOrder.CustomerId = 2;
            TestOrder.BookId = 2;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderPrice = 2;
            TestOrder.OrderStatus = "on the way";
            AllOrders.ThisOrder = TestOrder;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);



        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.OrderId = 1;
            TestOrder.CustomerId = 1;
            TestOrder.BookId = 1;
            TestOrder.OrderDate = DateTime.Now;
            TestOrder.OrderPrice = 1;
            TestOrder.OrderStatus = "delivered";
            AllOrders.ThisOrder = TestOrder;
            PrimaryKey = AllOrders.Add();
            TestOrder.OrderId = PrimaryKey;
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }
        [TestMethod]
        public void ReportByOrderStatusNotFound()
        {
            clsOrderCollection FilteredOrder = new clsOrderCollection();
            FilteredOrder.ReportByOrderStatus("xxxxxx");
            Assert.AreEqual(0, FilteredOrder.Count);

        }
        [TestMethod]
        public void ReportByOrderStatusTestDataFound()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Boolean OK = true;
            AllOrders.ReportByOrderStatus("on the way");
            if (AllOrders.Count == 1)
            {
                if (AllOrders.OrderList[0].OrderId != 3)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        
    }
}
