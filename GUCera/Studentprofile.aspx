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
         .Label1 {
          
              color: #FFFFFF;
              font-weight: 700;
          }
           .Label2 {
          
              color: #8B5E31;
              font-weight: 700;
          }
    </style>
</head>
<body>
    <form id="form1" runat="server">   

        <h1 style="color:#8B5E31">Student profile</h1>
        <br />      
        <img src="https://img.icons8.com/bubbles/100/000000/test-account.png" style="height: 115px; width: 119px"/><br />
        <br />
        <asp:DetailsView ID="DetailsView1" runat="server" Height="241px" Width="276px" AutoGenerateRows="False"  horizontalalign="Center" style="background-color: #FFFFFF" >
            <Fields>
                <asp:BoundField DataField="id" HeaderText="ID" ReadOnly="True" SortExpression="id" >                
                <HeaderStyle CssClass="Label1" BackColor="#688688" BorderWidth="0px" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
                <asp:BoundField DataField="firstName" HeaderText="First name" SortExpression="firstName" >
                <HeaderStyle BackColor="#688688" CssClass="Label1" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
                <asp:BoundField DataField="lastName" HeaderText="Last name" SortExpression="lastName" >
                <HeaderStyle BackColor="#688688" CssClass="Label1" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
                <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" >
                <HeaderStyle BackColor="#688688" CssClass="Label1" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
                <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" >
                <HeaderStyle BackColor="#688688" CssClass="Label1" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
                <asp:BoundField DataField="gpa" HeaderText="GPA" SortExpression="gpa" >
                <HeaderStyle BackColor="#688688" CssClass="Label1" />
                <ItemStyle BackColor="#C8DDD9" CssClass="Label2" />
                </asp:BoundField>
            </Fields>
        </asp:DetailsView>
       
        <br />
     
    </form>
</body>
</html>
