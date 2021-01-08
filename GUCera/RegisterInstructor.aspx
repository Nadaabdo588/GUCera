<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterInstructor.aspx.cs" Inherits="GUCera.RegisterInstructor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        
    <title></title>
    <style>
        .Curved        {    	-webkit-border-radius: 50px;        -moz-border-radius: 50px;        border-radius: 30px;        }
        .Curved1        {    	-webkit-border-radius: 50px;        -moz-border-radius: 50px;        border-radius: 30px;        color: #8B5E31;         font-weight: 700;         background-color: #71A2A6;        }

    </style>
</head>
<body style="background-color: #F4E8E8">
    <form id="form2" runat="server">
        <asp:TextBox CssClass="Curved" ID="firstnameText" runat="server" placeholder="First name :"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="lastnameText" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="passwordText" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="emailText" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="addressText" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:DropDownList ID="genderList" runat="server" CssClass="Curved" >
            <asp:ListItem Value="Male" Selected="True" >Male</asp:ListItem>
            <asp:ListItem Value="Female" >Female</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="RegisterButton" runat="server" Text="Register" CssClass="Curved1" OnClick="RegisterButton_Click" />
        <br />
        <br />
    </form>
</body>
</html>
