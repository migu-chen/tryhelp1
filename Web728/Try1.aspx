<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Try1.aspx.cs" Inherits="Web728.Try1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" OnInit="Button1_Init1"/>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_OnSelectedIndexChanged"
            AutoPostBack="true" OnInit="DropDownList1_Init1">
            <asp:ListItem>AAA<</asp:ListItem>
            <asp:ListItem>BBB<</asp:ListItem>
            <asp:ListItem>CCC<</asp:ListItem>
        </asp:DropDownList>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged"
            AutoPostBack="true" OnInit="RadioButtonList1_Init">
             <asp:ListItem>11AAA<</asp:ListItem>
            <asp:ListItem>22BBB<</asp:ListItem>
            <asp:ListItem>33CCC<</asp:ListItem>
            <asp:ListItem>444AAA<</asp:ListItem>
            <asp:ListItem>55BBB<</asp:ListItem>
            <asp:ListItem>66CCC<</asp:ListItem>
        </asp:RadioButtonList>
    </form>
</body>
</html>
