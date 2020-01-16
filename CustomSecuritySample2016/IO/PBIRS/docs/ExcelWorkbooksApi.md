# IO.PBIRS.Swagger.Api.ExcelWorkbooksApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddExcelWorkbook**](ExcelWorkbooksApi.md#addexcelworkbook) | **POST** /ExcelWorkbooks | Creates a new ExcelWorkbook CatalogItem.
[**AddExcelWorkbookComment**](ExcelWorkbooksApi.md#addexcelworkbookcomment) | **POST** /ExcelWorkbooks({Id})/Comments | Creates a new Comment associated to the specified ExcelWorkbook.
[**DeleteExcelWorkbook**](ExcelWorkbooksApi.md#deleteexcelworkbook) | **DELETE** /ExcelWorkbooks({Id}) | Deletes the specified ExcelWorkbook.
[**DeleteExcelWorkbookComment**](ExcelWorkbooksApi.md#deleteexcelworkbookcomment) | **DELETE** /ExcelWorkbooks({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the ExcelWorkbook.
[**GetExcelWorkbook**](ExcelWorkbooksApi.md#getexcelworkbook) | **GET** /ExcelWorkbooks({Id}) | Gets the ExcelWorkbook CatalogItem specified by the Id.
[**GetExcelWorkbookAllowedActions**](ExcelWorkbooksApi.md#getexcelworkbookallowedactions) | **GET** /ExcelWorkbooks({Id})/AllowedActions | Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.
[**GetExcelWorkbookComments**](ExcelWorkbooksApi.md#getexcelworkbookcomments) | **GET** /ExcelWorkbooks({Id})/Comments | Gets the Comments for a ExcelWorkbook specified by the Id.
[**GetExcelWorkbookContent**](ExcelWorkbooksApi.md#getexcelworkbookcontent) | **GET** /ExcelWorkbooks({Id})/Content/$value | Gets the content of the specified ExcelWorkbook CatalogItem specified by the Id.
[**GetExcelWorkbookPolicies**](ExcelWorkbooksApi.md#getexcelworkbookpolicies) | **GET** /ExcelWorkbooks({Id})/Policies | Gets policies associated with the specified ExcelWorkbook CatalogItem.
[**GetExcelWorkbookProperties**](ExcelWorkbooksApi.md#getexcelworkbookproperties) | **GET** /ExcelWorkbooks({Id})/Properties | Gets ExcelWorkbook properties (takes list of property names to retrieve the values)
[**GetExcelWorkbooks**](ExcelWorkbooksApi.md#getexcelworkbooks) | **GET** /ExcelWorkbooks | Gets an array of ExcelWorkbook CatalogItems.
[**SetExcelWorkbookPolicies**](ExcelWorkbooksApi.md#setexcelworkbookpolicies) | **PUT** /ExcelWorkbooks({Id})/Policies | Replaces ItemPolicies associated with the specified ExcelWorkbook item.
[**UpdateExcelWorkbook**](ExcelWorkbooksApi.md#updateexcelworkbook) | **PATCH** /ExcelWorkbooks({Id}) | Updates the specified ExcelWorkbook CatalogItem using the provided definition.
[**UpdateExcelWorkbookComment**](ExcelWorkbooksApi.md#updateexcelworkbookcomment) | **PUT** /ExcelWorkbooks({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated ExcelWorkbook.
[**UpdateExcelWorkbookProperties**](ExcelWorkbooksApi.md#updateexcelworkbookproperties) | **PUT** /ExcelWorkbooks({Id})/Properties | Updates the ExcelWorkbook properties included in the given list.
[**UploadExcelWorkbook**](ExcelWorkbooksApi.md#uploadexcelworkbook) | **POST** /ExcelWorkbooks({Id})/Model.Upload | Creates a new ExcelWorkbook CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addexcelworkbook"></a>
# **AddExcelWorkbook**
> ExcelWorkbook AddExcelWorkbook (ExcelWorkbook excelWorkbook)

Creates a new ExcelWorkbook CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddExcelWorkbookExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var excelWorkbook = new ExcelWorkbook(); // ExcelWorkbook | The definition of the new ExcelWorkbook CatalogItem.

            try
            {
                // Creates a new ExcelWorkbook CatalogItem.
                ExcelWorkbook result = apiInstance.AddExcelWorkbook(excelWorkbook);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.AddExcelWorkbook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excelWorkbook** | [**ExcelWorkbook**](ExcelWorkbook.md)| The definition of the new ExcelWorkbook CatalogItem. | 

### Return type

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="addexcelworkbookcomment"></a>
# **AddExcelWorkbookComment**
> void AddExcelWorkbookComment (string id, Comment comment)

Creates a new Comment associated to the specified ExcelWorkbook.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddExcelWorkbookCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var comment = new Comment(); // Comment | The Comment to be created

            try
            {
                // Creates a new Comment associated to the specified ExcelWorkbook.
                apiInstance.AddExcelWorkbookComment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.AddExcelWorkbookComment: " + e.Message );
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

<a name="deleteexcelworkbook"></a>
# **DeleteExcelWorkbook**
> void DeleteExcelWorkbook (string id)

Deletes the specified ExcelWorkbook.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteExcelWorkbookExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified ExcelWorkbook.
                apiInstance.DeleteExcelWorkbook(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.DeleteExcelWorkbook: " + e.Message );
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

<a name="deleteexcelworkbookcomment"></a>
# **DeleteExcelWorkbookComment**
> void DeleteExcelWorkbookComment (string id, string commentId)

Deletes the specified Comment associated to the ExcelWorkbook.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteExcelWorkbookCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.

            try
            {
                // Deletes the specified Comment associated to the ExcelWorkbook.
                apiInstance.DeleteExcelWorkbookComment(id, commentId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.DeleteExcelWorkbookComment: " + e.Message );
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

<a name="getexcelworkbook"></a>
# **GetExcelWorkbook**
> ExcelWorkbook GetExcelWorkbook (string id)

Gets the ExcelWorkbook CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the ExcelWorkbook CatalogItem specified by the Id.
                ExcelWorkbook result = apiInstance.GetExcelWorkbook(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbook: " + e.Message );
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

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexcelworkbookallowedactions"></a>
# **GetExcelWorkbookAllowedActions**
> ODataAllowedActions GetExcelWorkbookAllowedActions (string id)

Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetExcelWorkbookAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbookAllowedActions: " + e.Message );
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

<a name="getexcelworkbookcomments"></a>
# **GetExcelWorkbookComments**
> ODataComments GetExcelWorkbookComments (string id)

Gets the Comments for a ExcelWorkbook specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookCommentsExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the Comments for a ExcelWorkbook specified by the Id.
                ODataComments result = apiInstance.GetExcelWorkbookComments(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbookComments: " + e.Message );
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

<a name="getexcelworkbookcontent"></a>
# **GetExcelWorkbookContent**
> System.IO.Stream GetExcelWorkbookContent (string id)

Gets the content of the specified ExcelWorkbook CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookContentExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified ExcelWorkbook CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetExcelWorkbookContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbookContent: " + e.Message );
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

<a name="getexcelworkbookpolicies"></a>
# **GetExcelWorkbookPolicies**
> List<ItemPolicy> GetExcelWorkbookPolicies (string id)

Gets policies associated with the specified ExcelWorkbook CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets policies associated with the specified ExcelWorkbook CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetExcelWorkbookPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbookPolicies: " + e.Message );
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

<a name="getexcelworkbookproperties"></a>
# **GetExcelWorkbookProperties**
> ODataProperties GetExcelWorkbookProperties (string id, List<string> properties)

Gets ExcelWorkbook properties (takes list of property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbookPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the properties to be returned. (optional) 

            try
            {
                // Gets ExcelWorkbook properties (takes list of property names to retrieve the values)
                ODataProperties result = apiInstance.GetExcelWorkbookProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbookProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<string>**](string.md)| Names for the properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexcelworkbooks"></a>
# **GetExcelWorkbooks**
> ODataExcelWorkbooks GetExcelWorkbooks (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of ExcelWorkbook CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExcelWorkbooksExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of ExcelWorkbook CatalogItems.
                ODataExcelWorkbooks result = apiInstance.GetExcelWorkbooks(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.GetExcelWorkbooks: " + e.Message );
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

[**ODataExcelWorkbooks**](ODataExcelWorkbooks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setexcelworkbookpolicies"></a>
# **SetExcelWorkbookPolicies**
> void SetExcelWorkbookPolicies (string id, List<ItemPolicy> itemPolicy)

Replaces ItemPolicies associated with the specified ExcelWorkbook item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetExcelWorkbookPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the specified ExcelWorkbook item.
                apiInstance.SetExcelWorkbookPolicies(id, itemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.SetExcelWorkbookPolicies: " + e.Message );
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

<a name="updateexcelworkbook"></a>
# **UpdateExcelWorkbook**
> void UpdateExcelWorkbook (string id, ExcelWorkbook excelWorkbook)

Updates the specified ExcelWorkbook CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateExcelWorkbookExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var excelWorkbook = new ExcelWorkbook(); // ExcelWorkbook | Definition of the ExcelWorkbook item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified ExcelWorkbook CatalogItem using the provided definition.
                apiInstance.UpdateExcelWorkbook(id, excelWorkbook);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.UpdateExcelWorkbook: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **excelWorkbook** | [**ExcelWorkbook**](ExcelWorkbook.md)| Definition of the ExcelWorkbook item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateexcelworkbookcomment"></a>
# **UpdateExcelWorkbookComment**
> void UpdateExcelWorkbookComment (string id, string commentId, Comment comment)

Updates the Comment specified by CommentId in the associated ExcelWorkbook.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateExcelWorkbookCommentExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var commentId = commentId_example;  // string | The Id of the Comment.
            var comment = new Comment(); // Comment | The Comment to be updated

            try
            {
                // Updates the Comment specified by CommentId in the associated ExcelWorkbook.
                apiInstance.UpdateExcelWorkbookComment(id, commentId, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.UpdateExcelWorkbookComment: " + e.Message );
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

<a name="updateexcelworkbookproperties"></a>
# **UpdateExcelWorkbookProperties**
> void UpdateExcelWorkbookProperties (string id, List<Property> properties)

Updates the ExcelWorkbook properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateExcelWorkbookPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The properties that will be updated.

            try
            {
                // Updates the ExcelWorkbook properties included in the given list.
                apiInstance.UpdateExcelWorkbookProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.UpdateExcelWorkbookProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<Property>**](Property.md)| The properties that will be updated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadexcelworkbook"></a>
# **UploadExcelWorkbook**
> ExcelWorkbook UploadExcelWorkbook (string id, System.IO.Stream _file)

Creates a new ExcelWorkbook CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UploadExcelWorkbookExample
    {
        public void main()
        {
            
            var apiInstance = new ExcelWorkbooksApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var _file = new System.IO.Stream(); // System.IO.Stream | The file contents.

            try
            {
                // Creates a new ExcelWorkbook CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
                ExcelWorkbook result = apiInstance.UploadExcelWorkbook(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExcelWorkbooksApi.UploadExcelWorkbook: " + e.Message );
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

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

