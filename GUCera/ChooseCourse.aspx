<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseCourse.aspx.cs" Inherits="GUCera.ChooseCourse" %>

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
        
       <h1 style="color:#8B5E31">Add Telephone number</h1>
        <br />
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/task.png"/>
        <br />
        <br />
      
        <asp:TextBox CssClass="Curved" ID="courseText" runat="server" placeholder="Course ID"></asp:TextBox>
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
