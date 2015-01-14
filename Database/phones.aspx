<%@ Page Title="Telephones" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Phones.aspx.cs" Inherits="Database.Phones" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="tables.css"/>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <asp:Button ID="btn_emps" runat="server" Text="Employees" CssClass="button navigation"
        style="margin-top:5px;" OnClick="btn_emps_Click"/>
    <asp:Button ID="btn_emp_phones" runat="server" Text="Telephones" CssClass="button navigation"
        style="margin-top:5px; margin-left: 15px;" OnClick="btn_emp_phones_Click"/>
    <asp:Button ID="btn_emp_addr" runat="server" Text="Addresses" CssClass="button navigation"
        style="margin-top:5px; margin-left: 15px;" OnClick="btn_emp_addr_Click"/>


    <h1 class="header">TELEPHONES</h1>


    <asp:GridView ID="gv_emp_phones" runat="server" AutoGenerateColumns="False" DataKeyNames="emp_id" DataSourceID="ds_phones" CssClass="table">
        <Columns>

            <asp:BoundField DataField="emp_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="emp_id" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField DataField="emp_name" HeaderText="Name" SortExpression="emp_name" />
            <asp:BoundField DataField="emp_surname" HeaderText="Surname" SortExpression="emp_surname" />

            <asp:BoundField DataField="tel_num" HeaderText="Phone" SortExpression="tel_num" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="ds_phones" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Employees.emp_id, Employees.emp_name, Employees.emp_surname, Telephones.tel_num FROM Employees INNER JOIN Telephones ON Employees.emp_tel_id = Telephones.tel_id">
    </asp:SqlDataSource>
</asp:Content>
