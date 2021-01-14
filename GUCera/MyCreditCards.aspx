<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCreditCards.aspx.cs" Inherits="GUCera.MyCreditCards" %>

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

        <h1 class="Label1">Credit Card details</h1>  
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png"/>
        <br />
        <br />
       
        <%--<asp:TextBox CssClass="Curved" ID="ccn" runat="server" MaxLength="15" placeholder="Credit card number"></asp:TextBox>--%>
        <input type="text" id="cnn" name="cnn" class="Curved" placeholder="Credit card number" required />
        <br />
        <br />
      
        <%--<asp:TextBox CssClass="Curved" ID="hname" runat="server" MaxLength="16" placeholder="Card holder name"></asp:TextBox>--%>
        <input type="text" id="hname" name="hname" class="Curved" placeholder="Card holder name" required />

        <br />
        <br />
     
        <%--<asp:TextBox CssClass="Curved" ID="date" runat="server" placeholder="Expiry date"></asp:TextBox>--%>
        <input type="text" id="date" name="date" class="Curved" placeholder="Expiry date" required />

        <br />
        <br />
        <%--<asp:TextBox CssClass="Curved" ID="cvv" runat="server" MaxLength="3" placeholder="CVV" ></asp:TextBox>--%>
        <input type="text" id="cvv" name="cvv" class="Curved" placeholder="CVV" required />

        <br />
        <br />
        <br />
        <asp:Button ID="submitC" CssClass="Curved1" runat="server" Text="Add credit card" OnClick="submitC_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
