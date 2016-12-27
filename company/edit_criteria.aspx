<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit_criteria.aspx.cs" Inherits="PPC.company.edit_criteria" %>

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
                        <legend>Company's Edit Criteria Form <i class="fa fa-pencil pull-right"></i></legend>
                        
                        <div class="form-group">
                            <asp:Label ID="Label9" runat="server" Text="Visiting Date" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox7" runat="server" placeholder="MM/DD/YYYY [FORMAT]" CssClass="form-control" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                        
                        
                        <div class="form-group">
                            <asp:Label ID="Label6" runat="server" Text="Designation" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox4" runat="server" placeholder="Designation" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox4" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                                    ControlToValidate="TextBox4" ErrorMessage="* Enter only letters." 
                                    ValidationExpression="[a-zA-Z ]+" BackColor="White" ForeColor="Red"></asp:RegularExpressionValidator>
                            
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label1" runat="server" Text="10th % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox1" runat="server" placeholder="10th % / CGPA" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox1" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" 
                                    ErrorMessage="* Enter integer part oly." ControlToValidate="TextBox1" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                           
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="12th / Diploma % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox2" runat="server" placeholder="12th / Diploma % / CGPA" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox2" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                    ErrorMessage="* Enter integer part oly." ControlToValidate="TextBox2" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                            
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="Label3" runat="server" Text="U.G % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox3" runat="server" placeholder="Under Graduation" CssClass="form-control"></asp:TextBox>
                           <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox3" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                                    ErrorMessage="* Enter integer part oly." ControlToValidate="TextBox3" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                            
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label7" runat="server" Text="B.E Domains" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <div class="radio">
                                    <label>
                                        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                            <asp:ListItem Text="Civil Engineering" Value="BE_civil"></asp:ListItem>
                                            <asp:ListItem Text="Mechanical Engineering" Value="BE_Mechanical"></asp:ListItem>
                                            <asp:ListItem Text="Computer Science" Value="BE_Computers"></asp:ListItem>
                                            <asp:ListItem Text="Electronics" Value="BE_Electronics"></asp:ListItem>
                                        </asp:CheckBoxList>

                                    </label>
                                </div>
                            </div>
                        </div>


                        <div class="form-group">
                            <asp:Label ID="Label4" runat="server" Text="P.G % / CGPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox5" runat="server" placeholder="Post Graduation" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="* Please fill the Text Box." 
                                    ControlToValidate="TextBox5" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                             <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" 
                                    ErrorMessage="* Enter integer part oly." ControlToValidate="TextBox5" ValidationExpression="^[1-9]?[0-9]{1}$|^100$"></asp:RegularExpressionValidator>
                            
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="Label5" runat="server" Text="PG Domains" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <div class="radio">
                                    <label>
                                        <asp:CheckBoxList ID="CheckBoxList2" runat="server">
                                            <asp:ListItem Text="MCA" Value="PG_MCA"></asp:ListItem>
                                            <asp:ListItem Text="MBA" Value="PG_MBA"></asp:ListItem>
                                            <asp:ListItem Text="MTECH Civil Engineering" Value="MTECH_Civil"></asp:ListItem>
                                            <asp:ListItem Text="MTECH Mechanical Engineering" Value="MTECH_Mechanical"></asp:ListItem>
                                            <asp:ListItem Text="MTECH Computers" Value="MTECH_Computers"></asp:ListItem>
                                            <asp:ListItem Text="MTECH Electronics" Value="MTECH_Electronics"></asp:ListItem>
                                        </asp:CheckBoxList>

                                    </label>
                                </div>
                            </div>
                        </div>

                         <div class="form-group">
                            <asp:Label ID="Label8" runat="server" Text="CTC LPA" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="TextBox6" runat="server" placeholder="CTC LPA" CssClass="form-control"></asp:TextBox>
                                 <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="* Please fill the Text Box." 
                                     ControlToValidate="TextBox6" BackColor="White" ForeColor="Red"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" 
                                    ErrorMessage="* Range 3 - 20 only." ControlToValidate="TextBox6" ValidationExpression="\b([3-9]|1[0-9])\b"></asp:RegularExpressionValidator>
                           
                                </div>
                        </div>

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Update" onclick="btnSubmit_Click12" />
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
           // "/img/44.jpg",
           // "/img/colorful.jpg",
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
