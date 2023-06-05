<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staffhome.aspx.cs" Inherits="Raamen.View.Staffhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label1" runat="server" Text="Welcome, "></asp:Label>
            <asp:Label ID="name" runat="server" Text=""></asp:Label> <br />
            <asp:Label ID="Label2" runat="server" Text="You are currently on Staff homepage"></asp:Label> <br />

            <asp:Button ID="logoutBtn" runat="server" Text="Logout" OnClick="logoutBtn_Click" />
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Customer Data"></asp:Label>
            <asp:GridView ID="cust_GV" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="CustomerId" HeaderText="ID" />
                    <asp:BoundField DataField="RoleId" HeaderText="Role ID" />
                    <asp:BoundField DataField="Username" HeaderText="Username" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
