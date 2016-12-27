<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="PPC.About" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MCA V SEM PROJECT</title>
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

    <div> <img src="/img/slider/www.GIFCreator.me_Jn5Gnk.gif" width="100%" height="400px" alt="Image" /></div>
   <div style="font-size:16px; font-family:consolas; margin-left:100px; margin-right:100px"><p >RNS Institute of Technology is a college of engineering and technology and is located in Bangalore, India. The college is affiliated to Visvesvaraya Technological University. Rama Nagappa Shetty Institute of Technology (RNSIT) established in the year 2001, is the brain-child of the Group Chairman, Dr. R.N. Shetty.The Murudeshwar Group of Companies headed by Sri. R. N. Shetty is a leading player in many industries viz construction, manufacturing, hotel, automobile, power & IT services and education. The group has contributed significantly to the field of education. A number of educational institutions are run by the R. N. Shetty Trust, with RNSIT one amongst them. RNSIT is among the engineering colleges in Karnataka
 <%--<p>Combine years of experience in education with a unique curriculum world-class infrastructure, with a committed responsive faculty, unwavering commitment to the quality of education, today PES has more than 18,000 students, spread across four different campuses, Three state of art campuses in Bangalore and a Medical College with 750 bed hospital in Kuppam, Andra Pradesh.</p>
--%>
<p><i style="color:Black"><b>The RNSIT Mission</b></i></p>
<p>To impart high quality education in engineering technology and management with a diffrance,enbabling students to excel in their career
<p><i style="color:Black"><b>The RNSIT Quality Policy</b></i></p>
<p>Our quality policy is to develop highly skilled human resources with the ability to adapt to an intellectually and technologically changing environment with the participative efforts of the management, staff, students and parents.</p></div>


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
            duration: 2000,
            fade: 1500
        }
    );
    </script>
    </form>
</body>
</html>

