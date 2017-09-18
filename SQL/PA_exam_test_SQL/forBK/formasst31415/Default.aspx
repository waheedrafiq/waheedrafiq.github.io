<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Formative assignment 3 - build basic order entry system</h1>
            </hgroup>
            <p>
                add order and show order pages must be created before the menu links will work.</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>hello
        <asp:label ID="usersname" runat="server"></asp:label>
&nbsp;&nbsp;<asp:LinqDataSource ID="customeridLDS" runat="server" ContextTypeName="orderdatabaseDataContext" EntityTypeName="" Select="new (customerid)" TableName="customers" Where="custusername == @custusername1">
            <WhereParameters>
                <asp:SessionParameter DefaultValue="0" Name="custusername1" SessionField="usersloginid" Type="String" />
            </WhereParameters>
        </asp:LinqDataSource>
        <asp:DetailsView ID="customerdetails" runat="server" AutoGenerateRows="False" DataSourceID="customeridLDS" Height="50px" Width="260px">
            <Fields>
                <asp:BoundField DataField="customerid" HeaderText="your customerid is: " ReadOnly="True" SortExpression="customerid" />
            </Fields>
        </asp:DetailsView>
    </h3>
    <h5>To add an order, use the add order menu link and then view the order just 
                added using the show order menu link. </h5>
    
</asp:Content>
