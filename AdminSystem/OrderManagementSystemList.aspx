<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementSystemList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 2px; top: 539px; position: absolute" Text="filter by order status"></asp:Label>
</div>
<asp:ListBox ID="lstOrderList" runat="server" Height="372px" Width="451px"></asp:ListBox>
<p>
    <asp:Button ID="Addbtn" runat="server" OnClick="Addbtn_Click" style="z-index: 1; left: 43px; top: 442px; position: absolute" Text="Add" />
    <asp:TextBox ID="txtReport" runat="server" style="z-index: 1; left: 144px; top: 541px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnmenu" runat="server" style="z-index: 1; left: 381px; top: 442px; position: absolute" Text="Return to the Main Menu" OnClick="btnmenu_Click1" />
</p>
<asp:Button ID="Editbtn" runat="server" OnClick="Editbtn_Click" style="z-index: 1; left: 148px; top: 442px; position: absolute" Text="Edit" />
<asp:Button ID="Deletebtn" runat="server" OnClick="Deletebtn_Click" style="z-index: 1; left: 269px; top: 441px; position: absolute" Text="Delete" />
<asp:Label ID="lblError" runat="server" style="z-index: 1; left: 98px; top: 488px; position: absolute" Text="lblError"></asp:Label>
<asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 33px; top: 585px; position: absolute" Text="Apply" />
<p>
    <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 167px; top: 581px; position: absolute" Text="Clear" />
</p>
    </form>
</body>
</html>
