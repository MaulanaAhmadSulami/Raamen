<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Raamen.View.Staff.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Staff Homepage</title>
    <link href="HomeStyle.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="mt-3 mb-4">
            <p class="fs-3">Welcome, Staff</p>
        </div>
        <div class="mt-3">
            <asp:Label ID="Label3" runat="server" Text="Customer Data" CssClass="fs-4"></asp:Label>
            <asp:GridView ID="cust_GV" runat="server" AutoGenerateColumns="false" CssClass="table table-hover">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="User ID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
