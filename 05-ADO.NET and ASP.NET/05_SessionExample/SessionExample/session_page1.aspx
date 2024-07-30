<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session_page1.aspx.cs" Inherits="SessionExample.session_page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Usename: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            Password:  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" style="margin-bottom: 1px" Text="Submit" Width="68px" />
        </p>
    </form>
</body>
</html>
