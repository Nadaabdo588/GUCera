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
        .button1 {
            border-radius: 8px;
        }
        .Label1{
              color: #8B5E31; 
              font-weight: 700;
        }

    </style>
</head>
<body style="background-color:#F4E8E8">       
    <asp:Label ID="credit" runat="server" Text="Credit Card details"></asp:Label>  
    <form id="form1" runat="server">
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png"/>
        <br />
        <br />
        <asp:Label CssClass="Label1" runat="server" Text="Credit card number :"></asp:Label>
        &nbsp;<br />
        <asp:TextBox ID="ccn" runat="server" MaxLength="15"></asp:TextBox>
        <br />
        <br />
        <asp:Label CssClass="Label1" runat="server" Text="Card holder name :"></asp:Label>
        <br />
        <asp:TextBox ID="hname" runat="server" MaxLength="16"></asp:TextBox>
        <br />
        <br />
        <asp:Label CssClass="Label1" runat="server"  Text="Expiry date :"></asp:Label> 
        <br />
        <asp:TextBox ID="date" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label CssClass="Label1" runat="server" Text="CVV number :"></asp:Label>
        <br />
        <asp:TextBox ID="cvv" runat="server" MaxLength="3" ></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="submitC" CssClass="button1" runat="server" style="color: #8B5E31; font-weight: 700; background-color: #71A2A6" Text="Add credit card" OnClick="submitC_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
</body>
</html>
