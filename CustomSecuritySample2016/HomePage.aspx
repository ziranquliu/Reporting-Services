﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Microsoft.Samples.ReportingServices.CustomSecurity.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>主页</title>
    <script src="/powerbi/libs/scripts/jquery.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function () {
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 40%; float: left; border-right: 1px dotted; overflow-y: scroll; height: 550px;">
            <%--<asp:TextBox ID="tbFolder" runat="server"></asp:TextBox>
            <asp:Button ID="btnAddFolder" runat="server" Text="新增目录" OnClick="btnAddFolder_Click" />
            <asp:Button ID="btnDelFolder" runat="server" Text="删除目录" OnClick="btnDelFolder_Click" />
            <br />
            <asp:FileUpload ID="upFile" runat="server" />
            <asp:Button ID="btnUpFile" runat="server" Text="上传报表" OnClick="btnUpFile_Click" />
            <asp:Button ID="btnDelFile" runat="server" Text="删除报表" OnClick="btnDelFile_Click" />
            <br />
            <%  
                // Folder,PowerBIReport,Report
                List<CatalogItem> items = GetCatalog();
                foreach (CatalogItem item in items)
                {
                    switch (item.TypeName)
                    {
                        case "Folder":
            %>
            <%=item.Name %>
            <br />
            <%
                    break;
                case "PowerBIReport":
            %>
            &nbsp;&nbsp;&nbsp;&nbsp;
        <a href="javascript:void(0);" onclick="document.getElementById('frame').src='/reports/powerbi<%=item.Path %>?rs:embed=true'"><%=item.Name %></a><br />
            <%
                    break;
                case "Report":
            %>
                           &nbsp;&nbsp;&nbsp;&nbsp;
        <a href="javascript:void(0);" onclick="document.getElementById('frame').src='/reports/powerbi<%=item.Path %>?rs:embed=true'"><%=item.Name %></a><br />
            <%
                        break;
                    default:
                        break;
                }
            %>
            <%
                }
            %>--%>
        </div>
        <div style="left: 41%; width: 60%; float: right; z-index: 9999; position: fixed ! important;">
            <iframe id="frame" style="width: 97%; height: 550px; border: 1px solid gray;"></iframe>
        </div>
    </form>
</body>
</html>
