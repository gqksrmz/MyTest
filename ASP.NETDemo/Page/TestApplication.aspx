<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestApplication.aspx.cs" Inherits="ASP.NETDemo.Page.TestApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnC" runat="server" Text="清除访问人数" style="height: 21px" OnClick="btnC_Click" />
        </div>
        <asp:Literal ID="lit1" runat="server"></asp:Literal>
    </form>
</body>
</html>
