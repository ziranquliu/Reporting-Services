# SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addCacheRefreshPlan**](CacheRefreshPlansApi.md#addCacheRefreshPlan) | **POST** /CacheRefreshPlans | Creates a new CacheRefreshPlan item.
[**deleteCacheRefreshPlan**](CacheRefreshPlansApi.md#deleteCacheRefreshPlan) | **DELETE** /CacheRefreshPlans({Id}) | Deletes the specified CacheRefreshPlan.
[**executeCacheRefreshPlan**](CacheRefreshPlansApi.md#executeCacheRefreshPlan) | **POST** /CacheRefreshPlans({Id})/Model.Execute | Executes given CacheRefreshPlan immediately.
[**getCacheRefreshPlan**](CacheRefreshPlansApi.md#getCacheRefreshPlan) | **GET** /CacheRefreshPlans({Id}) | Gets a CacheRefreshPlan item specified by the Id.
[**setCacheRefreshPlan**](CacheRefreshPlansApi.md#setCacheRefreshPlan) | **PUT** /CacheRefreshPlans({Id}) | Replaces the specified CacheRefreshPlan item using the provided definition.


<a name="addCacheRefreshPlan"></a>
# **addCacheRefreshPlan**
> CacheRefreshPlan addCacheRefreshPlan(cacheRefreshPlan)

Creates a new CacheRefreshPlan item.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi();

var cacheRefreshPlan = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlan(); // CacheRefreshPlan | The definition of the new CacheRefreshPlan item.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addCacheRefreshPlan(cacheRefreshPlan, callback);
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

<a name="deleteCacheRefreshPlan"></a>
# **deleteCacheRefreshPlan**
> deleteCacheRefreshPlan(id, )

Deletes the specified CacheRefreshPlan.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteCacheRefreshPlan(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="executeCacheRefreshPlan"></a>
# **executeCacheRefreshPlan**
> executeCacheRefreshPlan(id, )

Executes given CacheRefreshPlan immediately.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.executeCacheRefreshPlan(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getCacheRefreshPlan"></a>
# **getCacheRefreshPlan**
> CacheRefreshPlan getCacheRefreshPlan(id, )

Gets a CacheRefreshPlan item specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getCacheRefreshPlan(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setCacheRefreshPlan"></a>
# **setCacheRefreshPlan**
> CacheRefreshPlan setCacheRefreshPlan(id, cacheRefreshPlan)

Replaces the specified CacheRefreshPlan item using the provided definition.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var cacheRefreshPlan = new SqlServer2017ReportingServicesRestApi.CacheRefreshPlan(); // CacheRefreshPlan | Definition of the CacheRefreshPlan item that updates the current item on the server.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.setCacheRefreshPlan(id, cacheRefreshPlan, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md)| Definition of the CacheRefreshPlan item that updates the current item on the server. | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

