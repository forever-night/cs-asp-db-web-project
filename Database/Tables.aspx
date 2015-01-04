<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Tables.aspx.cs" Inherits="Database.Employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="main">

        <div class="add" style="height: 210px;">

            <div style="height: 150px;">
                <asp:Label CssClass="labels" ID="lbl_emp_name" runat="server" 
                    Text="Name"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_emp_name" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_emp_surname" runat="server" 
                    Text="Surname"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_emp_surname" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_emp_personal_id" runat="server" 
                    Text="PESEL"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_emp_personal_id" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_emp_dept" runat="server" 
                    Text="Department"> </asp:Label>


                <asp:DropDownList CssClass="data" ID="dl_dept_id" runat="server" DataSourceID="DepartmentsDataSource" 
                    DataTextField="dept_name" DataValueField="dept_id" Width="150px" AppendDataBoundItems="True">
                    <asp:ListItem Value="empty">Select...</asp:ListItem>
                </asp:DropDownList>
            </div>


            <asp:Label ID="lbl_status_emp" runat="server"
                style="margin: 0px 60px; text-align: center; font-size:small;" Width="380px" Height="20px" > </asp:Label>


            <asp:Button CssClass="btn" ID="btn_insert_emp" runat="server" Text="Insert" OnClick="btn_insert_emp_Click"/>
            <asp:Button CssClass="btn" ID="btn_clear_emp" runat="server" Text="Clear" OnClick="btn_clear_emp_Click"/>
        </div>


        <asp:GridView CssClass="employees" ID="EmployeesGridView" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="emp_id" DataSourceID="EmployeesDataSource" AllowSorting="True" Width="617px">
            <Columns>
                <asp:BoundField DataField="emp_id" HeaderText="ID" ReadOnly="True" SortExpression="emp_id" />
                <asp:BoundField DataField="emp_name" HeaderText="Name" SortExpression="emp_name" />
                <asp:BoundField DataField="emp_surname" HeaderText="Surname" SortExpression="emp_surname" />
                <asp:BoundField DataField="emp_personal_id" HeaderText="PESEL" SortExpression="emp_personal_id" />
                <asp:BoundField DataField="dept_name" HeaderText="Department" SortExpression="dept_name" />

                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>


        <asp:SqlDataSource ID="EmployeesDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT Employees.emp_id, Employees.emp_name, Employees.emp_surname, Employees.emp_personal_id, Departments.dept_name FROM Employees INNER JOIN Departments ON Employees.emp_dept_id = Departments.dept_id"
            DeleteCommand="DELETE FROM Employees WHERE emp_id = @emp_id">
            <DeleteParameters>
                <asp:Parameter Name="ID"/>
            </DeleteParameters>
        </asp:SqlDataSource>


        <asp:GridView CssClass="departments" ID="DepartmentsGridView" runat="server" 
            AutoGenerateColumns="False" DataSourceID="DepartmentsDataSource" DataKeyNames="dept_id">
            <Columns>
                <asp:BoundField DataField="dept_id" HeaderText="ID" ReadOnly="True" SortExpression="dept_id" />
                <asp:BoundField DataField="dept_name" HeaderText="Department" SortExpression="dept_name" />
            </Columns>
        </asp:GridView>


        <asp:SqlDataSource ID="DepartmentsDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT * FROM [Departments]">
        </asp:SqlDataSource>


        <div class="add big" style="height: 280px; margin-bottom:60px;">
            <div>
                <asp:Label CssClass="labels" ID="lbl_addr_emp_id" runat="server" 
                    Text="Employee ID"> </asp:Label>


                <asp:DropDownList CssClass="data" ID="dl_addr_emp_id" runat="server" AppendDataBoundItems="True"
                    DataSourceID="EmployeesDataSource" DataTextField="emp_id" DataValueField="emp_id">
                    <asp:ListItem Value="empty">Select...</asp:ListItem>
                </asp:DropDownList>


                <asp:Label CssClass="labels" ID="lbl_country" runat="server" 
                    Text="Country"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_country" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_city" runat="server" 
                    Text="City"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_city" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_street" runat="server" 
                    Text="Street"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_street" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_house" runat="server" 
                    Text="House"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_house" runat="server"></asp:TextBox>


                <asp:Label CssClass="labels" ID="lbl_zipcode" runat="server" 
                    Text="Zip-Code"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_zipcode" runat="server"></asp:TextBox>
            </div>


            <asp:Label ID="lbl_status_addr" runat="server"
                style="margin: 0px 60px; text-align: center; font-size:small;" Width="380px" Height="20px" > </asp:Label>


            <asp:Button CssClass="btn" ID="btn_insert_addr" runat="server" Text="Insert" OnClick="btn_insert_addr_Click"/>
            <asp:Button CssClass="btn" ID="btn_clear_addr" runat="server" Text="Clear" OnClick="btn_clear_addr_Click"/>
        </div>


        <asp:GridView CssClass="addresses" ID="AddressesGridView" runat="server" AutoGenerateColumns="False" 
            DataSourceID="AddressesDataSource" AllowSorting="True" DataKeyNames="Expr1" Width="617px">

            <Columns>
                <asp:BoundField DataField="Expr1" HeaderText="ID" SortExpression="Expr1" ReadOnly="True" />
                <asp:BoundField DataField="Expr2" HeaderText="Name" SortExpression="Expr2" />
                <asp:BoundField DataField="Expr3" HeaderText="Surname" SortExpression="Expr3" />
                <asp:BoundField DataField="addr_country" HeaderText="Country" SortExpression="addr_country" />
                <asp:BoundField DataField="addr_city" HeaderText="City" SortExpression="addr_city" />
                <asp:BoundField DataField="addr_street" HeaderText="Street" SortExpression="addr_street" />
                <asp:BoundField DataField="addr_house" HeaderText="House" SortExpression="addr_house" />
                <asp:BoundField DataField="addr_zipcode" HeaderText="Zip-Code" SortExpression="addr_zipcode" />

                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>


        <asp:SqlDataSource ID="AddressesDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT Addresses.addr_country, Addresses.addr_city, Addresses.addr_street, Addresses.addr_house, Addresses.addr_zipcode, Employees.emp_id AS Expr1, Employees.emp_name AS Expr2, Employees.emp_surname AS Expr3 FROM Addresses INNER JOIN Employees ON Addresses.addr_emp_id = Employees.emp_id"
            DeleteCommand="UPDATE Employees SET emp_addr_id = NULL WHERE emp_id = @Addresses.addr_emp_id; DELETE FROM Addresses WHERE addr_emp_id = @addr_emp_id">
            <DeleteParameters>
                <asp:Parameter Name="ID" />
            </DeleteParameters>
        </asp:SqlDataSource>


        <div class="add" style="height: 130px; margin-bottom: 60px;">
            <div>
                <asp:Label CssClass="labels" ID="lbl_tel_emp_id" runat="server" 
                    Text="Employee ID"> </asp:Label>


                <asp:DropDownList CssClass="data" ID="dl_tel_emp_id" runat="server" AppendDataBoundItems="true"
                    DataSourceID="EmployeesDataSource" DataTextField="emp_id" DataValueField="emp_id">
                    <asp:ListItem Value="empty">Select...</asp:ListItem>
                </asp:DropDownList>


                <asp:Label CssClass="labels" ID="lbl_tel_number" runat="server" 
                    Text="Phone"> </asp:Label>


                <asp:TextBox CssClass="data" ID="tb_tel_number" runat="server"></asp:TextBox>
            </div>


            <asp:Label ID="lbl_status_tel" runat="server"
                style="margin: 0px 60px; text-align: center; font-size:small;" Width="380px" Height="20px" > </asp:Label>


            <asp:Button CssClass="btn" ID="btn_insert_tel" runat="server" Text="Insert" OnClick="btn_insert_tel_Click"/>
            <asp:Button CssClass="btn" ID="btn_clear_tel" runat="server" Text="Clear" OnClick="btn_clear_tel_Click"/>
        </div>


        <asp:GridView CssClass="telephones" ID="TelephonesGridView" runat="server" AutoGenerateColumns="False" 
            DataSourceID="TelephonesDataSource" AllowSorting="True" DataKeyNames="emp_id" Width="616px">

            <Columns>
                <asp:BoundField DataField="emp_id" HeaderText="ID" SortExpression="emp_id" ReadOnly="True" />
                <asp:BoundField DataField="emp_name" HeaderText="Name" SortExpression="emp_name" />
                <asp:BoundField DataField="emp_surname" HeaderText="Surname" SortExpression="emp_surname" />
                <asp:BoundField DataField="tel_num" HeaderText="Phone" SortExpression="tel_num" />
            </Columns>
        </asp:GridView>


        <asp:SqlDataSource ID="TelephonesDataSource" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
            SelectCommand="SELECT Telephones.tel_num, Employees.emp_name, Employees.emp_id, Employees.emp_surname FROM Telephones INNER JOIN Employees ON Telephones.tel_emp_id = Employees.emp_id">
        </asp:SqlDataSource>
            

    </div>
</asp:Content>