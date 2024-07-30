<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="Ecom.CartPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar navbar-expand-lg navbar-light bg-light">
    <a class="navbar-brand" href="IndexPage.aspx">E-Commerce</a>
    <div class="collapse navbar-collapse">
        <ul class="navbar-nav mr-auto">
            <li class="nav-item">
                <a class="nav-link" href="IndexPage.aspx">Home</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ProductsPage.aspx">Products</a>
            </li>
            <li class="nav-item">
                <a class="nav-link" href="ContactPage.aspx">Contact</a>
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="LogoutButton" runat="server" OnClick="LogoutButton_Click" CssClass="nav-link">Logout</asp:LinkButton>
            </li>
        </ul>
    </div>
</div>
        <asp:ListBox ID="lstCartItems" runat="server" Rows="10" Width="50%"></asp:ListBox>
        <asp:Label ID="lblTotal" runat="server" CssClass="total-label"></asp:Label>
    </form>
</body>
</html>
