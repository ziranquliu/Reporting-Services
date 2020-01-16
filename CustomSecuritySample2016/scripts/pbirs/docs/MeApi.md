# PowerBiReportServerRestApi.MeApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getUserDetails**](MeApi.md#getUserDetails) | **GET** /Me | Gets the User object for the current user.


<a name="getUserDetails"></a>
# **getUserDetails**
> User getUserDetails()

Gets the User object for the current user.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.MeApi();

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getUserDetails(callback);
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

