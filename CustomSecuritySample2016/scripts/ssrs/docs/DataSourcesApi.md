# SqlServer2017ReportingServicesRestApi.DataSourcesApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addDataSource**](DataSourcesApi.md#addDataSource) | **POST** /DataSources | Creates a new DataSource CatalogItem.
[**checkExistingDataSourceConnection**](DataSourcesApi.md#checkExistingDataSourceConnection) | **POST** /DataSources({Id})/Model.CheckConnection | Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
[**checkNewDataSourceConnection**](DataSourcesApi.md#checkNewDataSourceConnection) | **POST** /DataSources/Model.CheckConnection | Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
[**deleteDataSource**](DataSourcesApi.md#deleteDataSource) | **DELETE** /DataSources({Id}) | Deletes the specified DataSource.
[**getDataSource**](DataSourcesApi.md#getDataSource) | **GET** /DataSources({Id}) | Gets a DataSource CatalogItem specified by the Id.
[**getDataSourceAllowedActions**](DataSourcesApi.md#getDataSourceAllowedActions) | **GET** /DataSources({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**getDataSourceContent**](DataSourcesApi.md#getDataSourceContent) | **GET** /DataSources({Id})/Content/$value | Gets the content of the DataSource CatalogItem specified by the Id.
[**getDataSourceDependentItems**](DataSourcesApi.md#getDataSourceDependentItems) | **GET** /DataSources({Id})/DependentItems | Returns a list of CatalogItems that reference the DataSource specified by the Id.
[**getDataSourcePolicies**](DataSourcesApi.md#getDataSourcePolicies) | **GET** /DataSources({Id})/Policies | Gets ItemPolicies associated with the DataSource specified by the Id.
[**getDataSourceQueryFields**](DataSourcesApi.md#getDataSourceQueryFields) | **POST** /DataSources/Model.GetQueryFields | Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
[**getDataSources**](DataSourcesApi.md#getDataSources) | **GET** /DataSources | Gets an array of DataSource CatalogItems.
[**getDatasourceProperties**](DataSourcesApi.md#getDatasourceProperties) | **GET** /DataSources({Id})/Properties | Gets DataSource Properties (takes list of property names to retrieve the values)
[**setDataSourcePolicies**](DataSourcesApi.md#setDataSourcePolicies) | **PUT** /DataSources({Id})/Policies | Replaces ItemPolicies associated with the DataSource specified by the Id.
[**updateDataSource**](DataSourcesApi.md#updateDataSource) | **PATCH** /DataSources({Id}) | Updates the DataSource CatalogItem specified by the Id using the provided definition.
[**updateDatasourceProperties**](DataSourcesApi.md#updateDatasourceProperties) | **PUT** /DataSources({Id})/Properties | Updates the DataSource Properties included in the given list.


<a name="addDataSource"></a>
# **addDataSource**
> DataSource addDataSource(dataSource)

Creates a new DataSource CatalogItem.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var dataSource = new SqlServer2017ReportingServicesRestApi.DataSource(); // DataSource | The definition of the new DataSource CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addDataSource(dataSource, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataSource** | [**DataSource**](DataSource.md)| The definition of the new DataSource CatalogItem. | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="checkExistingDataSourceConnection"></a>
# **checkExistingDataSourceConnection**
> DataSourceCheckResult checkExistingDataSourceConnection(id, )

Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.checkExistingDataSourceConnection(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="checkNewDataSourceConnection"></a>
# **checkNewDataSourceConnection**
> DataSourceCheckResult checkNewDataSourceConnection(dataSource)

Tests the connection for a data source. This method supports the direct testing of the unsaved data source.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var dataSource = new SqlServer2017ReportingServicesRestApi.DataSource(); // DataSource | The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.checkNewDataSourceConnection(dataSource, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataSource** | [**DataSource**](DataSource.md)| The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. | 

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteDataSource"></a>
# **deleteDataSource**
> deleteDataSource(id, )

Deletes the specified DataSource.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteDataSource(id, , callback);
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

<a name="getDataSource"></a>
# **getDataSource**
> DataSource getDataSource(id, )

Gets a DataSource CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSource(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSourceAllowedActions"></a>
# **getDataSourceAllowedActions**
> ODataAllowedActions getDataSourceAllowedActions(id, )

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSourceAllowedActions(id, , callback);
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

<a name="getDataSourceContent"></a>
# **getDataSourceContent**
> File getDataSourceContent(id, )

Gets the content of the DataSource CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSourceContent(id, , callback);
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

<a name="getDataSourceDependentItems"></a>
# **getDataSourceDependentItems**
> ODataDependentItems getDataSourceDependentItems(id, )

Returns a list of CatalogItems that reference the DataSource specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSourceDependentItems(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDependentItems**](ODataDependentItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSourcePolicies"></a>
# **getDataSourcePolicies**
> [ItemPolicy] getDataSourcePolicies(id, )

Gets ItemPolicies associated with the DataSource specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSourcePolicies(id, , callback);
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

<a name="getDataSourceQueryFields"></a>
# **getDataSourceQueryFields**
> ODataQueryFields getDataSourceQueryFields(opts)

Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var opts = { 
  'queryFieldsRequest': new SqlServer2017ReportingServicesRestApi.QueryFieldsRequest() // QueryFieldsRequest | 
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSourceQueryFields(opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryFieldsRequest** | [**QueryFieldsRequest**](QueryFieldsRequest.md)|  | [optional] 

### Return type

[**ODataQueryFields**](ODataQueryFields.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSources"></a>
# **getDataSources**
> ODataDataSources getDataSources(opts)

Gets an array of DataSource CatalogItems.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

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
apiInstance.getDataSources(opts, callback);
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

[**ODataDataSources**](ODataDataSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDatasourceProperties"></a>
# **getDatasourceProperties**
> ODataProperties getDatasourceProperties(id, , opts)

Gets DataSource Properties (takes list of property names to retrieve the values)

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

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
apiInstance.getDatasourceProperties(id, , opts, callback);
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

<a name="setDataSourcePolicies"></a>
# **setDataSourcePolicies**
> setDataSourcePolicies(id, itemPolicy)

Replaces ItemPolicies associated with the DataSource specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var itemPolicy = [new SqlServer2017ReportingServicesRestApi.ItemPolicy()]; // [ItemPolicy] | The ItemPolicy definitions that will be replaced.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setDataSourcePolicies(id, itemPolicy, callback);
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

<a name="updateDataSource"></a>
# **updateDataSource**
> updateDataSource(id, dataSource)

Updates the DataSource CatalogItem specified by the Id using the provided definition.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSource = new SqlServer2017ReportingServicesRestApi.DataSource(); // DataSource | Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateDataSource(id, dataSource, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSource** | [**DataSource**](DataSource.md)| Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateDatasourceProperties"></a>
# **updateDatasourceProperties**
> updateDatasourceProperties(id, properties)

Updates the DataSource Properties included in the given list.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSourcesApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var properties = [new SqlServer2017ReportingServicesRestApi.Property()]; // [Property] | The Properties that will be updated.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateDatasourceProperties(id, properties, callback);
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

