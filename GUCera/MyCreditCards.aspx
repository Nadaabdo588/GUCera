<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyCreditCards.aspx.cs" Inherits="GUCera.MyCreditCards" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #credit{
            display: block;
            text-align: center;
            color: #8B5E31; 
            font-weight: 700;
            font-size: xx-large;
        }
        #form1{
            height:100%;
            text-align: center;  
            position: center;
 
        }
      
        .Label1{
              color: #8B5E31; 
              font-weight: 700;
        }
        .Curved        {    	    -webkit-border-radius: 50px;            -moz-border-radius: 50px;            border-radius: 30px;        }
        .Curved1        {    	    -webkit-border-radius: 50px;            -moz-border-radius: 50px;            border-radius: 30px;            color: #8B5E31;             font-weight: 700;             background-color: #71A2A6;        }
    </style>
</head>
<body style="background-color:#F4E8E8">       
    <asp:Label ID="credit" runat="server" Text="Credit Card details"></asp:Label>  
    <form id="form1" runat="server">
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png"/>
        <br />
        <br />
       
        <asp:TextBox CssClass="Curved" ID="ccn" runat="server" MaxLength="15" placeholder="Credit card number"></asp:TextBox>
        <br />
        <br />
      
        <asp:TextBox CssClass="Curved" ID="hname" runat="server" MaxLength="16" placeholder="Card holder name"></asp:TextBox>
        <br />
        <br />
     
        <asp:TextBox CssClass="Curved" ID="date" runat="server" placeholder="Expiry date"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="cvv" runat="server" MaxLength="3" placeholder="CVV" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="submitC" CssClass="Curved1" runat="server" Text="Add credit card" OnClick="submitC_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
</body>
</html>
