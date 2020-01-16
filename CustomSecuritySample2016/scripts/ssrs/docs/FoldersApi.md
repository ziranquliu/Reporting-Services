# SqlServer2017ReportingServicesRestApi.FoldersApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addFolder**](FoldersApi.md#addFolder) | **POST** /Folders | Creates a new Folder CatalogItem.
[**deleteFolder**](FoldersApi.md#deleteFolder) | **DELETE** /Folders({Id}) | Deletes the specified Folder.
[**getFolder**](FoldersApi.md#getFolder) | **GET** /Folders({Id}) | Gets a Folder CatalogItem specified by the Id.
[**getFolderAllowedActions**](FoldersApi.md#getFolderAllowedActions) | **GET** /Folders({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**getFolderCatalogItems**](FoldersApi.md#getFolderCatalogItems) | **GET** /Folders({Id})/CatalogItems | Gets a list of child CatalogItems in the specified folder.
[**getFolderPolicies**](FoldersApi.md#getFolderPolicies) | **GET** /Folders({Id})/Policies | Gets policies associated with the Folder CatalogItem specified by the Id.
[**getFolderProperties**](FoldersApi.md#getFolderProperties) | **GET** /Folders({Id})/Properties | Gets Folder Properties (takes list of Property names to retrieve the values)
[**getFolders**](FoldersApi.md#getFolders) | **GET** /Folders | Gets an array of Folder CatalogItems.
[**searchCatalogItemsInFolder**](FoldersApi.md#searchCatalogItemsInFolder) | **POST** /Folders({Id})/Model.SearchItems(searchText=%27{searchText}%27) | Searches items in a given folder.
[**setFolderPolicies**](FoldersApi.md#setFolderPolicies) | **PUT** /Folders({Id})/Policies | Replaces ItemPolicies associated with the Folder item specified by the Id.
[**updateFolder**](FoldersApi.md#updateFolder) | **PATCH** /Folders({Id}) | Updates the specified Folder CatalogItem using the provided definition.
[**updateFolderProperties**](FoldersApi.md#updateFolderProperties) | **PUT** /Folders({Id})/Properties | Updates the Folder Properties included in the given list.


<a name="addFolder"></a>
# **addFolder**
> Folder addFolder(body)

Creates a new Folder CatalogItem.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var body = new SqlServer2017ReportingServicesRestApi.Folder(); // Folder | The definition of the new Folder CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addFolder(body, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Folder**](Folder.md)| The definition of the new Folder CatalogItem. | 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteFolder"></a>
# **deleteFolder**
> deleteFolder(id, )

Deletes the specified Folder.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteFolder(id, , callback);
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

<a name="getFolder"></a>
# **getFolder**
> Folder getFolder(id, )

Gets a Folder CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFolder(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**Folder**](Folder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFolderAllowedActions"></a>
# **getFolderAllowedActions**
> ODataAllowedActions getFolderAllowedActions(id, )

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFolderAllowedActions(id, , callback);
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

<a name="getFolderCatalogItems"></a>
# **getFolderCatalogItems**
> ODataCatalogItems getFolderCatalogItems(id, )

Gets a list of child CatalogItems in the specified folder.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFolderCatalogItems(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataCatalogItems**](ODataCatalogItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getFolderPolicies"></a>
# **getFolderPolicies**
> [ItemPolicy] getFolderPolicies(id, )

Gets policies associated with the Folder CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getFolderPolicies(id, , callback);
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

<a name="getFolderProperties"></a>
# **getFolderProperties**
> ODataProperties getFolderProperties(id, , opts)

Gets Folder Properties (takes list of Property names to retrieve the values)

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

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
apiInstance.getFolderProperties(id, , opts, callback);
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

<a name="getFolders"></a>
# **getFolders**
> ODataFolders getFolders(opts)

Gets an array of Folder CatalogItems.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

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
apiInstance.getFolders(opts, callback);
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

[**ODataFolders**](ODataFolders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="searchCatalogItemsInFolder"></a>
# **searchCatalogItemsInFolder**
> ODataDependentItems searchCatalogItemsInFolder(id, searchText)

Searches items in a given folder.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var searchText = "searchText_example"; // String | Name of item to search in the folder.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.searchCatalogItemsInFolder(id, searchText, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **searchText** | **String**| Name of item to search in the folder. | 

### Return type

[**ODataDependentItems**](ODataDependentItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setFolderPolicies"></a>
# **setFolderPolicies**
> setFolderPolicies(id, itemPolicy)

Replaces ItemPolicies associated with the Folder item specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var itemPolicy = [new SqlServer2017ReportingServicesRestApi.ItemPolicy()]; // [ItemPolicy] | The ItemPolicy definitions that will be replaced.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setFolderPolicies(id, itemPolicy, callback);
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

<a name="updateFolder"></a>
# **updateFolder**
> updateFolder(id, folder)

Updates the specified Folder CatalogItem using the provided definition.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var folder = new SqlServer2017ReportingServicesRestApi.Folder(); // Folder | Definition of the Folder item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateFolder(id, folder, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **folder** | [**Folder**](Folder.md)| Definition of the Folder item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateFolderProperties"></a>
# **updateFolderProperties**
> updateFolderProperties(id, properties)

Updates the Folder Properties included in the given list.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.FoldersApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var properties = [new SqlServer2017ReportingServicesRestApi.Property()]; // [Property] | The Properties that will be updated.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateFolderProperties(id, properties, callback);
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

