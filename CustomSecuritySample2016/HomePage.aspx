<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Microsoft.Samples.ReportingServices.CustomSecurity.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>主页</title>
    <link rel='icon' href="favicon.ico" />
    <script src="/powerbi/libs/scripts/jquery.js" type="text/javascript"></script>
    <script src="/powerbi/libs/scripts/angular.js" type="text/javascript"></script>
    <script src="/powerbi/libs/scripts/require.js" type="text/javascript"></script>
    <script type="text/javascript">
        var ref = "<%= Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery,"") %>/Reports/api/v2.0";
    </script>
    <style type="text/css">
        dl {
        }

        dt {
            margin-inline-start: 40px;
        }

        dd {
        }
    </style>
</head>
<body>
    <form id="form1">
        <div style="width: 40%; float: left; border-right: 1px dotted; overflow-y: scroll; height: 550px;">
            <input type="text" id="tbfolder" />
            <input type="button" id="btnAddFolder" onclick="addFolder()" value="新增目录" />
            <br />
            <input type="file" id="upfile" onchange="upload1(this.files[0])" />
            <div id="list"><img src="/Reports/assets/img/spinner.gif" /></div>
            <script type="text/javascript">
                var rooturl = ref + "/CatalogItems";
                require.config({
                    baseUrl: "./scripts/pbirs/src",
                    paths: {
                        'pbirs': "index"
                    }

                });
                require(['pbirs'], function (res) {
                    //console.dir(res)
                    var cataLogItem = new res.CatalogItemsApi()
                    var opts = {};
                    //opts.top = 56;
                    //opts.skip = 56;
                    //opts.filter = "filter_example";
                    //opts.count = "count_example";
                    //opts.orderBy = "orderBy_example";
                    //opts.select = "select_example";
                    cataLogItem.getCatalogItems(opts, function (error, data, response) {
                        $("#list").empty();
                        for (index in data.value) {
                            var obj = data.value[index];
                            if (!obj.parentFolderId) {
                                $("#list").append("<dl><span onclick=\"loadChild(this,'" + obj.id + "')\">" + obj.name
                                    + "</span>&nbsp;|&nbsp;<button onclick=\"Delete(this,'" + obj.id + "')\">删除</button></dl>");
                            }
                        }
                    });
                })
                function addFolder() {
                    if ($("#tbfolder").val()) {
                        $.ajax({
                            url: rooturl,
                            type: 'POST',
                            data: JSON.stringify({
                                "@odata.type": "#Model.Folder",
                                "Name": $("#tbfolder").val(),
                                "Path": "/" + $("#tbfolder").val()
                            }),
                            contentType: 'application/json; charset=utf-8',
                            dataType: 'json',
                            async: false,
                            success: function (msg) {
                                location.reload();
                            }
                        }).done(function (res) {
                        }).fail(function (res) { });
                    }
                }

                function upload1(objfile) {
                    var reader = new FileReader()
                    reader.readAsText(objfile);
                    reader.onload = function () {
                        $.ajax({
                            url: rooturl,
                            type: 'POST',
                            data: JSON.stringify({
                                "@odata.type": "#Model.PowerBIReport",
                                "Content": this.result,
                                "ContentType": "",
                                "Name": objfile["name"],
                                "Path": "/" + objfile["name"]
                            }),
                            contentType: 'application/json; charset=utf-8',
                            dataType: 'json',
                            async: false,
                            success: function (msg) {
                                alert("ook")
                            },
                            error: function (msg) {
                                debugger
                            }
                        }).done(function (res) {
                            debugger;
                        }).fail(function (res) {
                            debugger
                        });
                    }
                }

                function loadChild(obj, id) {
                    var url = ref + "/catalogitems(" + id + ")/Model.Folder/catalogitems/?$orderby=name%20ASC";
                    $.get(url, function (data) {
                        $(obj).parent().find("dt").remove();
                        $(obj).parent().find("dd").remove();
                        for (index in data.value) {
                            if (data.value[index].Type === "Folder") {
                                $(obj).parent().append("<dt><span onclick=\"loadChild(this,'" + data.value[index].Id + "')\">" + data.value[index].Name + "</span>&nbsp;|&nbsp;<button onclick=\"Delete(this,'" + data.value[index].Id + "')\">删除</button></dt>");
                            } else {
                                $(obj).parent().append("<dd><a href='javascript:void(0);' onclick=\"document.getElementById('frame').src='/reports/powerbi" + data.value[index].Path + "?rs:embed=true';\">" + data.value[index].Name + "</a>&nbsp;|&nbsp;<button onclick=\"Delete(this,'" + data.value[index].Id + "')\">删除</button></dd>");
                            }
                        }
                    });
                }

                function Delete(obj, id) {
                    var url = ref + "/catalogitems(" + id + ")";
                    $.ajax({
                        url: url,
                        type: 'DELETE',
                        success: function (result) {
                            $(obj).parent("dt").remove();
                        }
                    });
                }
            </script>
        </div>
        <div style="left: 41%; width: 60%; float: right; z-index: 9999; position: fixed ! important;">
            <iframe id="frame" style="width: 97%; height: 550px; border: 1px solid gray;"></iframe>
        </div>
        <div style="right: 10px; bottom: 5px; position: absolute;">
            <a href="javascript:void(0);" onclick="window.document.location.href='<%=domain %>/logout?redirect_login=true'">退出</a>
        </div>
    </form>
</body>
</html>
