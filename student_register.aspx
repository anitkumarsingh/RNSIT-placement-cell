<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_register.aspx.cs" Inherits="PPC.student_register" %>

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
    <link href="/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <link href="/css/font-awesome.css" rel="stylesheet" type="text/css" />

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
                        <legend>Student's Registration Form <i class="fa fa-pencil pull-right"></i></legend>
                        
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" Text="USN" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox7" runat="server" placeholder="Student USN" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox7" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                    ControlToValidate="TextBox7" ErrorMessage="* Enter only VTU USN Format." 
                                    ValidationExpression="^[1-4][A-Z]{2}[0-9]{2}[A-Z]{2}[0-9A-Z][0-9]{2}$" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                               
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Name" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="Student Name" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox4" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="TextBox4" ErrorMessage="* Enter only letters." 
                                    ValidationExpression="[a-zA-Z ]+" BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                              
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label10" runat="server" Text="Password" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox8" runat="server" placeholder="Password" CssClass="form-control"
                                    TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox8" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                    ErrorMessage="* Minimum 8 characters at least 1 Alphabet, 1 Number and 1 Special Character." ControlToValidate="TextBox8" 
                                    ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&amp;])[A-Za-z\d$@$!%*#?&amp;]{8,}$" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="10th % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="10th % / CGPA" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox1" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                    ErrorMessage="* Enter valid and only first two digits of your percentage." ControlToValidate="TextBox1" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                           </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="12th / Diploma % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="12th / Diploma % / CGPA" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox2" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" 
                                    ErrorMessage="* Enter valid and only first two digits of your percentage." ControlToValidate="TextBox2" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="U.G % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Under Graduation" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox3" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" 
                                    ErrorMessage="* Enter valid and only first two digits of your percentage." ControlToValidate="TextBox3" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="P.G % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Post Graduation" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox5" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" 
                                    ErrorMessage="* Enter valid and only first two digits of your percentage." ControlToValidate="TextBox5" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                           </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Email" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox6" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox6" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Enter valid E-Mail format." ControlToValidate="TextBox6" 
                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="Mobile" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox9" runat="server" placeholder="Mobile Number" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox9" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                    ErrorMessage="* Enter valid mobile number." ControlToValidate="TextBox9" 
                                    ValidationExpression="^[7-9]\d{9}$" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                              
                            </div>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Stream" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="DropDownList2" runat="server" BackColor="#0099FF" ForeColor="White">
                            <asp:ListItem Text="Click Here" Value=""></asp:ListItem>
                            <asp:ListItem Text="BE_Civil" Value="BE_Civil"></asp:ListItem>
                            <asp:ListItem Text="BE_Mechanical" Value="BE_Mechanical"></asp:ListItem>
                            <asp:ListItem Text="BE_Computers" Value="BE_Computers"></asp:ListItem>
                            <asp:ListItem Text="BE_Electronics" Value="BE_Electronics"></asp:ListItem>
                            <asp:ListItem Text="PG_MBA" Value="PG_MBA"></asp:ListItem>
                            <asp:ListItem Text="PG_MCA" Value="PG_MCA"></asp:ListItem>
                            <asp:ListItem Text="MTECH_Civil" Value="MTECH_Civil"></asp:ListItem>
                            <asp:ListItem Text="MTECH_Mechanical" Value="MTECH_Mechanical"></asp:ListItem>
                            <asp:ListItem Text="MTECH_Computers" Value="MTECH_Computers"></asp:ListItem>
                            <asp:ListItem Text="MTECH_Electronics" Value="MTECH_Electronics"></asp:ListItem>
                        </asp:DropDownList>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="* Please select the option." 
                                    ControlToValidate="DropDownList2" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                              </div>
                        </div>
                        

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" 
                                    Text="Submit" onclick="btnSubmit_Click1"/>
                                  <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-warning" 
                                    Text="Clear" onclick="btnCancel_Click" CausesValidation="False" />                              
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
            "/img/44.jpg",
           // "/img/colorful.jpg",
           // "/img/34.jpg",
           // "/img/images.jpg"
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


