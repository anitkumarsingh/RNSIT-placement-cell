<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_link.aspx.cs" Inherits="PPC.login_link" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MCA V SEMESTER PROJECT</title>
    <!-- ============ Google fonts ============ -->
    <link href='http://fonts.googleapis.com/css?family=EB+Garamond' rel='stylesheet'
        type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,300,800'
        rel='stylesheet' type='text/css' />
    <!-- ============ Add custom CSS here ============ -->
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.css" rel="stylesheet" type="text/css" />
</head>
<body>
     <form id="form1" runat="server">
    <div id="custom-bootstrap-menu" class="navbar navbar-default">
        <div class="container">
            <div class="navbar-header">
                <a class="navbar-brand" href="/ppc_home.aspx"><legend>RNSIT PLACEMENT CELL</legend></a>
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span
                        class="icon-bar"></span><span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse navbar-menubuilder">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="/ppc_home.aspx">HOME</a> </li>
                    <li><a href="/register_link.aspx">REGISTER</a> </li>
                    <li><a href="/login_link.aspx">LOGIN</a> </li>
                    <li><a href="/admin_login.aspx">ADMIN</a> </li>
                    <li><a href="/about.aspx">ABOUT US</a> </li>
                    <li><a href="/contact.aspx">CONTACT US</a> </li>
                </ul>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 text-center">
            <div id="banner">
                <h1>
                   <strong>RN Shetty's Education Society</strong></h1>
                <h5>
                    <strong></strong></h5>
            </div>
        </div>
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Company Login Link <i class="fa fa-pencil pull-right"></i></legend>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                               <asp:Button ID="butnSubmit" runat="server" CssClass="btn btn-primary" Text="CLICK HERE" onclick="btnSubmit_Click15" Height="46px" Width="182px" />                             
                            </div>
                        </div>

                        <legend>Student Login Link <i class="fa fa-pencil pull-right"></i></legend>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                               <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="CLICK HERE" onclick="btnSubmit_Click16" Height="46px" Width="182px" />                             
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>
        </div>
    </div>

        <div id="Div1" class="navbar navbar-default" style="background:transparent; bottom:0px; position:absolute; width:100%; margin-top:10px; bottom:0px; position:relative">
        <div class="container">
            <div class="navbar-header">
                <legend style="text-align:center; font-size:30px; margin-left:140px">Copyright &copy; 2016. All Rights Reserved. RNSIT Placement Cell.</legend>
            </div>
        </div>
    </div>
    <script src="js/jquery.js" type="text/javascript"></script>
    <script src="js/bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery.backstretch.js" type="text/javascript"></script>
    <script type="text/javascript">
        'use strict';

        /* ========================== */
        /* ::::::: Backstrech ::::::: */
        /* ========================== */
        // You may also attach Backstretch to a block-level element
        $.backstretch(
        [
            "img/44.jpg",
            //"img/colorful.jpg",
            //"img/34.jpg",
            //"img/images.jpg"
        ],

        {
            duration: 4500,
            fade: 1500
        }
    );
    </script>
    </form>
</body>
</html>


