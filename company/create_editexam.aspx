<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create_editexam.aspx.cs" Inherits="PPC.company.create_editexam" %>

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
    <link href="/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="/css/style.css" rel="stylesheet" type="text/css" />
    <link href="/css/font-awesome.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="custom-bootstrap-menu" class="navbar navbar-default">
        <div class="container">
            <div class="navbar-header">
                <legend><a href="/company/company_home.aspx" style="text-decoration:none; color:white"><asp:Literal ID="Literal2" runat="server"></asp:Literal></a></legend>
                <button type="button" class="navbar-toggle">
                    <span class="sr-only">Toggle navigation</span><span class="icon-bar"></span><span
                        class="icon-bar"></span><span class="icon-bar"></span>
                </button>
            </div>
            <div class="collapse navbar-collapse navbar-menubuilder">
                <ul class="nav navbar-nav navbar-right">
                    <li><a href="/company/company_home.aspx">HOME</a> </li>
                    <li><a href="/company/company_logout.aspx">LOGOUT</a> </li>
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
                        <legend>Create New Set Of Questions <i class="fa fa-pencil pull-right"></i></legend>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Number Of Questions" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="Number Of Questions" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox1" BackColor="White" ForeColor="Red" 
                                    ValidationGroup="Group1"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                    ErrorMessage="* Enter valid and maximum of two numbers." 
                                    ControlToValidate="TextBox1" ValidationExpression="^[1-9]?[0-9]{1}$|^99$" 
                                    ValidationGroup="Group1"></asp:RegularExpressionValidator>
                           
                            </div>
                           
                        </div>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                               <asp:Button ID="butnSubmit" runat="server" CssClass="btn btn-primary" 
                                    Text="CREATE QUESTIONS" onclick="btnSubmit_Click17" Height="46px" 
                                    Width="182px" ValidationGroup="Group1" />                             
                            </div>
                        </div>

                        <legend>Edit Previous Set Of Questions <i class="fa fa-pencil pull-right"></i></legend>
                         <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="Select Exam" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:DropDownList ID="DropDownList2" runat="server" BackColor="#0099FF" 
                                    ForeColor="White" Height="35px" Width="248px" >
                                    <asp:ListItem Text="Select Exam Code" Value="0"></asp:ListItem>
                                 </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Select any one option." 
                                    ControlToValidate="DropDownList2" BackColor="White" ForeColor="Red" 
                                    ValidationGroup="Group2"></asp:RequiredFieldValidator>
                             
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                               <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" 
                                    Text="APPEND QUESTIONS" onclick="btnSubmit_Click18" Height="46px" 
                                    Width="248px" ValidationGroup="Group2" /> 
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                 <asp:Button ID="Button2" runat="server" CssClass="btn btn-primary" 
                                    Text="EDIT PARTICULAR QUESTION" Height="46px" Width="248px" 
                                    onclick="Button2_Click" ValidationGroup="Group2" />
                             </div>
                        </div> 

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                 <asp:Button ID="Button3" runat="server" CssClass="btn btn-primary" 
                                    Text="UPDATE NUMBER OF QUESTIONS" Height="46px" Width="248px" 
                                     onclick="Button3_Click" ValidationGroup="Group2" 
                                    />
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
            "/img/34.jpg",
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
