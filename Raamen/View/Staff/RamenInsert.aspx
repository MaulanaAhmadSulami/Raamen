<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="RamenInsert.aspx.cs" Inherits="Raamen.View.Staff.RamenInsert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Insert Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="w-25">
            <div class="d-flex justify-content-between align-items-center mt-3 mb-4">
                <asp:Button ID="backButton" runat="server" Text="< Back" OnClick="backButton_Click" CssClass="btn btn-sm btn-secondary h-50"/>
                <h1>Insert Ramen</h1>
                <div></div>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label1" runat="server" Text="Name" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="Name" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label ID="Label4" runat="server" Text="Meat" CssClass="form-label"></asp:Label>
                <asp:DropDownList ID="Meat" runat="server" CssClass="form-select">
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
                <asp:TextBox ID="Broth" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-4">
                <asp:Label ID="Label3" runat="server" Text="Price" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="Price" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="text-center">
                <asp:Button ID="insertButton" runat="server" Text="Insert" OnClick="insertButton_Click" CssClass="btn btn-primary mb-2"/>
                <asp:Label ID="status" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
