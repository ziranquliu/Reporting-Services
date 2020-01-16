# SqlServer2017ReportingServicesRestApi.DataSetsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addDataSet**](DataSetsApi.md#addDataSet) | **POST** /DataSets | Creates a new DataSet CatalogItem.
[**deleteDataSet**](DataSetsApi.md#deleteDataSet) | **DELETE** /DataSets({Id}) | Deletes the specified DataSet.
[**getDataSet**](DataSetsApi.md#getDataSet) | **GET** /DataSets({Id}) | Gets a DataSet CatalogItem specified by the Id.
[**getDataSetAggregatedValue**](DataSetsApi.md#getDataSetAggregatedValue) | **POST** /DataSets({Id})/Model.GetAggregatedValue | Gets the value for the specified DataSet column using the given aggregation type.
[**getDataSetAllowedActions**](DataSetsApi.md#getDataSetAllowedActions) | **GET** /DataSets({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**getDataSetCacheOptions**](DataSetsApi.md#getDataSetCacheOptions) | **GET** /DataSets({Id})/CacheOptions | Gets the CacheOption's content for a given DataSet.
[**getDataSetCacheRefreshPlans**](DataSetsApi.md#getDataSetCacheRefreshPlans) | **GET** /DataSets({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a given DataSet.
[**getDataSetContent**](DataSetsApi.md#getDataSetContent) | **GET** /DataSets({Id})/Content/$value | Gets the content of the specified DataSet CatalogItem specified by the Id.
[**getDataSetData**](DataSetsApi.md#getDataSetData) | **POST** /DataSets({Id})/Model.GetData | Gets the query results for the specified DataSet.
[**getDataSetDataSource**](DataSetsApi.md#getDataSetDataSource) | **GET** /DataSets({Id})/DataSources({DataSourceId}) | Gets the DataSource specified by the DataSourceId that is associated with the DataSet.
[**getDataSetDataSources**](DataSetsApi.md#getDataSetDataSources) | **GET** /DataSets({Id})/DataSources | Gets the DataSources associated with the specified DataSet.
[**getDataSetDependentItems**](DataSetsApi.md#getDataSetDependentItems) | **GET** /DataSets({Id})/DependentItems | Returns a list of CatalogItems that reference the specified DataSet.
[**getDataSetParameterDefinitions**](DataSetsApi.md#getDataSetParameterDefinitions) | **GET** /DataSets({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the specified DataSet.
[**getDataSetPolicies**](DataSetsApi.md#getDataSetPolicies) | **GET** /DataSets({Id})/Policies | Gets ItemPolicies associated with the specified DataSet CatalogItem.
[**getDataSetSchema**](DataSetsApi.md#getDataSetSchema) | **GET** /DataSets({Id})/Model.GetSchema | Gets the schema for the specified DataSet.
[**getDataSets**](DataSetsApi.md#getDataSets) | **GET** /DataSets | Gets an array of DataSet CatalogItems.
[**getDatasetProperties**](DataSetsApi.md#getDatasetProperties) | **GET** /DataSets({Id})/Properties | Gets DataSet Properties (takes list of property names to retrieve the values)
[**setDataSetCacheOptions**](DataSetsApi.md#setDataSetCacheOptions) | **PUT** /DataSets({Id})/CacheOptions | Replaces the CacheOption's content for a given DataSet using the provided definition.
[**setDataSetDataSource**](DataSetsApi.md#setDataSetDataSource) | **PUT** /DataSets({Id})/DataSources({DataSourceId}) | Updates the DataSource specified by the DataSourceId that is associated with the DataSet.
[**setDataSetDataSources**](DataSetsApi.md#setDataSetDataSources) | **PUT** /DataSets({Id})/DataSources | Updates the DataSource definition associated with the specified DataSet.
[**setDataSetPolicies**](DataSetsApi.md#setDataSetPolicies) | **PUT** /DataSets({Id})/Policies | Replaces ItemPolicies associated with the specified DataSet item.
[**updateDataSet**](DataSetsApi.md#updateDataSet) | **PATCH** /DataSets({Id}) | Updates the specified DataSet CatalogItem using the provided definition.
[**updateDataSetParameterDefinitions**](DataSetsApi.md#updateDataSetParameterDefinitions) | **PATCH** /DataSets({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the DataSet specified.
[**updateDatasetProperties**](DataSetsApi.md#updateDatasetProperties) | **PUT** /DataSets({Id})/Properties | Updates the DataSet Properties included in the given list.


<a name="addDataSet"></a>
# **addDataSet**
> DataSet addDataSet(dataSet)

Creates a new DataSet CatalogItem.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var dataSet = new SqlServer2017ReportingServicesRestApi.DataSet(); // DataSet | The definition of the new DataSet CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addDataSet(dataSet, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataSet** | [**DataSet**](DataSet.md)| The definition of the new DataSet CatalogItem. | 

### Return type

[**DataSet**](DataSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="deleteDataSet"></a>
# **deleteDataSet**
> deleteDataSet(id, )

Deletes the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.deleteDataSet(id, , callback);
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

<a name="getDataSet"></a>
# **getDataSet**
> DataSet getDataSet(id, )

Gets a DataSet CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSet(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSet**](DataSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetAggregatedValue"></a>
# **getDataSetAggregatedValue**
> ['Number'] getDataSetAggregatedValue(id, columnName, aggregation, opts)

Gets the value for the specified DataSet column using the given aggregation type.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var columnName = "columnName_example"; // String | The name of the DataSet column to aggregate the value for.

var aggregation = "aggregation_example"; // String | The type of aggregation to use on the specified column. Values come from the KpiSharedDataItemAggregation enum.

var opts = { 
  'parameters': new SqlServer2017ReportingServicesRestApi.DataSetAggregateValueParameters() // DataSetAggregateValueParameters | An array of DataSet parameters to use when executing the query.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetAggregatedValue(id, columnName, aggregation, opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **columnName** | **String**| The name of the DataSet column to aggregate the value for. | 
 **aggregation** | **String**| The type of aggregation to use on the specified column. Values come from the KpiSharedDataItemAggregation enum. | 
 **parameters** | [**DataSetAggregateValueParameters**](DataSetAggregateValueParameters.md)| An array of DataSet parameters to use when executing the query. | [optional] 

### Return type

**['Number']**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetAllowedActions"></a>
# **getDataSetAllowedActions**
> ODataAllowedActions getDataSetAllowedActions(id, )

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetAllowedActions(id, , callback);
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

<a name="getDataSetCacheOptions"></a>
# **getDataSetCacheOptions**
> CacheOptions getDataSetCacheOptions(id, )

Gets the CacheOption's content for a given DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetCacheOptions(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**CacheOptions**](CacheOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetCacheRefreshPlans"></a>
# **getDataSetCacheRefreshPlans**
> ODataCacheRefreshPlans getDataSetCacheRefreshPlans(id, )

Gets the CacheRefreshPlans for a given DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetCacheRefreshPlans(id, , callback);
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

<a name="getDataSetContent"></a>
# **getDataSetContent**
> File getDataSetContent(id, )

Gets the content of the specified DataSet CatalogItem specified by the Id.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetContent(id, , callback);
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

<a name="getDataSetData"></a>
# **getDataSetData**
> DataSetData getDataSetData(id, , opts)

Gets the query results for the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var opts = { 
  'maxRows': 8.14, // Number | Specifies the maximum number of rows to return from the query.
  'parameters': new SqlServer2017ReportingServicesRestApi.DataSetDataParameters() // DataSetDataParameters | An array of DataSet parameters to use when executing the query.
};

var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetData(id, , opts, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **maxRows** | **Number**| Specifies the maximum number of rows to return from the query. | [optional] 
 **parameters** | [**DataSetDataParameters**](DataSetDataParameters.md)| An array of DataSet parameters to use when executing the query. | [optional] 

### Return type

[**DataSetData**](DataSetData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetDataSource"></a>
# **getDataSetDataSource**
> DataSource getDataSetDataSource(id, dataSourceId, )

Gets the DataSource specified by the DataSourceId that is associated with the DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSourceId = "dataSourceId_example"; // String | The Id of the DataSource associated with the DataSet.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetDataSource(id, dataSourceId, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceId** | **String**| The Id of the DataSource associated with the DataSet. | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetDataSources"></a>
# **getDataSetDataSources**
> [DataSource] getDataSetDataSources(id, )

Gets the DataSources associated with the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetDataSources(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**[DataSource]**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetDependentItems"></a>
# **getDataSetDependentItems**
> ODataDependentItems getDataSetDependentItems(id, )

Returns a list of CatalogItems that reference the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetDependentItems(id, , callback);
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

<a name="getDataSetParameterDefinitions"></a>
# **getDataSetParameterDefinitions**
> ODataReportParameterDefinitions getDataSetParameterDefinitions(id, )

Gets the ParameterDefinitions associated with the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetParameterDefinitions(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataReportParameterDefinitions**](ODataReportParameterDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSetPolicies"></a>
# **getDataSetPolicies**
> [ItemPolicy] getDataSetPolicies(id, )

Gets ItemPolicies associated with the specified DataSet CatalogItem.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetPolicies(id, , callback);
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

<a name="getDataSetSchema"></a>
# **getDataSetSchema**
> DataSetSchema getDataSetSchema(id, )

Gets the schema for the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getDataSetSchema(id, , callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSetSchema**](DataSetSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDataSets"></a>
# **getDataSets**
> ODataDataSets getDataSets(opts)

Gets an array of DataSet CatalogItems.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

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
apiInstance.getDataSets(opts, callback);
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

[**ODataDataSets**](ODataDataSets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="getDatasetProperties"></a>
# **getDatasetProperties**
> ODataProperties getDatasetProperties(id, , opts)

Gets DataSet Properties (takes list of property names to retrieve the values)

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

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
apiInstance.getDatasetProperties(id, , opts, callback);
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

<a name="setDataSetCacheOptions"></a>
# **setDataSetCacheOptions**
> setDataSetCacheOptions(id, cacheOptions)

Replaces the CacheOption's content for a given DataSet using the provided definition.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var cacheOptions = new SqlServer2017ReportingServicesRestApi.CacheOptions(); // CacheOptions | Updated definition for the CacheOption's content associated with the given DataSet.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setDataSetCacheOptions(id, cacheOptions, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheOptions** | [**CacheOptions**](CacheOptions.md)| Updated definition for the CacheOption's content associated with the given DataSet. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setDataSetDataSource"></a>
# **setDataSetDataSource**
> setDataSetDataSource(id, dataSourceId, dataSource)

Updates the DataSource specified by the DataSourceId that is associated with the DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSourceId = "dataSourceId_example"; // String | The Id of the DataSource associated with the DataSet.

var dataSource = new SqlServer2017ReportingServicesRestApi.DataSource(); // DataSource | Updated definition for the DataSource associated with the DataSet.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setDataSetDataSource(id, dataSourceId, dataSource, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceId** | **String**| The Id of the DataSource associated with the DataSet. | 
 **dataSource** | [**DataSource**](DataSource.md)| Updated definition for the DataSource associated with the DataSet. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setDataSetDataSources"></a>
# **setDataSetDataSources**
> setDataSetDataSources(id, dataSource)

Updates the DataSource definition associated with the specified DataSet.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSource = new SqlServer2017ReportingServicesRestApi.DataSource(); // DataSource | Updated definition for the DataSource associated with the specified DataSet CatalogItem.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setDataSetDataSources(id, dataSource, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSource** | [**DataSource**](DataSource.md)| Updated definition for the DataSource associated with the specified DataSet CatalogItem. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="setDataSetPolicies"></a>
# **setDataSetPolicies**
> setDataSetPolicies(id, itemPolicy)

Replaces ItemPolicies associated with the specified DataSet item.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var itemPolicy = [new SqlServer2017ReportingServicesRestApi.ItemPolicy()]; // [ItemPolicy] | The ItemPolicy definitions that will be replaced.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.setDataSetPolicies(id, itemPolicy, callback);
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

<a name="updateDataSet"></a>
# **updateDataSet**
> updateDataSet(id, dataSet)

Updates the specified DataSet CatalogItem using the provided definition.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var dataSet = new SqlServer2017ReportingServicesRestApi.DataSet(); // DataSet | Definition of the DataSet item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateDataSet(id, dataSet, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSet** | [**DataSet**](DataSet.md)| Definition of the DataSet item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateDataSetParameterDefinitions"></a>
# **updateDataSetParameterDefinitions**
> updateDataSetParameterDefinitions(id, parameterDefinitions)

Updates the ParameterDefinitions associated with the DataSet specified.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var parameterDefinitions = [new SqlServer2017ReportingServicesRestApi.ReportParameterDefinitionPatch()]; // [ReportParameterDefinitionPatch] | Updated definitions for the ParameterDefinitions associated with the DataSet, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property valueswill be left unchanged.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateDataSetParameterDefinitions(id, parameterDefinitions, callback);
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote. | 
 **parameterDefinitions** | [**[ReportParameterDefinitionPatch]**](ReportParameterDefinitionPatch.md)| Updated definitions for the ParameterDefinitions associated with the DataSet, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property valueswill be left unchanged. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateDatasetProperties"></a>
# **updateDatasetProperties**
> updateDatasetProperties(id, properties)

Updates the DataSet Properties included in the given list.

### Example
```javascript
var SqlServer2017ReportingServicesRestApi = require('sql_server_2017_reporting_services_rest_api');

var apiInstance = new SqlServer2017ReportingServicesRestApi.DataSetsApi();

var id = "id_example"; // String | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

var properties = [new SqlServer2017ReportingServicesRestApi.Property()]; // [Property] | The Properties that will be updated.


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
};
apiInstance.updateDatasetProperties(id, properties, callback);
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

