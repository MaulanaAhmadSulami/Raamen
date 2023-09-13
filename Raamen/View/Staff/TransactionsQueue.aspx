<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="TransactionsQueue.aspx.cs" Inherits="Raamen.View.Staff.TransactionsQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Transactions Queue</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mt-3 mb-4">Order Queue</h1>
    <div>
        <h2>Unhandled Transactions</h2>
        <asp:GridView ID="unhandledGV" runat="server" AutoGenerateColumns="false" OnRowCommand="unhandledGV_RowCommand" CssClass="table table-hover">
                <columns>
                    <asp:BoundField DataField="HeaderID" HeaderText="Transaction ID" />
                    <asp:BoundField DataField="User.Username" HeaderText="Customer Username" />
                    <asp:BoundField DataField="StaffID" HeaderText="Staff ID" />
                    <asp:BoundField DataField="Date" HeaderText="Date" />
                    <asp:TemplateField>
                        <itemtemplate>
                            <asp:Button ID="btnHandle" UseSubmitBehavior="false" runat="server" Text="Handle" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="trxHandle" CssClass="btn btn-sm btn-primary"/>
                        </itemtemplate>
                    </asp:TemplateField>
                </columns>
            </asp:GridView>
           <asp:Label ID="status" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <h2>Handled Transactions</h2>
        <asp:GridView ID="handledGV" runat="server" AutoGenerateColumns="false" OnRowCommand="handled_RowCommand" CssClass="table table-hover">
            <columns>
                <asp:BoundField DataField="HeaderID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="User.Username" HeaderText="Customer Username" />
                <asp:BoundField DataField="StaffID" HeaderText="Staff ID" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:TemplateField>
                    <itemtemplate>
                        <asp:Button ID="btnDetail" UseSubmitBehavior="false" runat="server" Text="Detail" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="trxDetail" CssClass="btn btn-sm btn-info"/>
                    </itemtemplate>
                </asp:TemplateField>
            </columns>
        </asp:GridView>
    </div>
</asp:Content>
