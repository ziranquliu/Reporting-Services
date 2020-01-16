# IO.PBIRS.Swagger.Api.ResourcesApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddResource**](ResourcesApi.md#addresource) | **POST** /Resources | Creates new Resource item
[**DeleteResource**](ResourcesApi.md#deleteresource) | **DELETE** /Resources({Id}) | Delete the specified Resource catalog item.
[**GetResource**](ResourcesApi.md#getresource) | **GET** /Resources({Id}) | Get the specified Resource.
[**GetResourceAllowedActions**](ResourcesApi.md#getresourceallowedactions) | **GET** /Resources({Id})/AllowedActions | Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
[**GetResourceContent**](ResourcesApi.md#getresourcecontent) | **GET** /Resources({Id})/Content/$value | Gets the content of the specified Resource CatalogItem specified by the Id.
[**GetResourcePolicies**](ResourcesApi.md#getresourcepolicies) | **GET** /Resources({Id})/Policies | Gets ItemPolicies on the Resource item.
[**GetResourceProperties**](ResourcesApi.md#getresourceproperties) | **GET** /Resources({Id})/Properties | Gets the specified Resources Properties (takes list of Property names to retrieve the values)
[**GetResources**](ResourcesApi.md#getresources) | **GET** /Resources | Gets an array of Resource catalog items
[**SetResourcePolicies**](ResourcesApi.md#setresourcepolicies) | **PUT** /Resources({Id})/Policies | Replaces ItemPolicies on the Resource item.
[**UpdateResource**](ResourcesApi.md#updateresource) | **PATCH** /Resources({Id}) | Updates the specified Resource catalog item.
[**UpdateResourceProperties**](ResourcesApi.md#updateresourceproperties) | **PUT** /Resources({Id})/Properties | Updates the Resource Properties included in the given list.
[**UploadResource**](ResourcesApi.md#uploadresource) | **POST** /Resources({Id})/Model.Upload | Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addresource"></a>
# **AddResource**
> Resource AddResource (Resource resource)

Creates new Resource item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddResourceExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var resource = new Resource(); // Resource | The definition of the new Resource item.

            try
            {
                // Creates new Resource item
                Resource result = apiInstance.AddResource(resource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.AddResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **resource** | [**Resource**](Resource.md)| The definition of the new Resource item. | 

### Return type

[**Resource**](Resource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteresource"></a>
# **DeleteResource**
> void DeleteResource (string id)

Delete the specified Resource catalog item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteResourceExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Delete the specified Resource catalog item.
                apiInstance.DeleteResource(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.DeleteResource: " + e.Message );
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

<a name="getresource"></a>
# **GetResource**
> Resource GetResource (string id)

Get the specified Resource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetResourceExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Get the specified Resource.
                Resource result = apiInstance.GetResource(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResource: " + e.Message );
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

[**Resource**](Resource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresourceallowedactions"></a>
# **GetResourceAllowedActions**
> ODataAllowedActions GetResourceAllowedActions (string id)

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
    public class GetResourceAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
                ODataAllowedActions result = apiInstance.GetResourceAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourceAllowedActions: " + e.Message );
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

<a name="getresourcecontent"></a>
# **GetResourceContent**
> System.IO.Stream GetResourceContent (string id)

Gets the content of the specified Resource CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetResourceContentExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified Resource CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetResourceContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourceContent: " + e.Message );
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

<a name="getresourcepolicies"></a>
# **GetResourcePolicies**
> List<ItemPolicy> GetResourcePolicies (string id)

Gets ItemPolicies on the Resource item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetResourcePoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies on the Resource item.
                List&lt;ItemPolicy&gt; result = apiInstance.GetResourcePolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourcePolicies: " + e.Message );
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

<a name="getresourceproperties"></a>
# **GetResourceProperties**
> ODataProperties GetResourceProperties (string id, List<string> properties)

Gets the specified Resources Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetResourcePropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets the specified Resources Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetResourceProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResourceProperties: " + e.Message );
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

<a name="getresources"></a>
# **GetResources**
> ODataResources GetResources (int? top, int? skip, string filter, string count)

Gets an array of Resource catalog items

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetResourcesExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 

            try
            {
                // Gets an array of Resource catalog items
                ODataResources result = apiInstance.GetResources(top, skip, filter, count);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.GetResources: " + e.Message );
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

[**ODataResources**](ODataResources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setresourcepolicies"></a>
# **SetResourcePolicies**
> void SetResourcePolicies (string id, List<ItemPolicy> policies)

Replaces ItemPolicies on the Resource item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetResourcePoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var policies = new List<ItemPolicy>(); // List<ItemPolicy> | Array of ItemPolicies to set on the Resource CatalogItem.

            try
            {
                // Replaces ItemPolicies on the Resource item.
                apiInstance.SetResourcePolicies(id, policies);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.SetResourcePolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **policies** | [**List<ItemPolicy>**](ItemPolicy.md)| Array of ItemPolicies to set on the Resource CatalogItem. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresource"></a>
# **UpdateResource**
> Resource UpdateResource (string id, Resource resource)

Updates the specified Resource catalog item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateResourceExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var resource = new Resource(); // Resource | Definition of the Resource item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified Resource catalog item.
                Resource result = apiInstance.UpdateResource(id, resource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.UpdateResource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **resource** | [**Resource**](Resource.md)| Definition of the Resource item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

[**Resource**](Resource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateresourceproperties"></a>
# **UpdateResourceProperties**
> void UpdateResourceProperties (string id, List<Property> properties)

Updates the Resource Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateResourcePropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the Resource Properties included in the given list.
                apiInstance.UpdateResourceProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.UpdateResourceProperties: " + e.Message );
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

<a name="uploadresource"></a>
# **UploadResource**
> Resource UploadResource (string id, System.IO.Stream _file)

Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UploadResourceExample
    {
        public void main()
        {
            
            var apiInstance = new ResourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var _file = new System.IO.Stream(); // System.IO.Stream | The file contents.

            try
            {
                // Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
                Resource result = apiInstance.UploadResource(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ResourcesApi.UploadResource: " + e.Message );
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

[**Resource**](Resource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

