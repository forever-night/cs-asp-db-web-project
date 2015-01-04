<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="Database.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>main</title>
    <link rel="stylesheet" type="text/css" href="main.css"/>
    <link rel="stylesheet" type="text/css" href="login.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
        <asp:Label ID="lbl_user" runat="server" Text="You've logged in as "
            CssClass="label" Width="780" style="text-align: right;"></asp:Label>

        <asp:Button ID="btn_logout" runat="server" Text="Log Out" CssClass="button"
            style="width: 60px; height: 25px; font-size: 12px; float: right; margin: 10px 5px;"/>


        <div style="width: 350px; margin: auto; margin-top: 50px;">
            <asp:Button ID="btn_depts" runat="server" Text="Departments" CssClass="button big"
                Font-Size="20px"/>
            <br>
            <asp:Button ID="btn_emps" runat="server" Text="Employees" CssClass="button big"
                Font-Size="20px"/>
        </div>

    </div>
    </form>

</body>
</html>
