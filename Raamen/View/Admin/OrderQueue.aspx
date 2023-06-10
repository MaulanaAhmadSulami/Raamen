<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="Raamen.View.Admin.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Orders Queue</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Order Queue</h2>

        <h3>Unhandled Orders</h3>
        <asp:GridView ID="gvUnhandledOrders" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                <asp:BoundField DataField="RamenId" HeaderText="Ramen ID" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:ButtonField ButtonType="Button" Text="Handle" CommandName="HandleOrder" />
            </Columns>
        </asp:GridView>

        <h3>Handled Orders</h3>
        <asp:GridView ID="gvHandledOrders" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="Customer ID" />
                <asp:BoundField DataField="RamenId" HeaderText="Ramen ID" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                <asp:BoundField DataField="StaffId" HeaderText="StaffId" />
            </Columns>
        </asp:GridView>
</asp:GridView>

</asp:Content>
