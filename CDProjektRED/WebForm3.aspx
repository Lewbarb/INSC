<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="CDProjektRED.WebForm3" %>
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
    <asp:Button ID="editButton" runat="server" OnClick="editButton_Click" Text="Edit Selected Record" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
         ControlToValidate="TextBox1" runat="server"
         ErrorMessage="Only Numbers allowed"
         ValidationExpression="\d+">
</asp:RegularExpressionValidator>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" />
    <br />

</asp:Content>
