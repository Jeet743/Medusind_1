<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Validator.aspx.cs" Inherits="Assignment_1.Validator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Insert Your Details:
        </p>
        <p>
            Name:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
        </p>
        <p>
            Family Name:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Family Name Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="differs from name" ForeColor="Red" ValidationGroup="D1"></asp:CompareValidator>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Address : " MinLength="2"></asp:Label>
            &nbsp;<asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtaddress" ErrorMessage="Address Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:CustomValidator ID="CustomValidator3" runat="server" ControlToValidate="txtaddress" Display="Dynamic" ErrorMessage="at least 2 char" ForeColor="Red" ValidationGroup="D1"></asp:CustomValidator>
            <br />

            <br />
            <asp:Label ID="Label4" runat="server" Text="City : " MinLength="2"></asp:Label>
            <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="City Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:CustomValidator ID="CustomValidator4" runat="server" ControlToValidate="txtcity" Display="Dynamic" ErrorMessage="at least 2 char" ForeColor="Red" ValidationGroup="D1"></asp:CustomValidator>
        <br />
        <br />
        Zip Code:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Zip Code Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="xxxxx" ForeColor="Red" ValidationExpression="\d{5}(-\d{4})?" ValidationGroup="D1"></asp:RegularExpressionValidator>
        <br />
        <br />
        Phone:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Phone Is Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="XX-XXXXXXX or XXX-XXXXXXX" ForeColor="Red" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ValidationGroup="D1"></asp:RegularExpressionValidator>
        <br />
        <br />
        E-Mail:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox5" ErrorMessage="Email Required" ForeColor="Red" ValidationGroup="D1">*</asp:RequiredFieldValidator>
&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" ErrorMessage="example@example.com" ForeColor="Blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="D1"></asp:RegularExpressionValidator>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Check" ValidationGroup="D1" />
        <br />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="D1" />
        <br />
            <br />
    </form>
</body>
</html>
