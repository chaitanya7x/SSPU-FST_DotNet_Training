<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductsPage.aspx.cs" Inherits="Ecom.Products" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Products</title>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" rel="stylesheet" />
    <style>
        .bg-banner {
            position: absolute;
            height: 200px;
            left: 0;
            right: 0;
            top: 56px;
            background: #FFFFFF;
            box-shadow: 0px 1px 1px rgba(0, 0, 0, 0.16);
            display: flex;
            justify-content: space-around;
            align-items: center;
        }

            .bg-banner img {
                height: 100px;
                cursor: pointer;
            }

        .product-img {
            width: 228px;
            height: 250px;
        }

        .product-details {
            display: none;
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
        <div class="bg-banner">
            <asp:ImageButton ID="imgGrocery" runat="server" ImageUrl="grocery.png" OnClick="Category_Click" CommandArgument="Grocery" />
            <asp:ImageButton ID="imgMobiles" runat="server" ImageUrl="mobiles.png" OnClick="Category_Click" CommandArgument="Mobiles" />
            <asp:ImageButton ID="imgFashion" runat="server" ImageUrl="fashion.png" OnClick="Category_Click" CommandArgument="Fashion" />
            <asp:ImageButton ID="imgElectronics" runat="server" ImageUrl="electronics.png" OnClick="Category_Click" CommandArgument="Electronics" />
            <asp:ImageButton ID="imgHome" runat="server" ImageUrl="home.png" OnClick="Category_Click" CommandArgument="Home" />
            <asp:ImageButton ID="imgAppliances" runat="server" ImageUrl="appliances.png" OnClick="Category_Click" CommandArgument="Appliances" />
        </div>
        <div class="container" style="margin-top: 200px;">
            <asp:MultiView ID="MultiView1" runat="server">
                <asp:View ID="ViewGrocery" runat="server">
                    <h2>Grocery</h2>
                    <div class="row">
                        <div class="col-md-3">
                            <div class="card">
                                <img class="card-img-top" src="product-img.png" alt="Grocery1">
                                <div class="card-body">
                                    <h5 class="card-title">Grocery Item 1</h5>
                                    <p class="card-text">1000</p>
                                    <asp:Button ID="btnAddGrocery1" runat="server" Text="Add to Cart"
                                        CssClass="btn btn-primary"
                                        data-name="Grocery Item 1" data-price="1000"
                                        OnClick="AddToCart_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="card">
                                <img class="card-img-top" src="product-img.png" alt="Grocery2">
                                <div class="card-body">
                                    <h5 class="card-title">Grocery Item 2</h5>
                                    <p class="card-text">200</p>
                                    <asp:Button ID="Button2" runat="server" Text="Add to Cart"
                                        CssClass="btn btn-primary"
                                        data-name="Grocery Item 2" data-price="200"
                                        OnClick="AddToCart_Click" />
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="card">
                                <img class="card-img-top" src="product-img.png" alt="Grocery3">
                                <div class="card-body">
                                    <h5 class="card-title">Grocery Item 3</h5>
                                    <p class="card-text">800</p>
                                    <asp:Button ID="Button3" runat="server" Text="Add to Cart"
                                        CssClass="btn btn-primary"
                                        data-name="Grocery Item 3" data-price="800"
                                        OnClick="AddToCart_Click" />
                                </div>
                            </div>
                        </div>
                </asp:View>
                <asp:View ID="ViewMobiles" runat="server">
                    <h2>Mobiles</h2>
                    <div class="row">
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('4')" />
                            <button class="btn btn-primary" onclick="showProductDetails('4')">Add to Cart</button>
                            <div id="details-4" class="product-details">
                                <p>Mobile 1 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('5')" />
                            <button class="btn btn-primary" onclick="showProductDetails('5')">Add to Cart</button>
                            <div id="details-5" class="product-details">
                                <p>Mobile 2 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('6')" />
                            <button class="btn btn-primary" onclick="showProductDetails('6')">Add to Cart</button>
                            <div id="details-6" class="product-details">
                                <p>Mobile 3 details...</p>
                            </div>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="ViewFashion" runat="server">
                    <h2>Fashion</h2>
                    <div class="row">
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('7')" />
                            <button class="btn btn-primary" onclick="showProductDetails('7')">Add to Cart</button>
                            <div id="details-7" class="product-details">
                                <p>Fashion 1 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('8')" />
                            <button class="btn btn-primary" onclick="showProductDetails('8')">Add to Cart</button>
                            <div id="details-8" class="product-details">
                                <p>Fashion 2 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('9')" />
                            <button class="btn btn-primary" onclick="showProductDetails('9')">Add to Cart</button>
                            <div id="details-9" class="product-details">
                                <p>Fashion 3 details...</p>
                            </div>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="ViewElectronics" runat="server">
                    <h2>Electronics</h2>
                    <div class="row">
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('10')" />
                            <button class="btn btn-primary" onclick="showProductDetails('10')">Add to Cart</button>
                            <div id="details-10" class="product-details">
                                <p>Electronics 1 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('11')" />
                            <button class="btn btn-primary" onclick="showProductDetails('11')">Add to Cart</button>
                            <div id="details-11" class="product-details">
                                <p>Electronics 2 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('12')" />
                            <button class="btn btn-primary" onclick="showProductDetails('12')">Add to Cart</button>
                            <div id="details-12" class="product-details">
                                <p>Electronics 3 details...</p>
                            </div>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="ViewHome" runat="server">
                    <h2>Home</h2>
                    <div class="row">
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('13')" />
                            <button class="btn btn-primary" onclick="showProductDetails('13')">Add to Cart</button>
                            <div id="details-13" class="product-details">
                                <p>Home 1 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('14')" />
                            <button class="btn btn-primary" onclick="showProductDetails('14')">Add to Cart</button>
                            <div id="details-14" class="product-details">
                                <p>Home 2 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('15')" />
                            <button class="btn btn-primary" onclick="showProductDetails('15')">Add to Cart</button>
                            <div id="details-15" class="product-details">
                                <p>Home 3 details...</p>
                            </div>
                        </div>
                    </div>
                </asp:View>
                <asp:View ID="ViewAppliances" runat="server">
                    <h2>Appliances</h2>
                    <div class="row">
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('16')" />
                            <button class="btn btn-primary" onclick="showProductDetails('16')">Add to Cart</button>
                            <div id="details-16" class="product-details">
                                <p>Appliance 1 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('17')" />
                            <button class="btn btn-primary" onclick="showProductDetails('17')">Add to Cart</button>
                            <div id="details-17" class="product-details">
                                <p>Appliance 2 details...</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <img src="product-img.png" class="product-img" onclick="showProductDetails('18')" />
                            <button class="btn btn-primary" onclick="showProductDetails('18')">Add to Cart</button>
                            <div id="details-18" class="product-details">
                                <p>Appliance 3 details...</p>
                            </div>
                        </div>
                    </div>
                </asp:View>
            </asp:MultiView>
        </div>

        <div class="container">
            <h2>Welcome to Our E-Commerce Website!</h2>
            <p>Browse our products and enjoy shopping.</p>
        </div>
    </form>
</body>
</html>
