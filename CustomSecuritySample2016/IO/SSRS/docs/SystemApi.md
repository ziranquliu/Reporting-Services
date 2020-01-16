# IO.SSRS.Swagger.Api.SystemApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSystemAllowedActions**](SystemApi.md#getsystemallowedactions) | **GET** /System/AllowedActions | Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetSystemInfo**](SystemApi.md#getsysteminfo) | **GET** /System | Get SystemInformation
[**GetSystemPolicies**](SystemApi.md#getsystempolicies) | **GET** /System/Policies | Gets the System Policies.
[**GetSystemProperties**](SystemApi.md#getsystemproperties) | **GET** /System/Properties | Gets the Systems Properties (takes list of Property names to retrieve the values)
[**SetSystemPolicies**](SystemApi.md#setsystempolicies) | **PUT** /System/Policies | Updates the System&#39;s Policies.
[**UpdateSystemProperties**](SystemApi.md#updatesystemproperties) | **PATCH** /System/Properties | Updates the System Properties with the given property list.


<a name="getsystemallowedactions"></a>
# **GetSystemAllowedActions**
> ODataAllowedActions GetSystemAllowedActions ()

Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSystemAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();

            try
            {
                // Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetSystemAllowedActions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemAllowedActions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ODataAllowedActions**](ODataAllowedActions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsysteminfo"></a>
# **GetSystemInfo**
> SystemInfo GetSystemInfo ()

Get SystemInformation

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSystemInfoExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();

            try
            {
                // Get SystemInformation
                SystemInfo result = apiInstance.GetSystemInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SystemInfo**](SystemInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystempolicies"></a>
# **GetSystemPolicies**
> List<Policy> GetSystemPolicies ()

Gets the System Policies.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSystemPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();

            try
            {
                // Gets the System Policies.
                List&lt;Policy&gt; result = apiInstance.GetSystemPolicies();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Policy>**](Policy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsystemproperties"></a>
# **GetSystemProperties**
> ODataProperties GetSystemProperties (List<string> properties)

Gets the Systems Properties (takes list of Property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSystemPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets the Systems Properties (takes list of Property names to retrieve the values)
                ODataProperties result = apiInstance.GetSystemProperties(properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.GetSystemProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properties** | [**List<string>**](string.md)| Names for the Properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setsystempolicies"></a>
# **SetSystemPolicies**
> void SetSystemPolicies (SystemPolicy systemPolicy)

Updates the System's Policies.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetSystemPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();
            var systemPolicy = new SystemPolicy(); // SystemPolicy | The SystemPolicy object that contains settings to apply.

            try
            {
                // Updates the System's Policies.
                apiInstance.SetSystemPolicies(systemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.SetSystemPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemPolicy** | [**SystemPolicy**](SystemPolicy.md)| The SystemPolicy object that contains settings to apply. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesystemproperties"></a>
# **UpdateSystemProperties**
> void UpdateSystemProperties (List<Property> properties)

Updates the System Properties with the given property list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateSystemPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new SystemApi();
            var properties = new List<Property>(); // List<Property> | Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the System Properties with the given property list.
                apiInstance.UpdateSystemProperties(properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemApi.UpdateSystemProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properties** | [**List<Property>**](Property.md)| Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

