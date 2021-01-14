<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>
    <title></title>
   
</head>
<body style="background-color: #F4E8E8">
   
    <form id="form1" runat="server">
        <h1 class="Label1">Student Home</h1> 
        <br />
        <br />
        <br />
        <div class="row" >
            <div class="col" >
                <asp:ImageButton ID="profile" runat="server" imageUrl="https://img.icons8.com/bubbles/100/000000/test-account.png" OnClick="profile_Click" />
                <br />
                <asp:Label ID="Label2" runat="server" cssclass="Label1" Text="My Profile"></asp:Label>
            </div>
             <div class="col" >
                <asp:ImageButton ID="courses" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/book-reading.png" OnClick="courses_Click"/>    
                <br />
                <asp:Label ID="Label3" runat="server" cssclass="Label1" Text="Available Courses"></asp:Label>
            </div> 
            <div class="col" >
                <asp:ImageButton ID="promocodes" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/transaction-list.png" OnClick="promocodes_Click"/>
                <br />
                <asp:Label ID="Label5" runat="server" cssclass="Label1" Text="My promo codes"></asp:Label>
            </div>
             <div class="col" >
                 <asp:ImageButton ID="creditcards" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/bank-card-back-side.png" OnClick="creditcards_Click"/>
                 <br />
                 <asp:Label ID="Label4" runat="server" cssclass="Label1" Text="Add credit card"></asp:Label>
            </div>
            <div class="col" >
                <asp:ImageButton ID="ImageButton1" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/number-pad.png" OnClick="telephone_Click"/>
                <br />
                <asp:Label ID="Label1" runat="server" cssclass="Label1" Text="Add telephone number"></asp:Label>
            </div>
           
             <div class="col" >
                <asp:ImageButton ID="ImageButton6" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/book-reading.png" OnClick="myCources_Click"/>
                <br />
                <asp:Label ID="Label6" runat="server" cssclass="Label1" Text="My Cources"></asp:Label>

            </div>
            <div class="col" >
                <asp:ImageButton ID="ImageButton7" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/task.png" OnClick="myAssignments_Click"/>
                <br />
                <asp:Label ID="Label7" runat="server" cssclass="Label1" Text="My Assignments"></asp:Label>

            </div>
            <div class="col" >
                <asp:ImageButton ID="ImageButton8" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/comments.png" OnClick="addFeedback_Click"/>
                <br />
                <asp:Label ID="Label8" runat="server" cssclass="Label1" Text="Add Feedback"></asp:Label>

            </div>
            <div class="col" >
                <asp:ImageButton ID="ImageButton9" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/education.png" OnClick="ListCertificates_Click"/>
                <br />
                <asp:Label ID="Label9" runat="server" cssclass="Label1" Text="List Certificates"></asp:Label>

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
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
