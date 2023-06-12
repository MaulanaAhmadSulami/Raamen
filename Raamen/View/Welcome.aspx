<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Raamen.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Welcome to RAAMEN</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" type="text/css"/>
    <style>
        .container-custom {
            max-width: 480px;
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
                <h1 class="fw-bold mb-0 text-center" style="color: #46555D">Welcome To RAAMEN</h1>
                <div class="d-flex justify-content-center my-4">
                    <img src="assets/ramen_nobg.png" alt="Ramen plain" style="width:200px"/>
                </div>
                <div class="container text-center">
                    <div class="row mb-3">
                        <div class="col">
                            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-primary px-4 py-2" OnClick="btnLogin_Click" /> <br />
                        </div>
                    </div>
                    <div class="row mb-1">
                        <div class="col">
                            <p class="mb-0">Are you new here?</p>
                        </div>
                    </div>
                    <div class="row mt-2">
                        <div class="col">
                            <asp:Button ID="btnRegister" runat="server" Text="Register as Buyer" CssClass="btn btn-primary px-4 py-2" OnClick="btnRegister_Click" />
                        </div>
                        <div class="col">
                            <asp:Button ID="btnRegisterStf" runat="server" Text="Register as Seller" CssClass="btn btn-primary px-4 py-2" OnClick="btnRegisterStf_Click1"/> <br />
                        </div>
                    </div>
                </div>
            </div>
         </div>
    </form>
</body>
</html>
