<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsView1.aspx.cs" Inherits="DetailsViewExample.DetailsView1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DetailsView ID="DV1" runat="server" Height="50px" Width="125px" p AllowPaging="true" AutoGenerateRows="false" DataSourceID="SqlDataSource1">
                <Fields>
                    <asp:BoundField DataField="categorycode" HeaderText="categorycode" SortExpression="categorycode" />
                    <asp:BoundField DataField="categoryname" HeaderText="categoryname" SortExpression="categoryname" />
                </Fields>
            </asp:DetailsView>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString%>" SelectCommand="SELECT * FROM Categories"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
