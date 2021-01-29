<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddAssignment.aspx.cs" Inherits="GUCera.AddAssignment" %>

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
                <asp:LinkButton ID="a" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Assignments" OnClick="as_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="f" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Feedbacks" OnClick="fd_Click" />
            </li>
        </ul>
        <div class="layout row" style="padding: 8% 8% 8%; margin: 8% 8% 8% 8%;">
            <div class="form col">
                <h2 class="Label3">Assignment details</h2>
                <br />
                <br />

                <input id="courseText" name="courseText" runat="server" placeholder="Course Number" required />


                <input id="typeText" name="typeText" runat="server" placeholder="Assignment Type" required />

                <input id="numberText" name="numberText" runat="server" placeholder="Assignment Number" required />


                <input id="gradeText" name="gradeText" runat="server" placeholder="Full Grade" required />



                <input id="weightText" name="weightText" runat="server" placeholder="Weight" required />


                <input id="deadlineText" name="deadlineText" runat="server" placeholder="Deadline" required />

                <input id="contentText" name="contentText" runat="server" placeholder="Content" required />

                <asp:Button ID="submitC" CssClass="button" runat="server" Text="Add Assignment" OnClick="submitC_Click" />

                <asp:Label ID="error" CssClass="message" runat="server" Visible="false"></asp:Label>

            </div>
            <div class="col">
                <img src="assignment.png" width="600" height="450"/>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>

