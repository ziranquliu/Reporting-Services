# IO.PBIRS.Swagger.Api.LinkedReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddLinkedReport**](LinkedReportsApi.md#addlinkedreport) | **POST** /LinkedReports | Creates a new LinkedReport CatalogItem.
[**AddLinkedReportComment**](LinkedReportsApi.md#addlinkedreportcomment) | **POST** /LinkedReports({Id})/Comments | Creates a new Comment associated to the specified LinkedReport.
[**AddLinkedReportHistorySnapshot**](LinkedReportsApi.md#addlinkedreporthistorysnapshot) | **POST** /LinkedReports({Id})/HistorySnapshots | Creates new HistorySnapshot
[**DeleteLinkedReport**](LinkedReportsApi.md#deletelinkedreport) | **DELETE** /LinkedReports({Id}) | Deletes the specified LinkedReport.
[**DeleteLinkedReportComment**](LinkedReportsApi.md#deletelinkedreportcomment) | **DELETE** /LinkedReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the LinkedReport.
[**DeleteLinkedReportHistorySnapshot**](LinkedReportsApi.md#deletelinkedreporthistorysnapshot) | **DELETE** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.
[**GetLinkedReport**](LinkedReportsApi.md#getlinkedreport) | **GET** /LinkedReports({Id}) | Gets a LinkedReport CatalogItem specified by the Id.
[**GetLinkedReportAllowedActions**](LinkedReportsApi.md#getlinkedreportallowedactions) | **GET** /LinkedReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetLinkedReportCacheOptions**](LinkedReportsApi.md#getlinkedreportcacheoptions) | **GET** /LinkedReports({Id})/CacheOptions | Gets the content of CacheOptions for the LinkedReport specified by the Id.
[**GetLinkedReportCacheRefreshPlans**](LinkedReportsApi.md#getlinkedreportcacherefreshplans) | **GET** /LinkedReports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a LinkedReport specified by the Id.
[**GetLinkedReportComments**](LinkedReportsApi.md#getlinkedreportcomments) | **GET** /LinkedReports({Id})/Comments | Gets the Comments for a LinkedReport specified by the Id.
[**GetLinkedReportHistorySnapshot**](LinkedReportsApi.md#getlinkedreporthistorysnapshot) | **GET** /LinkedReports({Id})/HistorySnapshots({HistoryId}) | Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.
[**GetLinkedReportHistorySnapshotOptions**](LinkedReportsApi.md#getlinkedreporthistorysnapshotoptions) | **GET** /LinkedReports({Id})/HistorySnapshotOptions | Gets HistorySnapshotOptions for the specified LinkedReport.
[**GetLinkedReportHistorySnapshots**](LinkedReportsApi.md#getlinkedreporthistorysnapshots) | **GET** /LinkedReports({Id})/HistorySnapshots | Get a list of HistorySnapshots of the LinkedReport specified by Id.
[**GetLinkedReportParameterDefinitions**](LinkedReportsApi.md#getlinkedreportparameterdefinitions) | **GET** /LinkedReports({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.
[**GetLinkedReportPolicies**](LinkedReportsApi.md#getlinkedreportpolicies) | **GET** /LinkedReports({Id})/Policies | Gets ItemPolicies associated with the specified LinkedReport CatalogItem.
[**GetLinkedReportProperties**](LinkedReportsApi.md#getlinkedreportproperties) | **GET** /LinkedReports({Id})/Properties | Gets LinkedReport Properties (takes list of Property names to retrieve the values)
[**GetLinkedReports**](LinkedReportsApi.md#getlinkedreports) | **GET** /LinkedReports | Gets an array of LinkedReport CatalogItems.
[**SetLinkedReportCacheOptions**](LinkedReportsApi.md#setlinkedreportcacheoptions) | **PUT** /LinkedReports({Id})/CacheOptions | Replaces the CacheOption&#39;s content for a given LinkedReport using the provided definition.
[**SetLinkedReportHistorySnapshotOptions**](LinkedReportsApi.md#setlinkedreporthistorysnapshotoptions) | **PUT** /LinkedReports({Id})/HistorySnapshotOptions | Updates HistorySnapshotOptions property.
[**SetLinkedReportPolicies**](LinkedReportsApi.md#setlinkedreportpolicies) | **PUT** /LinkedReports({Id})/Policies | Replaces ItemPolicies associated with the specified LinkedReport item.
[**UpdateLinkedReport**](LinkedReportsApi.md#updatelinkedreport) | **PATCH** /LinkedReports({Id}) | Updates the specified LinkedReport CatalogItem using the provided definition.
[**UpdateLinkedReportComment**](LinkedReportsApi.md#updatelinkedreportcomment) | **PUT** /LinkedReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated LinkedReport.
[**UpdateLinkedReportParameterDefinitions**](LinkedReportsApi.md#updatelinkedreportparameterdefinitions) | **PATCH** /LinkedReports({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.
[**UpdateLinkedReportProperties**](LinkedReportsApi.md#updatelinkedreportproperties) | **PUT** /LinkedReports({Id})/Properties | Updates the LinkedReport Properties included in the given list.


<a name="addlinkedreport"></a>
# **AddLinkedReport**
> LinkedReport AddLinkedReport (LinkedReport linkedReport)

Creates a new LinkedReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddLinkedReportExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var linkedReport = new LinkedReport(); // LinkedReport | The definition of the new LinkedReport CatalogItem.

            try
            {
                // Creates a new LinkedReport CatalogItem.
                LinkedReport result = apiInstance.AddLinkedReport(linkedReport);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **linkedReport** | [**LinkedReport**](LinkedReport.md)| The definition of the new LinkedReport CatalogItem. | 

### Return type

[**LinkedReport**](LinkedReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addlinkedreportcomment"></a>
# **AddLinkedReportComment**
> void AddLinkedReportComment (string id, Comment comment)

Creates a new Comment associated to the specified LinkedReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddLinkedReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var comment = new Comment(); // Comment | The Comment to be created

            try
            {
                // Creates a new Comment associated to the specified LinkedReport.
                apiInstance.AddLinkedReportComment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportComment: " + e.Message );
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

<a name="addlinkedreporthistorysnapshot"></a>
# **AddLinkedReportHistorySnapshot**
> bool? AddLinkedReportHistorySnapshot (string id)

Creates new HistorySnapshot

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddLinkedReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Creates new HistorySnapshot
                bool? result = apiInstance.AddLinkedReportHistorySnapshot(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.AddLinkedReportHistorySnapshot: " + e.Message );
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

<a name="deletelinkedreport"></a>
# **DeleteLinkedReport**
> void DeleteLinkedReport (string id)

Deletes the specified LinkedReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteLinkedReportExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified LinkedReport.
                apiInstance.DeleteLinkedReport(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReport: " + e.Message );
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

<a name="deletelinkedreportcomment"></a>
# **DeleteLinkedReportComment**
> void DeleteLinkedReportComment (string id, string commentId)

Deletes the specified Comment associated to the LinkedReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteLinkedReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the LinkedReport.
                apiInstance.DeleteLinkedReportComment(id, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportComment: " + e.Message );
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

<a name="deletelinkedreporthistorysnapshot"></a>
# **DeleteLinkedReportHistorySnapshot**
> bool? DeleteLinkedReportHistorySnapshot (string id, string historyId)

Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteLinkedReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = historyId_example;  // string | The Id property of the HistorySnapshot

            try
            {
                // Deletes a HistorySnapshot specified by HistoryId from the LinkedReport specified by Id.
                bool? result = apiInstance.DeleteLinkedReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.DeleteLinkedReportHistorySnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **historyId** | **string**| The Id property of the HistorySnapshot | 

### Return type

**bool?**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkedreport"></a>
# **GetLinkedReport**
> LinkedReport GetLinkedReport (string id)

Gets a LinkedReport CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a LinkedReport CatalogItem specified by the Id.
                LinkedReport result = apiInstance.GetLinkedReport(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReport: " + e.Message );
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

[**LinkedReport**](LinkedReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkedreportallowedactions"></a>
# **GetLinkedReportAllowedActions**
> ODataAllowedActions GetLinkedReportAllowedActions (string id)

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
    public class GetLinkedReportAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetLinkedReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportAllowedActions: " + e.Message );
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

<a name="getlinkedreportcacheoptions"></a>
# **GetLinkedReportCacheOptions**
> CacheOptions GetLinkedReportCacheOptions (string id)

Gets the content of CacheOptions for the LinkedReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of CacheOptions for the LinkedReport specified by the Id.
                CacheOptions result = apiInstance.GetLinkedReportCacheOptions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheOptions: " + e.Message );
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

<a name="getlinkedreportcacherefreshplans"></a>
# **GetLinkedReportCacheRefreshPlans**
> ODataCacheRefreshPlans GetLinkedReportCacheRefreshPlans (string id)

Gets the CacheRefreshPlans for a LinkedReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportCacheRefreshPlansExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheRefreshPlans for a LinkedReport specified by the Id.
                ODataCacheRefreshPlans result = apiInstance.GetLinkedReportCacheRefreshPlans(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportCacheRefreshPlans: " + e.Message );
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

<a name="getlinkedreportcomments"></a>
# **GetLinkedReportComments**
> ODataComments GetLinkedReportComments (string id)

Gets the Comments for a LinkedReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a LinkedReport specified by the Id.
                ODataComments result = apiInstance.GetLinkedReportComments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportComments: " + e.Message );
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

<a name="getlinkedreporthistorysnapshot"></a>
# **GetLinkedReportHistorySnapshot**
> HistorySnapshot GetLinkedReportHistorySnapshot (string id, string historyId)

Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historyId = historyId_example;  // string | The Id property of the HistorySnapshot

            try
            {
                // Gets requested HistorySnapshot item specified by HistoryId of the LinkedReport specified by Id.
                HistorySnapshot result = apiInstance.GetLinkedReportHistorySnapshot(id, historyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshot: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **historyId** | **string**| The Id property of the HistorySnapshot | 

### Return type

[**HistorySnapshot**](HistorySnapshot.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlinkedreporthistorysnapshotoptions"></a>
# **GetLinkedReportHistorySnapshotOptions**
> HistorySnapshotOptions GetLinkedReportHistorySnapshotOptions (string id)

Gets HistorySnapshotOptions for the specified LinkedReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets HistorySnapshotOptions for the specified LinkedReport.
                HistorySnapshotOptions result = apiInstance.GetLinkedReportHistorySnapshotOptions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshotOptions: " + e.Message );
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

<a name="getlinkedreporthistorysnapshots"></a>
# **GetLinkedReportHistorySnapshots**
> List<HistorySnapshot> GetLinkedReportHistorySnapshots (string id)

Get a list of HistorySnapshots of the LinkedReport specified by Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportHistorySnapshotsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Get a list of HistorySnapshots of the LinkedReport specified by Id.
                List&lt;HistorySnapshot&gt; result = apiInstance.GetLinkedReportHistorySnapshots(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportHistorySnapshots: " + e.Message );
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

<a name="getlinkedreportparameterdefinitions"></a>
# **GetLinkedReportParameterDefinitions**
> ODataReportParameterDefinitions GetLinkedReportParameterDefinitions (string id)

Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the ParameterDefinitions associated with the LinkedReport specified by the Id.
                ODataReportParameterDefinitions result = apiInstance.GetLinkedReportParameterDefinitions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportParameterDefinitions: " + e.Message );
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

<a name="getlinkedreportpolicies"></a>
# **GetLinkedReportPolicies**
> List<ItemPolicy> GetLinkedReportPolicies (string id)

Gets ItemPolicies associated with the specified LinkedReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the specified LinkedReport CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetLinkedReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportPolicies: " + e.Message );
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

<a name="getlinkedreportproperties"></a>
# **GetLinkedReportProperties**
> ODataProperties GetLinkedReportProperties (string id, List<string> properties)

Gets LinkedReport Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets LinkedReport Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetLinkedReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReportProperties: " + e.Message );
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

<a name="getlinkedreports"></a>
# **GetLinkedReports**
> ODataLinkedReports GetLinkedReports (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of LinkedReport CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetLinkedReportsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of LinkedReport CatalogItems.
                ODataLinkedReports result = apiInstance.GetLinkedReports(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.GetLinkedReports: " + e.Message );
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

[**ODataLinkedReports**](ODataLinkedReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setlinkedreportcacheoptions"></a>
# **SetLinkedReportCacheOptions**
> void SetLinkedReportCacheOptions (string id, CacheOptions cacheOptions)

Replaces the CacheOption's content for a given LinkedReport using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetLinkedReportCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var cacheOptions = new CacheOptions(); // CacheOptions | Updated definition for the CacheOption's content associated with the LinkedReport specified by the Id.

            try
            {
                // Replaces the CacheOption's content for a given LinkedReport using the provided definition.
                apiInstance.SetLinkedReportCacheOptions(id, cacheOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportCacheOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheOptions** | [**CacheOptions**](CacheOptions.md)| Updated definition for the CacheOption&#39;s content associated with the LinkedReport specified by the Id. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setlinkedreporthistorysnapshotoptions"></a>
# **SetLinkedReportHistorySnapshotOptions**
> void SetLinkedReportHistorySnapshotOptions (string id, HistorySnapshotOptions historySnapshotOptions)

Updates HistorySnapshotOptions property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetLinkedReportHistorySnapshotOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var historySnapshotOptions = new HistorySnapshotOptions(); // HistorySnapshotOptions | Modified HistorySnapshotOptions object.

            try
            {
                // Updates HistorySnapshotOptions property.
                apiInstance.SetLinkedReportHistorySnapshotOptions(id, historySnapshotOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportHistorySnapshotOptions: " + e.Message );
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

<a name="setlinkedreportpolicies"></a>
# **SetLinkedReportPolicies**
> void SetLinkedReportPolicies (string id, List<ItemPolicy> itemPolicy)

Replaces ItemPolicies associated with the specified LinkedReport item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetLinkedReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the specified LinkedReport item.
                apiInstance.SetLinkedReportPolicies(id, itemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.SetLinkedReportPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **itemPolicy** | [**List<ItemPolicy>**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelinkedreport"></a>
# **UpdateLinkedReport**
> void UpdateLinkedReport (string id, LinkedReport linkedReport)

Updates the specified LinkedReport CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateLinkedReportExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var linkedReport = new LinkedReport(); // LinkedReport | Definition of the LinkedReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified LinkedReport CatalogItem using the provided definition.
                apiInstance.UpdateLinkedReport(id, linkedReport);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **linkedReport** | [**LinkedReport**](LinkedReport.md)| Definition of the LinkedReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelinkedreportcomment"></a>
# **UpdateLinkedReportComment**
> void UpdateLinkedReportComment (string id, string commentId, Comment comment)

Updates the Comment specified by CommentId in the associated LinkedReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateLinkedReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.
            var comment = new Comment(); // Comment | The Comment to be updated

            try
            {
                // Updates the Comment specified by CommentId in the associated LinkedReport.
                apiInstance.UpdateLinkedReportComment(id, commentId, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportComment: " + e.Message );
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

<a name="updatelinkedreportparameterdefinitions"></a>
# **UpdateLinkedReportParameterDefinitions**
> void UpdateLinkedReportParameterDefinitions (string id, List<ReportParameterDefinitionPatch> parameterDefinitions)

Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateLinkedReportParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var parameterDefinitions = new List<ReportParameterDefinitionPatch>(); // List<ReportParameterDefinitionPatch> | Updated definitions for the ParameterDefinitions associated with the LinkedReport, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the ParameterDefinitions associated with the specified LinkedReport by the Id.
                apiInstance.UpdateLinkedReportParameterDefinitions(id, parameterDefinitions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportParameterDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **parameterDefinitions** | [**List<ReportParameterDefinitionPatch>**](ReportParameterDefinitionPatch.md)| Updated definitions for the ParameterDefinitions associated with the LinkedReport, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatelinkedreportproperties"></a>
# **UpdateLinkedReportProperties**
> void UpdateLinkedReportProperties (string id, List<Property> properties)

Updates the LinkedReport Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateLinkedReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new LinkedReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the LinkedReport Properties included in the given list.
                apiInstance.UpdateLinkedReportProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LinkedReportsApi.UpdateLinkedReportProperties: " + e.Message );
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

