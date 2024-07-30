<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Ecom.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
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
            <h2>Register</h2>
            <div class="form-group">
                <label for="username">Username</label>
                <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server"
                    ControlToValidate="username"
                    ErrorMessage="Username is required."
                    Display="Dynamic" CssClass="text-danger" />
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <asp:TextBox ID="password" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                    ControlToValidate="password"
                    ErrorMessage="Password is required."
                    Display="Dynamic" CssClass="text-danger" />
            </div>
             <div class="form-group">
                <label for="confirmPassword">Confirm Password</label>
                <asp:TextBox ID="txtConfirmPassword" TextMode="Password" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server"
                    ControlToValidate="txtConfirmPassword"
                    ErrorMessage="Please confirm password."
                    Display="Dynamic" CssClass="text-danger" />
                <asp:CompareValidator ID="cvPasswords" runat="server" 
                    ControlToCompare="password" 
                    ControlToValidate="txtConfirmPassword" 
                    ErrorMessage="Passwords do not match." 
                    CssClass="text-danger" />
            </div>
            <asp:Button ID="registerButton" CssClass="btn btn-primary" Text="Register" runat="server" OnClick="RegisterButton_Click" />
        </div>

    </form>
</body>
</html>
