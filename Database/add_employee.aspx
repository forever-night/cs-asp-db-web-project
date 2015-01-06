<%@ Page Title="Add employee" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Add_employee.aspx.cs" Inherits="Database.Add_employee" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
    <link rel="stylesheet" type="text/css" href="add.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">CREATE NEW EMPLOYEE</h1>


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
        <br>


        <asp:Label ID="lbl_status" runat="server" CssClass="label status" Width="650px"></asp:Label>


        <asp:Button ID="btn_next" runat="server" Text="Next" CssClass="button button2" style="margin-right: 70px;" OnClick="btn_next_Click"/>
        <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="button button2" OnClick="btn_cancel_Click"/>
    </div>
</asp:Content>
