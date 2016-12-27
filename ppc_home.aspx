<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ppc_home.aspx.cs" Inherits="PPC.ppc_home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>RNSIT Placement Cell</title>
    <link rel="shortcut icon" type="ico" href="images/RNSIT.png">
    <!-- ============ Google fonts ============ -->
    <link href='http://fonts.googleapis.com/css?family=EB+Garamond' rel='stylesheet'
        type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,300,800'
        rel='stylesheet' type='text/css' />
    <!-- ============ Add custom CSS here ============ -->
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/font-awesome.css" rel="stylesheet" type="text/css" />

    <link href="/css/animate.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/prettyPhoto.css" rel="stylesheet" type="text/css" />
    <link href="/css/main.css" rel="stylesheet" type="text/css" />
    <link href="/css/responsive.css" rel="stylesheet" type="text/css" />
     <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css"
        rel="stylesheet" type="text/css" />

    <link rel="stylesheet" href="/css/slit-slider.css" />
    <link href="Styles/Update.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <header id="header">
      <nav class="navbar navbar-inverse" role="banner">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <h3 style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-style: italic; text-transform: capitalize; color: #FFFFFF">RNSIT Placement Cell</h3>
                                  
                    <%--<a class="navbar-brand" href="/ppc_home.aspx"> 
                    <img src="images/res_image.jpg" width="300" height="2" alt="" /></a>--%>
                </div>
				
                <div class="collapse navbar-collapse navbar-right">
                    <ul class="nav navbar-nav">
                        <li class="active"><a href="/ppc_home.aspx">HOME</a></li>
                       <li><a href="/register_link.aspx">REGISTER</a></li>
                        <li><a href="/login_link.aspx">LOGIN</a></li>                        
                        <li><a href="/admin_login.aspx">ADMIN</a></li> 
                        <li><a href="/About.aspx">ABOUT US</a></li>
                        <li><a href="/contact.aspx">CONTACT US</a></li>                        
                    </ul>
                </div>
            </div><!--/.container-->
        </nav><!--/nav-->
        
                <p>&nbsp;</p><p>&nbsp;</p>
      <div id="sidebar">
       <div id="updates" class="boxed">
               
			<h2 class="title" style="font-size:medium"> Upcoming Companies</h2>
		<marquee direction="up">
            <DIV class="content"><UL><LI><H3>Dec 25,2016,Google</H3><P><A href="#">Google ....</A>
               </P></LI><LI><H3>January 3, 2017</H3><P><A href="#">Microsoft ....</A>
                </P></LI><LI><H3> Feb 28, BookMyShow</H3><P><A href="#">This is a test message ....</A>
                </P></LI><LI><H3>March 25, 2017</H3><P><A href="#">This is a test message.....</A>
                </P></LI><LI><H3>March 25, 2017</H3><P><A href="#">This is a test message.....</A>
                </P></LI></UL></DIV>
        </marquee>
	</div>
	</div>
 
    </header>
    <script src="/js/jquery.js" type="text/javascript"></script>
    <script src="/js/bootstrap.min.js" type="text/javascript"></script>
    <script src="/js/jquery.backstretch.js" type="text/javascript"></script>
    <script type="text/javascript">
        'use strict';

        /* ========================== */
        /* ::::::: Backstrech ::::::: */
        /* ========================== */
        // You may also attach Backstretch to a block-level element
        $.backstretch(
        [
           "/images/placement.jpg"
           //"img/44.jpg",
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
           <footer id="footer" class="midnight-blue" style="margin-top:550px">
        <div class="container" >
            <div class="row">
            <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
              <div class="top-number"><i class="fa fa-thumbs-up"></i> Keep In Touch.<span style="margin-left:50px">&copy; 2016 RNSIT PLACEMENT CELL. All Rights Reserved.</span></div>
            </div>
     <div class="col-xs-6 col-sm-6 col-md-6 col-lg-6">
      <div class="social">
     <ul class="social-share">
        <li><a href="https://web.facebook.com/pes.univ/" target="_blank"><i class="fa fa-facebook"></i></a></li>
        <li><a href="https://twitter.com/pesuniversity" target="_blank"><i class="fa fa-twitter"></i></a></li>
        <li><a href="https://plus.google.com/105291272346514933671/posts" target="_blank"><i class="fa fa-google-plus"></i></a></li>        
        <li><a href="https://www.pinterest.com/pesuniversity/" target="_blank"><i class="fa fa-pinterest"></i></a></li>
        <li><a href="https://www.youtube.com/user/PESUniversity" target="_blank"><i class="fa fa-youtube"></i></a></li>
     </ul>     
     </div>
   </div>

            </div>
        </div>
     </footer>
</body>
</html>
