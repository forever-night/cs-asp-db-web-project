<%@ Page Title="Departments" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Departments.aspx.cs" Inherits="Database.Departments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">DEPARTMENTS</h1>


    <asp:GridView ID="gv_depts" CssClass="table" runat="server" AutoGenerateColumns="False" DataKeyNames="dept_id" DataSourceID="ds_depts" Font-Names="Verdana" Font-Size="10pt">
        <Columns>
            <asp:BoundField DataField="dept_id" HeaderText="ID" InsertVisible="False" ReadOnly="True"           SortExpression="dept_id">

            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField DataField="dept_name" HeaderText="Department" SortExpression="dept_name" />
        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="ds_depts" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Departments]">
    </asp:SqlDataSource>


    <asp:Button ID="btn_add_dept" runat="server" Text="Add" CssClass="button"
        style="width: 80px; height: 30px; float: right; margin-right: 50px;" OnClick="btn_add_dept_Click"/>

</asp:Content>
