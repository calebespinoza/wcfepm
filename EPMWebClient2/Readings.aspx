<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Readings.aspx.cs" Inherits="EPMWebClient2.Readings" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1 style="text-align: center; height: 43px;">READINGS</h1>
        <br />
        <asp:Label ID="labelUser" runat="server" Text="User: "></asp:Label>
        
        <asp:Label ID="lblUser" runat="server"></asp:Label>
        &nbsp;
        <asp:LinkButton ID="lbtnLogOut" runat="server" onclick="lbtnLogOut_Click">Log Out</asp:LinkButton>
        <br />
        <br />
        <h3>Current Readings</h3>

        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="ID Client: "></asp:Label>
        <asp:TextBox ID="txtIDClient" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnSearch" runat="server" onclick="btnSearch_Click" 
            Text="Search" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Phone: " Visible="False"></asp:Label>
&nbsp;<asp:Label ID="lblPhone" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Current Readings: " Visible="False"></asp:Label>
        <asp:Label ID="lblCurrentReadings" runat="server" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:CheckBox ID="chbRead" runat="server" Enabled="False" Text="It has Read." 
            Visible="False" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="New Reading: " Visible="False"></asp:Label>
        <asp:TextBox ID="txtNewReading" runat="server" Visible="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
            Text="Update" Visible="False" />

    </div>
    </form>
</body>
</html>
