<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Database.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>log in</title>
    <link rel="stylesheet" href="login.css" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="loginform">
        
        <p class="label" style="margin-top: 20px">login</p>
        <asp:TextBox ID="tb_login" runat="server" CssClass="textbox"></asp:TextBox>


        <p class="label">password</p>
        <asp:TextBox ID="tb_pwd" runat="server" CssClass="textbox"></asp:TextBox>


        <asp:Label ID="lbl_status" runat="server" Text=""
            CssClass="label" Width="320px" style="padding-top: 20px;">
        </asp:Label>
        

        <asp:Button ID="btn_login" runat="server" CssClass="button" Text="Log In" />
    </div>
    </form>

</body>
</html>
