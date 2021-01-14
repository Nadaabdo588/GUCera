 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentprofile.aspx.cs" Inherits="GUCera.Student_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous"/>
    <title></title>
   
</head>
<body style="background-color:#F4E8E8">
    <form id="form1" runat="server">   

        <h1 style="color:#8B5E31">Student profile</h1>
        <br />      
        <img src="https://img.icons8.com/bubbles/100/000000/test-account.png" style="height: 115px; width: 119px"/><br />
        <br />
        <br />
        <br />

        <div class="container" style="width:20%">
             <div class="row">
        <div class="col">
           <asp:Label ID="l1" runat="server" cssclass="Label1" Text="ID :"></asp:Label>
        </div>
         <div class="col">
        <asp:Label ID="ID" runat="server" cssclass="Label2" Text=""></asp:Label>
        </div> 
        </div>
      
        <div class="row">
            <div class="col">

            <asp:Label ID="l2" runat="server" cssclass="Label1" Text="First name :"></asp:Label>  

            </div>
            <div class="col">
            <asp:Label ID="First_name" runat="server" cssclass="Label2" Text=""></asp:Label>
            </div>
        </div>

        <div class="row">
            <div class="col">
                 <asp:Label ID="l3" runat="server" cssclass="Label1" Text="Last name :"></asp:Label>  
            </div>
            <div class="col">
                 <asp:Label ID="Last_name" runat="server" cssclass="Label2" Text=""></asp:Label>
            </div>
        </div>
        <div class="row">       
        <div class="col">
        <asp:Label ID="l4" runat="server" cssclass="Label1" Text="Password :"></asp:Label>  
        </div>
        <div class="col">
        <asp:Label ID="Password" runat="server" cssclass="Label2" Text=""></asp:Label>
        </div>
        </div>
        <div class="row">
         <div class="col">
             <asp:Label ID="l5" runat="server" cssclass="Label1" Text="Gender:"></asp:Label>  
         </div>
        <div class="col">
             <asp:Label ID="Gender" runat="server" cssclass="Label2" Text=""></asp:Label>
        </div>
        </div>
       
         <div class="row">
             <div class="col">
        <asp:Label ID="l6" runat="server" cssclass="Label1" Text="Email :"></asp:Label>  

             </div>
             <div class="col">
             <asp:Label ID="Email" runat="server" cssclass="Label2" Text=""></asp:Label>
             </div>
         </div>
        <div class="row">
            <div class="col">
        <asp:Label ID="l7" runat="server" cssclass="Label1" Text="Address :"></asp:Label>  

            </div>
            <div class="col">
        <asp:Label ID="Address" runat="server" cssclass="Label2" Text=""></asp:Label>

            </div>
        </div>
        <div class="row">
            <div class="col">
               <asp:Label ID="l8" runat="server" cssclass="Label1" Text="GPA :"></asp:Label>  
            </div>
            <div class="col">
                <asp:Label ID="GPA" runat="server" cssclass="Label2" Text=""></asp:Label>
            </div>
        </div>
        
       
        </div>
       
        <br />
     
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
