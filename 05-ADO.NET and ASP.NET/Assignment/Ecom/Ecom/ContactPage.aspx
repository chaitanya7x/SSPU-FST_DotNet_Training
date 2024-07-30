<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="Ecom.ContactPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form runat="server">
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
                <a class="nav-link cart-icon" href="CartPage.aspx">
    <img src="cart-icon.png" alt="Cart" style="width: 30px;" />
</a>
            </div>
        </div>
        <div class="container">
            <h2>Welcome to Our E-Commerce Website!</h2>
            <h2>Contact Page</h2>
            <p>Browse our products and enjoy shopping.</p>
        </div>
         <div class="footer">
     <p>&copy; 2024 E-Commerce Website. All rights reserved.</p>
     <p><a href="PrivacyPolicy.aspx">Privacy Policy</a> | <a href="TermsOfService.aspx">Terms of Service</a></p>
 </div>
    </form>
</body>
</html>
