# IO.PBIRS.Swagger.Api.ExtensionsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExtensionParameters**](ExtensionsApi.md#getextensionparameters) | **GET** /Extensions({Id})/Parameters | Retrieves the ExtensionParameter list for given extension.
[**GetExtensions**](ExtensionsApi.md#getextensions) | **GET** /Extensions | Retreives all Extension items.
[**ValidateExtensionParameters**](ExtensionsApi.md#validateextensionparameters) | **POST** /Extensions/Model.ValidateExtensionSettings | Validates extension parameters and returns collection of ExtensionParameter.


<a name="getextensionparameters"></a>
# **GetExtensionParameters**
> List<ExtensionParameter> GetExtensionParameters (string id)

Retrieves the ExtensionParameter list for given extension.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExtensionParametersExample
    {
        public void main()
        {
            
            var apiInstance = new ExtensionsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Retrieves the ExtensionParameter list for given extension.
                List&lt;ExtensionParameter&gt; result = apiInstance.GetExtensionParameters(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtensionsApi.GetExtensionParameters: " + e.Message );
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

[**List<ExtensionParameter>**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getextensions"></a>
# **GetExtensions**
> List<Extension> GetExtensions ()

Retreives all Extension items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetExtensionsExample
    {
        public void main()
        {
            
            var apiInstance = new ExtensionsApi();

            try
            {
                // Retreives all Extension items.
                List&lt;Extension&gt; result = apiInstance.GetExtensions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtensionsApi.GetExtensions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Extension>**](Extension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validateextensionparameters"></a>
# **ValidateExtensionParameters**
> List<ExtensionParameter> ValidateExtensionParameters (ExtensionSettings extensionSettings)

Validates extension parameters and returns collection of ExtensionParameter.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class ValidateExtensionParametersExample
    {
        public void main()
        {
            
            var apiInstance = new ExtensionsApi();
            var extensionSettings = new ExtensionSettings(); // ExtensionSettings |  (optional) 

            try
            {
                // Validates extension parameters and returns collection of ExtensionParameter.
                List&lt;ExtensionParameter&gt; result = apiInstance.ValidateExtensionParameters(extensionSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExtensionsApi.ValidateExtensionParameters: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **extensionSettings** | [**ExtensionSettings**](ExtensionSettings.md)|  | [optional] 

### Return type

[**List<ExtensionParameter>**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

