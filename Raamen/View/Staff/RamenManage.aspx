<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="RamenManage.aspx.cs" Inherits="Raamen.View.Staff.RamenManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Manage Ramen</h1>
        <asp:Button ID="insertRamen" runat="server" Text="Insert" OnClick="insertRamen_Click"/>
        <br />
        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="false" OnRowEditing="ramenGV_RowEditing" OnRowDeleting="ramenGV_RowDeleting">
            <Columns>
                <asp:BoundField DataField="RamenID" HeaderText="Ramen ID" />
                <asp:BoundField DataField="MeatId" HeaderText="Meat ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
