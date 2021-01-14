<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="GUCera.AddFeedback" %>

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
    <asp:Label ID="credit" runat="server" Text="Add Feedback"></asp:Label>  
    <form id="form1" runat="server">
        <br />
        <img src="https://img.icons8.com/cute-clipart/64/000000/feedback.png"/>
        <br />
        <br />
       
        <asp:TextBox CssClass="Curved" ID="courseID" runat="server"  placeholder="Course ID"></asp:TextBox>
        <br />
        <br />
      
        
        <asp:TextBox CssClass="Curved" ID="comment" runat="server" MaxLength="100" placeholder="Comment"></asp:TextBox>
        <br />
        <br />


        <br />
        <asp:Button ID="submit" CssClass="Curved1" runat="server" Text="Add Feedback" OnClick="submit_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
</html>