<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Raamen.View.Register" EnableViewState="true"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Form</title>
    <link href="assets/css/global.css" rel="stylesheet" type="text/css"/>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <style>
        .container-custom {
            width: 400px;
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
                            <h1 class="fs-4 mb-5 fw-bold">Register</h1>
                        </div>
                    </div>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="Lblusername" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="Lblemail" runat="server" Text="Email" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="Lblgender" runat="server" Text="Gender" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlGender" runat="server" CssClass="form-select">
                        <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                        <asp:ListItem Text="Male" Value="male"></asp:ListItem>
                        <asp:ListItem Text="Female" Value="female"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="mb-3 pb-1">
                    <asp:Label ID="Lblpassword" runat="server" Text="Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" placeholder="Enter your password" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-2">
                    <asp:Label ID="Lblconfirm_password" runat="server" Text="Confirm Password" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm your password" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="mb-3 pb-1">
                    <asp:Label ID="lblError" runat="server" Text="" CssClass="text-danger"></asp:Label>
                </div>

                <div class="d-flex justify-content-center">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-primary mt-2 px-4 py-2"/> <br />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
