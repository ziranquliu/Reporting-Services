<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Microsoft.Samples.ReportingServices.CustomSecurity.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>主页</title>
    <link rel='icon' href="favicon.ico" />
    <script src="/powerbi/libs/scripts/jquery.js" type="text/javascript"></script>
    <script src="/powerbi/libs/scripts/angular.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 40%; float: left; border-right: 1px dotted; overflow-y: scroll; height: 550px;">
            <asp:TextBox ID="tbFolder" runat="server"></asp:TextBox>
            <asp:Button ID="btnAddFolder" runat="server" Text="新增目录" OnClick="btnAddFolder_Click" />
            <asp:Button ID="btnDelFolder" runat="server" Text="删除目录" OnClick="btnDelFolder_Click" />
            <br />
            <dl id="list"></dl>
            <script type="text/javascript">
                $(function () {
                    LoadRoot();
                });

                function LoadRoot() {
                    var rootid = "c6c3d333-439d-4293-b464-f8d5a8b8d1c8";
                    var url = "http://bji065-l7338977/Reports/api/v2.0/catalogitems(" + rootid + ")/Model.Folder/catalogitems/?$orderby=name%20ASC";
                    $.get(url, function (data) {
                        $("#list").empty();
                        for (index in data.value) {
                            $("#list").append("<dt><span onclick=\"loadChild(this,'" + data.value[index].Id + "')\">" + data.value[index].Name + "</span></dt>");
                        }
                    });
                }

                function loadChild(obj, id) {
                    var url = "http://bji065-l7338977/Reports/api/v2.0/catalogitems(" + id + ")/Model.Folder/catalogitems/?$orderby=name%20ASC";
                    $.get(url, function (data) {
                        $(obj).parent().find("dd").remove();
                        for (index in data.value) {
                            $(obj).parent().append("<dd><a href='javascript:void(0);' onclick=\"document.getElementById('frame').src='/reports/powerbi" + data.value[index].Path + "?rs:embed=true';\">" + data.value[index].Name + "</a></dd>");
                        }
                    });
                }

                function Delete(obj,id) {
                    var url = "http://bji065-l7338977/Reports/api/v2.0/catalogitems(" + id + ")";
                    $.ajax({
                        url: url,
                        type: 'DELETE',
                        success: function (result) {
                            $(obj).remove();
                        }
                    });
                }
            </script>
        </div>
        <div style="left: 41%; width: 60%; float: right; z-index: 9999; position: fixed ! important;">
            <iframe id="frame" style="width: 97%; height: 550px; border: 1px solid gray;"></iframe>
        </div>
        <script src="/Reports/assets/js/oauth.js"></script>
        <script src="/Reports/assets/js/app-443dcad0-751c-4017-ab6c-ae6cac983fd6.js"></script>
        <div style="right: 10px; bottom: 5px; position: absolute;">
            <a href="javascript:void(0);" onclick="window.document.location.href='<%=domain %>/logout?redirect_login=true'">退出</a>
        </div>
    </form>
</body>
</html>
