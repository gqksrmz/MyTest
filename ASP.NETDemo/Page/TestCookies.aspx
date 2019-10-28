<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestCookies.aspx.cs" Inherits="ASP.NETDemo.Page.TestCookies" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            请输入一个字符串<br />
&nbsp;<asp:TextBox ID="text" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSavaToCookies" runat="server" Text="将字符串保存到Cookies" OnClick="btnSavaToCookies_Click" />
            <br />

        </div>
    </form>
</body>
</html>
