# IO.SSRS.Swagger.Api.CacheRefreshPlansApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCacheRefreshPlan**](CacheRefreshPlansApi.md#addcacherefreshplan) | **POST** /CacheRefreshPlans | Creates a new CacheRefreshPlan item.
[**DeleteCacheRefreshPlan**](CacheRefreshPlansApi.md#deletecacherefreshplan) | **DELETE** /CacheRefreshPlans({Id}) | Deletes the specified CacheRefreshPlan.
[**ExecuteCacheRefreshPlan**](CacheRefreshPlansApi.md#executecacherefreshplan) | **POST** /CacheRefreshPlans({Id})/Model.Execute | Executes given CacheRefreshPlan immediately.
[**GetCacheRefreshPlan**](CacheRefreshPlansApi.md#getcacherefreshplan) | **GET** /CacheRefreshPlans({Id}) | Gets a CacheRefreshPlan item specified by the Id.
[**SetCacheRefreshPlan**](CacheRefreshPlansApi.md#setcacherefreshplan) | **PUT** /CacheRefreshPlans({Id}) | Replaces the specified CacheRefreshPlan item using the provided definition.


<a name="addcacherefreshplan"></a>
# **AddCacheRefreshPlan**
> CacheRefreshPlan AddCacheRefreshPlan (CacheRefreshPlan cacheRefreshPlan)

Creates a new CacheRefreshPlan item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddCacheRefreshPlanExample
    {
        public void main()
        {
            
            var apiInstance = new CacheRefreshPlansApi();
            var cacheRefreshPlan = new CacheRefreshPlan(); // CacheRefreshPlan | The definition of the new CacheRefreshPlan item.

            try
            {
                // Creates a new CacheRefreshPlan item.
                CacheRefreshPlan result = apiInstance.AddCacheRefreshPlan(cacheRefreshPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.AddCacheRefreshPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md)| The definition of the new CacheRefreshPlan item. | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletecacherefreshplan"></a>
# **DeleteCacheRefreshPlan**
> void DeleteCacheRefreshPlan (string id)

Deletes the specified CacheRefreshPlan.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteCacheRefreshPlanExample
    {
        public void main()
        {
            
            var apiInstance = new CacheRefreshPlansApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified CacheRefreshPlan.
                apiInstance.DeleteCacheRefreshPlan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.DeleteCacheRefreshPlan: " + e.Message );
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

<a name="executecacherefreshplan"></a>
# **ExecuteCacheRefreshPlan**
> void ExecuteCacheRefreshPlan (string id)

Executes given CacheRefreshPlan immediately.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class ExecuteCacheRefreshPlanExample
    {
        public void main()
        {
            
            var apiInstance = new CacheRefreshPlansApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Executes given CacheRefreshPlan immediately.
                apiInstance.ExecuteCacheRefreshPlan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.ExecuteCacheRefreshPlan: " + e.Message );
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

<a name="getcacherefreshplan"></a>
# **GetCacheRefreshPlan**
> CacheRefreshPlan GetCacheRefreshPlan (string id)

Gets a CacheRefreshPlan item specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetCacheRefreshPlanExample
    {
        public void main()
        {
            
            var apiInstance = new CacheRefreshPlansApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a CacheRefreshPlan item specified by the Id.
                CacheRefreshPlan result = apiInstance.GetCacheRefreshPlan(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.GetCacheRefreshPlan: " + e.Message );
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

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setcacherefreshplan"></a>
# **SetCacheRefreshPlan**
> CacheRefreshPlan SetCacheRefreshPlan (string id, CacheRefreshPlan cacheRefreshPlan)

Replaces the specified CacheRefreshPlan item using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetCacheRefreshPlanExample
    {
        public void main()
        {
            
            var apiInstance = new CacheRefreshPlansApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var cacheRefreshPlan = new CacheRefreshPlan(); // CacheRefreshPlan | Definition of the CacheRefreshPlan item that updates the current item on the server.

            try
            {
                // Replaces the specified CacheRefreshPlan item using the provided definition.
                CacheRefreshPlan result = apiInstance.SetCacheRefreshPlan(id, cacheRefreshPlan);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CacheRefreshPlansApi.SetCacheRefreshPlan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md)| Definition of the CacheRefreshPlan item that updates the current item on the server. | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

