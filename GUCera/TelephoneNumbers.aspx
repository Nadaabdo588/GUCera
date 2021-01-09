<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TelephoneNumbers.aspx.cs" Inherits="GUCera.TelephoneNumbers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
    </title>
    <style>
        .Curved1        {        	-webkit-border-radius: 50px;            -moz-border-radius: 50px;            border-radius: 30px;            color: #8B5E31;             font-weight: 700;             background-color: #71A2A6;        }
        .Curved        {    	    -webkit-border-radius: 50px;            -moz-border-radius: 50px;            border-radius: 30px;        }
        #form1{
            position:center;
            text-align:center;
            height:100%;
        }
        .Label1{
            color: #8B5E31; 
            font-weight: 700;
        }
    </style>
</head>
<body style="background-color: #F4E8E8">
    <form id="form1" runat="server">
        
       <h2 style="color:#8B5E31">Add Telephone number</h2>
        <br />
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/number-pad.png"/>
        <br />
        <br />
      
        <asp:TextBox CssClass="Curved" ID="numberText" runat="server" placeholder="Number"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button CssClass="Curved1" ID="Button1" runat="server" Text="Add number" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>

        
    </form>
</body>
</html>
