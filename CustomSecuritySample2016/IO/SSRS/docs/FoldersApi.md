# IO.SSRS.Swagger.Api.FoldersApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddFolder**](FoldersApi.md#addfolder) | **POST** /Folders | Creates a new Folder CatalogItem.
[**DeleteFolder**](FoldersApi.md#deletefolder) | **DELETE** /Folders({Id}) | Deletes the specified Folder.
[**GetFolder**](FoldersApi.md#getfolder) | **GET** /Folders({Id}) | Gets a Folder CatalogItem specified by the Id.
[**GetFolderAllowedActions**](FoldersApi.md#getfolderallowedactions) | **GET** /Folders({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetFolderCatalogItems**](FoldersApi.md#getfoldercatalogitems) | **GET** /Folders({Id})/CatalogItems | Gets a list of child CatalogItems in the specified folder.
[**GetFolderPolicies**](FoldersApi.md#getfolderpolicies) | **GET** /Folders({Id})/Policies | Gets policies associated with the Folder CatalogItem specified by the Id.
[**GetFolderProperties**](FoldersApi.md#getfolderproperties) | **GET** /Folders({Id})/Properties | Gets Folder Properties (takes list of Property names to retrieve the values)
[**GetFolders**](FoldersApi.md#getfolders) | **GET** /Folders | Gets an array of Folder CatalogItems.
[**SearchCatalogItemsInFolder**](FoldersApi.md#searchcatalogitemsinfolder) | **POST** /Folders({Id})/Model.SearchItems(searchText&#x3D;&#39;{searchText}&#39;) | Searches items in a given folder.
[**SetFolderPolicies**](FoldersApi.md#setfolderpolicies) | **PUT** /Folders({Id})/Policies | Replaces ItemPolicies associated with the Folder item specified by the Id.
[**UpdateFolder**](FoldersApi.md#updatefolder) | **PATCH** /Folders({Id}) | Updates the specified Folder CatalogItem using the provided definition.
[**UpdateFolderProperties**](FoldersApi.md#updatefolderproperties) | **PUT** /Folders({Id})/Properties | Updates the Folder Properties included in the given list.


<a name="addfolder"></a>
# **AddFolder**
> Folder AddFolder (Folder body)

Creates a new Folder CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddFolderExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var body = new Folder(); // Folder | The definition of the new Folder CatalogItem.

            try
            {
                // Creates a new Folder CatalogItem.
                Folder result = apiInstance.AddFolder(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.AddFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Folder**](Folder.md)| The definition of the new Folder CatalogItem. | 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string id)

Deletes the specified Folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified Folder.
                apiInstance.DeleteFolder(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.DeleteFolder: " + e.Message );
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

<a name="getfolder"></a>
# **GetFolder**
> Folder GetFolder (string id)

Gets a Folder CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFolderExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a Folder CatalogItem specified by the Id.
                Folder result = apiInstance.GetFolder(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolder: " + e.Message );
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

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolderallowedactions"></a>
# **GetFolderAllowedActions**
> ODataAllowedActions GetFolderAllowedActions (string id)

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
    public class GetFolderAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetFolderAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderAllowedActions: " + e.Message );
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

<a name="getfoldercatalogitems"></a>
# **GetFolderCatalogItems**
> ODataCatalogItems GetFolderCatalogItems (string id)

Gets a list of child CatalogItems in the specified folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFolderCatalogItemsExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of child CatalogItems in the specified folder.
                ODataCatalogItems result = apiInstance.GetFolderCatalogItems(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderCatalogItems: " + e.Message );
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

[**ODataCatalogItems**](ODataCatalogItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfolderpolicies"></a>
# **GetFolderPolicies**
> List<ItemPolicy> GetFolderPolicies (string id)

Gets policies associated with the Folder CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFolderPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets policies associated with the Folder CatalogItem specified by the Id.
                List&lt;ItemPolicy&gt; result = apiInstance.GetFolderPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderPolicies: " + e.Message );
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

<a name="getfolderproperties"></a>
# **GetFolderProperties**
> ODataProperties GetFolderProperties (string id, List<string> properties)

Gets Folder Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFolderPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets Folder Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetFolderProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolderProperties: " + e.Message );
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

<a name="getfolders"></a>
# **GetFolders**
> ODataFolders GetFolders (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of Folder CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFoldersExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of Folder CatalogItems.
                ODataFolders result = apiInstance.GetFolders(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.GetFolders: " + e.Message );
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

[**ODataFolders**](ODataFolders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchcatalogitemsinfolder"></a>
# **SearchCatalogItemsInFolder**
> ODataDependentItems SearchCatalogItemsInFolder (string id, string searchText)

Searches items in a given folder.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SearchCatalogItemsInFolderExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var searchText = searchText_example;  // string | Name of item to search in the folder.

            try
            {
                // Searches items in a given folder.
                ODataDependentItems result = apiInstance.SearchCatalogItemsInFolder(id, searchText);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.SearchCatalogItemsInFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **searchText** | **string**| Name of item to search in the folder. | 

### Return type

[**ODataDependentItems**](ODataDependentItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfolderpolicies"></a>
# **SetFolderPolicies**
> void SetFolderPolicies (string id, List<ItemPolicy> itemPolicy)

Replaces ItemPolicies associated with the Folder item specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetFolderPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the Folder item specified by the Id.
                apiInstance.SetFolderPolicies(id, itemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.SetFolderPolicies: " + e.Message );
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

<a name="updatefolder"></a>
# **UpdateFolder**
> void UpdateFolder (string id, Folder folder)

Updates the specified Folder CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateFolderExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var folder = new Folder(); // Folder | Definition of the Folder item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified Folder CatalogItem using the provided definition.
                apiInstance.UpdateFolder(id, folder);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.UpdateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **folder** | [**Folder**](Folder.md)| Definition of the Folder item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatefolderproperties"></a>
# **UpdateFolderProperties**
> void UpdateFolderProperties (string id, List<Property> properties)

Updates the Folder Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateFolderPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new FoldersApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the Folder Properties included in the given list.
                apiInstance.UpdateFolderProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FoldersApi.UpdateFolderProperties: " + e.Message );
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

