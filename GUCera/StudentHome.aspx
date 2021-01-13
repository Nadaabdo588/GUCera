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
        #form1 {
            position: center;
            text-align: center;
            height: 100%;
        }
       
     
    </style>
</head>
<body style="background-color: #F4E8E8">
   
    <form id="form1" runat="server">
        <h1 style="color:#8B5E31">Student Home</h1> 
    
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
                <asp:ImageButton ID="promocodes" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/transaction-list.png" OnClick="promocodes_Click"/>
                <br />
                <asp:Label ID="Label5" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="My promo codes"></asp:Label>
            </div>
             <div class="block" >
                 <asp:ImageButton ID="creditcards" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png" OnClick="creditcards_Click"/>
                 <br />
                 <asp:Label ID="Label4" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add credit card"></asp:Label>
            </div>
            <div class="block" >
                <asp:ImageButton ID="ImageButton1" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/number-pad.png" OnClick="telephone_Click"/>
                <br />
                <asp:Label ID="Label1" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add telephone number"></asp:Label>

            </div>
            <div class="block" >
                <asp:ImageButton ID="ImageButton6" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/book-reading.png" OnClick="myCources_Click"/>
                <br />
                <asp:Label ID="Label6" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="My Cources"></asp:Label>

            </div>
            
            <div class="block" >
                <asp:ImageButton ID="ImageButton7" runat="server" imageurl="https://img.icons8.com/cute-clipart/64/000000/feedback.png" OnClick="addFeedback_Click"/>
                <br />
                <asp:Label ID="Label7" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add Feedback"></asp:Label>

            </div>

            <div class="block" >
                <asp:ImageButton ID="ImageButton8" runat="server" imageurl="https://img.icons8.com/doodle/48/000000/certificate.png" OnClick="ListCertificates_Click"/>
                <br />
                <asp:Label ID="Label8" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="My Certificates"></asp:Label>

            </div>
        </div>
    
    </form>
</body>
</html>
