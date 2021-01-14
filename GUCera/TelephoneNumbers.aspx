<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelephoneNumbers.aspx.cs" Inherits="GUCera.TelephoneNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>
    <title></title>
   
</head>
<body style="background-color: #F4E8E8">

    <form id="form1" runat="server">     
       <h1 style="color:#8B5E31">Add Telephone number</h1>
        <br />
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/number-pad.png"/>
        <br />
        <br />
        <input type="text" class="Curved" id="numberText" name="numberText" placeholder="Number" required/>
        <br />
        <br />
        <br />
        <asp:Button CssClass="Curved1" ID="Button1" runat="server" Text="Add number" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>

        
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
