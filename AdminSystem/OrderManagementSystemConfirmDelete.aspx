<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderManagementSystemConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 343px; top: 53px; position: absolute" Text="Are you sure do you want to delete "></asp:Label>
<asp:Button ID="Nobtn" runat="server" style="z-index: 1; left: 498px; top: 100px; position: absolute" Text="No" OnClick="Nobtn_Click" />
<asp:Button ID="Yesbtn" runat="server" style="z-index: 1; left: 347px; top: 103px; position: absolute" Text="Yes" OnClick="Yesbtn_Click" />
    </form>
</body>
</html>
