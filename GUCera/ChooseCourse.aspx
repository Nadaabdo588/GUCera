<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseCourse.aspx.cs" Inherits="GUCera.ChooseCourse" %>

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
                <p class="nav-link Label3" ><b>GUCera</b></p>
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="h" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>

            <li class="nav-item">
                <asp:LinkButton ID="a" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Assignments" OnClick="as_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="f" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Feedbacks" OnClick="fd_Click" />
            </li>
        </ul>
        <div class="login-page">
            <div class="form">



                <h2 class="Label3">Choose Course</h2>
                <br />
                <br />
                <img src="https://img.icons8.com/bubbles/100/000000/book-reading.png" />
                <br />
                <br />

                <input id="courseText" name="courseText" runat="server" placeholder="Course ID" required />

                <asp:Button CssClass="button" ID="Button1" runat="server" Text="Choose" OnClick="Button1_Click" />

                <asp:Label ID="error" CssClass="message" runat="server" Visible="false"></asp:Label>



            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
