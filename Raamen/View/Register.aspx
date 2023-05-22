<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Raamen.View.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Raamen</title>
    <link href="RegistStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>    Raamen</h1>
            <div class="form-group">
                <label for="username">Username</label>
                <input type="text" id="username" name="username" runat="server" placeholder="Enter your username" required />
            </div>
            <div class="form-group">
                <label for="email">Email</label>
                <input type="email" id="email" name="email" runat="server" placeholder="Enter your email" required />
            </div>
            <div class="form-group">
                <label for="gender">Gender</label>
                <select id="gender" name="gender" runat="server" required>
                    <option value="">Select Gender</option>
                    <option value="male">Male</option>
                    <option value="female">Female</option>
                </select>
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" id="password" name="password" runat="server" placeholder="Enter your password" required />
            </div>
            <div class="form-group">
                <label for="confirmPassword">Confirm Password</label>
                <input type="password" id="confirmPassword" name="confirmPassword" runat="server" placeholder="Confirm your password" required />
            </div>
            <div class="form-group">
                <button type="submit" onclick="">Register</button>
            </div>
        </div>
    </form>
</body>
</html>
