<%@ Page Title="Users" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="Database.Users" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
	<h1 class="header">USERS</h1>


	<asp:GridView ID="gv_users" CssClass="table" runat="server" AutoGenerateColumns="False" DataSourceID="ds_users">
		<Columns>
			<asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
			<asp:BoundField DataField="role" HeaderText="role" SortExpression="role" />
		</Columns>
	</asp:GridView>


	<asp:SqlDataSource ID="ds_users" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [username], [role] FROM [Users]">
	</asp:SqlDataSource>


	<asp:Button ID="btn_add_use" runat="server" Text="Add User" CssClass="button"
        style="width: 80px; height: 30px; float: right; margin-right: 50px;" OnClick="btn_add_use_Click"/>
</asp:Content>
