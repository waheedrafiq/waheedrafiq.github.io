<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.vb" Inherits="About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        
        <h2>Formative assignment 3 - build basic order entry system</h2>
    </hgroup>

    <article>
            <p>
                Before you can use the system, you must first register yourself as a customer and then set up your customer details,</p>
            <p>
                the system is designed to force immediate login or registration, so that must be completed before you can go any further.</p>
            <p>
                You can change your user using the log in link top right.</p>
            <p>
                add order is used to create an order record and its order lines and show order will display order details.</p>
    </article>

    <aside>
        <h3>menu info</h3>
        <p>        
            these links are standard asp.net</p>
        <ul>
            <li><a runat="server" href="~/">Home</a></li>
            <li><a runat="server" href="~/About">About</a></li>
            <li><a runat="server" href="~/Contact">Contact</a></li>
        </ul>
    </aside>
</asp:Content>