<%@ Page Title="Add phone" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Add_phone.aspx.cs" Inherits="Database.Add_phone" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
    <link rel="stylesheet" type="text/css" href="add.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">ADD TELEPHONE</h1>


    <div style="width: 700px; margin: auto; margin-top: 40px; margin-bottom: 40px; padding: 0px 100px;">
        <asp:Label ID="lbl_phone" runat="server" Text="Phone" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_phone" runat="server" Width="150px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_status" runat="server" CssClass="label" Width="650px"></asp:Label>


        <asp:Button ID="btn_next" runat="server" Text="Next" CssClass="button button2" style="margin-right: 70px;" OnClick="btn_next_Click"/>
        <asp:Button ID="btn_back" runat="server" Text="Back" CssClass="button button2" OnClick="btn_back_Click"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button button2" OnClick="btn_cancel_Click"/>

    </div>
</asp:Content>
