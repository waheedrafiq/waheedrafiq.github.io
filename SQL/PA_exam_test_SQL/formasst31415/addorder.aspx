<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="addorder.aspx.vb" Inherits="addorder" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        Locate customer ID for current user and add customer order record
    </p>
    <p>
        Hello:
        <asp:Label ID="lblHelloUser" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Your ID is :</p>
    <p>
        CustomerID :
        <asp:Label ID="lblCustID" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="orderdatabaseDataContext" EnableUpdate="True" EntityTypeName="" Select="new (customerid, orderdate, orderduedate, orderstatus, ordertotal, ordertrackingid, orderdeliverytime, ordercollectdeliver, ordercomment)" TableName="orders">
            </asp:LinqDataSource>
            <br />
            <br />
            <br />
            <asp:FormView ID="FormView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataSourceID="LinqDataSource1" GridLines="Both"
                DefaultMode="Insert" >
                <EditItemTemplate>
                    customerid:
                    <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:TextBox ID="orderdateTextBox" runat="server" Text='<%# Bind("orderdate") %>' />
                    <br />
                    orderduedate:
                    <asp:TextBox ID="orderduedateTextBox" runat="server" Text='<%# Bind("orderduedate") %>' />
                    <br />
                    orderstatus:
                    <asp:TextBox ID="orderstatusTextBox" runat="server" Text='<%# Bind("orderstatus") %>' />
                    <br />
                    ordertotal:
                    <asp:TextBox ID="ordertotalTextBox" runat="server" Text='<%# Bind("ordertotal") %>' />
                    <br />
                    ordertrackingid:
                    <asp:TextBox ID="ordertrackingidTextBox" runat="server" Text='<%# Bind("ordertrackingid") %>' />
                    <br />
                    orderdeliverytime:
                    <asp:TextBox ID="orderdeliverytimeTextBox" runat="server" Text='<%# Bind("orderdeliverytime") %>' />
                    <br />
                    ordercollectdeliver:
                    <asp:TextBox ID="ordercollectdeliverTextBox" runat="server" Text='<%# Bind("ordercollectdeliver") %>' />
                    <br />
                    ordercomment:
                    <asp:TextBox ID="ordercommentTextBox" runat="server" Text='<%# Bind("ordercomment") %>' />
                    <br />
                    <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
                    &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </EditItemTemplate>
                <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <EmptyDataTemplate>
                    No Data Found
                </EmptyDataTemplate>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <InsertItemTemplate>
                    customerid:
                    <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:TextBox ID="orderdateTextBox" runat="server" Text='<%# Bind("orderdate") %>' />
                    <br />
                    orderduedate:
                    <asp:TextBox ID="orderduedateTextBox" runat="server" Text='<%# Bind("orderduedate") %>' />
                    <br />
                    orderstatus:
                    <asp:TextBox ID="orderstatusTextBox" runat="server" Text='<%# Bind("orderstatus") %>' />
                    <br />
                    ordertotal:
                    <asp:TextBox ID="ordertotalTextBox" runat="server" Text='<%# Bind("ordertotal") %>' />
                    <br />
                    ordertrackingid:
                    <asp:TextBox ID="ordertrackingidTextBox" runat="server" Text='<%# Bind("ordertrackingid") %>' />
                    <br />
                    orderdeliverytime:
                    <asp:TextBox ID="orderdeliverytimeTextBox" runat="server" Text='<%# Bind("orderdeliverytime") %>' />
                    <br />
                    ordercollectdeliver:
                    <asp:TextBox ID="ordercollectdeliverTextBox" runat="server" Text='<%# Bind("ordercollectdeliver") %>' />
                    <br />
                    ordercomment:
                    <asp:TextBox ID="ordercommentTextBox" runat="server" Text='<%# Bind("ordercomment") %>' />
                    <br />
                    <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                    &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                </InsertItemTemplate>
                <ItemTemplate>
                    customerid:
                    <asp:Label ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' Visible='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:Label ID="orderdateLabel" runat="server" Text='<%# Bind("orderdate", "{0:d}") %>' />
                    <br />
                    orderduedate:
                    <asp:Label ID="orderduedateLabel" runat="server" Text='<%# Bind("orderduedate", "{0:d}") %>' />
                    <br />
                    orderstatus:
                    <asp:Label ID="orderstatusLabel" runat="server" Text='<%# Bind("orderstatus", "{1}") %>' />
                    <br />
                    ordertotal:
                    <asp:Label ID="ordertotalLabel" runat="server" Text='<%# Bind("ordertotal", "{0}") %>' />
                    <br />
                    ordertrackingid:
                    <asp:Label ID="ordertrackingidLabel" runat="server" Text='<%# Bind("ordertrackingid", "{1}") %>' />
                    <br />
                    orderdeliverytime:
                    <asp:Label ID="orderdeliverytimeLabel" runat="server" Text='<%# Bind("orderdeliverytime") %>' />
                    <br />
                    ordercollectdeliver:
                    <asp:Label ID="ordercollectdeliverLabel" runat="server" Text='<%# Bind("ordercollectdeliver") %>' />
                    <br />
                    ordercomment:
                    <asp:Label ID="ordercommentLabel" runat="server" Text='<%# Bind("ordercomment") %>' />
                    <br />
                </ItemTemplate>
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            </asp:FormView>
            <br />
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

