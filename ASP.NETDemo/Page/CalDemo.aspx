<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalDemo.aspx.cs" Inherits="ASP.NETDemo.CalDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Test</title>
</head>
<body>
 
    <form  runat="server">
        <asp:TextBox ID="text1" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnCopy" runat="server" Text="Button" OnClick="btnCopy_Click" /><br />
        <asp:TextBox ID="text2" runat="server"></asp:TextBox><br />
    </form>
</body>
</html>
