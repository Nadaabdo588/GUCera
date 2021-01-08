<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        .row {
         position:absolute;
         width: 100%;
         text-align: center; 
         top:25%;
         left:0%;
    
        }

        .block {
            width: 200px;
            height: 170px;
            display: inline-block;
        }
        #home{
            display: block;
            text-align: center;
            color: #8B5E31; 
            font-weight: 700;
            font-size: xx-large;
        }
    
     
    </style>
</head>
<body style="background-color: #F4E8E8">
   
    <form id="form1" runat="server">
        <asp:Label ID="home" runat="server" Text="Student Home"></asp:Label> 
        <div class="row" >
            <div class="block" >
                <asp:ImageButton ID="profile" runat="server" imageUrl="https://img.icons8.com/bubbles/100/000000/test-account.png" OnClick="profile_Click" />
                <br />
                <asp:Label ID="Label2" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="My Profile"></asp:Label>
            </div>
             <div class="block" >
                <asp:ImageButton ID="courses" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/book-reading.png" OnClick="courses_Click"/>    
                <br />
                <asp:Label ID="Label3" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Available Courses"></asp:Label>
            </div>
             <div class="block" >
                 <asp:ImageButton ID="creditcards" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png" OnClick="creditcards_Click"/>
                 <br />
                 <asp:Label ID="Label4" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add credit card"></asp:Label>
            </div>
            <div class="block" >
                <asp:ImageButton ID="promocodes" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/transaction-list.png" OnClick="promocodes_Click"/>
                <br />
                <asp:Label ID="Label5" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="My promo codes"></asp:Label>

            </div>
        </div>
    
    </form>
</body>
</html>
