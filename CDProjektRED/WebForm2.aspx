<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="CDProjektRED.WebForm2" %>
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
    <asp:Button ID="btnEdit" runat="server" Height="16px" OnClick="btnEdit_Click" Text="Edit Record" Width="132px" />
    <asp:TextBox ID="TextBox1" runat="server" Width="111px"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server" Width="83px"></asp:TextBox>
    <asp:TextBox ID="TextBox3" runat="server" Width="113px"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
         ControlToValidate="TextBox1" runat="server"
         ErrorMessage="Only Numbers allowed"
         ValidationExpression="\d+">
</asp:RegularExpressionValidator>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Record" />
    <br />

</asp:Content>
