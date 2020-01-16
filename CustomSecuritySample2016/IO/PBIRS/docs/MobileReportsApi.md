# IO.PBIRS.Swagger.Api.MobileReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMobileReport**](MobileReportsApi.md#addmobilereport) | **POST** /MobileReports | Creates new MobileReport item
[**AddMobileReportComment**](MobileReportsApi.md#addmobilereportcomment) | **POST** /MobileReports({Id})/Comments | Creates a new Comment associated to the specified MobileReport.
[**DeleteMobileReport**](MobileReportsApi.md#deletemobilereport) | **DELETE** /MobileReports({Id}) | Delete the specified MobileReport.
[**DeleteMobileReportComment**](MobileReportsApi.md#deletemobilereportcomment) | **DELETE** /MobileReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the MobileReport.
[**GetMobileReport**](MobileReportsApi.md#getmobilereport) | **GET** /MobileReports({Id}) | Fetch MobileReport item by Id or path property.
[**GetMobileReportAllowedActions**](MobileReportsApi.md#getmobilereportallowedactions) | **GET** /MobileReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
[**GetMobileReportComments**](MobileReportsApi.md#getmobilereportcomments) | **GET** /MobileReports({Id})/Comments | Gets the Comments for a MobileReport specified by the Id.
[**GetMobileReportContent**](MobileReportsApi.md#getmobilereportcontent) | **GET** /MobileReports({Id})/Content/$value | Gets the content of the specified MobileReport CatalogItem.
[**GetMobileReportPolicies**](MobileReportsApi.md#getmobilereportpolicies) | **GET** /MobileReports({Id})/Policies | Gets ItemPolicies associated with the MobileReport catalog item.
[**GetMobileReportProperties**](MobileReportsApi.md#getmobilereportproperties) | **GET** /MobileReports({Id})/Properties | Gets MobileReport Properties (takes list of Property names to retrieve the values)
[**GetMobileReports**](MobileReportsApi.md#getmobilereports) | **GET** /MobileReports | Retrieve array of MobileReport catalog items.
[**SetMobileReportPolicies**](MobileReportsApi.md#setmobilereportpolicies) | **PUT** /MobileReports({Id})/Policies | Sets ItemPolicies on the MobileReport item.
[**UpdateMobileReport**](MobileReportsApi.md#updatemobilereport) | **PATCH** /MobileReports({Id}) | Updates the specified MobileReport CatalogItem using the provided definition.
[**UpdateMobileReportComment**](MobileReportsApi.md#updatemobilereportcomment) | **PUT** /MobileReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated MobileReport.
[**UpdateMobileReportProperties**](MobileReportsApi.md#updatemobilereportproperties) | **PUT** /MobileReports({Id})/Properties | Updates the MobileReport properties included in the given list.
[**UploadMobileReport**](MobileReportsApi.md#uploadmobilereport) | **POST** /MobileReports({Id})/Model.Upload | Does an efficient binary upload of a new or existing MobileReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addmobilereport"></a>
# **AddMobileReport**
> MobileReport AddMobileReport (MobileReport body)

Creates new MobileReport item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddMobileReportExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var body = new MobileReport(); // MobileReport | The definition of the new MobileReport item.

            try
            {
                // Creates new MobileReport item
                MobileReport result = apiInstance.AddMobileReport(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.AddMobileReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MobileReport**](MobileReport.md)| The definition of the new MobileReport item. | 

### Return type

[**MobileReport**](MobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addmobilereportcomment"></a>
# **AddMobileReportComment**
> void AddMobileReportComment (string id, Comment comment)

Creates a new Comment associated to the specified MobileReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddMobileReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var comment = new Comment(); // Comment | The Comment to be created

            try
            {
                // Creates a new Comment associated to the specified MobileReport.
                apiInstance.AddMobileReportComment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.AddMobileReportComment: " + e.Message );
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

<a name="deletemobilereport"></a>
# **DeleteMobileReport**
> void DeleteMobileReport (string id)

Delete the specified MobileReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteMobileReportExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Delete the specified MobileReport.
                apiInstance.DeleteMobileReport(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReport: " + e.Message );
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

<a name="deletemobilereportcomment"></a>
# **DeleteMobileReportComment**
> void DeleteMobileReportComment (string id, string commentId)

Deletes the specified Comment associated to the MobileReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteMobileReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the MobileReport.
                apiInstance.DeleteMobileReportComment(id, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.DeleteMobileReportComment: " + e.Message );
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

<a name="getmobilereport"></a>
# **GetMobileReport**
> MobileReport GetMobileReport (string id)

Fetch MobileReport item by Id or path property.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Fetch MobileReport item by Id or path property.
                MobileReport result = apiInstance.GetMobileReport(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReport: " + e.Message );
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

[**MobileReport**](MobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getmobilereportallowedactions"></a>
# **GetMobileReportAllowedActions**
> ODataAllowedActions GetMobileReportAllowedActions (string id)

Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
                ODataAllowedActions result = apiInstance.GetMobileReportAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportAllowedActions: " + e.Message );
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

<a name="getmobilereportcomments"></a>
# **GetMobileReportComments**
> ODataComments GetMobileReportComments (string id)

Gets the Comments for a MobileReport specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a MobileReport specified by the Id.
                ODataComments result = apiInstance.GetMobileReportComments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportComments: " + e.Message );
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

<a name="getmobilereportcontent"></a>
# **GetMobileReportContent**
> System.IO.Stream GetMobileReportContent (string id)

Gets the content of the specified MobileReport CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportContentExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified MobileReport CatalogItem.
                System.IO.Stream result = apiInstance.GetMobileReportContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportContent: " + e.Message );
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

<a name="getmobilereportpolicies"></a>
# **GetMobileReportPolicies**
> List<ItemPolicy> GetMobileReportPolicies (string id)

Gets ItemPolicies associated with the MobileReport catalog item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the MobileReport catalog item.
                List&lt;ItemPolicy&gt; result = apiInstance.GetMobileReportPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportPolicies: " + e.Message );
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

<a name="getmobilereportproperties"></a>
# **GetMobileReportProperties**
> ODataProperties GetMobileReportProperties (string id, List<string> properties)

Gets MobileReport Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets MobileReport Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetMobileReportProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReportProperties: " + e.Message );
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

<a name="getmobilereports"></a>
# **GetMobileReports**
> ODataMobileReport GetMobileReports (int? top, int? skip, string filter, string count)

Retrieve array of MobileReport catalog items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetMobileReportsExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 

            try
            {
                // Retrieve array of MobileReport catalog items.
                ODataMobileReport result = apiInstance.GetMobileReports(top, skip, filter, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.GetMobileReports: " + e.Message );
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

### Return type

[**ODataMobileReport**](ODataMobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setmobilereportpolicies"></a>
# **SetMobileReportPolicies**
> void SetMobileReportPolicies (string id, List<ItemPolicy> mobileReports)

Sets ItemPolicies on the MobileReport item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetMobileReportPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var mobileReports = new List<ItemPolicy>(); // List<ItemPolicy> | Array of ItemPolicies to set on the MobileReport CatalogItem.

            try
            {
                // Sets ItemPolicies on the MobileReport item.
                apiInstance.SetMobileReportPolicies(id, mobileReports);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.SetMobileReportPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **mobileReports** | [**List<ItemPolicy>**](ItemPolicy.md)| Array of ItemPolicies to set on the MobileReport CatalogItem. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemobilereport"></a>
# **UpdateMobileReport**
> MobileReport UpdateMobileReport (string id, MobileReport body)

Updates the specified MobileReport CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateMobileReportExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var body = new MobileReport(); // MobileReport | Definition of the MobileReport item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified MobileReport CatalogItem using the provided definition.
                MobileReport result = apiInstance.UpdateMobileReport(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReport: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **body** | [**MobileReport**](MobileReport.md)| Definition of the MobileReport item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

[**MobileReport**](MobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatemobilereportcomment"></a>
# **UpdateMobileReportComment**
> void UpdateMobileReportComment (string id, string commentId, Comment comment)

Updates the Comment specified by CommentId in the associated MobileReport.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateMobileReportCommentExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.
            var comment = new Comment(); // Comment | The Comment to be updated

            try
            {
                // Updates the Comment specified by CommentId in the associated MobileReport.
                apiInstance.UpdateMobileReportComment(id, commentId, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportComment: " + e.Message );
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

<a name="updatemobilereportproperties"></a>
# **UpdateMobileReportProperties**
> void UpdateMobileReportProperties (string id, List<Property> properties)

Updates the MobileReport properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateMobileReportPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the MobileReport properties included in the given list.
                apiInstance.UpdateMobileReportProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UpdateMobileReportProperties: " + e.Message );
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

<a name="uploadmobilereport"></a>
# **UploadMobileReport**
> MobileReport UploadMobileReport (string id, System.IO.Stream _file)

Does an efficient binary upload of a new or existing MobileReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UploadMobileReportExample
    {
        public void main()
        {
            
            var apiInstance = new MobileReportsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var _file = new System.IO.Stream(); // System.IO.Stream | The file contents.

            try
            {
                // Does an efficient binary upload of a new or existing MobileReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
                MobileReport result = apiInstance.UploadMobileReport(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MobileReportsApi.UploadMobileReport: " + e.Message );
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

[**MobileReport**](MobileReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

