 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentprofile.aspx.cs" Inherits="GUCera.Student_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #8B5E31;
        }
        .auto-style2 {
            color: #71A2A6;
        }
        body {
            background-color: #F4E8E8;
        }
        #form1
        {
            position:center;
            text-align:center;
            height:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="color:#8B5E31">Student profile</h1>
        <br />
        <br />
    <img src="https://img.icons8.com/bubbles/100/000000/test-account.png" style="height: 115px; width: 119px"/><br />
        <p>
            <strong><span class="auto-style1">ID :</span><span class="auto-style2"> </span></strong>&nbsp;&nbsp

            <asp:Label ID="ID" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
        <p>
        <strong><span class="auto-style1">First name :</span><span class="auto-style2"> </span></strong>&nbsp;&nbsp
        <asp:Label ID="First_name" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
        <p>
            <strong><span class="auto-style1">Last name : </span><span class="auto-style2"> </span></strong>&nbsp;&nbsp;
            <asp:Label ID="Last_name" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
        <p>
            <span class="auto-style1"><strong>Password :</strong></span>&nbsp;&nbsp;
            <asp:Label ID="Password" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
    <p>
        <span class="auto-style1"><strong>Gender : </strong></span>&nbsp;&nbsp;
        <asp:Label ID="Gender" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
    <p>
        <strong><span class="auto-style1">Email :</span> </strong>&nbsp;&nbsp;
        <asp:Label ID="Email" runat="server" style="color: #71A2A6" Text=""></asp:Label>
    </p>
    <p>
        <span class="auto-style1"><strong>Address : </strong></span>&nbsp;&nbsp
        <asp:Label ID="Address" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
    <p>
        <span class="auto-style1"><strong>GPA :</strong></span>&nbsp;&nbsp;
        <asp:Label ID="GPA" runat="server" style="color: #71A2A6" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
