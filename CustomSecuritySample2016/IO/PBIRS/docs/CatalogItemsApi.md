# IO.PBIRS.Swagger.Api.CatalogItemsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCatalogItem**](CatalogItemsApi.md#addcatalogitem) | **POST** /CatalogItems | Creates a new CatalogItem.
[**DeleteCatalogItem**](CatalogItemsApi.md#deletecatalogitem) | **DELETE** /CatalogItems({Id}) | Deletes the specified CatalogItem.
[**DeleteCatalogItems**](CatalogItemsApi.md#deletecatalogitems) | **POST** /CatalogItems/Model.DeleteItems | Deletes the given list of items
[**GetCatalogItem**](CatalogItemsApi.md#getcatalogitem) | **GET** /CatalogItems({Id}) | Gets a CatalogItem specified by the Id.
[**GetCatalogItemContent**](CatalogItemsApi.md#getcatalogitemcontent) | **GET** /CatalogItems({Id})/Content/$value | Gets the content of the specified CatalogItem specified by the Id.
[**GetCatalogItemPolicies**](CatalogItemsApi.md#getcatalogitempolicies) | **GET** /CatalogItems({Id})/Policies | Gets ItemPolicies associated with the specified CatalogItem.
[**GetCatalogItemProperties**](CatalogItemsApi.md#getcatalogitemproperties) | **GET** /CatalogItems({Id})/Properties | Gets the specified Properties for the CatalogItem (takes list of Property names to retrieve the values)
[**GetCatalogItemRoles**](CatalogItemsApi.md#getcatalogitemroles) | **GET** /CatalogItems({Id})/Roles | Gets the list of available Roles for the CatalogItem
[**GetCatalogItems**](CatalogItemsApi.md#getcatalogitems) | **GET** /CatalogItems | Gets an array of CatalogItems.
[**MoveCatalogItems**](CatalogItemsApi.md#movecatalogitems) | **POST** /CatalogItems/Model.MoveItems | Moves given list of items to target folder.
[**SetCatalogItemPolicies**](CatalogItemsApi.md#setcatalogitempolicies) | **PUT** /CatalogItems({Id})/Policies | Replaces ItemPolicies associated with the specified CatalogItem.
[**UpdateCatalogItem**](CatalogItemsApi.md#updatecatalogitem) | **PATCH** /CatalogItems({Id}) | Updates the specified CatalogItem using the provided definition.
[**UpdateCatalogItemProperties**](CatalogItemsApi.md#updatecatalogitemproperties) | **PUT** /CatalogItems({Id})/Properties | Updates a CatalogItem&#39;s Properties with the list of given properties.


<a name="addcatalogitem"></a>
# **AddCatalogItem**
> CatalogItem AddCatalogItem (CatalogItem catalogItem)

Creates a new CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddCatalogItemExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var catalogItem = new CatalogItem(); // CatalogItem | The definition of the new CatalogItem.

            try
            {
                // Creates a new CatalogItem.
                CatalogItem result = apiInstance.AddCatalogItem(catalogItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.AddCatalogItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **catalogItem** | [**CatalogItem**](CatalogItem.md)| The definition of the new CatalogItem. | 

### Return type

[**CatalogItem**](CatalogItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecatalogitem"></a>
# **DeleteCatalogItem**
> void DeleteCatalogItem (string id)

Deletes the specified CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteCatalogItemExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified CatalogItem.
                apiInstance.DeleteCatalogItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.DeleteCatalogItem: " + e.Message );
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

<a name="deletecatalogitems"></a>
# **DeleteCatalogItems**
> BulkOperationsResult DeleteCatalogItems (DeleteItemsRequest deleteItemsRequest)

Deletes the given list of items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteCatalogItemsExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var deleteItemsRequest = new DeleteItemsRequest(); // DeleteItemsRequest | List of catalog item paths to delete.

            try
            {
                // Deletes the given list of items
                BulkOperationsResult result = apiInstance.DeleteCatalogItems(deleteItemsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.DeleteCatalogItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **deleteItemsRequest** | [**DeleteItemsRequest**](DeleteItemsRequest.md)| List of catalog item paths to delete. | 

### Return type

[**BulkOperationsResult**](BulkOperationsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogitem"></a>
# **GetCatalogItem**
> CatalogItem GetCatalogItem (string id)

Gets a CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a CatalogItem specified by the Id.
                CatalogItem result = apiInstance.GetCatalogItem(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItem: " + e.Message );
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

[**CatalogItem**](CatalogItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogitemcontent"></a>
# **GetCatalogItemContent**
> System.IO.Stream GetCatalogItemContent (string id)

Gets the content of the specified CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemContentExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetCatalogItemContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItemContent: " + e.Message );
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

<a name="getcatalogitempolicies"></a>
# **GetCatalogItemPolicies**
> List<ItemPolicy> GetCatalogItemPolicies (string id)

Gets ItemPolicies associated with the specified CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the specified CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetCatalogItemPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItemPolicies: " + e.Message );
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

<a name="getcatalogitemproperties"></a>
# **GetCatalogItemProperties**
> ODataProperties GetCatalogItemProperties (string id, List<string> properties)

Gets the specified Properties for the CatalogItem (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Comma-separated list of Property names to be returned. (optional) 

            try
            {
                // Gets the specified Properties for the CatalogItem (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetCatalogItemProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItemProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<string>**](string.md)| Comma-separated list of Property names to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogitemroles"></a>
# **GetCatalogItemRoles**
> ODataProperties1 GetCatalogItemRoles (string id)

Gets the list of available Roles for the CatalogItem

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemRolesExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the list of available Roles for the CatalogItem
                ODataProperties1 result = apiInstance.GetCatalogItemRoles(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItemRoles: " + e.Message );
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

[**ODataProperties1**](ODataProperties1.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcatalogitems"></a>
# **GetCatalogItems**
> ODataCatalogItems GetCatalogItems (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetCatalogItemsExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of CatalogItems.
                ODataCatalogItems result = apiInstance.GetCatalogItems(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.GetCatalogItems: " + e.Message );
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

[**ODataCatalogItems**](ODataCatalogItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movecatalogitems"></a>
# **MoveCatalogItems**
> BulkOperationsResult MoveCatalogItems (MoveItemsRequest moveItemsRequest)

Moves given list of items to target folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class MoveCatalogItemsExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var moveItemsRequest = new MoveItemsRequest(); // MoveItemsRequest | List of catalog item paths and target folder.

            try
            {
                // Moves given list of items to target folder.
                BulkOperationsResult result = apiInstance.MoveCatalogItems(moveItemsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.MoveCatalogItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **moveItemsRequest** | [**MoveItemsRequest**](MoveItemsRequest.md)| List of catalog item paths and target folder. | 

### Return type

[**BulkOperationsResult**](BulkOperationsResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcatalogitempolicies"></a>
# **SetCatalogItemPolicies**
> void SetCatalogItemPolicies (string id, List<ItemPolicy> catalogItem)

Replaces ItemPolicies associated with the specified CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetCatalogItemPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var catalogItem = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the specified CatalogItem.
                apiInstance.SetCatalogItemPolicies(id, catalogItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.SetCatalogItemPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **catalogItem** | [**List<ItemPolicy>**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecatalogitem"></a>
# **UpdateCatalogItem**
> void UpdateCatalogItem (string id, CatalogItem catalogItem)

Updates the specified CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateCatalogItemExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var catalogItem = new CatalogItem(); // CatalogItem | Definition of the CatalogItem that updates the current item on the server. The type for the defintion can be any of the supported CatalogItemTypes. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the specified CatalogItem using the provided definition.
                apiInstance.UpdateCatalogItem(id, catalogItem);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.UpdateCatalogItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **catalogItem** | [**CatalogItem**](CatalogItem.md)| Definition of the CatalogItem that updates the current item on the server. The type for the defintion can be any of the supported CatalogItemTypes. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatecatalogitemproperties"></a>
# **UpdateCatalogItemProperties**
> void UpdateCatalogItemProperties (string id, List<Property> properties)

Updates a CatalogItem's Properties with the list of given properties.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateCatalogItemPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new CatalogItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates a CatalogItem's Properties with the list of given properties.
                apiInstance.UpdateCatalogItemProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogItemsApi.UpdateCatalogItemProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<Property>**](Property.md)| The Properties that will be updated. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

