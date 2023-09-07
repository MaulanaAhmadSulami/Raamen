<%@ Page Title="" Language="C#" MasterPageFile="~/View/Customer/Customer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="Raamen.View.Customer.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Order Ramen</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div>
        <h1 class="mt-3 mb-4 ps-2">Order Ramen</h1>
        <asp:GridView ID="ramenGV" runat="server" AutoGenerateColumns="false" OnRowCommand="ramenGV_RowCommand" CssClass="table table-hover">
            <Columns>
                <asp:BoundField DataField="RamenID" HeaderText="ID"/>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Meat.Name" HeaderText="Meat" />
                <asp:BoundField DataField="Broth" HeaderText="Broth" />
                <asp:BoundField DataField="Price" HeaderText="Price" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnOrder" UseSubmitBehavior="false" runat="server" Text="Add to Cart" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="insertCart" CssClass="btn btn-sm btn-primary"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       <asp:Label ID="status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <h1 class="mt-5 mb-4 ps-2">Cart</h1>
        <div class="mb-3">
            <asp:GridView ID="cartGV" runat="server" AutoGenerateColumns="false" OnRowCommand="cartGV_RowCommand" CssClass="table table-hover mb-1">
                <Columns>
                    <asp:BoundField DataField="Raman.Name" HeaderText="Ramen Name" />
                    <asp:BoundField DataField="Raman.Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:TemplateField HeaderText="Subtotal">
                        <ItemTemplate>
                            <asp:Label ID="subtotal" runat="server" Text='<%# (Convert.ToInt32(Eval("Raman.Price")) * Convert.ToInt32(Eval("Quantity"))).ToString() %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnRemove" UseSubmitBehavior="false" runat="server" Text="Remove" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="removeRamen" CssClass="btn btn-sm btn-danger"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="LabelTotal" runat="server" CssClass="ps-2">Total: </asp:Label>
            <asp:Label ID="total" runat="server" Text=""></asp:Label>
        </div>
        <div class="px-2">
            <asp:Button ID="checkout" runat="server" Text="Buy Cart" OnClick="checkout_Click" CssClass="btn btn-primary me-2"/>
            <asp:Button ID="clearCart" runat="server" Text="Clear Cart" OnClick="clearCart_Click" CssClass="btn btn-secondary"/>
        </div>
    </div>
</asp:Content>
