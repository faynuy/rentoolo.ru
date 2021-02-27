<%@ Page Title="Новости Faynuy=) " Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsFaynuy.aspx.cs" Inherits="Rentoolo.Faynuy.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

  <hgroup class="title">
        <h1><%: Title %></h1>
    </hgroup>
    <br />
    <% foreach (var item in ListNews)
        { %>
    <p>
        <span class="date"><%=item.Date.ToString("dd.MM.yyyy") %></span>
        <br />
        <%=item.Text %><span>&nbsp;</span>
    </p>
    <hr />
    <% } %>

    </asp:Content>