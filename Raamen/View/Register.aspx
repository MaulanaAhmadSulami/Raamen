<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Raamen.View.Register" EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raamen</title>
    <link href="RegistStyle.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Raamen</h1>
            <div class="form-group">
                <asp:Label ID="Lblusername" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username" ></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Lblemail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email" ></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Lblgender" runat="server" Text="Gender"></asp:Label>
                <asp:DropDownList ID="ddlGender" runat="server">
                    <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                    <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <asp:Label ID="Lblpassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password"  ></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label ID="Lblconfirm_password" runat="server" Text="Confirm Password" ></asp:Label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm your password"  ></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            </div>

            <div class="form-group">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="Regist-btn"/> <br />
                <asp:Button ID="btnReturn" runat="server" Text="Return" OnClick="btnReturn_Click" CssClass="Return-btn"/>
            </div>
        </div>
    </form>
</body>
</html>
