<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XMLExample.aspx.cs" Inherits="GridViewExample.XMLExample" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>XML Data Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="USA" Value="USA"></asp:ListItem>
                <asp:ListItem Text="Canada" Value="Canada"></asp:ListItem>
                <asp:ListItem Text="India" Value="India"></asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                <asp:ListItem Text="Seattle" Value="Seattle"></asp:ListItem>
                <asp:ListItem Text="Toronto" Value="Toronto"></asp:ListItem>
                <asp:ListItem Text="New York" Value="New York"></asp:ListItem>
                <asp:ListItem Text="Nashik" Value="Nashik"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/XMLFile1.xml" XPath="/Employees/Employee"></asp:XmlDataSource>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="XmlDataSource1" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Id" HeaderStyle-Width="50">
                    <ItemTemplate>
                        <%# XPath("@Id") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name" HeaderStyle-Width="100">
                    <ItemTemplate>
                        <%# XPath("EmployeeName") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City" HeaderStyle-Width="100">
                    <ItemTemplate>
                        <%# XPath("@City") %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country" HeaderStyle-Width="100">
                    <ItemTemplate>
                        <%# XPath("Country") %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </form>
</body>
</html>
