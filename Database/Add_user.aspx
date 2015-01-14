<%@ Page Title="Add User" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Add_user.aspx.cs" Inherits="Database.Add_user" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
		<link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
	<h1 class="header">ADD NEW USER</h1>


	<div style="width: 700px; margin: auto; margin-top: 40px; margin-bottom: 40px;">
        <asp:Label ID="lbl_username" runat="server" Text="Username"
            style="font-family: verdana; color: #555555; margin-left: 40px;">
        </asp:Label>

        <asp:TextBox ID="tb_username" runat="server" Width="350px" style="margin-left: 40px;"></asp:TextBox>
        <br>

		<asp:Label ID="lbl_pwd" runat="server" Text="Password"
            style="font-family: verdana; color: #555555; margin-left: 40px;">
        </asp:Label>

        <asp:TextBox ID="tb_pwd" runat="server" Width="350px" style="margin-left: 45px;" TextMode="Password"></asp:TextBox>
        <br>

		<asp:Label ID="lbl_role" runat="server" Text="Role"
            style="font-family: verdana; color: #555555; margin-left: 40px;">
        </asp:Label>

        <asp:TextBox ID="tb_role" runat="server" Width="350px" style="margin-left: 85px;"></asp:TextBox>
        <br>

        <asp:Button ID="btn_finish" runat="server" Text="Finish" CssClass="button" 
            style="float: right; margin-right: 40px; margin-top: 40px;" OnClick="btn_finish_Click"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button" 
            style="float: right; margin-right: 50px; margin-top: 40px;" OnClick="btn_cancel_Click"/>
    </div>
</asp:Content>
