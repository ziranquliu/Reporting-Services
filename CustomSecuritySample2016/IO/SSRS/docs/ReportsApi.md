# IO.SSRS.Swagger.Api.ReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddReport**](ReportsApi.md#addreport) | **POST** /Reports | Creates a new Report CatalogItem.
[**AddReportComment**](ReportsApi.md#addreportcomment) | **POST** /Reports({Id})/Comments | Creates a new Comment associated to the specified Report.
[**AddReportHistorySnapshot**](ReportsApi.md#addreporthistorysnapshot) | **POST** /Reports({Id})/HistorySnapshots | Creates new HistorySnapshot
[**CheckReportDataSourceConnection**](ReportsApi.md#checkreportdatasourceconnection) | **POST** /Reports({Id})/Model.CheckDataSourceConnection | Checks the status of the specified Reports DataSource connection.
[**DeleteReport**](ReportsApi.md#deletereport) | **DELETE** /Reports({Id}) | Deletes the specified Report.
[**DeleteReportComment**](ReportsApi.md#deletereportcomment) | **DELETE** /Reports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the Report.
[**DeleteReportHistorySnapshot**](ReportsApi.md#deletereporthistorysnapshot) | **DELETE** /Reports({Id})/HistorySnapshots({HistoryId}) | Deletes the requested Reports HistorySnapshot specified by HistoryId.
[**GetReport**](ReportsApi.md#getreport) | **GET** /Reports({Id}) | Gets a Report CatalogItem specified by the Id.
[**GetReportAllowedActions**](ReportsApi.md#getreportallowedactions) | **GET** /Reports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetReportCacheOptions**](ReportsApi.md#getreportcacheoptions) | **GET** /Reports({Id})/CacheOptions | Gets the content of CacheOptions for the Report specified by the Id
[**GetReportCacheRefreshPlans**](ReportsApi.md#getreportcacherefreshplans) | **GET** /Reports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for the Report specified by the Id
[**GetReportComments**](ReportsApi.md#getreportcomments) | **GET** /Reports({Id})/Comments | Gets the Comments for a Report specified by the Id.
[**GetReportContent**](ReportsApi.md#getreportcontent) | **GET** /Reports({Id})/Content/$value | Gets the content of the specified Report CatalogItem specified by the Id.
[**GetReportDataSources**](ReportsApi.md#getreportdatasources) | **GET** /Reports({Id})/DataSources | Gets the DataSources associated with the Report specified by the Id.
[**GetReportDependentItems**](ReportsApi.md#getreportdependentitems) | **GET** /Reports({Id})/DependentItems | Returns a list of CatalogItems that reference the Report specified by the Id.
[**GetReportHistorySnapshot**](ReportsApi.md#getreporthistorysnapshot) | **GET** /Reports({Id})/HistorySnapshots({HistoryId}) | Gets the requested Reports HistorySnapshot specified by HistoryId.
[**GetReportHistorySnapshotOptions**](ReportsApi.md#getreporthistorysnapshotoptions) | **GET** /Reports({Id})/HistorySnapshotOptions | Gets the HistorySnapshotOptions for the specified Report.
[**GetReportHistorySnapshots**](ReportsApi.md#getreporthistorysnapshots) | **GET** /Reports({Id})/HistorySnapshots | Get a list of HistorySnapshots for the specified Report.
[**GetReportParameterDefinitions**](ReportsApi.md#getreportparameterdefinitions) | **GET** /Reports({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the Report specified by the Id.
[**GetReportPolicies**](ReportsApi.md#getreportpolicies) | **GET** /Reports({Id})/Policies | Gets policies associated with the specified Report CatalogItem.
[**GetReportProperties**](ReportsApi.md#getreportproperties) | **GET** /Reports({Id})/Properties | Gets the specified Reports Properties (takes list of Property names to retrieve the values)
[**GetReportSharedDataSets**](ReportsApi.md#getreportshareddatasets) | **GET** /Reports({Id})/SharedDataSets | Gets the shared DataSets for the specified Report.
[**GetReportSubscriptions**](ReportsApi.md#getreportsubscriptions) | **GET** /Reports({Id})/Subscriptions | Gets the Subscriptions for the specified Report.
[**GetReports**](ReportsApi.md#getreports) | **GET** /Reports | Gets an array of Report CatalogItems.
[**SetReportCacheOptions**](ReportsApi.md#setreportcacheoptions) | **PUT** /Reports({Id})/CacheOptions | Replaces the CacheOptions content for a given Report using the provided definition.
[**SetReportDataSource**](ReportsApi.md#setreportdatasource) | **PUT** /Reports({Id})/DataSources | Updates the DataSource definition associated with the Report specified by the Id.
[**SetReportHistorySnapshotOptions**](ReportsApi.md#setreporthistorysnapshotoptions) | **PUT** /Reports({Id})/HistorySnapshotOptions | Updates HistorySnapshotOptions for the specified Report.
[**SetReportPolicies**](ReportsApi.md#setreportpolicies) | **PUT** /Reports({Id})/Policies | Replaces ItemPolicies associated with the Report specified by the Id.
[**SetReportSharedDataSets**](ReportsApi.md#setreportshareddatasets) | **PUT** /Reports({Id})/SharedDataSets | Updates the DataSet definitions associated with the specified Report.
[**UpdateCacheSnapshot**](ReportsApi.md#updatecachesnapshot) | **POST** /Reports({Id})/Model.UpdateCacheSnapshot | Updates the execution cache snapshot for the specified report.
[**UpdateReport**](ReportsApi.md#updatereport) | **PATCH** /Reports({Id}) | Updates the specified Report CatalogItem using the provided definition.
[**UpdateReportComment**](ReportsApi.md#updatereportcomment) | **PUT** /Reports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated Report.
[**UpdateReportParameterDefinitions**](ReportsApi.md#updatereportparameterdefinitions) | **PATCH** /Reports({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the Report specified by Id.
[**UpdateReportProperties**](ReportsApi.md#updatereportproperties) | **PUT** /Reports({Id})/Properties | Updates the Report Properties included in the given list.


<a name="addreport"></a>
# **AddReport**
> Report AddReport (Report report)

Creates a new Report CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var report = new Report(); // Report | The definition of the new Report CatalogItem.

            try
            {
                // Creates a new Report CatalogItem.
                Report result = apiInstance.AddReport(report);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.AddReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **report** | [**Report**](Report.md)| The definition of the new Report CatalogItem. | 

### Return type

[**Report**](Report.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addreportcomment"></a>
# **AddReportComment**
> void AddReportComment (string id, Comment comment)

Creates a new Comment associated to the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var comment = new Comment(); // Comment | The Comment to be created

            try
            {
                // Creates a new Comment associated to the specified Report.
                apiInstance.AddReportComment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.AddReportComment: " + e.Message );
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

<a name="addreporthistorysnapshot"></a>
# **AddReportHistorySnapshot**
> bool? AddReportHistorySnapshot (string id)

Creates new HistorySnapshot

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Creates new HistorySnapshot
                bool? result = apiInstance.AddReportHistorySnapshot(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.AddReportHistorySnapshot: " + e.Message );
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

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkreportdatasourceconnection"></a>
# **CheckReportDataSourceConnection**
> DataSourceCheckResult CheckReportDataSourceConnection (string id, string dataSourceName)

Checks the status of the specified Reports DataSource connection.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class CheckReportDataSourceConnectionExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSourceName = dataSourceName_example;  // string | The name of the DataSource to check.

            try
            {
                // Checks the status of the specified Reports DataSource connection.
                DataSourceCheckResult result = apiInstance.CheckReportDataSourceConnection(id, dataSourceName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.CheckReportDataSourceConnection: " + e.Message );
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

<a name="deletereport"></a>
# **DeleteReport**
> void DeleteReport (string id)

Deletes the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified Report.
                apiInstance.DeleteReport(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteReport: " + e.Message );
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

<a name="deletereportcomment"></a>
# **DeleteReportComment**
> void DeleteReportComment (string id, string commentId)

Deletes the specified Comment associated to the Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the Report.
                apiInstance.DeleteReportComment(id, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteReportComment: " + e.Message );
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

<a name="deletereporthistorysnapshot"></a>
# **DeleteReportHistorySnapshot**
> bool? DeleteReportHistorySnapshot (string id, string historyId)

Deletes the requested Reports HistorySnapshot specified by HistoryId.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = historyId_example;  // string | The ID property of the HistorySnapshot

            try
            {
                // Deletes the requested Reports HistorySnapshot specified by HistoryId.
                bool? result = apiInstance.DeleteReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.DeleteReportHistorySnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **historyId** | **string**| The ID property of the HistorySnapshot | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreport"></a>
# **GetReport**
> Report GetReport (string id)

Gets a Report CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a Report CatalogItem specified by the Id.
                Report result = apiInstance.GetReport(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReport: " + e.Message );
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

[**Report**](Report.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportallowedactions"></a>
# **GetReportAllowedActions**
> ODataAllowedActions GetReportAllowedActions (string id)

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportAllowedActions: " + e.Message );
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

<a name="getreportcacheoptions"></a>
# **GetReportCacheOptions**
> CacheOptions GetReportCacheOptions (string id)

Gets the content of CacheOptions for the Report specified by the Id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of CacheOptions for the Report specified by the Id
                CacheOptions result = apiInstance.GetReportCacheOptions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportCacheOptions: " + e.Message );
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

[**CacheOptions**](CacheOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportcacherefreshplans"></a>
# **GetReportCacheRefreshPlans**
> ODataCacheRefreshPlans GetReportCacheRefreshPlans (string id)

Gets the CacheRefreshPlans for the Report specified by the Id

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportCacheRefreshPlansExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheRefreshPlans for the Report specified by the Id
                ODataCacheRefreshPlans result = apiInstance.GetReportCacheRefreshPlans(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportCacheRefreshPlans: " + e.Message );
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

<a name="getreportcomments"></a>
# **GetReportComments**
> ODataComments GetReportComments (string id)

Gets the Comments for a Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a Report specified by the Id.
                ODataComments result = apiInstance.GetReportComments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportComments: " + e.Message );
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

<a name="getreportcontent"></a>
# **GetReportContent**
> System.IO.Stream GetReportContent (string id)

Gets the content of the specified Report CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportContentExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified Report CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetReportContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportContent: " + e.Message );
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

<a name="getreportdatasources"></a>
# **GetReportDataSources**
> ODataDataSources GetReportDataSources (string id)

Gets the DataSources associated with the Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportDataSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the DataSources associated with the Report specified by the Id.
                ODataDataSources result = apiInstance.GetReportDataSources(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportDataSources: " + e.Message );
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

<a name="getreportdependentitems"></a>
# **GetReportDependentItems**
> ODataDependentItems GetReportDependentItems (string id)

Returns a list of CatalogItems that reference the Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportDependentItemsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Returns a list of CatalogItems that reference the Report specified by the Id.
                ODataDependentItems result = apiInstance.GetReportDependentItems(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportDependentItems: " + e.Message );
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

[**ODataDependentItems**](ODataDependentItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreporthistorysnapshot"></a>
# **GetReportHistorySnapshot**
> HistorySnapshot GetReportHistorySnapshot (string id, string historyId)

Gets the requested Reports HistorySnapshot specified by HistoryId.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = historyId_example;  // string | The ID property of the HistorySnapshot

            try
            {
                // Gets the requested Reports HistorySnapshot specified by HistoryId.
                HistorySnapshot result = apiInstance.GetReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportHistorySnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **historyId** | **string**| The ID property of the HistorySnapshot | 

### Return type

[**HistorySnapshot**](HistorySnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreporthistorysnapshotoptions"></a>
# **GetReportHistorySnapshotOptions**
> HistorySnapshotOptions GetReportHistorySnapshotOptions (string id)

Gets the HistorySnapshotOptions for the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportHistorySnapshotOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the HistorySnapshotOptions for the specified Report.
                HistorySnapshotOptions result = apiInstance.GetReportHistorySnapshotOptions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportHistorySnapshotOptions: " + e.Message );
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

[**HistorySnapshotOptions**](HistorySnapshotOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreporthistorysnapshots"></a>
# **GetReportHistorySnapshots**
> List<HistorySnapshot> GetReportHistorySnapshots (string id)

Get a list of HistorySnapshots for the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportHistorySnapshotsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Get a list of HistorySnapshots for the specified Report.
                List&lt;HistorySnapshot&gt; result = apiInstance.GetReportHistorySnapshots(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportHistorySnapshots: " + e.Message );
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

[**List<HistorySnapshot>**](HistorySnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportparameterdefinitions"></a>
# **GetReportParameterDefinitions**
> ODataReportParameterDefinitions GetReportParameterDefinitions (string id)

Gets the ParameterDefinitions associated with the Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the ParameterDefinitions associated with the Report specified by the Id.
                ODataReportParameterDefinitions result = apiInstance.GetReportParameterDefinitions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportParameterDefinitions: " + e.Message );
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

[**ODataReportParameterDefinitions**](ODataReportParameterDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportpolicies"></a>
# **GetReportPolicies**
> List<ItemPolicy> GetReportPolicies (string id)

Gets policies associated with the specified Report CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets policies associated with the specified Report CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportPolicies: " + e.Message );
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

<a name="getreportproperties"></a>
# **GetReportProperties**
> ODataProperties GetReportProperties (string id, List<string> properties)

Gets the specified Reports Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets the specified Reports Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportProperties: " + e.Message );
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

<a name="getreportshareddatasets"></a>
# **GetReportSharedDataSets**
> List<DataSet> GetReportSharedDataSets (string id)

Gets the shared DataSets for the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportSharedDataSetsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the shared DataSets for the specified Report.
                List&lt;DataSet&gt; result = apiInstance.GetReportSharedDataSets(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportSharedDataSets: " + e.Message );
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

[**List<DataSet>**](DataSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreportsubscriptions"></a>
# **GetReportSubscriptions**
> List<Subscription> GetReportSubscriptions (string id, int? top, int? skip, string filter, string count, string orderBy, string expand, string select)

Gets the Subscriptions for the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportSubscriptionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var expand = expand_example;  // string | Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets the Subscriptions for the specified Report.
                List&lt;Subscription&gt; result = apiInstance.GetReportSubscriptions(id, top, skip, filter, count, orderBy, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReportSubscriptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **top** | **int?**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **int?**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **string**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **string**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **string**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **expand** | **string**| Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) | [optional] 
 **select** | **string**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**List<Subscription>**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreports"></a>
# **GetReports**
> ODataReports GetReports (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of Report CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetReportsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of Report CatalogItems.
                ODataReports result = apiInstance.GetReports(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.GetReports: " + e.Message );
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

[**ODataReports**](ODataReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setreportcacheoptions"></a>
# **SetReportCacheOptions**
> void SetReportCacheOptions (string id, CacheOptions cacheOptions)

Replaces the CacheOptions content for a given Report using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetReportCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var cacheOptions = new CacheOptions(); // CacheOptions | Updated definition for the CacheOptions content associated with the given Report.

            try
            {
                // Replaces the CacheOptions content for a given Report using the provided definition.
                apiInstance.SetReportCacheOptions(id, cacheOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SetReportCacheOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheOptions** | [**CacheOptions**](CacheOptions.md)| Updated definition for the CacheOptions content associated with the given Report. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setreportdatasource"></a>
# **SetReportDataSource**
> void SetReportDataSource (string id, DataSource dataSource)

Updates the DataSource definition associated with the Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetReportDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSource = new DataSource(); // DataSource | Updated definition for the DataSource associated with the Report specified by the Id.

            try
            {
                // Updates the DataSource definition associated with the Report specified by the Id.
                apiInstance.SetReportDataSource(id, dataSource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SetReportDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSource** | [**DataSource**](DataSource.md)| Updated definition for the DataSource associated with the Report specified by the Id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setreporthistorysnapshotoptions"></a>
# **SetReportHistorySnapshotOptions**
> void SetReportHistorySnapshotOptions (string id, HistorySnapshotOptions historySnapshotOptions)

Updates HistorySnapshotOptions for the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetReportHistorySnapshotOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historySnapshotOptions = new HistorySnapshotOptions(); // HistorySnapshotOptions | Modified HistorySnapshotOptions object.

            try
            {
                // Updates HistorySnapshotOptions for the specified Report.
                apiInstance.SetReportHistorySnapshotOptions(id, historySnapshotOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SetReportHistorySnapshotOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **historySnapshotOptions** | [**HistorySnapshotOptions**](HistorySnapshotOptions.md)| Modified HistorySnapshotOptions object. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setreportpolicies"></a>
# **SetReportPolicies**
> void SetReportPolicies (string id, List<ItemPolicy> itemPolicies)

Replaces ItemPolicies associated with the Report specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicies = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the Report specified by the Id.
                apiInstance.SetReportPolicies(id, itemPolicies);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SetReportPolicies: " + e.Message );
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

<a name="setreportshareddatasets"></a>
# **SetReportSharedDataSets**
> void SetReportSharedDataSets (string id, List<DataSet> dataSets)

Updates the DataSet definitions associated with the specified Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetReportSharedDataSetsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSets = new List<DataSet>(); // List<DataSet> | Updated DataSet definitions for the specified Report.

            try
            {
                // Updates the DataSet definitions associated with the specified Report.
                apiInstance.SetReportSharedDataSets(id, dataSets);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.SetReportSharedDataSets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSets** | [**List<DataSet>**](DataSet.md)| Updated DataSet definitions for the specified Report. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecachesnapshot"></a>
# **UpdateCacheSnapshot**
> UpdateCacheSnapshotResult UpdateCacheSnapshot (string id)

Updates the execution cache snapshot for the specified report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateCacheSnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Updates the execution cache snapshot for the specified report.
                UpdateCacheSnapshotResult result = apiInstance.UpdateCacheSnapshot(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.UpdateCacheSnapshot: " + e.Message );
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

[**UpdateCacheSnapshotResult**](UpdateCacheSnapshotResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereport"></a>
# **UpdateReport**
> void UpdateReport (string id, Report report)

Updates the specified Report CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateReportExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var report = new Report(); // Report | Definition of the Report item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified Report CatalogItem using the provided definition.
                apiInstance.UpdateReport(id, report);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.UpdateReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **report** | [**Report**](Report.md)| Definition of the Report item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereportcomment"></a>
# **UpdateReportComment**
> void UpdateReportComment (string id, string commentId, Comment comment)

Updates the Comment specified by CommentId in the associated Report.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.
            var comment = new Comment(); // Comment | The Comment to be updated

            try
            {
                // Updates the Comment specified by CommentId in the associated Report.
                apiInstance.UpdateReportComment(id, commentId, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.UpdateReportComment: " + e.Message );
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

<a name="updatereportparameterdefinitions"></a>
# **UpdateReportParameterDefinitions**
> void UpdateReportParameterDefinitions (string id, List<ReportParameterDefinitionPatch> parameterDefinitions)

Updates the ParameterDefinitions associated with the Report specified by Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateReportParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var parameterDefinitions = new List<ReportParameterDefinitionPatch>(); // List<ReportParameterDefinitionPatch> | Updated definitions for the ParameterDefinitions associated with the Report, represented as ParameterDefinitionsPatch object. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the ParameterDefinitions associated with the Report specified by Id.
                apiInstance.UpdateReportParameterDefinitions(id, parameterDefinitions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.UpdateReportParameterDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **parameterDefinitions** | [**List<ReportParameterDefinitionPatch>**](ReportParameterDefinitionPatch.md)| Updated definitions for the ParameterDefinitions associated with the Report, represented as ParameterDefinitionsPatch object. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereportproperties"></a>
# **UpdateReportProperties**
> void UpdateReportProperties (string id, List<Property> properties)

Updates the Report Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the Report Properties included in the given list.
                apiInstance.UpdateReportProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReportsApi.UpdateReportProperties: " + e.Message );
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

