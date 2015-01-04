<%@ Page Title="Employees" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="employees.aspx.cs" Inherits="Database.employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <h1 class="header">EMPLOYEES</h1>


    <asp:GridView ID="gv_emps" CssClass="table" runat="server" AutoGenerateColumns="False" DataKeyNames="emp_id" DataSourceID="ds_emps" Font-Names="Verdana" Font-Size="10pt">
        <Columns>
            <asp:BoundField DataField="emp_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="emp_id">
            <HeaderStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField DataField="emp_name" HeaderText="Name" SortExpression="emp_name" />
            <asp:BoundField DataField="emp_surname" HeaderText="Surname" SortExpression="emp_surname" />
            <asp:BoundField DataField="emp_personal_id" HeaderText="PESEL" SortExpression="emp_personal_id" />
            <asp:BoundField DataField="dept_name" HeaderText="Department" SortExpression="dept_name" />

        </Columns>
    </asp:GridView>
    
    <asp:SqlDataSource ID="ds_emps" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Employees.emp_id, Employees.emp_name, Employees.emp_surname, Employees.emp_personal_id, Departments.dept_name FROM Employees INNER JOIN Departments ON Employees.emp_dept_id = Departments.dept_id">
    </asp:SqlDataSource>


    <asp:Button ID="btn_add_dept" runat="server" Text="Add" CssClass="button"
        style="width: 80px; height: 30px; float: right; margin-right: 50px;"/>
</asp:Content>
