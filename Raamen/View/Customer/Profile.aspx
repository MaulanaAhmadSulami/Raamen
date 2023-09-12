<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Raamen.View.Customer.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Profile</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="d-flex justify-content-center">
        <div class="w-25">
            <h1 class="mt-3 mb-4 text-center">Profile</h1>
            <div>
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
                <div class="mb-3">
                    <asp:Label ID="Label3" runat="server" Text="Current Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" placeholder="" CssClass="form-control" TextMode="Password"></asp:TextBox>
                </div>
                <asp:Label ID="lblMessage" runat="server" Text="" CssClass="mb-4"></asp:Label>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" ValidationGroup="updateGroup" CssClass="btn btn-primary mb-2"/>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
