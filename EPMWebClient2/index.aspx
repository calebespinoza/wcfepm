<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="EPMWebClient2.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="border:1px solid">
    
        <h1 style="text-align: center">EPM System</h1>
        <h3>Authentication</h3>
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
    
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" runat="server" onclick="btnLogin_Click" 
            Text="LogIn" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Visible="False" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
