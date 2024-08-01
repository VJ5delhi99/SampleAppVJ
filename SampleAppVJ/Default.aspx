<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SampleAppVJ._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
         body {
     padding-top: 50px;
     background-color: #f8f9fa;
 }

 .container {
     max-width: 500px;
     background-color: #ffffff;
     border-radius: 5px;
     box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
     padding: 20px;
 }

 .form-group {
     margin-bottom: 20px;
 }

 .btn {
     width: 100%;
 }
    </style>
    <div class="container">
     <h2 class="text-center mb-4">Azure AppSetting Tester</h2>
      
     <div class="form-group">
         <label for="txtDatabase">Type:</label>
         <asp:TextBox ID="txtDatabase" runat="server" CssClass="form-control"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvDatabase" runat="server" ControlToValidate="txtDatabase"
             ErrorMessage="Database name is required." Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
     </div>
     <div class="form-group">
         <label for="txtUserId">Key:</label>
         <asp:TextBox ID="txtUserId" runat="server" CssClass="form-control"></asp:TextBox>
         <asp:RequiredFieldValidator ID="rfvUserId" runat="server" ControlToValidate="txtUserId"
             ErrorMessage="User ID is required." Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
     </div> 
     <div class="form-group">
         <asp:Button ID="btnTestConnection" runat="server" Text="Test" CssClass="btn btn-primary"
             OnClick="btnTestConnection_Click" />
     </div>
     <div class="form-group">
         <asp:Label ID="lblStatus" runat="server" Text="" CssClass="text-center text-success"></asp:Label>
     </div>
      
 </div>
</asp:Content>
