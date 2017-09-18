<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="insertcustomer.aspx.vb" Inherits="insertcustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <p>
        enter your customer details</p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        enter all fields and click insert to complete your registration</p>
    <p>
        <asp:LinqDataSource ID="checkcustomerLDS" runat="server" ContextTypeName="orderdatabaseDataContext" EntityTypeName="" Select="new (customerid)" TableName="customers" Where="custusername == @custusername">
            <WhereParameters>
                <asp:SessionParameter DefaultValue="0" Name="custusername" SessionField="usersloginid" Type="String" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:DetailsView ID="customerdetails" runat="server" AutoGenerateRows="False" DataSourceID="checkcustomerLDS" Height="50px" Width="125px">
            <EmptyDataTemplate>
                session usersloginid not set
            </EmptyDataTemplate>
            <Fields>
                <asp:BoundField DataField="customerid" HeaderText="customerid" ReadOnly="True" SortExpression="customerid" />
            </Fields>
        </asp:DetailsView>
    </p>
    <p>
        <asp:LinqDataSource ID="insertcustomerLDS" runat="server" ContextTypeName="orderdatabaseDataContext" EnableInsert="True" EntityTypeName="" TableName="customers">
        </asp:LinqDataSource>
        <asp:FormView ID="insertcustomerform" runat="server" DataKeyNames="customerid" DataSourceID="insertcustomerLDS">
            <EditItemTemplate>
                custemail:
                <asp:TextBox ID="custemailTextBox" runat="server" Text='<%# Bind("custemail") %>' />
                <br />
                custusername:
                <asp:TextBox ID="custusernameTextBox" runat="server" Text='<%# Bind("custusername") %>' />
                <br />
                custquestion:
                <asp:TextBox ID="custquestionTextBox" runat="server" Text='<%# Bind("custquestion") %>' />
                <br />
                custanswer:
                <asp:TextBox ID="custanswerTextBox" runat="server" Text='<%# Bind("custanswer") %>' />
                <br />
                custtelno:
                <asp:TextBox ID="custtelnoTextBox" runat="server" Text='<%# Bind("custtelno") %>' />
                <br />
                custname:
                <asp:TextBox ID="custnameTextBox" runat="server" Text='<%# Bind("custname") %>' />
                <br />
                custaddress1:
                <asp:TextBox ID="custaddress1TextBox" runat="server" Text='<%# Bind("custaddress1") %>' />
                <br />
                custaddress2:
                <asp:TextBox ID="custaddress2TextBox" runat="server" Text='<%# Bind("custaddress2") %>' />
                <br />
                custaddress3:
                <asp:TextBox ID="custaddress3TextBox" runat="server" Text='<%# Bind("custaddress3") %>' />
                <br />
                custpostode:
                <asp:TextBox ID="custpostodeTextBox" runat="server" Text='<%# Bind("custpostode") %>' />
                <br />
                custcomment:
                <asp:TextBox ID="custcommentTextBox" runat="server" Text='<%# Bind("custcomment") %>' />
                <br />
                custupdatedate:
                <asp:TextBox ID="custupdatedateTextBox" runat="server" Text='<%# Bind("custupdatedate") %>' />
                <br />
                customerid:
                <asp:Label ID="customeridLabel1" runat="server" Text='<%# Eval("customerid") %>' />
                <br />
                orders:
                <asp:TextBox ID="ordersTextBox" runat="server" Text='<%# Bind("orders") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </EditItemTemplate>
            <InsertItemTemplate>
                custemail:
                <asp:TextBox ID="custemailTextBox" runat="server" Text='<%# Bind("custemail") %>' />
                <br />
                custusername:
                <asp:TextBox ID="custusernameTextBox" runat="server" Text='<%# Bind("custusername") %>' />
                <br />
                custtelno:
                <asp:TextBox ID="custtelnoTextBox" runat="server" Text='<%# Bind("custtelno") %>' />
                <br />
                custname:
                <asp:TextBox ID="custnameTextBox" runat="server" Text='<%# Bind("custname") %>' />
                <br />
                custaddress1:
                <asp:TextBox ID="custaddress1TextBox" runat="server" Text='<%# Bind("custaddress1") %>' />
                <br />
                custaddress2:
                <asp:TextBox ID="custaddress2TextBox" runat="server" Text='<%# Bind("custaddress2") %>' />
                <br />
                custaddress3:
                <asp:TextBox ID="custaddress3TextBox" runat="server" Text='<%# Bind("custaddress3") %>' />
                <br />
                custpostode:
                <asp:TextBox ID="custpostodeTextBox" runat="server" Text='<%# Bind("custpostode") %>' />
                <br />
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
            </InsertItemTemplate>
            <ItemTemplate>
                custemail:
                <asp:Label ID="custemailLabel" runat="server" Text='<%# Bind("custemail") %>' />
                <br />
                custusername:
                <asp:Label ID="custusernameLabel" runat="server" Text='<%# Bind("custusername") %>' />
                <br />
                custquestion:
                <asp:Label ID="custquestionLabel" runat="server" Text='<%# Bind("custquestion") %>' />
                <br />
                custanswer:
                <asp:Label ID="custanswerLabel" runat="server" Text='<%# Bind("custanswer") %>' />
                <br />
                custtelno:
                <asp:Label ID="custtelnoLabel" runat="server" Text='<%# Bind("custtelno") %>' />
                <br />
                custname:
                <asp:Label ID="custnameLabel" runat="server" Text='<%# Bind("custname") %>' />
                <br />
                custaddress1:
                <asp:Label ID="custaddress1Label" runat="server" Text='<%# Bind("custaddress1") %>' />
                <br />
                custaddress2:
                <asp:Label ID="custaddress2Label" runat="server" Text='<%# Bind("custaddress2") %>' />
                <br />
                custaddress3:
                <asp:Label ID="custaddress3Label" runat="server" Text='<%# Bind("custaddress3") %>' />
                <br />
                custpostode:
                <asp:Label ID="custpostodeLabel" runat="server" Text='<%# Bind("custpostode") %>' />
                <br />
                custcomment:
                <asp:Label ID="custcommentLabel" runat="server" Text='<%# Bind("custcomment") %>' />
                <br />
                custupdatedate:
                <asp:Label ID="custupdatedateLabel" runat="server" Text='<%# Bind("custupdatedate") %>' />
                <br />
                customerid:
                <asp:Label ID="customeridLabel" runat="server" Text='<%# Eval("customerid") %>' />
                <br />
                orders:
                <asp:Label ID="ordersLabel" runat="server" Text='<%# Bind("orders") %>' />
                <br />
                <asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="New" />
            </ItemTemplate>
        </asp:FormView>
    </p>
    <p>
        Your customer details will be displayed when you click insert</p>
</asp:Content>

