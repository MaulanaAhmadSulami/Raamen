<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="HistoryDetail.aspx.cs" Inherits="Raamen.View.Admin.HistoryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>History Detail</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="mt-3 mb-4">Transaction Detail</h1>
    <div class="d-flex justify-content-between align-items-center mt-3 mb-2">
        <div>
            <asp:Button ID="backButton" runat="server" Text="< Back" OnClick="backButton_Click" CssClass="btn btn-sm btn-secondary"/>
        </div>
        <div class="fs-4">
            <asp:Label ID="Label1" runat="server" Text="Transaction ID: "></asp:Label>
            <asp:Label ID="trxID" runat="server" Text=""></asp:Label>
        </div>
        <div></div>
    </div>
    <div>
        <asp:GridView ID="detailGV" runat="server" CssClass="table table-hover" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="RamenId" HeaderText="Ramen ID" />
                <asp:BoundField DataField="Raman.Name" HeaderText="Ramen Name" />
                <asp:BoundField DataField="Raman.Meat.Name" HeaderText="Ramen Meat" />
                <asp:BoundField DataField="Raman.Broth" HeaderText="Ramen Broth" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
