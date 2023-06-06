<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staffhome.aspx.cs" Inherits="Raamen.View.Staffhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Homepage</title>
    <link href="StaffStyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" runat="server">
        <div class="navbar">
            <div class="logo">
                <img src="ramen_nobg.png" alt="Company Logo" class="company-logo" />
            </div>
            <div class="navbar-items">
                <ul>
                    <li><a href="Staffhome.aspx">Home</a></li>
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
        <div>
            <asp:Label ID="Label3" runat="server" Text="Customer Data"></asp:Label>
            <asp:GridView ID="cust_GV" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="ID" />
                    <asp:BoundField DataField="RoleId" HeaderText="Role ID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
