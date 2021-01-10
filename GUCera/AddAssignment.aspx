<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAssignment.aspx.cs" Inherits="GUCera.AddAssignment" %>

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
    <asp:Label ID="credit" runat="server" Text="Assignment details"></asp:Label>  
    <form id="form1" runat="server">
        <br />
        <img src="https://img.icons8.com/bubbles/100/000000/task.png"/>
        <br />
        <br />
       
        <asp:TextBox CssClass="Curved" ID="courseText" runat="server"  placeholder="Course Number"></asp:TextBox>
        <br />
        <br />
      
        
        <asp:TextBox CssClass="Curved" ID="typeText" runat="server" MaxLength="10" placeholder="Assignment Type"></asp:TextBox>
        <br />
        <br />

        
        <asp:TextBox CssClass="Curved" ID="numberText" runat="server" placeholder="Assignment Number"></asp:TextBox>
        <br />
        <br />

        
        <asp:TextBox CssClass="Curved" ID="gradeText" runat="server" placeholder="Full Grade"></asp:TextBox>
        <br />
        <br />

        
        <asp:TextBox CssClass="Curved" ID="weightText" runat="server" placeholder="Weight"></asp:TextBox>
        <br />
        <br />


        <asp:TextBox CssClass="Curved" ID="deadlineText" runat="server"  placeholder="Deadline"></asp:TextBox>
        <br />
        <br />
     
        <asp:TextBox CssClass="Curved" ID="contentText" runat="server" MaxLength = 200 placeholder="Content"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="submitC" CssClass="Curved1" runat="server" Text="Add Assignment" OnClick="submitC_Click" />
        <br />
        <asp:Label ID="error" CssClass="Label1" runat="server" Visible="false"></asp:Label>


    &nbsp;</form>
</body>
</html>

