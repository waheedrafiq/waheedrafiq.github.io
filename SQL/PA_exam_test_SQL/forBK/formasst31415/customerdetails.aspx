<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="customerdetails.aspx.vb" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    hello
    <asp:label ID="usersname" runat="server"></asp:label>
&nbsp;</p>
<p>
    your account customer details are as follows:</p>
<p>
    <asp:LinqDataSource ID="accountLDS" runat="server" ContextTypeName="orderdatabaseDataContext" EntityTypeName="" Select="new (custemail, custusername, custtelno, custname, custaddress1, custaddress3, custpostode, customerid)" TableName="customers" Where="custusername == @custusername">
        <WhereParameters>
            <asp:SessionParameter DefaultValue="0" Name="custusername" SessionField="usersloginid" Type="String" />
        </WhereParameters>
    </asp:LinqDataSource>
    <asp:FormView ID="customerdetails" runat="server" DataSourceID="accountLDS">
        <EditItemTemplate>
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
            custaddress3:
            <asp:TextBox ID="custaddress3TextBox" runat="server" Text='<%# Bind("custaddress3") %>' />
            <br />
            custpostode:
            <asp:TextBox ID="custpostodeTextBox" runat="server" Text='<%# Bind("custpostode") %>' />
            <br />
            customerid:
            <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
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
            custaddress3:
            <asp:TextBox ID="custaddress3TextBox" runat="server" Text='<%# Bind("custaddress3") %>' />
            <br />
            custpostode:
            <asp:TextBox ID="custpostodeTextBox" runat="server" Text='<%# Bind("custpostode") %>' />
            <br />
            customerid:
            <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
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
            custtelno:
            <asp:Label ID="custtelnoLabel" runat="server" Text='<%# Bind("custtelno") %>' />
            <br />
            custname:
            <asp:Label ID="custnameLabel" runat="server" Text='<%# Bind("custname") %>' />
            <br />
            custaddress1:
            <asp:Label ID="custaddress1Label" runat="server" Text='<%# Bind("custaddress1") %>' />
            <br />
            custaddress3:
            <asp:Label ID="custaddress3Label" runat="server" Text='<%# Bind("custaddress3") %>' />
            <br />
            custpostode:
            <asp:Label ID="custpostodeLabel" runat="server" Text='<%# Bind("custpostode") %>' />
            <br />
            customerid:
            <asp:Label ID="customeridLabel" runat="server" Text='<%# Bind("customerid") %>' />
            <br />

        </ItemTemplate>
    </asp:FormView>
</p>
<p>
    now go to the menu to add an order</p>
</asp:Content>

