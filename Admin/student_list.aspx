<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_list.aspx.cs" Inherits="PPC.admin.student_list" %>

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
        
    <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12" style="width:100%">
            <div class="registrationform" style="width:100%">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>View Student List. <i class="fa fa-pencil pull-right"></i></legend>
                       
   <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="USN" DataSourceID="SqlDataSource1" Height="195px" Width="632px">
        <Columns>
            <asp:BoundField DataField="USN" HeaderText="USN" ReadOnly="True" 
                SortExpression="USN" />
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
            <asp:BoundField DataField="Tenth" HeaderText="Tenth" 
                SortExpression="Tenth" />
            <asp:BoundField DataField="Twelve" HeaderText="Twelve" 
                SortExpression="Twelve" />
            <asp:BoundField DataField="UG" HeaderText="UG" 
                SortExpression="UG" />
            <asp:BoundField DataField="PG" HeaderText="PG" SortExpression="PG" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="Mobile" HeaderText="Mobile" 
                SortExpression="Mobile" />
            <asp:BoundField DataField="Stream" HeaderText="Stream" 
                SortExpression="Stream" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:PPCConnectionString1 %>" 
        
                            
                            SelectCommand="SELECT USN, Name, Tenth, Twelve, UG, PG, Email, Mobile, Stream FROM tbl_Student WHERE (Stream LIKE '%' + @Stream + '%')">
        <SelectParameters>
            <asp:SessionParameter DefaultValue="MCA" Name="Stream" SessionField="Course" 
                Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

                       <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" 
                                    Text="BACK" onclick="btnSubmit_Click" />
                                                               
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
