﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadingPage.aspx.cs" Inherits="GUCera.LoadingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1{
            position:center;
            text-align:center;
            height:100%;
        }
        .Curved1
          .Label1{
              color: #8B5E31; 
              font-weight: 700;
        }

    </style>
</head>
<body style="background-color: #F4E8E8">
    <form id="form1" runat="server">
        <asp:Label CssClass="Label1" ID="Label1" runat="server" ></asp:Label>
        <br />
        <br />
        <asp:Button CssClass="Curved1" ID="Button1" runat="server" Text="Go home" />
    </form>
</body>
</html>