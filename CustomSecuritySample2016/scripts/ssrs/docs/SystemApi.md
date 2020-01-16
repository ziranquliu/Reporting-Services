# SqlServer2017ReportingServicesRestApi.SystemApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getSystemAllowedActions**](SystemApi.md#getSystemAllowedActions) | **GET** /System/AllowedActions | Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**getSystemInfo**](SystemApi.md#getSystemInfo) | **GET** /System | Get SystemInformation
[**getSystemPolicies**](SystemApi.md#getSystemPolicies) | **GET** /System/Policies | Gets the System Policies.
[**getSystemProperties**](SystemApi.md#getSystemProperties) | **GET** /System/Properties | Gets the Systems Properties (takes list of Property names to retrieve the values)
[**setSystemPolicies**](SystemApi.md#setSystemPolicies) | **PUT** /System/Policies | Updates the System's Policies.
[**updateSystemProperties**](SystemApi.md#updateSystemProperties) | **PATCH** /System/Properties | Updates the System Properties with the given property list.


<a name="getSystemAllowedActions"></a>
# **getSystemAllowedActions**
> ODataAllowedActions getSystemAllowedActions()

Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSystemAllowedActions(callback);
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

<a name="getSystemInfo"></a>
# **getSystemInfo**
> SystemInfo getSystemInfo()

Get SystemInformation

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSystemInfo(callback);
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

<a name="getSystemPolicies"></a>
# **getSystemPolicies**
> [Policy] getSystemPolicies()

Gets the System Policies.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSystemPolicies(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Policy]**](Policy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getSystemProperties"></a>
# **getSystemProperties**
> ODataProperties getSystemProperties(opts)

Gets the Systems Properties (takes list of Property names to retrieve the values)

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var opts = { 
  'properties': ["properties_example"] // [String] | Names for the Properties to be returned.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getSystemProperties(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properties** | [**[String]**](String.md)| Names for the Properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setSystemPolicies"></a>
# **setSystemPolicies**
> setSystemPolicies(systemPolicy)

Updates the System's Policies.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var systemPolicy = new SqlServer2017ReportingServicesRestApi.SystemPolicy(); // SystemPolicy | The SystemPolicy object that contains settings to apply.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setSystemPolicies(systemPolicy, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemPolicy** | [**SystemPolicy**](SystemPolicy.md)| The SystemPolicy object that contains settings to apply. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateSystemProperties"></a>
# **updateSystemProperties**
> updateSystemProperties(properties)

Updates the System Properties with the given property list.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.SystemApi();

var properties = [new SqlServer2017ReportingServicesRestApi.Property()]; // [Property] | Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateSystemProperties(properties, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **properties** | [**[Property]**](Property.md)| Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

