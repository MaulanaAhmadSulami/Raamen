<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminhome.aspx.cs" Inherits="Raamen.View.Adminhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin homepage</title>
    <link href="AdminStyle.css" rel="stylesheet" type="text/css" />
</head>
<body style="background-color: #ECE8E7;">
    <form id="form1" runat="server">
        <div class="navbar">
            <div class="logo">
                <img src="ramen_nobg.png" alt="Company Logo" class="company-logo" />
            </div>
            <div class="navbar-items">
                <ul>
                    <li><a href="Adminhome.aspx">Home</a></li>
                    <li><a href="#">Manage Ramen</a></li>
                    <li><a href="#">Order Queue</a></li>
                    <li><a href="#">Profile</a></li>
                    <li><a href="#">History</a></li>
                </ul>
            </div>
            <div class="navbar-items navbar-right">
                <ul>
                    <li><a href="#">Report</a></li>
                    <li><asp:Label ID="Label1" runat="server" Text="Hello! How are you," CssClass="greet_lbl"></asp:Label></li>
                    <li><asp:Label ID="name" runat="server" Text="" CssClass="greets_userlbl"></asp:Label></li>
                    <li><asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click" /></li>
                </ul>
            </div>
        </div>
    </form>
</body>
</html>