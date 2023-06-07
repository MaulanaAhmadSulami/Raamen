<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Raamen.View.UpdatePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User update Homepage</title>
    <link href="UpdateStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="navbar">
            <div class="logo">
                <img src="assets/ramen_nobg.png" alt="Company Logo" class="company-logo" />
            </div>
            <div class="navbar-items">
                <ul>
                    <li><a href="Adminhome.aspx">Home</a></li>
                    <li><a href="#">Manage Ramen</a></li>
                    <li><a href="#">Order Queue</a></li>
                    <li><a href="UpdatePage.aspx">Profile</a></li>
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
                <asp:Label ID="Lblusername" runat="server" Text="Username"></asp:Label>
                <asp:TextBox ID="txtUsername" runat="server" placeholder="" ></asp:TextBox> <br />

                <asp:Label ID="Lblemail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="" ></asp:TextBox> <br />

                <asp:Label ID="ddlGender" runat="server" Text="Gender"></asp:Label>
                <div class="gender-radios">
                    <asp:RadioButton ID="rbMale" runat="server" GroupName="genderGroup" Text="Male" />
                    <asp:RadioButton ID="rbFemale" runat="server" GroupName="genderGroup" Text="Female" />
                </div>
                
                <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" placeholder="" ></asp:TextBox> <br />

                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="updateGroup" /> <br />
                <asp:Label ID="lblMessage" runat="server" CssClass="message-label" Text=""></asp:Label>
    </form>
</body>
</html>
