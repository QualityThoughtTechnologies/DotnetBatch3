<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="MyFirstWebSite.registration" %>

<form id="form1" runat="server">
  A  <asp:TextBox ID="txtFirstName" Text="Hello" runat="server"></asp:TextBox>
    <p>
   B  <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </p>
    <asp:Button ID="btnSubmit" OnClick="btnSubmit_Click" runat="server" Text="Calculate" />
</form>

