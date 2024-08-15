<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

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
    &nbsp;</p>
<p>
    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 540px; top: 519px; position: absolute" Text="Login" />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 708px; top: 521px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
</p>
<asp:Label ID="Label1" runat="server" style="z-index: 1; left: 414px; top: 352px; position: absolute" Text="Username"></asp:Label>
<p>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 414px; top: 430px; position: absolute" Text="Password"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 568px; top: 349px; position: absolute"></asp:TextBox>
</p>
<asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 566px; top: 418px; position: absolute" TextMode="Password"></asp:TextBox>
<asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 920px; top: 400px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
