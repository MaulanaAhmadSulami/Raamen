<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="RamenManage.aspx.cs" Inherits="Raamen.View.Admin.RamenManage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Manage Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 class="mb-3">Manage Ramen</h1>
        <asp:Button ID="insertRamen" runat="server" Text="Insert" OnClick="insertRamen_Click" CssClass="btn btn-primary mb-1 btn-sm"/>
        <br />
        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="false" OnRowEditing="ramenGV_RowEditing" OnRowDeleting="ramenGV_RowDeleting" CssClass="table table-hover">
            <Columns>
                <asp:BoundField DataField="RamenID" HeaderText="Ramen ID"/>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Meat.Name" HeaderText="Meat" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:CommandField ShowEditButton="true" ControlStyle-CssClass="btn btn-sm btn-secondary"/>
                <asp:CommandField ShowDeleteButton="true"  ControlStyle-CssClass="btn btn-sm btn-danger"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
