<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStateExample.aspx.cs" Inherits="ProjectWebApplication3.ViewStateExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>View State</h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Restore" />
        </p>
    </form>
</body>
</html>
