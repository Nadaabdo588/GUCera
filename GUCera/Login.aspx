<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
          .button1 {

              border-radius: 8px;
          }

          .Label1 {
          
              color: #8B5E31;
              font-weight: 700;
          }

          #head{
              
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

    </style>
</head>
<body style="background-color: #F4E8E8">
    <form id="form1" runat="server">
        <asp:Label ID="head" runat="server" Text="Welcome to GUCera !"></asp:Label>
        <br />
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/lock.png"/>      
        <br />
        <asp:Label CssClass="Label1" runat="server" Text="Username :"></asp:Label> 
        <br />
        <asp:TextBox ID="usernameText" runat="server"></asp:TextBox>
        <br />
        <asp:Label CssClass="Label1" runat="server" Text="Password :"></asp:Label> 
        <br />
        <asp:TextBox ID="passwordText" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="logIn" CssClass="button1" runat="server" style="color: #8B5E31; font-weight: 700; background-color: #71A2A6" Text="Login" OnClick="logIn_Click" />
        <br />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>

        <br />
        <a href="RegisterStudent.aspx" style="color:#71A2A6; font-weight: 700;">Register as student</a>
        <br />
        <a href="RegisterInstructor.aspx" style="color:#71A2A6; font-weight: 700;">Register as instructor</a>

    </form>
</body>
</html>
