<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CDProjektRED.Index" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <header>
        <script src="jquery-3.3.1.min.js"></script>
    </header>
    <h2><%: Title %>.</h2>
    <div class="row">
        <div class="col-md-8">
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>Use a local administrator account to log in.<asp:ScriptManager ID="ScriptManager1" runat="server">
                        </asp:ScriptManager>
                    </h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label">Admin Account Name</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="The user name field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                        </div>
                    </div>
                    <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Login" />
                </div>
            </section>
        </div>

    </div>
</asp:Content>
