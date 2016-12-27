<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="change_password.aspx.cs" Inherits="PPC.admin.change_password" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>MCA V SEM PROJECT</title>
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
                <a class="navbar-brand" href="/admin/admin_home.aspx">ADMIN HOME</a>
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span
                        class="icon-bar"></span><span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse navbar-menubuilder">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="/admin/admin_home.aspx">HOME</a> </li>
                    <li><a href="/admin/admin_logout.aspx">LOGOUT</a> </li>
                </ul>
            </div>
        </div>
    </div>

   <div class="container">
       <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12 text-center">
            <div id="banner">
              <h1><strong>RN Shetty's Education Society</strong></h1>  
            </div>
        </div>
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Admin Change Password Form <i class="fa fa-pencil pull-right"></i></legend>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Username" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="Username" CssClass="form-control" ReadOnly="true" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                    ErrorMessage="* Please fill the Text Box." ControlToValidate="TextBox1"
                                    BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="TextBox1" ErrorMessage="* Enter only letters." 
                                    ValidationExpression="[a-zA-Z]+" BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                            
                             </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="New Password" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="New Password" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                    ErrorMessage="* Please fill the Text Box." ControlToValidate="TextBox2"
                                    BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                    ErrorMessage="* Minimum 8 characters at least 1 Alphabet, 1 Number and 1 Special Character." ControlToValidate="TextBox2" 
                                    ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&amp;])[A-Za-z\d$@$!%*#?&amp;]{8,}$" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                            
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Confirm Password" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Confirm New Password" CssClass="form-control"></asp:TextBox>
                               <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                                    ErrorMessage="* Please fill the Text Box." ControlToValidate="TextBox3"
                                    BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                            
                               <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ErrorMessage="* Minimum 8 characters at least 1 Alphabet, 1 Number and 1 Special Character." ControlToValidate="TextBox3" 
                                    ValidationExpression="^(?=.*[A-Za-z])(?=.*\d)(?=.*[$@$!%*#?&amp;])[A-Za-z\d$@$!%*#?&amp;]{8,}$" 
                                    BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                            
                                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                                    ErrorMessage="* Passwords Not Matching." BackColor="White" ControlToCompare="TextBox2" 
                                    ControlToValidate="TextBox3" ForeColor="Red"></asp:CompareValidator>  
                            </div>
                        </div>
                        
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary"  
                                    Text="Update" onclick="btnSubmit_Click"/>
                                  <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-warning" 
                                    Text="Cancel" onclick="btnCancel_Click" CausesValidation="False" />                              
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
        //"/img/44.jpg",
        //"/img/colorful.jpg",
        //"/img/34.jpg",
        "/img/images.jpg"
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
