# PowerBiReportServerRestApi.CacheRefreshPlansApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addCacheRefreshPlan**](CacheRefreshPlansApi.md#addCacheRefreshPlan) | **POST** /CacheRefreshPlans | Creates a new CacheRefreshPlan item.
[**deleteCacheRefreshPlan**](CacheRefreshPlansApi.md#deleteCacheRefreshPlan) | **DELETE** /CacheRefreshPlans({Id}) | Deletes the specified CacheRefreshPlan.
[**executeCacheRefreshPlan**](CacheRefreshPlansApi.md#executeCacheRefreshPlan) | **POST** /CacheRefreshPlans({Id})/Model.Execute | Executes given CacheRefreshPlan immediately.
[**getCacheRefreshPlan**](CacheRefreshPlansApi.md#getCacheRefreshPlan) | **GET** /CacheRefreshPlans({Id}) | Gets a CacheRefreshPlan item specified by the Id.
[**getCacheRefreshPlanHistory**](CacheRefreshPlansApi.md#getCacheRefreshPlanHistory) | **GET** /CacheRefreshPlans({Id})/History | Gets an array of history or execution records for the specified cache refresh plan.
[**setCacheRefreshPlan**](CacheRefreshPlansApi.md#setCacheRefreshPlan) | **PUT** /CacheRefreshPlans({Id}) | Replaces the specified CacheRefreshPlan item using the provided definition.


<a name="addCacheRefreshPlan"></a>
# **addCacheRefreshPlan**
> CacheRefreshPlan addCacheRefreshPlan(cacheRefreshPlan)

Creates a new CacheRefreshPlan item.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var cacheRefreshPlan = new PowerBiReportServerRestApi.CacheRefreshPlan(); // CacheRefreshPlan | The definition of the new CacheRefreshPlan item.


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
> deleteCacheRefreshPlan(id)

Deletes the specified CacheRefreshPlan.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteCacheRefreshPlan(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="executeCacheRefreshPlan"></a>
# **executeCacheRefreshPlan**
> executeCacheRefreshPlan(id)

Executes given CacheRefreshPlan immediately.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.executeCacheRefreshPlan(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getCacheRefreshPlan"></a>
# **getCacheRefreshPlan**
> CacheRefreshPlan getCacheRefreshPlan(id)

Gets a CacheRefreshPlan item specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getCacheRefreshPlan(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getCacheRefreshPlanHistory"></a>
# **getCacheRefreshPlanHistory**
> ODataSubscriptionHistory getCacheRefreshPlanHistory(id)

Gets an array of history or execution records for the specified cache refresh plan.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getCacheRefreshPlanHistory(id, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 

### Return type

[**ODataSubscriptionHistory**](ODataSubscriptionHistory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setCacheRefreshPlan"></a>
# **setCacheRefreshPlan**
> CacheRefreshPlan setCacheRefreshPlan(idcacheRefreshPlan)

Replaces the specified CacheRefreshPlan item using the provided definition.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.CacheRefreshPlansApi();

var id = "id_example"; // String | The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef

var cacheRefreshPlan = new PowerBiReportServerRestApi.CacheRefreshPlan(); // CacheRefreshPlan | Definition of the CacheRefreshPlan item that updates the current item on the server.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.setCacheRefreshPlan(idcacheRefreshPlan, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The GUID that uniquely identifies the CacheRefreshPlan. GUID example: 01234567-89ab-cdef-0123-456789abcdef | 
 **cacheRefreshPlan** | [**CacheRefreshPlan**](CacheRefreshPlan.md)| Definition of the CacheRefreshPlan item that updates the current item on the server. | 

### Return type

[**CacheRefreshPlan**](CacheRefreshPlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

