<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GUCera.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 328px">
    <form id="form1" runat="server">
        <div>
            Admin Home</div>
        <asp:Button ID="viewC" runat="server" Text="View Courses" Width="300px" OnClick="viewC_Click" />
        <p>
            <asp:Button ID="notacceptedC" runat="server" Text="View not Accepted Courses" OnClick="notacceptedC_Click" />
        </p>
        <p>
            Accept Course :-</p>
        <p>
            &nbsp;
            <asp:Label ID="courseidLabel" runat="server" Text="Course ID"></asp:Label>
            <asp:TextBox ID="courseId" runat="server" style="margin-left: 57px" Width="140px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="acceptC">   Accept course</asp:LinkButton>
        </p>
        <p>
            Create Promo Code :-</p>
        <p>
            Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pcode" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Expiry Date&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="expirydate" runat="server"></asp:TextBox>

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Discount&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="discount" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="createP">Create</asp:LinkButton>
        </p>
        <p>
            Issue Promo Code to a Student :-</p>
        <p>
            Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="sid" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Promo Code&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="pid" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton3" runat="server" OnClick="issue">Issue</asp:LinkButton>
        </p>
        <p>
            <asp:Label ID="errmsg" runat="server" Text="This field can not be empty"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
