<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstructorHome.aspx.cs" Inherits="GUCera.InstructorHome" %>

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
                <asp:LinkButton ID="h" CssClass="nav-link active Label4" aria-current="page" runat="server" Text="Home" OnClick="h_Click" />
            </li>

            <li class="nav-item">
                <asp:LinkButton ID="a" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Assignments" OnClick="as_Click" />
            </li>
            <li class="nav-item">
                <asp:LinkButton ID="f" CssClass="nav-link Label4" aria-current="page" runat="server" Text="Feedbacks" OnClick="fd_Click" />
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
        <div class="row" style="margin: 25px 25px 25px 25px">
            <div class="col-md-8" ">
                <div class="row row-cols-2" style="margin: 25px 25px 25px 25px">
                    <div class="col">
                        <div class="card h-100">
                            <div class="card-header">
                                <h2 class="Label3">Add new Course</h2>
                            </div>
                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/book-shelf.png" />
                                <p class="card-text Label4">Add new course for students to enroll in .</p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="courses" runat="server" Text="Add course" OnClick="courses_Click" />
                            </div>
                        </div>
                    </div>
                    <div class="col">

                        <div class="card h-100">
                            <div class="card-header">
                                <h2 class="Label3">Add new assignment</h2>
                            </div>
                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/task.png" />
                                <p class="card-text Label4">Add new assignment for a specific course .</p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="promocodes" runat="server" Text="Add assignment" OnClick="addAssignment_Click" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="row row-cols-2" style="margin: 25px 25px 25px 25px">
                    <div class="col">
                        <div class="card h-100">
                            <div class="card-header">
                                <h2 class="Label3">Issue course certificate</h2>
                            </div>
                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/graduation-cap.png" />
                                <p class="card-text Label4"> Issue course certificate to a specific student </p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="certificate" runat="server" Text="Issue Certificate" OnClick="certificate_Click" />
                            </div>
                        </div>


                    </div>
                    <div class="col">

                        <div class="card h-100">
                            <div class="card-header">
                                <h2 class="Label3">Grade assignments</h2>
                            </div>
                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/report-card.png" />
                                <p class="card-text Label4">add assignments grades for students</p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="creditcards" runat="server" Text="Grade assignments" OnClick="gradeAssignments_Click" />
                            </div>
                        </div>

                    </div>
                </div>
                <div class="row" style="margin: 25px 25px 25px 25px">
                    <div class="col">
                        <div class="card ">
                            <div class="card-header">
                                <h2 class="Label3">Phone numbers</h2>
                            </div>

                            <div class="card-body">
                                <img src="https://img.icons8.com/clouds/100/000000/iphone.png" />
                                <p class="card-text Label4">Add new telephone numbers </p>
                            </div>
                            <div class="card-footer">
                                <asp:Button CssClass="Curved1" ID="Button1" runat="server" OnClick="telephone_Click" Text="Add telephone number" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-6 col-md-4">
                <div class="row h-50 w-75" style="margin: 25px 25px 25px 25px">
                    <div class="card ">
                        <div class="card-header">
                            <h2 class="Label3">View submitted assignmets</h2>
                        </div>
                        <div class="card-body">
                            <img src="https://img.icons8.com/clouds/100/000000/add-file.png" />
                            <p class="card-text Label4">View all assignments that the students submit.</p>
                        </div>
                        <div class="card-footer">
                            <asp:Button CssClass="Curved1" ID="submittedAssignments" runat="server" Text="View assignments" OnClick="submittedAssignments_Click" />
                        </div>

                    </div>
                </div>
                <div class="row h-50 w-75" style="margin: 25px 25px 25px 25px">
                    <div class="card ">
                        <div class="card-header">
                            <h2 class="Label3">View feedbscks</h2>
                        </div>
                        <div class="card-body">
                            <img src="https://img.icons8.com/clouds/100/000000/task.png" />
                            <p class="card-text Label4"> Choose a course to view its feedbacks</p>
                        </div>
                        <div class="card-footer">
                            <asp:Button CssClass="Curved1" ID="feedbacks" runat="server" Text="View Feedbacks" OnClick="feedbacks_Click" />
                        </div>
                    </div>

                </div>
            </div>

        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
