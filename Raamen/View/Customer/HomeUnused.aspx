﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUnused.aspx.cs" Inherits="Raamen.View.Customerhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Welcome, "></asp:Label>
            <asp:Label ID="name" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label2" runat="server" Text="You are currently on Customer homepage"></asp:Label> <br />
            
            <a href="/View/UpdatePage.aspx">Profile</a>
            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click" />
        </div>
    </form>
</body>
</html>