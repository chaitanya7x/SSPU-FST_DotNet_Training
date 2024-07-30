<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProcedure.aspx.cs" Inherits="GridViewExample.InsertProcedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            name
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Please Select</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Save Changes" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Close" />
        </p>
    </form>
</body>
</html>
