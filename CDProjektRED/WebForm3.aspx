<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="True" CodeBehind="WebForm3.aspx.cs" Inherits="CDProjektRED.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:TextBox ID="TextBoxArtist" runat="server" OnTextChanged="TextBoxArtist_TextChanged"></asp:TextBox>
    <asp:TextBox ID="TextBoxAlbum" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBoxYear" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit Changes" />
    <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
    <p>
    </p>
</asp:Content>
