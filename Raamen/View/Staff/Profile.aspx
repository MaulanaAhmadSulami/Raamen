<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Raamen.View.Staff.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile</title>
    <link href="ProfileStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mt-3 mb-4">Profile</h1>
    <div class="w-25">
        <div class="mb-3">
            <asp:Label ID="Lblusername" runat="server" Text="Username" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" placeholder="" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Label ID="Lblemail" runat="server" Text="Email" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="mb-3">
            <asp:Label ID="ddlGender" runat="server" Text="Gender" CssClass="form-label"></asp:Label>
            <div>
                <asp:RadioButton ID="rbMale" runat="server" GroupName="genderGroup" Text="Male" />
                <asp:RadioButton ID="rbFemale" runat="server" GroupName="genderGroup" Text="Female" />
            </div>
        </div>
        <div class="mb-4">
            <asp:Label ID="Label3" runat="server" Text="Password" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="" CssClass="form-control" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="updateGroup" CssClass="btn btn-primary mb-2"/> <br />
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
