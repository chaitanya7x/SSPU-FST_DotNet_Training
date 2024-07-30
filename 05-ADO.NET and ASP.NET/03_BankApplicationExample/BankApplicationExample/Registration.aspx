<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BankApplicationExample.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
</head>
<body>
    <h2>Register</h2>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Gender:"></asp:Label>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Hobbies:"></asp:Label>
            <asp:CheckBoxList ID="cblHobbies" runat="server">
                <asp:ListItem>Reading</asp:ListItem>
                <asp:ListItem>Travelling</asp:ListItem>
                <asp:ListItem>Sports</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Country:"></asp:Label>
            <asp:DropDownList ID="ddlCountry" runat="server">
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>Canada</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </div>
    </form>
</body>
</html>
