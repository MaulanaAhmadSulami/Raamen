<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="Raamen.View.Customer.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Order Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
        <h1>Order Ramen</h1>
        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="false" OnRowCommand="ramenGV_RowCommand">
            <Columns>
                <asp:BoundField DataField="RamenID" HeaderText="Ramen ID" />
                <asp:BoundField DataField="MeatId" HeaderText="Meat ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnOrder" UseSubmitBehavior="false" runat="server" Text="Add to Cart" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="insertCart"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       <asp:Label ID="status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <h1>Cart</h1>
            <asp:GridView ID="cartGV" runat="server" AutoGenerateColumns="false" OnRowCommand="cartGV_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CartDetailId" HeaderText="Cart Detail ID" />
                    <asp:BoundField DataField="CartId" HeaderText="Cart ID" />
                    <asp:BoundField DataField="RamenID" HeaderText="Ramen ID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnRemove" UseSubmitBehavior="false" runat="server" Text="Remove" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="removeRamen"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Button ID="clearCart" runat="server" Text="Clear Cart" OnClick="clearCart_Click"/>
    </div>
</asp:Content>
