using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrderss();
        }
        

        clsOrderUser AnUser =  new clsOrderUser();
        AnUser = (clsOrderUser)Session["Anuser"];
        Response.Write("Logged in as: " + AnUser.UserName);

    }
    void DisplayOrderss()
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();

    }
    protected void Addbtn_Click(object sender, EventArgs e)
    {
        Session["Order_ID"] = -1;
        Response.Redirect("OrderManagementSystemDataEntry.aspx");
    }

    protected void Deletebtn_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["Order_ID"] = OrderId;
            Response.Redirect("OrderManagementSystemConfirmDelete.aspx");

        }
        else
        {
            lblError.Text = "please select a record from list";
        }
    }

    protected void Editbtn_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["Order_ID"] = OrderId;
            Response.Redirect("OrderManagementSystemDataEntry.aspx");
        }
        else
        {
            lblError.Text = "please select a record from list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ReportByOrderStatus(txtReport.Text);
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection AllOrders = new clsOrderCollection();
        AllOrders.ReportByOrderStatus("");
        txtReport.Text = "";
        lstOrderList.DataSource = AllOrders.OrderList;
        lstOrderList.DataValueField = "OrderId";
        lstOrderList.DataTextField = "OrderStatus";
        lstOrderList.DataBind();
    }

    protected void btnmenu_Click(object sender, EventArgs e)
    {
        
    }

    protected void btnmenu_Click1(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}