<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewsubAssignments.aspx.cs" Inherits="GUCera.ViewAssignments" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ul class="nav nav-tabs " style="background-color: #FFFFFF;">
            <li class="nav-item">
                <p class="nav-link" style="color: #483D8B;"><b>GUCera</b></p>
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="h" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>

            <li class="nav-item">
                <asp:LinkButton ID="a" CssClass="nav-link active Label4" aria-current="page" runat="server" Text="Assignments" OnClick="as_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="f" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Feedbacks" OnClick="fd_Click" />
            </li>
        </ul>
        <div class="layout" style="margin: 25px 25px 25px 25px; padding: 8% 8% 8%; background-color: white">
            <div class="row row-cols-3">
                <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

            </div>
        </div>

    </form>
</body>
</html>
