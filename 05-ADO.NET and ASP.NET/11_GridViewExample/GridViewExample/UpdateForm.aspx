<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateForm.aspx.cs" Inherits="GridViewExample.UpdateForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Select Employee ID to Update:</label>
            <asp:DropDownList ID="ddlEmployeeIds" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlEmployeeIds_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <label>Full Name:</label>
            <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox>
            <br />
            <label>Address:</label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <br />
            <label>City:</label>
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
            <br />
            <label>Date of Birth:</label>
            <asp:Calendar ID="calDOB" runat="server"></asp:Calendar>
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        </div>
    </form>
</body>
</html>
