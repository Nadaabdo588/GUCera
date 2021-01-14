<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>
    <title></title>
   
</head>
<body style="background-color:#F4E8E8">
    <form id="form1" runat="server">
        <h1 class="Label1">Welcome to GUCera !</h1>
        <br />
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/lock.png"/>      
        <br />
        <br />
        <input id="usernameText" type="text" name="usernameText" class="Curved" placeholder="User ID" required />
        <br />
        <br />
        <input id="passwordText" type="password" name="passwordText" class="Curved" placeholder="Password" required />

        <br />
        <br />

        <asp:Button CssClass="Curved1" ID="logIn" runat="server"  Text="Login" OnClick="logIn_Click" />
        <br />
        <br />

        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>
        <br />


        <a href="RegisterStudent.aspx" style="color:#71A2A6; font-weight: 700;">Register as student</a>
        <br />
        <a href="RegisterInstructor.aspx" style="color:#71A2A6; font-weight: 700;">Register as instructor</a>

    </form>       
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
