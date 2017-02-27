<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="QaEmail_Rocketeers.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Email: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password: <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Remember my password: <asp:CheckBox ID="rememberMe" runat="server" />
        <br />
        <br />
        <a href="forgotPword.aspx">Forgotten password?</a>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click"/>

        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
