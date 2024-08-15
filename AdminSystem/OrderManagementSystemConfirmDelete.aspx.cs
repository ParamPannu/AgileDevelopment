using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    Int32 OrderId;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderId = Convert.ToInt32(Session["Order_ID"]);
    }

    protected void Yesbtn_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ThisOrder.Find(OrderId);
        AllOrders.Delete();
        Response.Redirect("OrderManagementSystemList.aspx");
    }

    protected void Nobtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderManagementSystemList.aspx");
    }
}