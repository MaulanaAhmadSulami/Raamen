<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="Raamen.View.Admin.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>History</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>
            Transaction History
        </h1>
        <asp:GridView ID="trxGV" runat="server" AutoGenerateColumns="false" OnRowCommand="trxGV_RowCommand">
            <columns>
                <asp:BoundField DataField="HeaderID" HeaderText="Transaction ID" />
                <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" />
                <asp:BoundField DataField="StaffID" HeaderText="Staff ID" />
                <asp:BoundField DataField="Date" HeaderText="Date" />
                <asp:TemplateField>
                    <itemtemplate>
                        <asp:Button ID="btnDetail" UseSubmitBehavior="false" runat="server" Text="Detail" CommandArgument="<%# ((GridViewRow)Container).RowIndex %>" CommandName="trxDetail" />
                    </itemtemplate>
                </asp:TemplateField>
            </columns>
        </asp:GridView>
       <asp:Label ID="status" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
