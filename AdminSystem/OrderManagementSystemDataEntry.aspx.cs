using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["Order_ID"]);
        if (IsPostBack == false)
        {
            if (OrderId != 1)
            {
                DisplayOrders();
            }

        }
    }

    protected void OKbtn_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        String OrderID = OrderIDtxt.Text;
        String CustomerID = CustomerIDtxt.Text;
        String BookID = BookIDtxt.Text;
        String OrderDatee = OrderDatetxt.Text;
        String OrderPricee = orderpricetxt.Text;
        String OrderStatuss = OrderStatustxt.Text;
        String Error = "";
        Error = AnOrder.Valid(OrderPricee, OrderStatuss, OrderDatee);
        if (Error == "")
        {
            AnOrder.OrderId = OrderId;
            AnOrder.CustomerId = Convert.ToInt32(CustomerID);
            AnOrder.BookId = Convert.ToInt32(BookID);
            AnOrder.OrderPrice = Convert.ToInt32(OrderPricee);
            AnOrder.OrderStatus = OrderStatuss;
            AnOrder.OrderDate = Convert.ToDateTime(OrderDatee);
            clsOrderCollection AllOrders = new clsOrderCollection();
            if (OrderId == -1)
            {
                AllOrders.ThisOrder = AnOrder;
                AllOrders.Add();

            }
            else
            {
                AllOrders.ThisOrder.Find(OrderId);
                AllOrders.ThisOrder = AnOrder;
                AllOrders.Update();
            }

            Response.Redirect("OrderManagementSystemList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void Cancelbtn_Click(object sender, EventArgs e)
    {

        Response.Redirect("OrderManagementSystemList.aspx");
    }

    protected void Findbtn_Click1(object sender, EventArgs e)
    {

        clsOrder AnOrder = new clsOrder();
        Int32 OrderId;
        Boolean Found = false;
        OrderId = Convert.ToInt32(OrderIDtxt.Text);
        if (OrderId != 0)
        {
            Found = AnOrder.Find(OrderId);
            if (Found == true)
            {
                CustomerIDtxt.Text = AnOrder.CustomerId.ToString();
                BookIDtxt.Text = AnOrder.BookId.ToString();
                OrderDatetxt.Text = AnOrder.OrderDate.ToString();
                orderpricetxt.Text = AnOrder.OrderPrice.ToString();
                OrderStatustxt.Text = AnOrder.OrderStatus;

            }
            else
            {
                lblError.Text = "Order ID Not Find";
            }
        }
        else
        {

        }

    }
    void DisplayOrders()
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ThisOrder.Find(OrderId);
        OrderIDtxt.Text = AllOrders.ThisOrder.OrderId.ToString();
        CustomerIDtxt.Text = AllOrders.ThisOrder.CustomerId.ToString();
        BookIDtxt.Text = AllOrders.ThisOrder.BookId.ToString();
        OrderDatetxt.Text = AllOrders.ThisOrder.OrderDate.ToString();
        orderpricetxt.Text = AllOrders.ThisOrder.OrderPrice.ToString();
        OrderStatustxt.Text = AllOrders.ThisOrder.OrderStatus;
    }

    protected void btnmenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}