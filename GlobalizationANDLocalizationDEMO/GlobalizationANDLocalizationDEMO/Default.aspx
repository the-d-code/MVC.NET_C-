<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GlobalizationANDLocalizationDEMO._Default" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
       <div class="col-md-12">
           
           
            <div style="margin-left: 40px">
             <asp:Label ID="name1" runat="server" meta:resourceKey="name1">Names</asp:Label>
             <asp:DropDownList ID="drop1" runat="server" meta:resourcekey="drop1Resource1">
             </asp:DropDownList>
            </div>
           
           </div>
    </div>

</asp:Content>
