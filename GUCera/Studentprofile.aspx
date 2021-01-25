<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentprofile.aspx.cs" Inherits="GUCera.Student_profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />
    <title></title>

</head>
<body style="background-color: #F4E8E8">

    <form id="form1" runat="server">

        <ul class="nav nav-tabs " style="background-color: #FFFFFF;">
            <li class="nav-item">
                <p class="nav-link" style="color: #483D8B;"><b>GUCera</b></p>
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link " Style="color: #483D8B;" aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link active" aria-current="page" Style="color: #483D8B;" runat="server" Text="Profile" OnClick="p_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link" aria-current="page" Style="color: #483D8B;" runat="server" Text="Courses" OnClick="c_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link" aria-current="page" Style="color: #483D8B;" runat="server" Text="Promocodes" OnClick="pc_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Certificates" OnClick="cer_Click" />
            </li>
        </ul>
        <div class="layout" style="padding: 8% 0 0; margin: auto;">

            <div class="form">

                <div class="card">
                    <div class="card-header">
                        <h2 class="Label3">Student profile</h2>
                    </div>
                    <div class="card-body">
                        <img src="https://img.icons8.com/clouds/100/000000/user-female-circle.png" runat="server" visible="false" id="female" />
                        <img src="https://img.icons8.com/clouds/100/000000/user-male-circle.png" runat="server" visible="false" id="male" />
                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l1" runat="server" Text="ID :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="IDText" placeholder="First name" readonly />

                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l2" runat="server" Text="First name :"></asp:Label>


                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="firstnameText" placeholder="First name" readonly />

                            </div>

                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l3" runat="server" Text="Last name :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="lastnameText" placeholder="Last name" readonly />

                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l4" runat="server" Text="Password :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="password" runat="server" id="passwordText" placeholder="Password" readonly />

                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l5" runat="server" Text="Gender:"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="genderText" placeholder=" Gender" readonly />

                            </div>


                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l6" runat="server" Text="Email :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="emailText" placeholder="Email" readonly />

                            </div>


                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l7" runat="server" Text="Address :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="addressText" placeholder=" Address" readonly />

                            </div>


                        </div>
                        <div class="row">
                            <div class="col">
                                <asp:Label CssClass="Label4" ID="l8" runat="server" Text="GPA :"></asp:Label>

                            </div>
                            <div class="col">
                                <input type="text" runat="server" id="gpaText" placeholder=" GPA" readonly />
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>

    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
