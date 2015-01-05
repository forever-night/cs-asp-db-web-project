<%@ Page Title="Add address" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="add_address.aspx.cs" Inherits="Database.add_address" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
    <link rel="stylesheet" type="text/css" href="add.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">ADD ADDRESS</h1>


     <div style="width: 700px; margin: auto; margin-top: 40px; margin-bottom: 40px; padding: 0px 100px;">
        <asp:Label ID="lbl_country" runat="server" Text="Country" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_country" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_city" runat="server" Text="City" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_city" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_street" runat="server" Text="Street" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_street" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_house" runat="server" Text="House" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_house" runat="server" Width="100px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_zip" runat="server" Text="Zip-Code" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_zip" runat="server" Width="100px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_status" runat="server" CssClass="label" Width="650px"></asp:Label>


        <asp:Button ID="btn_next" runat="server" Text="Next" CssClass="button button2" style="margin-right: 70px;"/>
        <asp:Button ID="btn_back" runat="server" Text="Back" CssClass="button button2"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button button2"/>

    </div>
</asp:Content>
