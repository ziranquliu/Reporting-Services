# SqlServer2017ReportingServicesRestApi.SubscriptionsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addSubscription**](SubscriptionsApi.md#addSubscription) | **POST** /Subscriptions | Creates new Subscription item
[**deleteSubscription**](SubscriptionsApi.md#deleteSubscription) | **DELETE** /Subscriptions({Id}) | Deletes the specified Subscription.
[**disableSubscription**](SubscriptionsApi.md#disableSubscription) | **POST** /Subscriptions({Id})/Model.Disable | Disables the Subscription specified by the Id.
[**enableSubscription**](SubscriptionsApi.md#enableSubscription) | **POST** /Subscriptions({Id})/Model.Enable | Enables a Subscription specified by the Id.
[**executeSubscription**](SubscriptionsApi.md#executeSubscription) | **POST** /Subscriptions({Id})/Model.Execute | Executes the Subscription specified by the Id.
[**getSubscription**](SubscriptionsApi.md#getSubscription) | **GET** /Subscriptions({Id}) | Get the specified Subscription.
[**getSubscriptions**](SubscriptionsApi.md#getSubscriptions) | **GET** /Subscriptions | Gets an array of Subscriptions.
[**setSubscription**](SubscriptionsApi.md#setSubscription) | **PUT** /Subscriptions({Id}) | Replaces the Subscription item using Id property as key.
[**updateSubscription**](SubscriptionsApi.md#updateSubscription) | **PATCH** /Subscriptions({Id}) | Updates the Subscription item using Id property as key.


<a name="addSubscription"></a>
# **addSubscription**
> Subscription addSubscription(subscription)

Creates new Subscription item

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var subscription = new SqlServer2017ReportingServicesRestApi.Subscription(); // Subscription | The definition of the new Subscription item.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addSubscription(subscription, callback);
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

<a name="deleteSubscription"></a>
# **deleteSubscription**
> deleteSubscription(id)

Deletes the specified Subscription.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteSubscription(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="disableSubscription"></a>
# **disableSubscription**
> disableSubscription(id)

Disables the Subscription specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.disableSubscription(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="enableSubscription"></a>
# **enableSubscription**
> enableSubscription(id)

Enables a Subscription specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.enableSubscription(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="executeSubscription"></a>
# **executeSubscription**
> executeSubscription(id)

Executes the Subscription specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.executeSubscription(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getSubscription"></a>
# **getSubscription**
> Subscription getSubscription(id)

Get the specified Subscription.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSubscription(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

[**Subscription**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getSubscriptions"></a>
# **getSubscriptions**
> [Subscription] getSubscriptions(opts)

Gets an array of Subscriptions.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var opts = { 
  'top': 56, // Number | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)
  'skip': 56, // Number | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)
  'filter': "filter_example", // String | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)
  'count': "count_example", // String | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)
  'orderBy': "orderBy_example", // String | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)
  'expand': "expand_example", // String | Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621)
  'select': "select_example" // String | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSubscriptions(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **Number**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **Number**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **String**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **String**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **String**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **expand** | **String**| Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) | [optional] 
 **select** | **String**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**[Subscription]**](Subscription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setSubscription"></a>
# **setSubscription**
> setSubscription(idsubscription)

Replaces the Subscription item using Id property as key.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

var subscription = new SqlServer2017ReportingServicesRestApi.Subscription(); // Subscription | Subscription item to update.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setSubscription(idsubscription, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 
 **subscription** | [**Subscription**](Subscription.md)| Subscription item to update. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateSubscription"></a>
# **updateSubscription**
> updateSubscription(idsubscription)

Updates the Subscription item using Id property as key.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SubscriptionsApi();

var id = "id_example"; // String | The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef

var subscription = new SqlServer2017ReportingServicesRestApi.Subscription(); // Subscription | Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateSubscription(idsubscription, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 
 **subscription** | [**Subscription**](Subscription.md)| Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

