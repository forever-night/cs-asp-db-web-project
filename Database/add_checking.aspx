<%@ Page Title="Checking" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="add_checking.aspx.cs" Inherits="Database.add_checking" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
    <link rel="stylesheet" type="text/css" href="add.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div style="width: 700px; margin: auto; margin-top: 40px; margin-bottom: 40px; padding: 0px 100px;">
        
        <asp:Label ID="lbl_emp_name" runat="server" Text="Name" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_emp_name" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_emp_surname" runat="server" Text="Surname" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_emp_surname" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_emp_pers_id" runat="server" Text="PESEL" Width="80px" CssClass="label2">
        </asp:Label>
        <asp:TextBox ID="tb_emp_pers_id" runat="server" Width="350px" CssClass="textbox"></asp:TextBox>
        <br>


        <asp:Label ID="lbl_emp_dept" runat="server" Text="Department" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:DropDownList ID="dl_emp_dept" runat="server" CssClass="textbox" Width="150px" DataSourceID="ds_depts" DataTextField="dept_name" DataValueField="dept_id" AppendDataBoundItems="true">
            <asp:ListItem Value="empty" Selected=True Enabled=True>Select...</asp:ListItem>
        </asp:DropDownList>

        <asp:SqlDataSource ID="ds_depts" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Departments]">
        </asp:SqlDataSource>
        <br><br><br>


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
        <br><br><br>


        <asp:Label ID="lbl_phone" runat="server" Text="Phone" Width="80px" CssClass="label2">
        </asp:Label>

        <asp:TextBox ID="tb_phone" runat="server" Width="150px" CssClass="textbox"></asp:TextBox>
        <br><br>


        <asp:Label ID="lbl_status" runat="server" CssClass="label" Width="650px"></asp:Label>


        <asp:Button ID="btn_finish" runat="server" Text="Finish" CssClass="button button2" style="margin-right: 70px;"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button button2"/>
    </div>
</asp:Content>
