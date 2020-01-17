define(['app', 'jquery', 'CatalogItemsApi', 'FoldersApi', 'model/CatalogItem'], 
    function (app,$,CatalogItemsApi,FoldersApi,CatalogItem) {
        app.controller('folderCtrl', function($scope) {
            $scope.newname = "";
            $scope.add = function() {
                var newname=$scope.newname;
                if (newname) {
                    var folders = new FoldersApi();
                    var body = new CatalogItem();
                    body.Name = newname;
                    body.Path = "/"+newname;
                    folders.addFolder(body, function(error, data, response) {
                        if(error==null){
                            location.reload();
                        }
                    });
                }
        }
        });

        app.controller('CatalogItems', function ($scope) {

            //console.dir(res)
            var cataLogItem = new CatalogItemsApi();
            var opts = {};
            //opts.top = 56;
            //opts.skip = 56;
            //opts.filter = "filter_example";
            //opts.count = "count_example";
            opts.orderBy = "path";
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
    });
});

//function upload1(objfile) {
//    var reader = new FileReader()
//    reader.readAsText(objfile);
//    reader.onload = function () {
//        $.ajax({
//            url: rooturl,
//            type: 'POST',
//            data: JSON.stringify({
//                "@odata.type": "#Model.PowerBIReport",
//                "Content": this.result,
//                "ContentType": "",
//                "Name": objfile["name"],
//                "Path": "/" + objfile["name"]
//            }),
//            contentType: 'application/json; charset=utf-8',
//            dataType: 'json',
//            async: false,
//            success: function (msg) {
//                alert("ook")
//            },
//            error: function (msg) {
//                debugger
//            }
//        }).done(function (res) {
//            debugger;
//        }).fail(function (res) {
//            debugger
//        });
//    }
//}

//function loadChild(obj, id) {
//    var url = ref + "/catalogitems(" + id + ")/Model.Folder/catalogitems/?$orderby=name%20ASC";
//    $.get(url, function (data) {
//        $(obj).parent().find("dt").remove();
//        $(obj).parent().find("dd").remove();
//        for (index in data.value) {
//            if (data.value[index].Type === "Folder") {
//                $(obj).parent().append("<dt><span onclick=\"loadChild(this,'" + data.value[index].Id + "')\">" + data.value[index].Name + "</span>&nbsp;|&nbsp;<button onclick=\"Delete(this,'" + data.value[index].Id + "')\">删除</button></dt>");
//            } else {
//                $(obj).parent().append("<dd><a href='javascript:void(0);' onclick=\"document.getElementById('frame').src='/reports/powerbi" + data.value[index].Path + "?rs:embed=true';\">" + data.value[index].Name + "</a>&nbsp;|&nbsp;<button onclick=\"Delete(this,'" + data.value[index].Id + "')\">删除</button></dd>");
//            }
//        }
//    });
//}

//function Delete(obj, id) {
//    var url = ref + "/catalogitems(" + id + ")";
//    $.ajax({
//        url: url,
//        type: 'DELETE',
//        success: function (result) {
//            $(obj).parent("dt").remove();
//        }
//    });
//}