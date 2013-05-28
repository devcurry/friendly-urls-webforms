<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"
    CodeBehind="Article.aspx.cs" Inherits="FriendlyUrlsInWebForms.Blog.Article" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <h1>
            <asp:Label ID="title" runat="server" Text=""></asp:Label></h1>
    </div>
    <div>
        by <h2>
            <asp:Label ID="author" runat="server" Text="Label"></asp:Label></h2>
    </div>
    <div>
        <asp:Label ID="postDetails" runat="server" Text="Label"></asp:Label>
    </div>

</asp:Content>
