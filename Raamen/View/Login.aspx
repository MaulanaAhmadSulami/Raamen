<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raamen.View.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login Form</title>
    <link href="assets/css/Login.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="ramen-title">Login</h1>
            <div class="form-group">
                <asp:Label ID="lblUsername" runat="server" AssociatedControlID="txtUsername" Text="Username"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me" CssClass="remember-me" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>
            <div class="form-group">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="login-button" />
            </div>
        </div>
    </form>
</body>
</html>