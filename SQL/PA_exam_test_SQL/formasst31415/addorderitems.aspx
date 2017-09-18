<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="addorderitems.aspx.vb" Inherits="addorderitems" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" Runat="Server">
    <p>
        Add Orders Items Page
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        <br />
        Panel 1 - order header details:
    </p>
    <p>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </p>
    <asp:UpdatePanel ID="UpdPOrders" runat="server">
        <ContentTemplate>
<br />
            <asp:LinqDataSource ID="LDSorders" runat="server" ContextTypeName="orderdatabaseDataContext" EntityTypeName="" OrderBy="orderid desc" Select="new (orderid, customerid, orderdate, orderduedate, ordercollectdeliver, ordercomment)" TableName="orders" EnableUpdate="True">
            </asp:LinqDataSource>
            <asp:FormView ID="FrmVOrders" runat="server" DataSourceID="LDSorders">
                <EditItemTemplate>
                    orderid:
                    <asp:TextBox ID="orderidTextBox" runat="server" Text='<%# Bind("orderid") %>' />
                    <br />
                    customerid:
                    <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:TextBox ID="orderdateTextBox" runat="server" Text='<%# Bind("orderdate") %>' />
                    <br />
                    orderduedate:
                    <asp:TextBox ID="orderduedateTextBox" runat="server" Text='<%# Bind("orderduedate") %>' />
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
                <InsertItemTemplate>
                    orderid:
                    <asp:TextBox ID="orderidTextBox" runat="server" Text='<%# Bind("orderid") %>' />
                    <br />
                    customerid:
                    <asp:TextBox ID="customeridTextBox" runat="server" Text='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:TextBox ID="orderdateTextBox" runat="server" Text='<%# Bind("orderdate") %>' />
                    <br />
                    orderduedate:
                    <asp:TextBox ID="orderduedateTextBox" runat="server" Text='<%# Bind("orderduedate") %>' />
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
                    orderid:
                    <asp:Label ID="orderidLabel" runat="server" Text='<%# Bind("orderid") %>' />
                    <br />
                    customerid:
                    <asp:Label ID="customeridLabel" runat="server" Text='<%# Bind("customerid") %>' />
                    <br />
                    orderdate:
                    <asp:Label ID="orderdateLabel" runat="server" Text='<%# Bind("orderdate") %>' />
                    <br />
                    orderduedate:
                    <asp:Label ID="orderduedateLabel" runat="server" Text='<%# Bind("orderduedate") %>' />
                    <br />
                    ordercollectdeliver:
                    <asp:Label ID="ordercollectdeliverLabel" runat="server" Text='<%# Bind("ordercollectdeliver") %>' />
                    <br />
                    ordercomment:
                    <asp:Label ID="ordercommentLabel" runat="server" Text='<%# Bind("ordercomment") %>' />
                    <br />
                </ItemTemplate>
            </asp:FormView>
            <br />
            <br />
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        Panel 2 select restaurant menu and menu items for order line</p>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <asp:LinqDataSource ID="LDSRestName" runat="server" ContextTypeName="orderdatabaseDataContext" EntityTypeName="" Select="new (restname, restaurantid)" TableName="restaurants">
            </asp:LinqDataSource>
            <asp:LinqDataSource ID="LDSgridView" runat="server" ContextTypeName="orderdatabaseDataContext" EnableUpdate="True" EntityTypeName="" Select="new (menuid, restaurantid, menutype, menuexpirydate, menucomment, menuupdatedate)" TableName="menus" Where="restaurantid == @restaurantid">
                <WhereParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="restaurantid" PropertyName="SelectedValue" Type="Int32" />
                </WhereParameters>
            </asp:LinqDataSource>
<br />
            Select a restaurant:
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="LDSRestName" DataTextField="restname" DataValueField="restaurantid" Height="21px" Width="148px" AutoPostBack="True">
            </asp:DropDownList>
            <br />
            <br />
            Select a menu for this restaurant :<br />
            <br />
            <asp:GridView ID="gvMenu" runat="server" AutoGenerateColumns="False" DataSourceID="LDSgridView" ShowFooter="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="824px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="menuid" HeaderText="menuid" ReadOnly="True" SortExpression="menuid" />
                    <asp:BoundField DataField="restaurantid" HeaderText="restaurantid" ReadOnly="True" SortExpression="restaurantid" />
                    <asp:BoundField DataField="menutype" HeaderText="menutype" ReadOnly="True" SortExpression="menutype" />
                    <asp:BoundField DataField="menuexpirydate" HeaderText="menuexpirydate" ReadOnly="True" SortExpression="menuexpirydate" />
                    <asp:BoundField DataField="menucomment" HeaderText="menucomment" ReadOnly="True" SortExpression="menucomment" />
                    <asp:BoundField DataField="menuupdatedate" HeaderText="menuupdatedate" ReadOnly="True" SortExpression="menuupdatedate" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <EmptyDataTemplate>
                    NO data found for Menu
                </EmptyDataTemplate>
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
<br />
<br />
<br />
            Select a menu item for order:<br />
            <asp:LinqDataSource ID="LDSmenuItem" runat="server" ContextTypeName="orderdatabaseDataContext" EnableUpdate="True" EntityTypeName="" Select="new (menuitemid, menuid, itemname, itemdescription, itemprice, itempreptime, itemcomment, itemupdatedate)" TableName="menuitems">
            </asp:LinqDataSource>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="LDSmenuItem" ForeColor="#333333" GridLines="None" Width="921px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="menuitemid" HeaderText="menuitemid" ReadOnly="True" SortExpression="menuitemid" />
                    <asp:BoundField DataField="menuid" HeaderText="menuid" ReadOnly="True" SortExpression="menuid" />
                    <asp:BoundField DataField="itemname" HeaderText="itemname" ReadOnly="True" SortExpression="itemname" />
                    <asp:BoundField DataField="itemdescription" HeaderText="itemdescription" ReadOnly="True" SortExpression="itemdescription" />
                    <asp:BoundField DataField="itemprice" HeaderText="itemprice" ReadOnly="True" SortExpression="itemprice" />
                    <asp:BoundField DataField="itempreptime" HeaderText="itempreptime" ReadOnly="True" SortExpression="itempreptime" />
                    <asp:BoundField DataField="itemcomment" HeaderText="itemcomment" ReadOnly="True" SortExpression="itemcomment" />
                    <asp:BoundField DataField="itemupdatedate" HeaderText="itemupdatedate" ReadOnly="True" SortExpression="itemupdatedate" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <br />
<br />
<br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        &nbsp;</p>
    <p>
        Panel 3:</p>
    <p>
    </p>
    <asp:UpdatePanel ID="UpdatePanel3" runat="server">
        <ContentTemplate>
<br />
            <asp:LinqDataSource ID="LSDOrdersF" runat="server">
            </asp:LinqDataSource>
<br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

