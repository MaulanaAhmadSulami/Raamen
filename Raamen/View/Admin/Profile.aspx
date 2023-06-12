<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Raamen.View.Admin.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
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
    </div>
</asp:Content>
