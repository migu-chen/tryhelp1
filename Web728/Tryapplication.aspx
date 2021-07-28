<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tryapplication.aspx.cs" Inherits="Web728.Tryapplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="ClickMe" OnClick="Button1_Click" />
        <br />
        <asp:Literal ID="Lit1Msg" runat="server"></asp:Literal> 
    </form>
</body>
</html>
