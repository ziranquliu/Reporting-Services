# PowerBiReportServerRestApi.PowerBIReportsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addPowerBIReport**](PowerBIReportsApi.md#addPowerBIReport) | **POST** /PowerBIReports | Creates a new PowerBIReport CatalogItem.
[**addPowerBIReportComment**](PowerBIReportsApi.md#addPowerBIReportComment) | **POST** /PowerBIReports({Id})/Comments | Creates a new Comment associated to the specified PowerBIReport.
[**checkPowerBIReportDataSourceConnection**](PowerBIReportsApi.md#checkPowerBIReportDataSourceConnection) | **POST** /PowerBIReports({Id})/Model.CheckDataSourceConnection | Checks the status of the specified DataSource connection.
[**deletePowerBIReport**](PowerBIReportsApi.md#deletePowerBIReport) | **DELETE** /PowerBIReports({Id}) | Deletes the specified PowerBIReport.
[**deletePowerBIReportComment**](PowerBIReportsApi.md#deletePowerBIReportComment) | **DELETE** /PowerBIReports({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the PowerBIReport.
[**getPowerBICacheRefreshPlans**](PowerBIReportsApi.md#getPowerBICacheRefreshPlans) | **GET** /PowerBIReports({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a given Power BI Report.
[**getPowerBIReport**](PowerBIReportsApi.md#getPowerBIReport) | **GET** /PowerBIReports({Id}) | Gets a PowerBIReport CatalogItem specified by the Id.
[**getPowerBIReportAllowedActions**](PowerBIReportsApi.md#getPowerBIReportAllowedActions) | **GET** /PowerBIReports({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**getPowerBIReportComments**](PowerBIReportsApi.md#getPowerBIReportComments) | **GET** /PowerBIReports({Id})/Comments | Gets the Comments for a PowerBIReport specified by the Id.
[**getPowerBIReportContent**](PowerBIReportsApi.md#getPowerBIReportContent) | **GET** /PowerBIReports({Id})/Content/$value | Gets the content of the specified PowerBIReport CatalogItem.
[**getPowerBIReportDataModelRoleAssignments**](PowerBIReportsApi.md#getPowerBIReportDataModelRoleAssignments) | **GET** /PowerBIReports({Id})/DataModelRoleAssignments | Gets the data model role assignments that are associated with the specified PowerBIReport.
[**getPowerBIReportDataModelRoles**](PowerBIReportsApi.md#getPowerBIReportDataModelRoles) | **GET** /PowerBIReports({Id})/DataModelRoles | Gets the data model roles that are associated with the specified PowerBIReport.
[**getPowerBIReportDataSources**](PowerBIReportsApi.md#getPowerBIReportDataSources) | **GET** /PowerBIReports({Id})/DataSources | Gets the DataSources that are associated with the specified PowerBIReport.
[**getPowerBIReportPolicies**](PowerBIReportsApi.md#getPowerBIReportPolicies) | **GET** /PowerBIReports({Id})/Policies | Gets ItemPolicies associated with the specified PowerBIReport CatalogItem.
[**getPowerBIReportProperties**](PowerBIReportsApi.md#getPowerBIReportProperties) | **GET** /PowerBIReports({Id})/Properties | Gets PowerBIReports Properties (takes list of Property names to retrieve the values)
[**getPowerBIReports**](PowerBIReportsApi.md#getPowerBIReports) | **GET** /PowerBIReports | Gets an array of PowerBIReport CatalogItems.
[**replacePowerBIReportDataModelRoleAssignments**](PowerBIReportsApi.md#replacePowerBIReportDataModelRoleAssignments) | **PUT** /PowerBIReports({Id})/DataModelRoleAssignments | Replaces the data model role assignments that are associated with the specified PowerBIReport.
[**setPowerBIReportPolicies**](PowerBIReportsApi.md#setPowerBIReportPolicies) | **PUT** /PowerBIReports({Id})/Policies | Replaces ItemPolicies associated with the specified PowerBIReport item.
[**updatePowerBIReport**](PowerBIReportsApi.md#updatePowerBIReport) | **PATCH** /PowerBIReports({Id}) | Updates the specified PowerBIReport CatalogItem using the provided definition.
[**updatePowerBIReportComment**](PowerBIReportsApi.md#updatePowerBIReportComment) | **PUT** /PowerBIReports({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated PowerBIReport.
[**updatePowerBIReportDataSource**](PowerBIReportsApi.md#updatePowerBIReportDataSource) | **PATCH** /PowerBIReports({Id})/DataSources | Updates the DataSource definition associated with the PowerBIReport specified by the Id.
[**updatePowerBIReportProperties**](PowerBIReportsApi.md#updatePowerBIReportProperties) | **PUT** /PowerBIReports({Id})/Properties | Updates the PowerBIReport Properties included in the given list.
[**uploadPowerBIReport**](PowerBIReportsApi.md#uploadPowerBIReport) | **POST** /PowerBIReports({Id})/Model.Upload | Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addPowerBIReport"></a>
# **addPowerBIReport**
> PowerBIReport addPowerBIReport(powerBIReport)

Creates a new PowerBIReport CatalogItem.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var powerBIReport = new PowerBiReportServerRestApi.PowerBIReport(); // PowerBIReport | The definition of the new PowerBIReport CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addPowerBIReport(powerBIReport, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **powerBIReport** | [**PowerBIReport**](PowerBIReport.md)| The definition of the new PowerBIReport CatalogItem. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="addPowerBIReportComment"></a>
# **addPowerBIReportComment**
> addPowerBIReportComment(id, comment)

Creates a new Comment associated to the specified PowerBIReport.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var comment = new PowerBiReportServerRestApi.Comment(); // Comment | The Comment to be created


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.addPowerBIReportComment(id, comment, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **comment** | [**Comment**](Comment.md)| The Comment to be created | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="checkPowerBIReportDataSourceConnection"></a>
# **checkPowerBIReportDataSourceConnection**
> DataSourceCheckResult checkPowerBIReportDataSourceConnection(id, dataSourceName)

Checks the status of the specified DataSource connection.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSourceName = "dataSourceName_example"; // String | The name of the DataSource to check.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.checkPowerBIReportDataSourceConnection(id, dataSourceName, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceName** | **String**| The name of the DataSource to check. | 

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deletePowerBIReport"></a>
# **deletePowerBIReport**
> deletePowerBIReport(id, )

Deletes the specified PowerBIReport.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deletePowerBIReport(id, , callback);
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

<a name="deletePowerBIReportComment"></a>
# **deletePowerBIReportComment**
> deletePowerBIReportComment(id, commentId)

Deletes the specified Comment associated to the PowerBIReport.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var commentId = "commentId_example"; // String | The Id of the Comment.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deletePowerBIReportComment(id, commentId, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **commentId** | **String**| The Id of the Comment. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBICacheRefreshPlans"></a>
# **getPowerBICacheRefreshPlans**
> ODataCacheRefreshPlans getPowerBICacheRefreshPlans(id, )

Gets the CacheRefreshPlans for a given Power BI Report.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBICacheRefreshPlans(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataCacheRefreshPlans**](ODataCacheRefreshPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReport"></a>
# **getPowerBIReport**
> PowerBIReport getPowerBIReport(id, )

Gets a PowerBIReport CatalogItem specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReport(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportAllowedActions"></a>
# **getPowerBIReportAllowedActions**
> ODataAllowedActions getPowerBIReportAllowedActions(id, )

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportAllowedActions(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataAllowedActions**](ODataAllowedActions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportComments"></a>
# **getPowerBIReportComments**
> ODataComments getPowerBIReportComments(id, )

Gets the Comments for a PowerBIReport specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportComments(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataComments**](ODataComments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportContent"></a>
# **getPowerBIReportContent**
> File getPowerBIReportContent(id, )

Gets the content of the specified PowerBIReport CatalogItem.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportContent(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

**File**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

<a name="getPowerBIReportDataModelRoleAssignments"></a>
# **getPowerBIReportDataModelRoleAssignments**
> ODataDataModelRoleAssignments getPowerBIReportDataModelRoleAssignments(id, )

Gets the data model role assignments that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportDataModelRoleAssignments(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataModelRoleAssignments**](ODataDataModelRoleAssignments.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportDataModelRoles"></a>
# **getPowerBIReportDataModelRoles**
> ODataDataModelRoles getPowerBIReportDataModelRoles(id, )

Gets the data model roles that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportDataModelRoles(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataModelRoles**](ODataDataModelRoles.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportDataSources"></a>
# **getPowerBIReportDataSources**
> ODataDataSources getPowerBIReportDataSources(id, )

Gets the DataSources that are associated with the specified PowerBIReport.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportDataSources(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDataSources**](ODataDataSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportPolicies"></a>
# **getPowerBIReportPolicies**
> [ItemPolicy] getPowerBIReportPolicies(id, )

Gets ItemPolicies associated with the specified PowerBIReport CatalogItem.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReportPolicies(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**[ItemPolicy]**](ItemPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReportProperties"></a>
# **getPowerBIReportProperties**
> ODataProperties getPowerBIReportProperties(id, , opts)

Gets PowerBIReports Properties (takes list of Property names to retrieve the values)

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

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
apiInstance.getPowerBIReportProperties(id, , opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**[String]**](String.md)| Names for the Properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getPowerBIReports"></a>
# **getPowerBIReports**
> ODataPowerBIReports getPowerBIReports(opts)

Gets an array of PowerBIReport CatalogItems.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var opts = { 
  'top': 56, // Number | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)
  'skip': 56, // Number | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)
  'filter': "filter_example", // String | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)
  'count': "count_example", // String | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)
  'orderBy': "orderBy_example", // String | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)
  'select': "select_example" // String | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getPowerBIReports(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **Number**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **Number**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **String**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **String**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **String**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **select** | **String**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**ODataPowerBIReports**](ODataPowerBIReports.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="replacePowerBIReportDataModelRoleAssignments"></a>
# **replacePowerBIReportDataModelRoleAssignments**
> replacePowerBIReportDataModelRoleAssignments(id, dataModelRoleAssignments)

Replaces the data model role assignments that are associated with the specified PowerBIReport.

Added in January 2019 Release

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataModelRoleAssignments = [new PowerBiReportServerRestApi.DataModelRoleAssignment()]; // [DataModelRoleAssignment] | Updated data model role assignments associated with the specified PowerBIReport.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.replacePowerBIReportDataModelRoleAssignments(id, dataModelRoleAssignments, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataModelRoleAssignments** | [**[DataModelRoleAssignment]**](DataModelRoleAssignment.md)| Updated data model role assignments associated with the specified PowerBIReport. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setPowerBIReportPolicies"></a>
# **setPowerBIReportPolicies**
> setPowerBIReportPolicies(id, itemPolicies)

Replaces ItemPolicies associated with the specified PowerBIReport item.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var itemPolicies = [new PowerBiReportServerRestApi.ItemPolicy()]; // [ItemPolicy] | The ItemPolicy definitions that will be replaced.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setPowerBIReportPolicies(id, itemPolicies, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **itemPolicies** | [**[ItemPolicy]**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePowerBIReport"></a>
# **updatePowerBIReport**
> PowerBIReport updatePowerBIReport(id, powerBIReport)

Updates the specified PowerBIReport CatalogItem using the provided definition.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var powerBIReport = new PowerBiReportServerRestApi.PowerBIReport(); // PowerBIReport | Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.updatePowerBIReport(id, powerBIReport, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **powerBIReport** | [**PowerBIReport**](PowerBIReport.md)| Definition of the PowerBIReport item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePowerBIReportComment"></a>
# **updatePowerBIReportComment**
> updatePowerBIReportComment(id, commentIdcomment)

Updates the Comment specified by CommentId in the associated PowerBIReport.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var commentId = "commentId_example"; // String | The Id of the Comment.

var comment = new PowerBiReportServerRestApi.Comment(); // Comment | The Comment to be updated


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updatePowerBIReportComment(id, commentIdcomment, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **commentId** | **String**| The Id of the Comment. | 
 **comment** | [**Comment**](Comment.md)| The Comment to be updated | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePowerBIReportDataSource"></a>
# **updatePowerBIReportDataSource**
> updatePowerBIReportDataSource(id, dataSources)

Updates the DataSource definition associated with the PowerBIReport specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSources = [new PowerBiReportServerRestApi.DataSource()]; // [DataSource] | Updated definition for the DataSource associated with the PowerBIReport specified by the Id.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updatePowerBIReportDataSource(id, dataSources, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSources** | [**[DataSource]**](DataSource.md)| Updated definition for the DataSource associated with the PowerBIReport specified by the Id. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updatePowerBIReportProperties"></a>
# **updatePowerBIReportProperties**
> updatePowerBIReportProperties(id, properties)

Updates the PowerBIReport Properties included in the given list.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var properties = [new PowerBiReportServerRestApi.Property()]; // [Property] | The Properties that will be updated.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updatePowerBIReportProperties(id, properties, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**[Property]**](Property.md)| The Properties that will be updated. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="uploadPowerBIReport"></a>
# **uploadPowerBIReport**
> PowerBIReport uploadPowerBIReport(id, file)

Does an efficient binary upload of a new or existing PowerBIReport CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.PowerBIReportsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var file = "/path/to/file.txt"; // File | The file contents.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.uploadPowerBIReport(id, file, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **file** | **File**| The file contents. | 

### Return type

[**PowerBIReport**](PowerBIReport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

