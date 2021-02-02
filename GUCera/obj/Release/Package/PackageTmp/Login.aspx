<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

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
    <div class="login-page">

        <div class="form">
            <form id="form2" runat="server" class="register-formI">
                <h2 class="Label3">Instructor Registration</h2>
                <br />

                <input type="text" name="firstnameText" placeholder="First name" required />
                <input type="text" name="lastnameText" placeholder="Last name" required />
                <input type="password" name="passwordText" placeholder="Password" required />

                <input type="text" name="emailText" placeholder="Email" required />
                <input type="text" name="addressText" placeholder=" Address" />

                <div class="control">
                    <label class="Label3">
                        <input type="radio" name="GenderList" />
                        Male
                    </label>
                    <label class="Label3">
                        <input type="radio" name="GenderList" checked />
                        Female
                    </label>
                </div>
                <asp:Button ID="RegisterButton" runat="server" Text="Register" CssClass="button" OnClick="RegisterButtonI_Click" />

                <asp:Label ID="Label2" CssClass="message" runat="server" Visible="false"></asp:Label>

                <p class="message">Already registered?<asp:LinkButton Text="Sign in" CssClass="a" runat="server" OnClick="sigin_Click" /></p>
            </form>
            <form id="form3" runat="server" class="register-formS">
                <h2 class="Label3">Student Registration</h2>
                <br />

                <input type="text" name="firstnameText" placeholder="First name" required />
                <input type="text" name="lastnameText" placeholder="Last name" required />
                <input type="password" name="passwordText" placeholder="Password" required />

                <input type="text" name="emailText" placeholder="Email" required />
                <input type="text" name="addressText" placeholder=" Address" required />

                <div class="control">
                    <label class="radio">
                        <input type="radio" name="GenderList" />
                        Male
                    </label>
                    <label class="radio">
                        <input type="radio" name="GenderList" checked />
                        Female
                    </label>
                </div>
                <asp:Button ID="RegisterStudent" runat="server" Text="Register" CssClass="button" OnClick="RegisterButtonS_Click" />
                <asp:Label ID="Label1" CssClass="message" runat="server" Visible="false"></asp:Label>

                <p class="message">
                    Already registered?
                    <asp:LinkButton Text="Sign in" CssClass="a" runat="server" OnClick="sigin_Click" />
                </p>
            </form>
            <form id="form1" class="login-form" runat="server">
                <p class="Label3">Welcome to GUCera ! </p>
                <input type="text" name="usernameText" placeholder="User ID" />
                <input type="password" name="passwordText" placeholder="Password" />
                <asp:Button CssClass="button" OnClick="logIn_Click" runat="server" Text="Login" />
                <asp:Label ID="error" CssClass="message" runat="server" Visible="false"></asp:Label>

                <p class="message">
                    Not registered? Register as
                    <asp:LinkButton Text="Student" CssClass="a" runat="server" OnClick="MyFunction2_Click" />
                    or 
                    <asp:LinkButton Text="Instructor" CssClass="a" runat="server" OnClick="MyFunction_Click" />

                </p>
            </form>
        </div>
    </div>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-ygbV9kiqUc6oa4msXn9868pTtWMgiQaeYH7/t7LECLbyPA2x65Kgf80OJFdroafW" crossorigin="anonymous"></script>

</body>
</html>
