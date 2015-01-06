<%@ Page Title="Addresses" Language="C#" MasterPageFile="~/mp.Master" AutoEventWireup="true" CodeBehind="Addresses.aspx.cs" Inherits="Database.Addresses" %>


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


    <h1 class="header">ADDRESSES</h1>


    <asp:GridView ID="gv_emp_addr" CssClass="table" runat="server" AutoGenerateColumns="False" DataKeyNames="emp_id" DataSourceID="ds_addr">
        <Columns>
            <asp:BoundField DataField="emp_id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="emp_id" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField DataField="emp_name" HeaderText="Name" SortExpression="emp_name" />
            <asp:BoundField DataField="emp_surname" HeaderText="Surname" SortExpression="emp_surname" />
            <asp:BoundField DataField="addr_country" HeaderText="Country" SortExpression="addr_country" />
            <asp:BoundField DataField="addr_city" HeaderText="City" SortExpression="addr_city" />
            <asp:BoundField DataField="addr_street" HeaderText="Street" SortExpression="addr_street" />

            <asp:BoundField DataField="addr_house" HeaderText="House" SortExpression="addr_house" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

            <asp:BoundField DataField="addr_zipcode" HeaderText="Zip-code" SortExpression="addr_zipcode" >
                <HeaderStyle HorizontalAlign="Center" />
                <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>

        </Columns>
    </asp:GridView>

    <asp:SqlDataSource ID="ds_addr" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT Employees.emp_id, Employees.emp_name, Employees.emp_surname, Addresses.addr_country, Addresses.addr_city, Addresses.addr_street, Addresses.addr_house, Addresses.addr_zipcode FROM Employees INNER JOIN Addresses ON Employees.emp_addr_id = Addresses.addr_id">
    </asp:SqlDataSource>
</asp:Content>
