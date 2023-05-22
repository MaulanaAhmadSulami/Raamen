<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Raamen.View.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login Form</title>
    <link href="LoginStyle.css" rel="stylesheet" type="text/css"/>
</head>
<body>
    <div class="container">
        <h1 class="ramen-title">Login</h1>
        <form action="" method="post">
            <div class="form-group">
                <label for="username">Username</label>
                <input type="text" id="username" name="username" placeholder="Enter your username">
            </div>
            <div class="form-group">
                <label for="password">Password</label>
                <input type="password" id="password" name="password" placeholder="Enter your password">
            </div>
            <div class="form-group">
                <button type="submit" class="btn">Login</button>
            </div>
        </form>
    </div>
        </form>
    </div>
</body>
</html>

