<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Ecom.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
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
                        <a class="nav-link" href="LoginPage.aspx">Login</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="RegisterPage.aspx">Register</a>
                    </li>
                </ul>
            </div>
        </div>
       <div class="container">
             <h2>Login</h2>
            <div class="form-group">
                <label for="username">Username</label>
                <asp:TextBox ID="Lusername" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server"
                    ControlToValidate="Lusername"
                    ErrorMessage="Username is required."
                    Display="Dynamic" CssClass="text-danger" />
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox ID="Lpassword" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                    ControlToValidate="Lpassword"
                    ErrorMessage="Password is required."
                    Display="Dynamic" CssClass="text-danger" />
            </div>
            <asp:Button ID="loginButton" CssClass="btn btn-primary" Text="Login" runat="server" OnClick="LoginButton_Click" />
           <asp:Label ID="lblMessage" runat="server" CssClass="text-danger"></asp:Label>
        </div>
    </form>
</body>
</html>
