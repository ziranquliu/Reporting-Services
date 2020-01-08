<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CustomSecuritySampleWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sql Server 2016 Reporting Services Samples</title>
    <meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1" />
    <meta name="CODE_LANGUAGE" content="C#" />
    <meta name="vs_defaultClientScript" content="JavaScript" />
    <meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5" />
</head>
<body ms_positioning="GridLayout">
    <form id="form1" method="post" runat="server">
        <asp:Label ID="LblUser" Style="z-index: 101; left: 176px; position: absolute; top: 152px" runat="server"
            Width="96px" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" meta:resourcekey="LblUserResource1">User Name:</asp:Label>
        <asp:Button ID="BtnLogon" Style="z-index: 106; left: 352px; position: absolute; top: 224px"
            runat="server" Width="104px" Text="Logon" TabIndex="3" meta:resourcekey="BtnLogonResource1" OnClick="ServerBtnLogon_Click"></asp:Button>
        <asp:TextBox ID="TxtPwd" Style="z-index: 103; left: 296px; position: absolute; top: 184px" runat="server"
            TabIndex="2" Width="160px" TextMode="Password" meta:resourcekey="TxtPwdResource1"></asp:TextBox>
        <asp:Label ID="LblPwd" Style="z-index: 102; left: 176px; position: absolute; top: 192px" runat="server"
            Width="96px" Font-Size="X-Small" Font-Names="Verdana" Font-Bold="True" meta:resourcekey="LblPwdResource1">Password:</asp:Label>
        &nbsp;
         <asp:TextBox ID="TxtUser" Style="z-index: 104; left: 296px; position: absolute; top: 152px" runat="server"
             TabIndex="1" Width="160px" meta:resourcekey="TxtUserResource1"></asp:TextBox>
        <asp:Label ID="lblMessage" Style="z-index: 107; left: 168px; position: absolute; top: 272px"
            runat="server" Width="321px" meta:resourcekey="lblMessageResource1"></asp:Label>
        <asp:Label ID="Label1" Style="z-index: 108; left: 120px; position: absolute; top: 96px" runat="server"
            Width="416px" Height="32px" Font-Size="Medium" Font-Names="Verdana" meta:resourcekey="Label1Resource1" Text="SQL Server  Reporting Services Sample"></asp:Label>
    </form>
</body>
</html>
