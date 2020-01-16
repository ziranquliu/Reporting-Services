# PowerBiReportServerRestApi.ExcelWorkbooksApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addExcelWorkbook**](ExcelWorkbooksApi.md#addExcelWorkbook) | **POST** /ExcelWorkbooks | Creates a new ExcelWorkbook CatalogItem.
[**addExcelWorkbookComment**](ExcelWorkbooksApi.md#addExcelWorkbookComment) | **POST** /ExcelWorkbooks({Id})/Comments | Creates a new Comment associated to the specified ExcelWorkbook.
[**deleteExcelWorkbook**](ExcelWorkbooksApi.md#deleteExcelWorkbook) | **DELETE** /ExcelWorkbooks({Id}) | Deletes the specified ExcelWorkbook.
[**deleteExcelWorkbookComment**](ExcelWorkbooksApi.md#deleteExcelWorkbookComment) | **DELETE** /ExcelWorkbooks({Id})/Comments({CommentId}) | Deletes the specified Comment associated to the ExcelWorkbook.
[**getExcelWorkbook**](ExcelWorkbooksApi.md#getExcelWorkbook) | **GET** /ExcelWorkbooks({Id}) | Gets the ExcelWorkbook CatalogItem specified by the Id.
[**getExcelWorkbookAllowedActions**](ExcelWorkbooksApi.md#getExcelWorkbookAllowedActions) | **GET** /ExcelWorkbooks({Id})/AllowedActions | Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.
[**getExcelWorkbookComments**](ExcelWorkbooksApi.md#getExcelWorkbookComments) | **GET** /ExcelWorkbooks({Id})/Comments | Gets the Comments for a ExcelWorkbook specified by the Id.
[**getExcelWorkbookContent**](ExcelWorkbooksApi.md#getExcelWorkbookContent) | **GET** /ExcelWorkbooks({Id})/Content/$value | Gets the content of the specified ExcelWorkbook CatalogItem specified by the Id.
[**getExcelWorkbookPolicies**](ExcelWorkbooksApi.md#getExcelWorkbookPolicies) | **GET** /ExcelWorkbooks({Id})/Policies | Gets policies associated with the specified ExcelWorkbook CatalogItem.
[**getExcelWorkbookProperties**](ExcelWorkbooksApi.md#getExcelWorkbookProperties) | **GET** /ExcelWorkbooks({Id})/Properties | Gets ExcelWorkbook properties (takes list of property names to retrieve the values)
[**getExcelWorkbooks**](ExcelWorkbooksApi.md#getExcelWorkbooks) | **GET** /ExcelWorkbooks | Gets an array of ExcelWorkbook CatalogItems.
[**setExcelWorkbookPolicies**](ExcelWorkbooksApi.md#setExcelWorkbookPolicies) | **PUT** /ExcelWorkbooks({Id})/Policies | Replaces ItemPolicies associated with the specified ExcelWorkbook item.
[**updateExcelWorkbook**](ExcelWorkbooksApi.md#updateExcelWorkbook) | **PATCH** /ExcelWorkbooks({Id}) | Updates the specified ExcelWorkbook CatalogItem using the provided definition.
[**updateExcelWorkbookComment**](ExcelWorkbooksApi.md#updateExcelWorkbookComment) | **PUT** /ExcelWorkbooks({Id})/Comments({CommentId}) | Updates the Comment specified by CommentId in the associated ExcelWorkbook.
[**updateExcelWorkbookProperties**](ExcelWorkbooksApi.md#updateExcelWorkbookProperties) | **PUT** /ExcelWorkbooks({Id})/Properties | Updates the ExcelWorkbook properties included in the given list.
[**uploadExcelWorkbook**](ExcelWorkbooksApi.md#uploadExcelWorkbook) | **POST** /ExcelWorkbooks({Id})/Model.Upload | Creates a new ExcelWorkbook CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="addExcelWorkbook"></a>
# **addExcelWorkbook**
> ExcelWorkbook addExcelWorkbook(excelWorkbook)

Creates a new ExcelWorkbook CatalogItem.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var excelWorkbook = new PowerBiReportServerRestApi.ExcelWorkbook(); // ExcelWorkbook | The definition of the new ExcelWorkbook CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addExcelWorkbook(excelWorkbook, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excelWorkbook** | [**ExcelWorkbook**](ExcelWorkbook.md)| The definition of the new ExcelWorkbook CatalogItem. | 

### Return type

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="addExcelWorkbookComment"></a>
# **addExcelWorkbookComment**
> addExcelWorkbookComment(id, comment)

Creates a new Comment associated to the specified ExcelWorkbook.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var comment = new PowerBiReportServerRestApi.Comment(); // Comment | The Comment to be created


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.addExcelWorkbookComment(id, comment, callback);
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

<a name="deleteExcelWorkbook"></a>
# **deleteExcelWorkbook**
> deleteExcelWorkbook(id, )

Deletes the specified ExcelWorkbook.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteExcelWorkbook(id, , callback);
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

<a name="deleteExcelWorkbookComment"></a>
# **deleteExcelWorkbookComment**
> deleteExcelWorkbookComment(id, commentId)

Deletes the specified Comment associated to the ExcelWorkbook.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var commentId = "commentId_example"; // String | The Id of the Comment.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteExcelWorkbookComment(id, commentId, callback);
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

<a name="getExcelWorkbook"></a>
# **getExcelWorkbook**
> ExcelWorkbook getExcelWorkbook(id, )

Gets the ExcelWorkbook CatalogItem specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbook(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getExcelWorkbookAllowedActions"></a>
# **getExcelWorkbookAllowedActions**
> ODataAllowedActions getExcelWorkbookAllowedActions(id, )

Gets a list of actions allowed in the current session, user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbookAllowedActions(id, , callback);
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

<a name="getExcelWorkbookComments"></a>
# **getExcelWorkbookComments**
> ODataComments getExcelWorkbookComments(id, )

Gets the Comments for a ExcelWorkbook specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbookComments(id, , callback);
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

<a name="getExcelWorkbookContent"></a>
# **getExcelWorkbookContent**
> File getExcelWorkbookContent(id, )

Gets the content of the specified ExcelWorkbook CatalogItem specified by the Id.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbookContent(id, , callback);
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

<a name="getExcelWorkbookPolicies"></a>
# **getExcelWorkbookPolicies**
> [ItemPolicy] getExcelWorkbookPolicies(id, )

Gets policies associated with the specified ExcelWorkbook CatalogItem.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbookPolicies(id, , callback);
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

<a name="getExcelWorkbookProperties"></a>
# **getExcelWorkbookProperties**
> ODataProperties getExcelWorkbookProperties(id, , opts)

Gets ExcelWorkbook properties (takes list of property names to retrieve the values)

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var opts = { 
  'properties': ["properties_example"] // [String] | Names for the properties to be returned.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getExcelWorkbookProperties(id, , opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**[String]**](String.md)| Names for the properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getExcelWorkbooks"></a>
# **getExcelWorkbooks**
> ODataExcelWorkbooks getExcelWorkbooks(opts)

Gets an array of ExcelWorkbook CatalogItems.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

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
apiInstance.getExcelWorkbooks(opts, callback);
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

[**ODataExcelWorkbooks**](ODataExcelWorkbooks.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setExcelWorkbookPolicies"></a>
# **setExcelWorkbookPolicies**
> setExcelWorkbookPolicies(id, itemPolicy)

Replaces ItemPolicies associated with the specified ExcelWorkbook item.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var itemPolicy = [new PowerBiReportServerRestApi.ItemPolicy()]; // [ItemPolicy] | The ItemPolicy definitions that will be replaced.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setExcelWorkbookPolicies(id, itemPolicy, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **itemPolicy** | [**[ItemPolicy]**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateExcelWorkbook"></a>
# **updateExcelWorkbook**
> updateExcelWorkbook(id, excelWorkbook)

Updates the specified ExcelWorkbook CatalogItem using the provided definition.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var excelWorkbook = new PowerBiReportServerRestApi.ExcelWorkbook(); // ExcelWorkbook | Definition of the ExcelWorkbook item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateExcelWorkbook(id, excelWorkbook, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **excelWorkbook** | [**ExcelWorkbook**](ExcelWorkbook.md)| Definition of the ExcelWorkbook item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateExcelWorkbookComment"></a>
# **updateExcelWorkbookComment**
> updateExcelWorkbookComment(id, commentIdcomment)

Updates the Comment specified by CommentId in the associated ExcelWorkbook.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

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
apiInstance.updateExcelWorkbookComment(id, commentIdcomment, callback);
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

<a name="updateExcelWorkbookProperties"></a>
# **updateExcelWorkbookProperties**
> updateExcelWorkbookProperties(id, properties)

Updates the ExcelWorkbook properties included in the given list.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var properties = [new PowerBiReportServerRestApi.Property()]; // [Property] | The properties that will be updated.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateExcelWorkbookProperties(id, properties, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**[Property]**](Property.md)| The properties that will be updated. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="uploadExcelWorkbook"></a>
# **uploadExcelWorkbook**
> ExcelWorkbook uploadExcelWorkbook(id, file)

Creates a new ExcelWorkbook CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```javascript
var PowerBiReportServerRestApi = require('power_bi_report_server_rest_api');

var apiInstance = new PowerBiReportServerRestApi.ExcelWorkbooksApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var file = "/path/to/file.txt"; // File | The file contents.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.uploadExcelWorkbook(id, file, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **file** | **File**| The file contents. | 

### Return type

[**ExcelWorkbook**](ExcelWorkbook.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

