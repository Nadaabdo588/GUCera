<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddFeedback.aspx.cs" Inherits="GUCera.AddFeedback" %>

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
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Profile" OnClick="p_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Courses" OnClick="c_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Promocodes" OnClick="pc_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Certificates" OnClick="cer_Click" />
            </li>
        </ul>
        <div class="layout row" style="padding: 8% 8% 8%; margin: auto;">
            <div class="col">

                <div class="form">
                    <h2 class="Label3">Add Feedback</h2>
                    <br />
                    <br />

                    <br />

                    <input id="comment" name="comment" runat="server" placeholder="Comment" required />

                    <asp:Button ID="submit" CssClass="button" runat="server" Text="Add Feedback" OnClick="submit_Click" />
                    <br />
                    <asp:Label ID="error" CssClass="message" runat="server" Visible="false"></asp:Label>

                </div>
            </div>
            <div class="col">
                <img src="feedback.png" width="600" height="600" />
            </div>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
