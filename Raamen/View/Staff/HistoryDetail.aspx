﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/Staff/Staff.Master" AutoEventWireup="true" CodeBehind="HistoryDetail.aspx.cs" Inherits="Raamen.View.Staff.HistoryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>History Detail</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="backButton" runat="server" Text="< Back" OnClick="backButton_Click"/>
        <asp:Label ID="Label1" runat="server" Text="Transaction ID: "></asp:Label>
        <asp:Label ID="trxID" runat="server" Text=""></asp:Label>
    </div>
    <div>
        <asp:GridView ID="detailGV" runat="server"></asp:GridView>
    </div>
</asp:Content>