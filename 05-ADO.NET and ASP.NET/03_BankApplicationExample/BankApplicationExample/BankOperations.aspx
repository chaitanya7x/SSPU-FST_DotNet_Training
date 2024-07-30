<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BankOperations.aspx.cs" Inherits="BankApplicationExample.BankOperations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Bank Operations</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bank Operations</h2>
            <p>Welcome, <asp:Label ID="lblUsername" runat="server"></asp:Label>!</p>
            <p>-----------------------------------------------------------------</p>
                <h3>Balance </h3>
            <p>
                <asp:Label ID="chkBalance" runat="server" Text="Label"></asp:Label>
            </p>
            <p>-----------------------------------------------------------------</p>

                <h3>Withdraw Money</h3>
            <p>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="wbutton" runat="server" Text="Withdraw" />
            </p>
            <p>-----------------------------------------------------------------</p>

                <h3>View Transactions</h3>

            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>
</html>
