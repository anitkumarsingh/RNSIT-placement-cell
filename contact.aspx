<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="PPC.contact" %>

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

    <div> <img src="/img/slider/output_GYFka8.gif" width="100%" height="300px" alt="Image" /></div>




   <div style="font-size:20px; font-family:consolas; margin-left:100px; margin-right:100px">
   Your input is important to us. Please include your contact details along with a brief message in the form below and we will respond to your inquiry as soon as possible. We look forward to hearing from you!
   </div>
   <div class="container" >
       <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform" >
                <div class="form-horizontal">
                    <fieldset>
                        <legend> Get In Touch <i class="fa fa-pencil pull-right"></i></legend>

                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Website :" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="http://rnsit.edu.in/" ReadOnly="true"
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                                
                           </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Admission:" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="admissions@rnsit.edu.in" ReadOnly="true" 
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                                
                           </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Phone Number :" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="+91 80 26721983,+91 80 26722108" ReadOnly="true" 
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                                
                           </div>
                        </div>

                        
                       <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Address :" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox6" runat="server" ReadOnly="true" TextMode="MultiLine" Rows="3" placeholder="Dr.Vishnuvardhan Road, Rajarajeshwarinagar, Channasandra, Bengaluru, Karnataka 560098" CssClass="form-control" Width="346px"></asp:TextBox>
                            </div>
                            </div>
                        </div>
                    </fieldset>
                </div>
            </div>


            <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform" >
                <div class="form-horizontal">
                    <fieldset>
                        <legend> Enter Details Below <i class="fa fa-pencil pull-right"></i></legend>

                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Name" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter Your Name" 
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox4" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="TextBox4" ErrorMessage="* Enter only letters." 
                                    ValidationExpression="[a-zA-Z ]+" BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                            
                           </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="E-Mail" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Enter E-Mail" 
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox5" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                                
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Enter valid E-Mail format." ControlToValidate="TextBox5" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                           
                           </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Subject" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox7" runat="server" placeholder="Subject" 
                                    CssClass="form-control" Width="300px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox7" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                                
                               
                           </div>
                        </div>

                        
                       <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Type Message" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox8" runat="server" TextMode="MultiLine" Rows="4" placeholder="Enter Message"
                                    CssClass="form-control" Width="338px"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox8" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                                
                           
                            </div>
                            </div>
                        </div>

                    <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                            <asp:Button ID="Button2" runat="server" CssClass="btn btn-warning" 
                                    Text="Submit" Height="42px" Width="107px" onclick="Button1_Click"/>                             
                            </div>
                        </div>
                    </fieldset>
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
            duration: 2000,
            fade: 1500
        }
    );
    </script>
    </form>
</body>
</html>
