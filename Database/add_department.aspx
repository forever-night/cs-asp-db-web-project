<%@ Page Title="Add department" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Add_department.aspx.cs" Inherits="Database.Add_department" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">CREATE NEW DEPARTMENT</h1>


    <div style="width: 700px; margin: auto; margin-top: 40px; margin-bottom: 40px;">
        <asp:Label ID="lbl_dept_name" runat="server" Text="Department Name"
            style="font-family: verdana; color: #555555; margin-left: 40px;">
        </asp:Label>

        <asp:TextBox ID="tb_dept_name" runat="server" Width="350px" style="margin-left: 40px;"></asp:TextBox>
        <br>

        <asp:Button ID="btn_finish" runat="server" Text="Finish" CssClass="button" 
            style="float: right; margin-right: 40px; margin-top: 40px;" OnClick="btn_finish_Click"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button" 
            style="float: right; margin-right: 50px; margin-top: 40px;" OnClick="btn_cancel_Click"/>

    </div>
</asp:Content>
