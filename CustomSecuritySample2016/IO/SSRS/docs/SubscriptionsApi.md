# IO.SSRS.Swagger.Api.SubscriptionsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddSubscription**](SubscriptionsApi.md#addsubscription) | **POST** /Subscriptions | Creates new Subscription item
[**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /Subscriptions({Id}) | Deletes the specified Subscription.
[**DisableSubscription**](SubscriptionsApi.md#disablesubscription) | **POST** /Subscriptions({Id})/Model.Disable | Disables the Subscription specified by the Id.
[**EnableSubscription**](SubscriptionsApi.md#enablesubscription) | **POST** /Subscriptions({Id})/Model.Enable | Enables a Subscription specified by the Id.
[**ExecuteSubscription**](SubscriptionsApi.md#executesubscription) | **POST** /Subscriptions({Id})/Model.Execute | Executes the Subscription specified by the Id.
[**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /Subscriptions({Id}) | Get the specified Subscription.
[**GetSubscriptions**](SubscriptionsApi.md#getsubscriptions) | **GET** /Subscriptions | Gets an array of Subscriptions.
[**SetSubscription**](SubscriptionsApi.md#setsubscription) | **PUT** /Subscriptions({Id}) | Replaces the Subscription item using Id property as key.
[**UpdateSubscription**](SubscriptionsApi.md#updatesubscription) | **PATCH** /Subscriptions({Id}) | Updates the Subscription item using Id property as key.


<a name="addsubscription"></a>
# **AddSubscription**
> Subscription AddSubscription (Subscription subscription)

Creates new Subscription item

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var subscription = new Subscription(); // Subscription | The definition of the new Subscription item.

            try
            {
                // Creates new Subscription item
                Subscription result = apiInstance.AddSubscription(subscription);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.AddSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscription** | [**Subscription**](Subscription.md)| The definition of the new Subscription item. | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (string id)

Deletes the specified Subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

            try
            {
                // Deletes the specified Subscription.
                apiInstance.DeleteSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="disablesubscription"></a>
# **DisableSubscription**
> void DisableSubscription (string id)

Disables the Subscription specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DisableSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

            try
            {
                // Disables the Subscription specified by the Id.
                apiInstance.DisableSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.DisableSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="enablesubscription"></a>
# **EnableSubscription**
> void EnableSubscription (string id)

Enables a Subscription specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class EnableSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

            try
            {
                // Enables a Subscription specified by the Id.
                apiInstance.EnableSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.EnableSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="executesubscription"></a>
# **ExecuteSubscription**
> void ExecuteSubscription (string id)

Executes the Subscription specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class ExecuteSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

            try
            {
                // Executes the Subscription specified by the Id.
                apiInstance.ExecuteSubscription(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.ExecuteSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscription"></a>
# **GetSubscription**
> Subscription GetSubscription (string id)

Get the specified Subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

            try
            {
                // Get the specified Subscription.
                Subscription result = apiInstance.GetSubscription(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsubscriptions"></a>
# **GetSubscriptions**
> List<Subscription> GetSubscriptions (int? top, int? skip, string filter, string count, string orderBy, string expand, string select)

Gets an array of Subscriptions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetSubscriptionsExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var expand = expand_example;  // string | Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of Subscriptions.
                List&lt;Subscription&gt; result = apiInstance.GetSubscriptions(top, skip, filter, count, orderBy, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.GetSubscriptions: " + e.Message );
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

<a name="setsubscription"></a>
# **SetSubscription**
> void SetSubscription (string id, Subscription subscription)

Replaces the Subscription item using Id property as key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef
            var subscription = new Subscription(); // Subscription | Subscription item to update.

            try
            {
                // Replaces the Subscription item using Id property as key.
                apiInstance.SetSubscription(id, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.SetSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 
 **subscription** | [**Subscription**](Subscription.md)| Subscription item to update. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesubscription"></a>
# **UpdateSubscription**
> void UpdateSubscription (string id, Subscription subscription)

Updates the Subscription item using Id property as key.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateSubscriptionExample
    {
        public void main()
        {
            
            var apiInstance = new SubscriptionsApi();
            var id = id_example;  // string | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef
            var subscription = new Subscription(); // Subscription | Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.

            try
            {
                // Updates the Subscription item using Id property as key.
                apiInstance.UpdateSubscription(id, subscription);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscriptionsApi.UpdateSubscription: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 
 **subscription** | [**Subscription**](Subscription.md)| Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

