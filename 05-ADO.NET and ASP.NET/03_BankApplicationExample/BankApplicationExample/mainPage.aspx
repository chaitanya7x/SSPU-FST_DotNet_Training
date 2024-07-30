<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainPage.aspx.cs" Inherits="BankApplicationExample.mainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Bank Web Application</title>
</head>
<body>
         <h2>Welcome to Bank Web Application</h2>
 <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRegister" runat="server" Text="Registration" OnClick="btnRegister_Click" />
            <br />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
