<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Raamen.View.Customer.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Customer Homepage</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <div class="mt-3 mb-4 fs-3">
                <asp:Label ID="Label1" runat="server" Text="Welcome, "></asp:Label>
                <asp:Label ID="name" runat="server" Text=""></asp:Label>
            </div>
            <asp:Label ID="Label2" runat="server" Text="You are currently on Customer homepage"></asp:Label>
        </div>
</asp:Content>
