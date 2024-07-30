<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="GridViewExample.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Registration Form</h2>

            <div>
                <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="Username is required." />
            </div>

            <div>
                <asp:Label ID="lblUName" runat="server" Text="Full Name:"></asp:Label>
                <asp:TextBox ID="txtUName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUName" runat="server" ControlToValidate="txtUName" ErrorMessage="Full Name is required." />
            </div>

            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is required." />
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email format." ValidationExpression="\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}" />
            </div>

            <div>
                <asp:Label ID="lblGender" runat="server" Text="Gender:"></asp:Label>
                <asp:RadioButtonList ID="rblGender" runat="server">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="rfvGender" runat="server" ControlToValidate="rblGender" InitialValue="" ErrorMessage="Gender is required." />
            </div>

            <div>
                <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of Birth:"></asp:Label>
                <asp:TextBox ID="txtDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDateOfBirth" runat="server" ControlToValidate="txtDateOfBirth" ErrorMessage="Date of Birth is required." />
                <asp:RangeValidator ID="rvDateOfBirth" runat="server" ControlToValidate="txtDateOfBirth" Type="Date" ErrorMessage="Date of Birth must be between 1900-01-01 and today's date." MinimumValue="1900-01-01" MaximumValue='<%# DateTime.Now.ToString("yyyy-MM-dd") %>'></asp:RangeValidator>
            </div>

            <div>
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is required." />
                <asp:RegularExpressionValidator ID="revPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password must be at least 8 characters long." ValidationExpression=".{8,}" />
            </div>

            <div>
                <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password:"></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" ErrorMessage="Confirmation password is required." />
                <asp:CompareValidator ID="cvConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" ControlToCompare="txtPassword" ErrorMessage="Passwords do not match." />
            </div>

            <div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
