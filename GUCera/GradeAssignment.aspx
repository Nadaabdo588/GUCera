﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GradeAssignment.aspx.cs" Inherits="GUCera.GradeAssignment" %>


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
        .Curved
        .Curved1
    </style>
</head>
<body style="background-color:#F4E8E8">       
    <asp:Label ID="credit" runat="server" Text="Grade Assignment"></asp:Label>  
    <form id="form1" runat="server">
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/report-card.png"/>
        <br />
        <br />
       
        <asp:TextBox CssClass="Curved" ID="studentText" runat="server" placeholder="Student ID"></asp:TextBox>
        <br />
        <br />
      
        <asp:TextBox CssClass="Curved" ID="courseText" runat="server"  placeholder="Course ID"></asp:TextBox>
        <br />
        <br />
     
        <asp:TextBox CssClass="Curved" ID="typeText" runat="server" maxSize = 10 placeholder="Assingment Type"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="numberText" runat="server" placeholder="Assingment Number"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox CssClass="Curved" ID="gradeText" runat="server" placeholder="Grade"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="submitC" CssClass="Curved1" runat="server" Text="Sumit" OnClick="submitC_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
</body>
</html>