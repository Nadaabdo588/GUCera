<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ManageOptions.aspx.cs" Inherits="GUCera.ManageOptions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-giJF6kkoqNQ00vy+HMDP7azOuL0xtbfIcaT9wjKHr8RbDVddVHyTfAAsrekwKmP1" crossorigin="anonymous">
    <link rel="stylesheet" href="Styles\Style.css" />
    <title></title>
</head>

<body>
    <form id="form1" runat="server" style="position: center; text-align: center;">

        <ul class="nav nav-tabs" id="myTab" role="tablist" style="background-color: white">
            <li class="nav-item " role="presentation">
                <a class="nav-link Label3 ">GUCera</a>
            </li>
             <li class="nav-item " role="presentation">
                <asp:LinkButton Cssclass="nav-link Label3" role="tab" ID="h" aria-current="page" runat="server" text="home" aria-selected="true" OnClick="h_click" />
            </li>
            <li class="nav-item " role="presentation">
                <a class="nav-link active Label3" id="home-tab" data-bs-toggle="tab" href="#home" role="tab" aria-controls="home" aria-selected="true">Profile</a>
            </li>
            <li class="nav-item " role="presentation">
                <a class="nav-link Label3 " id="profile-tab" data-bs-toggle="tab" href="#profile" role="tab" aria-controls="profile" aria-selected="false">Accept Course</a>
            </li>
            <li class="nav-item-" role="presentation">
                <a class="nav-link Label3" id="contact-tab" data-bs-toggle="tab" href="#contact" role="tab" aria-controls="contact" aria-selected="false">Promo Codes</a>
            </li>
        </ul>
        <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/css/bootstrap.min.css" />
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
        <script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
        <div class="panel panel-default" style="width: 500px; padding: 10px; margin: 10px">
            <div class="tab-content" id="myTabContent">
                <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
                    <div class="position-absolute top-50 start-50 translate-middle">
                        <div class="card border-primary mb-3" style="max-width: 540px;">
                            <div class="row g-0">
                                <div class="col-md-4">
                                    <img src="administrator-300px.png" />
                                </div>
                                <div class="col-md-8">
                                    <div class="card-body text-primary">
                                        <div>
                                            <asp:Label CssClass="Label3" ID="adID" runat="server"></asp:Label>
                                        </div>
                                        <div>
                                            <asp:TextBox CssClass="omarinput" ID="mob" runat="server" placeholder="telephone Number" Width="200"></asp:TextBox>
                                        </div>
                                        <script type="text/javascript" src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.2/js/bootstrap.min.js"></script>
                                        <div>
                                            <asp:Button CssClass="Curved1" ID="LinkButton4" runat="server" OnClick="addNo" Text="Add" />
                                        </div>

                                        <div>
                                            <asp:Label CssClass="omarmessage" ID="sucadd" runat="server"><small class="text-muted">Last updated 3 mins ago</small></asp:Label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
                    <div class="position-absolute top-50 start-50 translate-middle">
                        <div class="card border-primary mb-3" style="width: 18rem;">
                            <div class="card-body text-primary">
                                <h5 class="card-title Label3">Accept Course</h5>
                                <asp:TextBox  CssClass="omarinput" ID="courseId" runat="server" placeholder="Course ID" Width="193px"></asp:TextBox>
                                <div>
                                    <asp:Label CssClass="omarmessage" ID="sucacc" runat="server"></asp:Label>
                                </div>

                            </div>
                            <div class="card-footer text-muted">
                                <asp:Button CssClass="Curved1" ID="LinkButton1" runat="server" OnClick="acceptC" Text="Accept" />
                            </div>
                        </div>

                    </div>
                </div>
                <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
                    <div class="position-absolute top-50 start-50 translate-middle">
                        <div class="d-flex justify-content-evenly" >
                            <div class="card border-primary mb-3" style="margin: 25px 25px 25px 25px" >
                                <div class="card-body text-primary">
                                    <h5 class="card-title Label3">Issue Promo Code to a Student</h5>
                                    <asp:TextBox CssClass="omarinput" ID="sid" runat="server" placeholder="Student ID" Width="193px"></asp:TextBox>
                                    <asp:TextBox CssClass="omarinput" ID="pid" runat="server" placeholder="Promo code" Width="193px"></asp:TextBox>
                                    <div>
                                        <asp:Label CssClass="omarmessage" ID="suciss" runat="server"><small class="text-muted">Last updated 3 mins ago</small></asp:Label>
                                    </div>

                                </div>
                                <div class="card-footer text-muted">
                                    <asp:Button CssClass="Curved1" ID="LinkButton3" runat="server" OnClick="issue" Text="Issue" />
                                </div>
                            </div>

                            <div class="card border-primary mb-3"style="margin: 25px 25px 25px 25px">
                                <div class="card-body text-primary">
                                    <h5 class="card-title Label3">Create Promo Code</h5>
                                    <asp:TextBox CssClass="omarinput" ID="pcode" placeholder="Code" runat="server" Width="193px"></asp:TextBox>
                                    <asp:TextBox CssClass="omarinput" ID="expirydate" placeholder="Expiry Date" runat="server" Width="193px"></asp:TextBox>
                                    <asp:TextBox CssClass="omarinput" ID="discount" placeholder="Discount" runat="server" Width="193px"></asp:TextBox>
                                    <div>
                                        <asp:Label CssClass="omarmessage" ID="succre" runat="server"><small class="text-muted">Last updated 3 mins ago</small></asp:Label>
                                    </div>
                                </div>
                                <div class="card-footer text-muted">
                                    <asp:Button CssClass="Curved1" ID="LinkButton2" runat="server" OnClick="createP" Text="Create" />
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
            <asp:HiddenField ID="TabName" runat="server" />
        </div>
        <script type="text/javascript">
            $(function () {
                var tabName = $("[id*=TabName]").val() != "" ? $("[id*=TabName]").val() : "personal";
                $('#Tabs a[href="#' + tabName + '"]').tab('show');
                $("#Tabs a").click(function () {
                    $("[id*=TabName]").val($(this).attr("href").replace("#", ""));
                });
            });
        </script>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>
</body>
</html>
