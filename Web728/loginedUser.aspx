<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginedUser.aspx.cs" Inherits="Web728.loginedUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="textAccount" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="textPassword" runat="server"></asp:TextBox>
        <asp:Literal ID="ltMessage" runat="server"></asp:Literal>

        
        <asp:Literal ID="ItUser" runat="server"></asp:Literal>
        <asp:Button ID="btnLog" runat="server" Text="Button" OnClick="btnLogout_Click" />
    </form>
</body>
</html>
