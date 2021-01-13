<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="GUCera.InstructorHome" %>

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
        <h1 style="color:#8B5E31">Instructor Home</h1> 
    
        <div class="row" >
            
             <div class="block" >
                <asp:ImageButton ID="courses" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/book-reading.png" OnClick="courses_Click"/>    
                <br />
                <asp:Label ID="Label3" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add Course"></asp:Label>
            </div> 
            <div class="block" >
                <asp:ImageButton ID="promocodes" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/task.png" OnClick="addAssignment_Click" />
                <br />
                <asp:Label ID="Label5" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add Assignment"></asp:Label>
            </div>
            <div class="block" >
                <asp:ImageButton ID="submittedAssignments" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/task.png" OnClick="submittedAssignments_Click" />
                <br />
                <asp:Label ID="Label6" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="View Submitted Assignments"></asp:Label>
            </div>
             <div class="block" >
                 <asp:ImageButton ID="creditcards" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/report-card.png" OnClick="gradeAssignments_Click" />
                 <br />
                 <asp:Label ID="Label4" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Grade Assignment"></asp:Label>
            </div>
            
             <div class="block" >
                 <asp:ImageButton ID="feedbacks" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/speech-bubble.png" OnClick="feedbacks_Click" />
                 <br />
                 <asp:Label ID="Label7" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="View Feedbacks"></asp:Label>
            </div>
            <div class="block" >
                 <asp:ImageButton ID="certificate" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/certificate.png" OnClick="certificate_Click" />
                 <br />
                 <asp:Label ID="Label2" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Issue Certificate"></asp:Label>
            </div>
            <div class="block" >
                <asp:ImageButton ID="ImageButton1" runat="server" imageurl="https://img.icons8.com/bubbles/100/000000/number-pad.png" OnClick="telephone_Click" />
                <br />
                <asp:Label ID="Label1" runat="server" style="color: #8B5E31; font-weight: 700; font-size: large;" Text="Add telephone number"></asp:Label>

            </div>
        </div>
    
    </form>
</body>
</html>
