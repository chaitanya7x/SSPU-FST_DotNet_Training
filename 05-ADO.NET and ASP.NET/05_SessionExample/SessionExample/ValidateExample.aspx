<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidateExample.aspx.cs" Inherits="SessionExample.ValidateExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator">Fields can not be blank</asp:RequiredFieldValidator>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="CompareValidator"></asp:CompareValidator>
        </p>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="RangeValidator" MaximumValue="18" MinimumValue="50" Type="Integer"></asp:RangeValidator>
        <p>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="RegularExpressionValidator" ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;=]*)?"></asp:RegularExpressionValidator>
        </p>
    </form>
</body>
</html>
