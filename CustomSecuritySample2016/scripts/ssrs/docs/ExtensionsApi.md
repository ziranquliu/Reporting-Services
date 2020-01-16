# SqlServer2017ReportingServicesRestApi.ExtensionsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getExtensionParameters**](ExtensionsApi.md#getExtensionParameters) | **GET** /Extensions({Id})/Parameters | Retrieves the ExtensionParameter list for given extension.
[**getExtensions**](ExtensionsApi.md#getExtensions) | **GET** /Extensions | Retreives all Extension items.
[**validateExtensionParameters**](ExtensionsApi.md#validateExtensionParameters) | **POST** /Extensions/Model.ValidateExtensionSettings | Validates extension parameters and returns collection of ExtensionParameter.


<a name="getExtensionParameters"></a>
# **getExtensionParameters**
> [ExtensionParameter] getExtensionParameters(id, )

Retrieves the ExtensionParameter list for given extension.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.ExtensionsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExtensionParameters(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**[ExtensionParameter]**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getExtensions"></a>
# **getExtensions**
> [Extension] getExtensions()

Retreives all Extension items.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.ExtensionsApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExtensions(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**[Extension]**](Extension.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="validateExtensionParameters"></a>
# **validateExtensionParameters**
> [ExtensionParameter] validateExtensionParameters(opts)

Validates extension parameters and returns collection of ExtensionParameter.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.ExtensionsApi();

var opts = { 
  'extensionSettings': new SqlServer2017ReportingServicesRestApi.ExtensionSettings() // ExtensionSettings | 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.validateExtensionParameters(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **extensionSettings** | [**ExtensionSettings**](ExtensionSettings.md)|  | [optional] 

### Return type

[**[ExtensionParameter]**](ExtensionParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

