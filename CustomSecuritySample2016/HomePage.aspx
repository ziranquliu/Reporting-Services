<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Microsoft.Samples.ReportingServices.CustomSecurity.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>主页</title>
    <link rel='icon' href="favicon.ico" />
    <base href="<%=HttpContext.Current.Request.ApplicationPath %>/"/>
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
    <!-- 路由界面 -->
    <div class="container" ui-view></div>
    <script data-main="./scripts/main.js" src="/powerbi/libs/scripts/require.js" type="text/javascript"></script>
</body>
</html>