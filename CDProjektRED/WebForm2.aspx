<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CDProjektRED.WebForm2"EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id ="addRecord">



    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
    <asp:Button ID="btnEdit" runat="server" Height="24px" OnClick="btnEdit_Click" Text="Edit Record" Width="157px" />
    <asp:TextBox ID="TextBoxArtist" runat="server" Width="111px"></asp:TextBox>
    <asp:TextBox ID="TextBoxAlbum" runat="server" Width="83px"></asp:TextBox>
    <asp:TextBox ID="TextBoxYear" runat="server" Width="113px"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
         ControlToValidate="TextBoxYear" runat="server"
         ErrorMessage="Only Numbers allowed"
         ValidationExpression="\d+">
</asp:RegularExpressionValidator>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" Width="74px" />
    <br />

</asp:Content>
