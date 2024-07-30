<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormBackend.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">

                <h2>Employee Details</h2>
                <asp:Label ID="lblEmpNumber" runat="server" Text="Employee Number:"></asp:Label>
                <asp:TextBox ID="txtEmpNumber" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblFullName" runat="server" Text="Full Name:"></asp:Label>
                <asp:TextBox ID="txtFullName" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblDOB" runat="server" Text="DOB:"></asp:Label>
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox><br />

                <asp:Button ID="btnSaveEmployee" runat="server" Text="Save" OnClick="SaveEmployee_Click" />
                <asp:Button ID="btnExitEmployee" runat="server" Text="Exit" OnClick="Exit_Click" />
            </asp:View>

            <asp:View ID="View2" runat="server">

                <h2>Customer Details</h2>
                <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name:"></asp:Label>
                <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblCustomerAddress" runat="server" Text="Address:"></asp:Label>
                <asp:TextBox ID="txtCustomerAddress" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblCustomerCity" runat="server" Text="City:"></asp:Label>
                <asp:TextBox ID="txtCustomerCity" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code:"></asp:Label>
                <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox><br />

                <asp:Label ID="lblContactNumber" runat="server" Text="Contact No:"></asp:Label>
                <asp:TextBox ID="txtContactNumber" runat="server"></asp:TextBox><br />

                <asp:Button ID="btnSaveCustomer" runat="server" Text="Save" OnClick="SaveCustomer_Click" />
                <asp:Button ID="btnExitCustomer" runat="server" Text="Exit" OnClick="Exit_Click" />
            </asp:View>
        </asp:MultiView>

        <asp:Button ID="btnSwitchToEmployee" runat="server" Text="Employee Details" OnClick="SwitchToEmployee_Click" />
        <asp:Button ID="btnSwitchToCustomer" runat="server" Text="Customer Details" OnClick="SwitchToCustomer_Click" />

    </form>
</body>
</html>
