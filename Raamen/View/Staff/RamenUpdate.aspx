<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="RamenUpdate.aspx.cs" Inherits="Raamen.View.Staff.RamenUpdate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Update Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="w-25">
            <div class="d-flex justify-content-between align-items-center mt-3 mb-4">
                <asp:Button ID="backButton" runat="server" Text="< Back" OnClick="backButton_Click" CssClass="btn btn-sm btn-secondary h-50"/>
                <h1>Update Ramen</h1>
                <div></div>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label1" runat="server" Text="Name" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="NameTxt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label4" runat="server" Text="Meat" CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="MeatDrop" runat="server" CssClass="form-select">
                    <asp:ListItem Value="0">-- Select Meat --</asp:ListItem>
                    <asp:ListItem Value="1">Beef</asp:ListItem>
                    <asp:ListItem Value="2">Pork</asp:ListItem>
                    <asp:ListItem Value="3">Chicken</asp:ListItem>
                    <asp:ListItem Value="4">Fish</asp:ListItem>
                    <asp:ListItem Value="5">Shrimp</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label2" runat="server" Text="Broth" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="BrothTxt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-4">
                <asp:Label ID="Label3" runat="server" Text="Price" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="PriceTxt" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="updateButton" runat="server" Text="Update" OnClick="updateButton_Click" CssClass="btn btn-primary mb-2"/>
                <asp:Label ID="statusTxt" runat="server" Text=""></asp:Label>
            </div>
            <asp:HiddenField ID="ID" runat="server" />
        </div>
    </div>
</asp:Content>
