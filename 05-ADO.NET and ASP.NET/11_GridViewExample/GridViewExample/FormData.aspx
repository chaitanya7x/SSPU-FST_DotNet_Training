<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormData.aspx.cs" Inherits="GridViewExample.gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="EmployeeNumber">Employee Number:</label>
            <asp:TextBox ID="txtEmployeeNumber" runat="server"></asp:TextBox>
            <br />
            <label for="FullName">Full Name:</label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            <br />
            <label for="Address">Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <label for="City">City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <label for="DOB">Date of Birth:</label>
            <asp:Calendar ID="calDOB" runat="server" SelectionMode="Day"></asp:Calendar>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
