<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrySession.aspx.cs" Inherits="Web728.TrySession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnClick" runat="server" Text="ClickMe" OnClick="btnClick_Click" />
        <br />
        <asp:Literal ID="Ltlmag" runat="server"></asp:Literal>
    </form>
</body>
</html>
