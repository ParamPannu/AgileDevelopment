using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrderss = new clsOrder();


        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sporc_OrderTable_SelectAll");
            PopulateArray(DB);
        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_ID"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["Customer_ID"]);
                AnOrder.BookId = Convert.ToInt32(DB.DataTable.Rows[Index]["Book_ID"]);
                AnOrder.OrderDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Order_Date"]);
                AnOrder.OrderPrice = Convert.ToInt32(DB.DataTable.Rows[Index]["Order_Price"]);
                AnOrder.OrderStatus = Convert.ToString(DB.DataTable.Rows[Index]["Order_Status"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }




        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrderss;
            }
            set
            {
                mThisOrderss = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }
            set

            {
                mOrderList = value;
            }

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Customer_ID", mThisOrderss.CustomerId);
            DB.AddParameter("@Book_ID", mThisOrderss.BookId);
            DB.AddParameter("@Order_Date", mThisOrderss.OrderDate);
            DB.AddParameter("@Order_Price", mThisOrderss.OrderPrice);
            DB.AddParameter("@Order_Status", mThisOrderss.OrderStatus);
            return DB.Execute("sproc_OrderTable_Insert");
        }
        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_ID", mThisOrderss.OrderId);
            DB.AddParameter("@Customer_ID", mThisOrderss.CustomerId);
            DB.AddParameter("@Book_ID", mThisOrderss.BookId);
            DB.AddParameter("@Order_Date", mThisOrderss.OrderDate);
            DB.AddParameter("@Order_Price", mThisOrderss.OrderPrice);
            DB.AddParameter("@Order_Status", mThisOrderss.OrderStatus);
            DB.Execute("sproc_OrderTable_Update");

        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_ID", mThisOrderss.OrderId);
            DB.Execute("sproc_OrderTable_Delete");
        }
        public void ReportByOrderStatus(string OrderStatus)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Order_Status", OrderStatus);
            DB.Execute("sporc_OrderTableFilterByOrderStatus");
            PopulateArray(DB);

        }







    }
}