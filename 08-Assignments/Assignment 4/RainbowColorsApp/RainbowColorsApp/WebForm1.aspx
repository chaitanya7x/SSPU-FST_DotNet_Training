<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RainbowColorsApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rainbow Colors</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstColorsUppercase" runat="server" Width="150px" Height="150px"></asp:ListBox>
            <asp:ListBox ID="lstColorsLowercase" runat="server" Width="150px" Height="150px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
