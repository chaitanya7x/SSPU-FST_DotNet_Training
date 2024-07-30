<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexPage.aspx.cs" Inherits="Ecom.IndexPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <style>
        .footer {
            background-color: #f1f1f1;
            padding: 20px;
            text-align: center;
        }

        .cart-icon {
            position: relative;
        }
    </style>
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
            <h2>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                &nbsp;Welcome to Our E-Commerce Website!
            </h2>
            <p>Browse our products and enjoy shopping.</p>
            <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" data-interval="3000">
                <ol class="carousel-indicators">
                    <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                    <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                </ol>
                <div class="carousel-inner">
                    <div class="carousel-item active">
                        <img class="d-block w-100" src="banner-1.jpg" alt="First slide">
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100" src="banner-2.jpg" alt="Second slide">
                    </div>
                    <div class="carousel-item">
                        <img class="d-block w-100" src="banner-3.jpg" alt="Third slide">
                    </div>
                </div>
                <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                    <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                    <span class="carousel-control-next-icon" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>


        </div>
        <div class="footer">
            <p>&copy; 2024 E-Commerce Website. All rights reserved.</p>
            <p><a href="PrivacyPolicy.aspx">Privacy Policy</a> | <a href="TermsOfService.aspx">Terms of Service</a></p>
        </div>
    </form>
</body>
</html>
