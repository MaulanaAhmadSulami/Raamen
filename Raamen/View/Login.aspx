<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raamen.View.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login Form</title>
    <link href="assets/css/global.css" rel="stylesheet" type="text/css"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <style>
        .container-custom {
            width: 360px;
            padding: 36px !important;
            background-color: #fff;
            border-radius: 4px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
    </style>
</head>
<body style="background-color: #7EC5F0 !important">
    <form id="form1" runat="server">
        <div class="d-flex flex-column min-vh-100 justify-content-center align-items-center">
            <div class="container-custom">
                <div class="container">
                    <div class="row d-flex">
                        <div class="col-2 justify-content-start px-0">
                            <asp:Button ID="backBtn" runat="server" Text="<" OnClick="backBtn_Click" CssClass="btn btn-light btn-sm"/>
                        </div>
                        <div class="col ms-5 justify-content-center">
                            <h1 class="fs-4 mb-5 fw-bold">Login</h1>
                        </div>
                    </div>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="lblUsername" runat="server" AssociatedControlID="txtUsername" Text="Username" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="lblPassword" runat="server" AssociatedControlID="txtPassword" Text="Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:CheckBox ID="RememberMe" runat="server" Text="" CssClass="form-check-input border-0"/>
                    <asp:Label ID="lblRememberMe" runat="server" AssociatedControlID="RememberMe" Text="Remember me" CssClass="form-check-label"></asp:Label>
                </div>
                <div class="mb-4 pb-3">
                    <asp:Label ID="lblError" runat="server" Text="" CssClass="text-danger"></asp:Label>
                </div>
                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" CssClass="btn btn-primary mt-2 px-4 py-2" />
                </div>
            </div>
         </div>
    </form>
</body>
</html>