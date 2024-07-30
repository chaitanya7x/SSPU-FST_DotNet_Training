<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReapeterExample.aspx.cs" Inherits="DetailsViewExample.ReapeterExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyConnectionString%>" SelectCommand="SELECT * FROM StudentDetails"></asp:SqlDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table>
                    <tr>
                        <th scope="col" style="width: 80px">Id</th>
                        <th scope="col" style="width: 120px">Name</th>
                        <th scope="col" style="width: 100px">Age</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="lblId" runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text='<%# Eval("Age") %>'></asp:Label>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
