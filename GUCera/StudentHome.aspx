<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentHome.aspx.cs" Inherits="GUCera.StudentHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles\style.css" type="text/css" />
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="preconnect" href="https://fonts.gstatic.com"/>
<link href="https://fonts.googleapis.com/css2?family=Archivo&display=swap" rel="stylesheet"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous" />
    <title></title>

    

</head>
<body style="text-align:center;">

    <form id="form1" runat="server" >
        <ul class="nav nav-tabs " style="background-color: #FFFFFF;">
            <li class="nav-item">
                <p class="nav-link" style="color: #483D8B;"><b>GUCera</b></p>
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link active Label4"  aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page"  runat="server" Text="Profile" OnClick="p_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page"  runat="server" Text="Courses" OnClick="c_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page"  runat="server" Text="Promocodes" OnClick="pc_Click" />
            </li>
             <li class="nav-item">
                <asp:LinkButton CssClass="nav-link Label4" aria-current="page" runat="server" Text="Certificates" OnClick="cer_Click" />
            </li>
        </ul>
        <div class="row">
            <div class="col" style="text-align:left; background-color: white">
                <img src="nav.jpg" width="626" height="416" />

            </div>
            <div class="col" style="text-align:center; background-color: white ;position:center">
               <p style="font-size:75px;font-weight:700;font-family: 'Arvo', serif;color:#483D8B"> WELCOME TO GUCERA ! </p>
               <p style="color:#483D8B">GUCera is a perfect website for best educational services for all students. You all have the chance to experience new courses and learning techniques. </p>
            </div>
        </div>
        <br />
        <br />
        <div class="row h6" style="margin:25px 25px 25px 25px">
            <div class="col">
                <div class="card h-100">
                    <div class="card-header">
                        <h2 class="Label3">Available courses</h2>
                    </div>
                    <div class="card-body">
                        <img style="position: center" src="https://img.icons8.com/clouds/100/000000/book-shelf.png" />
                        <p class="card-text Label4">Choose your favourite course to enroll in !</p>
                    </div>
                    <div class="card-footer">
                        <asp:Button CssClass="Curved1" ID="ImageButton2" runat="server" OnClick="courses_Click" Text="View available courses" />

                    </div>

                </div>
            </div>
            <div class="col">
                <div class="card h-100">
                    <div class="card-header">
                        <h2 class="Label3">Credit Cards</h2>
                    </div>
                    <div class="card-body">
                        <img src="https://img.icons8.com/clouds/100/000000/card-in-use.png" />
                        <p class="card-text Label4">Add new credit card details</p>

                    </div>
                    <div class="card-footer">
                        <asp:Button CssClass="Curved1" ID="Button1" runat="server" OnClick="creditcards_Click" Text="Add credit card" />
                    </div>
                </div>
            </div>
            <div class="col">

                <div class="card h-100">
                    <div class="card-header">
                        <h2 class="Label3">Phone numbers</h2>
                    </div>

                    <div class="card-body">
                        <img src="https://img.icons8.com/clouds/100/000000/iphone.png" />
                        <p class="card-text Label4">Add new telephone numbers </p>
                    </div>
                    <div class="card-footer">
                        <asp:Button CssClass="Curved1" ID="ImageButton1" runat="server" OnClick="telephone_Click" Text="Add telephone number" />

                    </div>

                </div>
            </div>
        </div>
        <br />
        <div class="row" style="margin:25px 25px 25px 25px">
            <div class="col w-75">
                <div class="row w-100">
                    <div class="card w-100 h6">
                        <div class="card-header">
                            <h2 class="Label3">In progress</h2>
                            <div class="progress">
                                <div class="progress-bar progress-bar-striped progress-bar-animated" role="progressbar" aria-valuenow="75" aria-valuemin="0" aria-valuemax="100" style="width: 75%"></div>
                            </div>
                        </div>
                        <div class="card-body">
                            <div class="row">
                                <div class="col">
                                    <p class="card-text Label4">You can review your progress in your enrolled-in courses, submit your assignments and add feedbacks to any of these courses.</p>
                                </div>
                              
                                <div class="col-3">
                                    <img class="card-img" src="inProgress.png" />
                                </div>

                            </div>

                        </div> 
                        <div class="card-footer">
                                    <asp:Button CssClass="Curved1" ID="ImageButton6" runat="server" OnClick="myCources_Click" Text="View my courses" />
                                </div>
                    </div>
                </div>
                <br />
                <div class="row w-100">
                    <div class="col">
                        <div class="card">
                            <div class="card-header">
                                <h2 class="Label3">Promocodes</h2>
                            </div>
                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/discount.png" />
                                <p class="card-text Label4">View All promocodes that admins isuued to you</p>

                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="ImageButton4" runat="server" OnClick="promocodes_Click" Text="View promocodes" />
                            </div>
                        </div>
                    </div>
                    <div class="col">
                        <div class="card">
                            <div class="card-header">
                                <h2 class="Label3">Certificates</h2>
                            </div>
                            <div class="card-body" >
                                <img src="https://img.icons8.com/clouds/100/000000/certificate.png" />
                                <p class="card-text Label4">View all the certificates for all the courses you have completed</p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="ImageButton9" runat="server" OnClick="ListCertificates_Click" Text="View certificates" />

                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <div class="col w-25">
                <div class="card h-100">
                    <div class="card-header">
                        <h2 class="Label3">Student profile</h2>
                    </div>
                    <div class="card-body">
                        <img src="profile.png" />
                    </div>
                    <div class="card-footer">
                        <asp:Button ID="profile" runat="server" OnClick="profile_Click" Text="View my profile" CssClass="Curved1" />

                    </div>
                </div>

            </div>
        </div>
      


    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
