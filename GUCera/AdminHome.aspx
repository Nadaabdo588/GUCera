<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GUCera.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">
    <link rel="stylesheet" href="Styles\Style.css" />
    <title></title>

</head>


<body style="text-align:center">
    <form id="form1" runat="server">
        <div class="row">
            <div class="col" style="text-align: left; background-color: white">
                <img src="nav.png" width="555" height="416" />
            </div>
            <div class="col" style="text-align: center; background-color: white; position: center">
                <p style="font-size: 75px; font-weight: 700; font-family: 'Arvo', serif; color: #3C4380">Welcome to GUCera! </p>
                <p style="color: #3C4380">GUCera is a perfect website for best educational services for all students. You all have the chance to experience new courses and learning techniques. </p>
            </div>
        </div>
        <div class="row" style="margin: 25px 25px 25px 25px">

            <div class="col">

                <div class="card">
                    <h5 class="card-header Label3">All courses</h5>
                    <!--    -->
                    <div class="card-body">
                        <img src="https://www.kindpng.com/picc/m/66-666349_logohomebanner-online-course-isometric-illustrations-free-hd-png.png" alt="" width="200" height="200">
                        <p class="card-text"></p>
                    </div>
                    <div class="card-footer">
                        <asp:Button class="Curved1" ID="viewC" runat="server" Text="View Courses" Width="" OnClick="viewC_Click" />

                    </div>

                </div>
            </div>
            <div class="col">

                <div class="card">
                    <h5 class="card-header Label3">Not Accepted Courses</h5>
                    <div class="card-body">
                        <img src="https://cdni.iconscout.com/illustration/premium/thumb/online-library-2601429-2182483.png" alt="" width="200" height="200">

                        <p class="card-text"></p>
                    </div>
                    <div class="card-footer">
                        <asp:Button class="Curved1" ID="notacceptedC" runat="server" Text="View not Accepted Courses" OnClick="notacceptedC_Click" />

                    </div>
                </div>
            </div>

            <div class="col">

                <div class="card">
                    <h5 class="card-header Label3">Manage </h5>

                    <div class="card-body">
                        <img src="https://cdn2.iconfinder.com/data/icons/testing-software-2-filled-outline/128/Testing_Software_2_-_Ps_Style_-_1-11-512.png" alt="" width="200" height="200">

                        <p class="card-text"></p>
                    </div>

                    <div class="card-footer">
                        <asp:Button class="Curved1" ID="MngOpt" runat="server" Text="Manage Options" OnClick="MngOpt_Click" />

                    </div>
                </div>
            </div>
        </div>








    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
</body>
</html>
