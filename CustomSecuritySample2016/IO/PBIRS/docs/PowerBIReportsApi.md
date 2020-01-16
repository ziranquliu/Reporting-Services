# IO.PBIRS.Swagger.Api.PowerBIReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddPowerBIReport**](PowerBIReportsApi.md#addpowerbireport) | **POST** /PowerBIReports | Creates a new PowerBIReport CatalogItem.
[**AddPowerBIReportComment**](PowerBIReportsApi.md#addpowerbireportcomment) | **POST** /PowerBIReports({Id})/Comments | Creates a new Comment associated to the specified PowerBIReport.
[**CheckPowerBIReportDataSourceConnection**](PowerBIReportsApi.md#checkpowerbireportdatasourceconnection) | **POST** /PowerBIReports({Id})/Model.CheckDataSourceConnection | Checks the status of the specified DataSource connection.
[**DeletePowerBIReport**](PowerBIReportsApi.md#deletepowerbireport) | **DELETE** /PowerBIReports({Id}) | Deletes the specified PowerBIReport.
[**DeletePowerBIReportComment**](PowerBIReportsApi.md#deletepowerbireportcomment) | **DELETE** /PowerBIReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the PowerBIReport.
[**GetPowerBICacheRefreshPlans**](PowerBIReportsApi.md#getpowerbicacherefreshplans) | **GET** /PowerBIReports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a given Power BI Report.
[**GetPowerBIReport**](PowerBIReportsApi.md#getpowerbireport) | **GET** /PowerBIReports({Id}) | Gets a PowerBIReport CatalogItem specified by the Id.
[**GetPowerBIReportAllowedActions**](PowerBIReportsApi.md#getpowerbireportallowedactions) | **GET** /PowerBIReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetPowerBIReportComments**](PowerBIReportsApi.md#getpowerbireportcomments) | **GET** /PowerBIReports({Id})/Comments | Gets the Comments for a PowerBIReport specified by the Id.
[**GetPowerBIReportContent**](PowerBIReportsApi.md#getpowerbireportcontent) | **GET** /PowerBIReports({Id})/Content/$value | Gets the content of the specified PowerBIReport CatalogItem.
[**GetPowerBIReportDataModelRoleAssignments**](PowerBIReportsApi.md#getpowerbireportdatamodelroleassignments) | **GET** /PowerBIReports({Id})/DataModelRoleAssignments | Gets the data model role assignments that are associated with the specified PowerBIReport.
[**GetPowerBIReportDataModelRoles**](PowerBIReportsApi.md#getpowerbireportdatamodelroles) | **GET** /PowerBIReports({Id})/DataModelRoles | Gets the data model roles that are associated with the specified PowerBIReport.
[**GetPowerBIReportDataSources**](PowerBIReportsApi.md#getpowerbireportdatasources) | **GET** /PowerBIReports({Id})/DataSources | Gets the DataSources that are associated with the specified PowerBIReport.
[**GetPowerBIReportPolicies**](PowerBIReportsApi.md#getpowerbireportpolicies) | **GET** /PowerBIReports({Id})/Policies | Gets ItemPolicies associated with the specified PowerBIReport CatalogItem.
[**GetPowerBIReportProperties**](PowerBIReportsApi.md#getpowerbireportproperties) | **GET** /PowerBIReports({Id})/Properties | Gets PowerBIReports Properties (takes list of Property names to retrieve the values)
[**GetPowerBIReports**](PowerBIReportsApi.md#getpowerbireports) | **GET** /PowerBIReports | Gets an array of PowerBIReport CatalogItems.
[**ReplacePowerBIReportDataModelRoleAssignments**](PowerBIReportsApi.md#replacepowerbireportdatamodelroleassignments) | **PUT** /PowerBIReports({Id})/DataModelRoleAssignments | Replaces the data model role assignments that are associated with the specified PowerBIReport.
[**SetPowerBIReportPolicies**](PowerBIReportsApi.md#setpowerbireportpolicies) | **PUT** /PowerBIReports({Id})/Policies | Replaces ItemPolicies associated with the specified PowerBIReport item.
[**UpdatePowerBIReport**](PowerBIReportsApi.md#updatepowerbireport) | **PATCH** /PowerBIReports({Id}) | Updates the specified PowerBIReport CatalogItem using the provided definition.
[**UpdatePowerBIReportComment**](PowerBIReportsApi.md#updatepowerbireportcomment) | **PUT** /PowerBIReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated PowerBIReport.
[**UpdatePowerBIReportDataSource**](PowerBIReportsApi.md#updatepowerbireportdatasource) | **PATCH** /PowerBIReports({Id})/DataSources | Updates the DataSource definition associated with the PowerBIReport specified by the Id.
[**UpdatePowerBIReportProperties**](PowerBIReportsApi.md#updatepowerbireportproperties) | **PUT** /PowerBIReports({Id})/Properties | Updates the PowerBIReport Properties included in the given list.
[**UploadPowerBIReport**](PowerBIReportsApi.md#uploadpowerbireport) | **POST** /PowerBIReports({Id})/Model.Upload | Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addpowerbireport"></a>
# **AddPowerBIReport**
> PowerBIReport AddPowerBIReport (PowerBIReport powerBIReport)

Creates a new PowerBIReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddPowerBIReportExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var powerBIReport = new PowerBIReport(); // PowerBIReport | The definition of the new PowerBIReport CatalogItem.

            try
            {
                // Creates a new PowerBIReport CatalogItem.
                PowerBIReport result = apiInstance.AddPowerBIReport(powerBIReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.AddPowerBIReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **powerBIReport** | [**PowerBIReport**](PowerBIReport.md)| The definition of the new PowerBIReport CatalogItem. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addpowerbireportcomment"></a>
# **AddPowerBIReportComment**
> void AddPowerBIReportComment (string id, Comment comment)

Creates a new Comment associated to the specified PowerBIReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddPowerBIReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var comment = new Comment(); // Comment | The Comment to be created

            try
            {
                // Creates a new Comment associated to the specified PowerBIReport.
                apiInstance.AddPowerBIReportComment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.AddPowerBIReportComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **comment** | [**Comment**](Comment.md)| The Comment to be created | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkpowerbireportdatasourceconnection"></a>
# **CheckPowerBIReportDataSourceConnection**
> DataSourceCheckResult CheckPowerBIReportDataSourceConnection (string id, string dataSourceName)

Checks the status of the specified DataSource connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class CheckPowerBIReportDataSourceConnectionExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSourceName = dataSourceName_example;  // string | The name of the DataSource to check.

            try
            {
                // Checks the status of the specified DataSource connection.
                DataSourceCheckResult result = apiInstance.CheckPowerBIReportDataSourceConnection(id, dataSourceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.CheckPowerBIReportDataSourceConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceName** | **string**| The name of the DataSource to check. | 

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepowerbireport"></a>
# **DeletePowerBIReport**
> void DeletePowerBIReport (string id)

Deletes the specified PowerBIReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeletePowerBIReportExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified PowerBIReport.
                apiInstance.DeletePowerBIReport(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.DeletePowerBIReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepowerbireportcomment"></a>
# **DeletePowerBIReportComment**
> void DeletePowerBIReportComment (string id, string commentId)

Deletes the specified Comment associated to the PowerBIReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeletePowerBIReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the PowerBIReport.
                apiInstance.DeletePowerBIReportComment(id, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.DeletePowerBIReportComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **commentId** | **string**| The Id of the Comment. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbicacherefreshplans"></a>
# **GetPowerBICacheRefreshPlans**
> ODataCacheRefreshPlans GetPowerBICacheRefreshPlans (string id)

Gets the CacheRefreshPlans for a given Power BI Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBICacheRefreshPlansExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheRefreshPlans for a given Power BI Report.
                ODataCacheRefreshPlans result = apiInstance.GetPowerBICacheRefreshPlans(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBICacheRefreshPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataCacheRefreshPlans**](ODataCacheRefreshPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireport"></a>
# **GetPowerBIReport**
> PowerBIReport GetPowerBIReport (string id)

Gets a PowerBIReport CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a PowerBIReport CatalogItem specified by the Id.
                PowerBIReport result = apiInstance.GetPowerBIReport(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportallowedactions"></a>
# **GetPowerBIReportAllowedActions**
> ODataAllowedActions GetPowerBIReportAllowedActions (string id)

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetPowerBIReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportAllowedActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataAllowedActions**](ODataAllowedActions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportcomments"></a>
# **GetPowerBIReportComments**
> ODataComments GetPowerBIReportComments (string id)

Gets the Comments for a PowerBIReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a PowerBIReport specified by the Id.
                ODataComments result = apiInstance.GetPowerBIReportComments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportComments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataComments**](ODataComments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportcontent"></a>
# **GetPowerBIReportContent**
> System.IO.Stream GetPowerBIReportContent (string id)

Gets the content of the specified PowerBIReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportContentExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified PowerBIReport CatalogItem.
                System.IO.Stream result = apiInstance.GetPowerBIReportContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportdatamodelroleassignments"></a>
# **GetPowerBIReportDataModelRoleAssignments**
> ODataDataModelRoleAssignments GetPowerBIReportDataModelRoleAssignments (string id)

Gets the data model role assignments that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportDataModelRoleAssignmentsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the data model role assignments that are associated with the specified PowerBIReport.
                ODataDataModelRoleAssignments result = apiInstance.GetPowerBIReportDataModelRoleAssignments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportDataModelRoleAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataModelRoleAssignments**](ODataDataModelRoleAssignments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportdatamodelroles"></a>
# **GetPowerBIReportDataModelRoles**
> ODataDataModelRoles GetPowerBIReportDataModelRoles (string id)

Gets the data model roles that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportDataModelRolesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the data model roles that are associated with the specified PowerBIReport.
                ODataDataModelRoles result = apiInstance.GetPowerBIReportDataModelRoles(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportDataModelRoles: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataModelRoles**](ODataDataModelRoles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportdatasources"></a>
# **GetPowerBIReportDataSources**
> ODataDataSources GetPowerBIReportDataSources (string id)

Gets the DataSources that are associated with the specified PowerBIReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportDataSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the DataSources that are associated with the specified PowerBIReport.
                ODataDataSources result = apiInstance.GetPowerBIReportDataSources(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportDataSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataSources**](ODataDataSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportpolicies"></a>
# **GetPowerBIReportPolicies**
> List<ItemPolicy> GetPowerBIReportPolicies (string id)

Gets ItemPolicies associated with the specified PowerBIReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the specified PowerBIReport CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetPowerBIReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**List<ItemPolicy>**](ItemPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireportproperties"></a>
# **GetPowerBIReportProperties**
> ODataProperties GetPowerBIReportProperties (string id, List<string> properties)

Gets PowerBIReports Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets PowerBIReports Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetPowerBIReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReportProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<string>**](string.md)| Names for the Properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpowerbireports"></a>
# **GetPowerBIReports**
> ODataPowerBIReports GetPowerBIReports (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of PowerBIReport CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetPowerBIReportsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of PowerBIReport CatalogItems.
                ODataPowerBIReports result = apiInstance.GetPowerBIReports(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.GetPowerBIReports: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **int?**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **string**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **string**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **string**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **select** | **string**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**ODataPowerBIReports**](ODataPowerBIReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="replacepowerbireportdatamodelroleassignments"></a>
# **ReplacePowerBIReportDataModelRoleAssignments**
> void ReplacePowerBIReportDataModelRoleAssignments (string id, List<DataModelRoleAssignment> dataModelRoleAssignments)

Replaces the data model role assignments that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class ReplacePowerBIReportDataModelRoleAssignmentsExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataModelRoleAssignments = new List<DataModelRoleAssignment>(); // List<DataModelRoleAssignment> | Updated data model role assignments associated with the specified PowerBIReport.

            try
            {
                // Replaces the data model role assignments that are associated with the specified PowerBIReport.
                apiInstance.ReplacePowerBIReportDataModelRoleAssignments(id, dataModelRoleAssignments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.ReplacePowerBIReportDataModelRoleAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataModelRoleAssignments** | [**List<DataModelRoleAssignment>**](DataModelRoleAssignment.md)| Updated data model role assignments associated with the specified PowerBIReport. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setpowerbireportpolicies"></a>
# **SetPowerBIReportPolicies**
> void SetPowerBIReportPolicies (string id, List<ItemPolicy> itemPolicies)

Replaces ItemPolicies associated with the specified PowerBIReport item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetPowerBIReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicies = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the specified PowerBIReport item.
                apiInstance.SetPowerBIReportPolicies(id, itemPolicies);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.SetPowerBIReportPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **itemPolicies** | [**List<ItemPolicy>**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepowerbireport"></a>
# **UpdatePowerBIReport**
> PowerBIReport UpdatePowerBIReport (string id, PowerBIReport powerBIReport)

Updates the specified PowerBIReport CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdatePowerBIReportExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var powerBIReport = new PowerBIReport(); // PowerBIReport | Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified PowerBIReport CatalogItem using the provided definition.
                PowerBIReport result = apiInstance.UpdatePowerBIReport(id, powerBIReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.UpdatePowerBIReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **powerBIReport** | [**PowerBIReport**](PowerBIReport.md)| Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepowerbireportcomment"></a>
# **UpdatePowerBIReportComment**
> void UpdatePowerBIReportComment (string id, string commentId, Comment comment)

Updates the Comment specified by CommentId in the associated PowerBIReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdatePowerBIReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.
            var comment = new Comment(); // Comment | The Comment to be updated

            try
            {
                // Updates the Comment specified by CommentId in the associated PowerBIReport.
                apiInstance.UpdatePowerBIReportComment(id, commentId, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.UpdatePowerBIReportComment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **commentId** | **string**| The Id of the Comment. | 
 **comment** | [**Comment**](Comment.md)| The Comment to be updated | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepowerbireportdatasource"></a>
# **UpdatePowerBIReportDataSource**
> void UpdatePowerBIReportDataSource (string id, List<DataSource> dataSources)

Updates the DataSource definition associated with the PowerBIReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdatePowerBIReportDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSources = new List<DataSource>(); // List<DataSource> | Updated definition for the DataSource associated with the PowerBIReport specified by the Id.

            try
            {
                // Updates the DataSource definition associated with the PowerBIReport specified by the Id.
                apiInstance.UpdatePowerBIReportDataSource(id, dataSources);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.UpdatePowerBIReportDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSources** | [**List<DataSource>**](DataSource.md)| Updated definition for the DataSource associated with the PowerBIReport specified by the Id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatepowerbireportproperties"></a>
# **UpdatePowerBIReportProperties**
> void UpdatePowerBIReportProperties (string id, List<Property> properties)

Updates the PowerBIReport Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdatePowerBIReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the PowerBIReport Properties included in the given list.
                apiInstance.UpdatePowerBIReportProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.UpdatePowerBIReportProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<Property>**](Property.md)| The Properties that will be updated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadpowerbireport"></a>
# **UploadPowerBIReport**
> PowerBIReport UploadPowerBIReport (string id, System.IO.Stream _file)

Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UploadPowerBIReportExample
    {
        public void main()
        {
            
            var apiInstance = new PowerBIReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var _file = new System.IO.Stream(); // System.IO.Stream | The file contents.

            try
            {
                // Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
                PowerBIReport result = apiInstance.UploadPowerBIReport(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PowerBIReportsApi.UploadPowerBIReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **_file** | **System.IO.Stream**| The file contents. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

