# PowerBiReportServerRestApi.SessionApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**createSession**](SessionApi.md#createSession) | **POST** /Session | Creates a new session
[**deleteSession**](SessionApi.md#deleteSession) | **DELETE** /Session | Deletes the currently active session


<a name="createSession"></a>
# **createSession**
> createSession(userCredentials)

Creates a new session

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.SessionApi();

var userCredentials = new PowerBiReportServerRestApi.UserCredentials(); // UserCredentials | The credentials of the user to logon as


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.createSession(userCredentials, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCredentials** | [**UserCredentials**](UserCredentials.md)| The credentials of the user to logon as | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteSession"></a>
# **deleteSession**
> deleteSession()

Deletes the currently active session

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.SessionApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteSession(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

