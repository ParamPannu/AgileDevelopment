<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementSystemDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
                <p>
   
</p>
<p>
    <asp:Label ID="OrderIDlbl" runat="server" height="32px" style="z-index: 1; left: 30px; top: 64px; position: absolute" Text="OrderID" width="143px"></asp:Label>
    <asp:Label ID="CustomerIDlbl" runat="server" height="32px" style="z-index: 1; left: 10px; top: 125px; position: absolute" Text="CustomerID" width="143px"></asp:Label>
    <asp:TextBox ID="CustomerIDtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 119px; position: absolute" width="248px"></asp:TextBox>
    <asp:Label ID="BokkIDlbl" runat="server" height="32px" style="z-index: 1; left: 26px; top: 180px; position: absolute" Text="ProductID" width="143px"></asp:Label>
    <asp:TextBox ID="OrderIDtxt" runat="server" style="z-index: 1; left: 328px; top: 64px; position: absolute"></asp:TextBox>
</p>
<asp:TextBox ID="BookIDtxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 180px; position: absolute" width="248px"></asp:TextBox>
<p>
    <asp:Button ID="Findbtn" runat="server" style="z-index: 1; left: 632px; top: 58px; position: absolute" Text="Find" OnClick="Findbtn_Click1" />
</p>
<p>
    &nbsp;</p>
<p>
    <asp:TextBox ID="OrderDatetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 249px; position: absolute" width="248px"></asp:TextBox>
</p>
<p>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 17px; top: 254px; position: absolute; height: 32px; margin-bottom: 0px" Text="Order Date"></asp:Label>
    <asp:TextBox ID="orderpricetxt" runat="server" height="38px" style="z-index: 1; left: 282px; top: 318px; position: absolute" width="248px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" height="32px" style="z-index: 1; left: 13px; top: 321px; position: absolute; width: 247px; margin-top: 0px;" Text="Order Price"></asp:Label>
</p>
<p>
    <asp:TextBox ID="OrderStatustxt" runat="server" height="38px" style="z-index: 1; left: 284px; top: 409px; position: absolute" width="248px"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Cancelbtn" runat="server" style="z-index: 1; top: 487px; position: absolute; left: 312px" Text="Cancel" OnClick="Cancelbtn_Click" />
</p>
<asp:Button ID="OKbtn" runat="server" OnClick="OKbtn_Click" style="z-index: 1; left: 156px; top: 487px; position: absolute" Text="OK" />
<p>
    <asp:Label ID="Label3" runat="server" height="32px" style="z-index: 1; left: 13px; top: 416px; position: absolute; bottom: 124px; width: 199px" Text="Order Status"></asp:Label>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 660px; top: 179px; position: absolute"></asp:Label>
        </p>
        <asp:Button ID="btnmenu" runat="server" OnClick="btnmenu_Click" style="z-index: 1; left: 497px; top: 486px; position: absolute" Text="Return to the Main Menu" />
    </form>
</body>
</html>
