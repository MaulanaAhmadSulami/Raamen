<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Raamen.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to RAAMEN</title>
    <link href="assets/css/Welcome.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="ramen-title">Welcome To Rameen Store</h1>
            <img src="assets/ramen_nobg.png" alt="Ramen plain" class="store-image" />
            <p class="new-here">Are you new here?</p>
            <div class="buttons-container">
                <asp:Button ID="btnRegister" runat="server" Text="Register as Buyer" CssClass="action-button" OnClick="btnRegister_Click" />
                <asp:Button ID="btnRegisterStf" runat="server" Text="Register as Seller" CssClass="action-button" OnClick="btnRegisterStf_Click1"/> <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="action-button" OnClick="btnLogin_Click" /> <br />
            </div>
        </div>
    </form>
</body>
</html>
