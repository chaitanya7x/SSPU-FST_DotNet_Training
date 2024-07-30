<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BoundFieldExample.aspx.cs" Inherits="GridViewExample.BoundFieldExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BoundField</title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="ID" />
                <asp:BoundField DataField="FullName" HeaderText="Name of Employee" />
                <asp:BoundField DataField="City" HeaderText="City" />
            </Columns>
        </asp:GridView>
        
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="testHeader1" />
                <asp:BoundField DataField="Addres" HeaderText="testHeader2" />
            </Columns>
        </asp:GridView>
        
    </form>
</body>
</html>
