<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClickCount.aspx.cs" Inherits="ASP.NETDemo.Page.ClickCount" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请点击按钮：<asp:Button ID="btnCount" runat="server" Text="Button" value="点击" OnClick="btnCount_Click" />
            <br />
            你点击了<asp:TextBox ID="text" runat="server">0</asp:TextBox>次
        </div>
    </form>
</body>
</html>
