<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="create_exam.aspx.cs" Inherits="PPC.company.create_exam" %>

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
                <legend><a href="/company/company_home.aspx" style="text-decoration:none; color:white"><asp:Literal ID="Literal3" runat="server"></asp:Literal></a></legend>
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
       <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform">
                <div class="form-horizontal">
                    <fieldset>
                        <legend> Type Questions Below. Qno.<asp:Literal ID="Literal1" runat="server"></asp:Literal>  <i class="fa fa-pencil pull-right"></i></legend>
                       
                      
                       <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="Question " CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox6" runat="server" TextMode="MultiLine" Rows="9" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox6" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                             
                            </div>
                             
                        </div>
                        <legend><asp:Literal ID="Literal2" runat="server"></asp:Literal></legend>
                    </fieldset>
                </div>
            </div>
        </div>

    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12">
            <div class="registrationform">
                <div class="form-horizontal">
                    <fieldset>
                        <legend> Enter Options Below <i class="fa fa-pencil pull-right"></i></legend>
                       
                       <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="Option 1:" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="Type Option 1" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox1" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="Option 2:" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="Type Option 2" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox2" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="Option 3:" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Type Option 3" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox3" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="Option 4:" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="Type Option 4" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox4" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                             
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Answer :" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Type Answer" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox5" BackColor="White" ForeColor="Red" ></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="* Enter Option number only"
                                    ControlToValidate="TextBox5" BackColor="White" ForeColor="Red" 
                                    ValidationExpression="^[1-4]" ></asp:RegularExpressionValidator>   
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" 
                                    Text="Next" Height="44px" Width="116px" onclick="btnSubmit_Click" />
                                  <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-warning" 
                                    Text="Clear" Height="42px" Width="107px" onclick="btnCancel_Click" 
                                    CausesValidation="False" />                              
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
            //"/img/images.jpg"
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

