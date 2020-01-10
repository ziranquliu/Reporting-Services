<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoadPBI.aspx.cs" Inherits="CustomSecuritySampleWeb.LoadPBI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title><%=Request["t"] %></title>
    <script src="js/app-443dcad0-751c-4017-ab6c-ae6cac983fd6.js" type="text/javascript"></script>
</head>
<body>
    <form runat="server">
        <table>
            <tr>
                <td>
                    <a href="javascript:void(0);" onclick="print()" role="button">打印
                    </a>
                </td>
            </tr>
        </table>
        <iframe id="frame" allowfullscreen="true" style="width: 100%; height: 500px; border: 0px;" src="<%=Request["s"] %>"></iframe>
    </form>
</body>
</html>
