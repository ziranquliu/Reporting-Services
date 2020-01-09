<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Microsoft.Samples.ReportingServices.CustomSecurity.HomePage" %>
<%@ Import Namespace="Microsoft.Samples.ReportingServices.CustomSecurity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 40%; float: left; border-right: 1px dotted; overflow-y: scroll; height: 550px;">
            <asp:TextBox ID="tb" runat="server"></asp:TextBox>
            <asp:Button ID="btnDelFolder" runat="server" Text="删除目录" OnClick="btnDelFolder_Click" />
            <asp:Button ID="btnAddFolder" runat="server" Text="新增目录" OnClick="btnAddFolder_Click" />
            <br />
            <%  
                // Folder,PowerBIReport,Report
                List<CatalogItemExt> items = GetCatalog();
                foreach (CatalogItemExt item in items)
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
        <a href="javascript:void(0);" onclick="document.getElementById('frame').src='LoadPBI.aspx?s=http://10.86.65.20/reports/powerbi<%=item.Path %>?rs:embed=true&t=<%=item.Name %>&id=<%=item.ID %>'"><%=item.Name %></a><br />
            <%
                    break;
                case "Report":
            %>
                           &nbsp;&nbsp;&nbsp;&nbsp;
        <a href="javascript:void(0);" onclick="document.getElementById('frame').src='LoadPBI.aspx?s=http://10.86.65.20/reports/powerbi<%=item.Path %>?rs:embed=true&t=<%=item.Name %>&id=<%=item.ID %>'"><%=item.Name %></a><br />
            <%
                        break;
                    default:
                        break;
                }
            %>
            <%
                }
            %>
        </div>
        <div style="left: 41%; width: 60%; float: right; z-index: 9999; position: fixed ! important;">
            <iframe id="frame" style="width: 97%; height: 550px; border: 1px solid gray;" src="LoadPBI.aspx"></iframe>
        </div>
    </form>
    <div style="float:left; bottom:5px; position:absolute; font-size:11px;">
        <%=Service2010.GetReportServerConfigInfo(true) %> 
        <%=GetSecurityScopes() %>
        <%=GetModelItemTypes() %>
        <%=GetItemTypes() %>
    </div>
</body>
</html>
