<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RamenUpdate.aspx.cs" Inherits="Raamen.View.Admin.RamenUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Update Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="backButton" runat="server" Text="< Back" OnClick="backButton_Click"/>
        <h1>Update Ramen</h1>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Meat"></asp:Label>
        <asp:DropDownList ID="MeatDrop" runat="server">
            <asp:ListItem Value="0">-- Select Meat --</asp:ListItem>
            <asp:ListItem Value="1">Beef</asp:ListItem>
            <asp:ListItem Value="2">Pork</asp:ListItem>
            <asp:ListItem Value="3">Chicken</asp:ListItem>
            <asp:ListItem Value="4">Fish</asp:ListItem>
            <asp:ListItem Value="5">Shrimp</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="Broth"></asp:Label>
        <asp:TextBox ID="BrothTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="PriceTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click"/>
        <asp:Label ID="statusTxt" runat="server" Text=""></asp:Label>
        <br />
        <asp:HiddenField ID="ID" runat="server" />
    </div>
</asp:Content>
