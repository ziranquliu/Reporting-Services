# IO.SSRS.Swagger.Api.DataSetsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDataSet**](DataSetsApi.md#adddataset) | **POST** /DataSets | Creates a new DataSet CatalogItem.
[**DeleteDataSet**](DataSetsApi.md#deletedataset) | **DELETE** /DataSets({Id}) | Deletes the specified DataSet.
[**GetDataSet**](DataSetsApi.md#getdataset) | **GET** /DataSets({Id}) | Gets a DataSet CatalogItem specified by the Id.
[**GetDataSetAggregatedValue**](DataSetsApi.md#getdatasetaggregatedvalue) | **POST** /DataSets({Id})/Model.GetAggregatedValue | Gets the value for the specified DataSet column using the given aggregation type.
[**GetDataSetAllowedActions**](DataSetsApi.md#getdatasetallowedactions) | **GET** /DataSets({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetDataSetCacheOptions**](DataSetsApi.md#getdatasetcacheoptions) | **GET** /DataSets({Id})/CacheOptions | Gets the CacheOption&#39;s content for a given DataSet.
[**GetDataSetCacheRefreshPlans**](DataSetsApi.md#getdatasetcacherefreshplans) | **GET** /DataSets({Id})/CacheRefreshPlans | Gets the CacheRefreshPlans for a given DataSet.
[**GetDataSetContent**](DataSetsApi.md#getdatasetcontent) | **GET** /DataSets({Id})/Content/$value | Gets the content of the specified DataSet CatalogItem specified by the Id.
[**GetDataSetData**](DataSetsApi.md#getdatasetdata) | **POST** /DataSets({Id})/Model.GetData | Gets the query results for the specified DataSet.
[**GetDataSetDataSource**](DataSetsApi.md#getdatasetdatasource) | **GET** /DataSets({Id})/DataSources({DataSourceId}) | Gets the DataSource specified by the DataSourceId that is associated with the DataSet.
[**GetDataSetDataSources**](DataSetsApi.md#getdatasetdatasources) | **GET** /DataSets({Id})/DataSources | Gets the DataSources associated with the specified DataSet.
[**GetDataSetDependentItems**](DataSetsApi.md#getdatasetdependentitems) | **GET** /DataSets({Id})/DependentItems | Returns a list of CatalogItems that reference the specified DataSet.
[**GetDataSetParameterDefinitions**](DataSetsApi.md#getdatasetparameterdefinitions) | **GET** /DataSets({Id})/ParameterDefinitions | Gets the ParameterDefinitions associated with the specified DataSet.
[**GetDataSetPolicies**](DataSetsApi.md#getdatasetpolicies) | **GET** /DataSets({Id})/Policies | Gets ItemPolicies associated with the specified DataSet CatalogItem.
[**GetDataSetSchema**](DataSetsApi.md#getdatasetschema) | **GET** /DataSets({Id})/Model.GetSchema | Gets the schema for the specified DataSet.
[**GetDataSets**](DataSetsApi.md#getdatasets) | **GET** /DataSets | Gets an array of DataSet CatalogItems.
[**GetDatasetProperties**](DataSetsApi.md#getdatasetproperties) | **GET** /DataSets({Id})/Properties | Gets DataSet Properties (takes list of property names to retrieve the values)
[**SetDataSetCacheOptions**](DataSetsApi.md#setdatasetcacheoptions) | **PUT** /DataSets({Id})/CacheOptions | Replaces the CacheOption&#39;s content for a given DataSet using the provided definition.
[**SetDataSetDataSource**](DataSetsApi.md#setdatasetdatasource) | **PUT** /DataSets({Id})/DataSources({DataSourceId}) | Updates the DataSource specified by the DataSourceId that is associated with the DataSet.
[**SetDataSetDataSources**](DataSetsApi.md#setdatasetdatasources) | **PUT** /DataSets({Id})/DataSources | Updates the DataSource definition associated with the specified DataSet.
[**SetDataSetPolicies**](DataSetsApi.md#setdatasetpolicies) | **PUT** /DataSets({Id})/Policies | Replaces ItemPolicies associated with the specified DataSet item.
[**UpdateDataSet**](DataSetsApi.md#updatedataset) | **PATCH** /DataSets({Id}) | Updates the specified DataSet CatalogItem using the provided definition.
[**UpdateDataSetParameterDefinitions**](DataSetsApi.md#updatedatasetparameterdefinitions) | **PATCH** /DataSets({Id})/ParameterDefinitions | Updates the ParameterDefinitions associated with the DataSet specified.
[**UpdateDatasetProperties**](DataSetsApi.md#updatedatasetproperties) | **PUT** /DataSets({Id})/Properties | Updates the DataSet Properties included in the given list.


<a name="adddataset"></a>
# **AddDataSet**
> DataSet AddDataSet (DataSet dataSet)

Creates a new DataSet CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class AddDataSetExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var dataSet = new DataSet(); // DataSet | The definition of the new DataSet CatalogItem.

            try
            {
                // Creates a new DataSet CatalogItem.
                DataSet result = apiInstance.AddDataSet(dataSet);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.AddDataSet: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedataset"></a>
# **DeleteDataSet**
> void DeleteDataSet (string id)

Deletes the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class DeleteDataSetExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified DataSet.
                apiInstance.DeleteDataSet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.DeleteDataSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdataset"></a>
# **GetDataSet**
> DataSet GetDataSet (string id)

Gets a DataSet CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a DataSet CatalogItem specified by the Id.
                DataSet result = apiInstance.GetDataSet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSet**](DataSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetaggregatedvalue"></a>
# **GetDataSetAggregatedValue**
> List<double?> GetDataSetAggregatedValue (string id, string columnName, string aggregation, DataSetAggregateValueParameters parameters)

Gets the value for the specified DataSet column using the given aggregation type.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetAggregatedValueExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var columnName = columnName_example;  // string | The name of the DataSet column to aggregate the value for.
            var aggregation = aggregation_example;  // string | The type of aggregation to use on the specified column. Values come from the KpiSharedDataItemAggregation enum.
            var parameters = new DataSetAggregateValueParameters(); // DataSetAggregateValueParameters | An array of DataSet parameters to use when executing the query. (optional) 

            try
            {
                // Gets the value for the specified DataSet column using the given aggregation type.
                List&lt;double?&gt; result = apiInstance.GetDataSetAggregatedValue(id, columnName, aggregation, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetAggregatedValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **columnName** | **string**| The name of the DataSet column to aggregate the value for. | 
 **aggregation** | **string**| The type of aggregation to use on the specified column. Values come from the KpiSharedDataItemAggregation enum. | 
 **parameters** | [**DataSetAggregateValueParameters**](DataSetAggregateValueParameters.md)| An array of DataSet parameters to use when executing the query. | [optional] 

### Return type

**List<double?>**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetallowedactions"></a>
# **GetDataSetAllowedActions**
> ODataAllowedActions GetDataSetAllowedActions (string id)

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetDataSetAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetAllowedActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataAllowedActions**](ODataAllowedActions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetcacheoptions"></a>
# **GetDataSetCacheOptions**
> CacheOptions GetDataSetCacheOptions (string id)

Gets the CacheOption's content for a given DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheOption's content for a given DataSet.
                CacheOptions result = apiInstance.GetDataSetCacheOptions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetCacheOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**CacheOptions**](CacheOptions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetcacherefreshplans"></a>
# **GetDataSetCacheRefreshPlans**
> ODataCacheRefreshPlans GetDataSetCacheRefreshPlans (string id)

Gets the CacheRefreshPlans for a given DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetCacheRefreshPlansExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the CacheRefreshPlans for a given DataSet.
                ODataCacheRefreshPlans result = apiInstance.GetDataSetCacheRefreshPlans(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetCacheRefreshPlans: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataCacheRefreshPlans**](ODataCacheRefreshPlans.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetcontent"></a>
# **GetDataSetContent**
> System.IO.Stream GetDataSetContent (string id)

Gets the content of the specified DataSet CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetContentExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the specified DataSet CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetDataSetContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

**System.IO.Stream**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetdata"></a>
# **GetDataSetData**
> DataSetData GetDataSetData (string id, decimal? maxRows, DataSetDataParameters parameters)

Gets the query results for the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetDataExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var maxRows = 8.14;  // decimal? | Specifies the maximum number of rows to return from the query. (optional) 
            var parameters = new DataSetDataParameters(); // DataSetDataParameters | An array of DataSet parameters to use when executing the query. (optional) 

            try
            {
                // Gets the query results for the specified DataSet.
                DataSetData result = apiInstance.GetDataSetData(id, maxRows, parameters);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **maxRows** | **decimal?**| Specifies the maximum number of rows to return from the query. | [optional] 
 **parameters** | [**DataSetDataParameters**](DataSetDataParameters.md)| An array of DataSet parameters to use when executing the query. | [optional] 

### Return type

[**DataSetData**](DataSetData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetdatasource"></a>
# **GetDataSetDataSource**
> DataSource GetDataSetDataSource (string id, string dataSourceId)

Gets the DataSource specified by the DataSourceId that is associated with the DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSourceId = dataSourceId_example;  // string | The Id of the DataSource associated with the DataSet.

            try
            {
                // Gets the DataSource specified by the DataSourceId that is associated with the DataSet.
                DataSource result = apiInstance.GetDataSetDataSource(id, dataSourceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceId** | **string**| The Id of the DataSource associated with the DataSet. | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetdatasources"></a>
# **GetDataSetDataSources**
> List<DataSource> GetDataSetDataSources (string id)

Gets the DataSources associated with the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetDataSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the DataSources associated with the specified DataSet.
                List&lt;DataSource&gt; result = apiInstance.GetDataSetDataSources(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetDataSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**List<DataSource>**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetdependentitems"></a>
# **GetDataSetDependentItems**
> ODataDependentItems GetDataSetDependentItems (string id)

Returns a list of CatalogItems that reference the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetDependentItemsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Returns a list of CatalogItems that reference the specified DataSet.
                ODataDependentItems result = apiInstance.GetDataSetDependentItems(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetDependentItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataDependentItems**](ODataDependentItems.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetparameterdefinitions"></a>
# **GetDataSetParameterDefinitions**
> ODataReportParameterDefinitions GetDataSetParameterDefinitions (string id)

Gets the ParameterDefinitions associated with the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the ParameterDefinitions associated with the specified DataSet.
                ODataReportParameterDefinitions result = apiInstance.GetDataSetParameterDefinitions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetParameterDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**ODataReportParameterDefinitions**](ODataReportParameterDefinitions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetpolicies"></a>
# **GetDataSetPolicies**
> List<ItemPolicy> GetDataSetPolicies (string id)

Gets ItemPolicies associated with the specified DataSet CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the specified DataSet CatalogItem.
                List&lt;ItemPolicy&gt; result = apiInstance.GetDataSetPolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**List<ItemPolicy>**](ItemPolicy.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetschema"></a>
# **GetDataSetSchema**
> DataSetSchema GetDataSetSchema (string id)

Gets the schema for the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetSchemaExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the schema for the specified DataSet.
                DataSetSchema result = apiInstance.GetDataSetSchema(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSetSchema: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

[**DataSetSchema**](DataSetSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasets"></a>
# **GetDataSets**
> ODataDataSets GetDataSets (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of DataSet CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDataSetsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of DataSet CatalogItems.
                ODataDataSets result = apiInstance.GetDataSets(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDataSets: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **int?**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **string**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **string**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **string**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **select** | **string**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**ODataDataSets**](ODataDataSets.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasetproperties"></a>
# **GetDatasetProperties**
> ODataProperties GetDatasetProperties (string id, List<string> properties)

Gets DataSet Properties (takes list of property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetDatasetPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets DataSet Properties (takes list of property names to retrieve the values)
                ODataProperties result = apiInstance.GetDatasetProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.GetDatasetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<string>**](string.md)| Names for the Properties to be returned. | [optional] 

### Return type

[**ODataProperties**](ODataProperties.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdatasetcacheoptions"></a>
# **SetDataSetCacheOptions**
> void SetDataSetCacheOptions (string id, CacheOptions cacheOptions)

Replaces the CacheOption's content for a given DataSet using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetDataSetCacheOptionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var cacheOptions = new CacheOptions(); // CacheOptions | Updated definition for the CacheOption's content associated with the given DataSet.

            try
            {
                // Replaces the CacheOption's content for a given DataSet using the provided definition.
                apiInstance.SetDataSetCacheOptions(id, cacheOptions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.SetDataSetCacheOptions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **cacheOptions** | [**CacheOptions**](CacheOptions.md)| Updated definition for the CacheOption&#39;s content associated with the given DataSet. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdatasetdatasource"></a>
# **SetDataSetDataSource**
> void SetDataSetDataSource (string id, string dataSourceId, DataSource dataSource)

Updates the DataSource specified by the DataSourceId that is associated with the DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetDataSetDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSourceId = dataSourceId_example;  // string | The Id of the DataSource associated with the DataSet.
            var dataSource = new DataSource(); // DataSource | Updated definition for the DataSource associated with the DataSet.

            try
            {
                // Updates the DataSource specified by the DataSourceId that is associated with the DataSet.
                apiInstance.SetDataSetDataSource(id, dataSourceId, dataSource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.SetDataSetDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSourceId** | **string**| The Id of the DataSource associated with the DataSet. | 
 **dataSource** | [**DataSource**](DataSource.md)| Updated definition for the DataSource associated with the DataSet. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdatasetdatasources"></a>
# **SetDataSetDataSources**
> void SetDataSetDataSources (string id, DataSource dataSource)

Updates the DataSource definition associated with the specified DataSet.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetDataSetDataSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSource = new DataSource(); // DataSource | Updated definition for the DataSource associated with the specified DataSet CatalogItem.

            try
            {
                // Updates the DataSource definition associated with the specified DataSet.
                apiInstance.SetDataSetDataSources(id, dataSource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.SetDataSetDataSources: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSource** | [**DataSource**](DataSource.md)| Updated definition for the DataSource associated with the specified DataSet CatalogItem. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setdatasetpolicies"></a>
# **SetDataSetPolicies**
> void SetDataSetPolicies (string id, List<ItemPolicy> itemPolicy)

Replaces ItemPolicies associated with the specified DataSet item.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetDataSetPoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the specified DataSet item.
                apiInstance.SetDataSetPolicies(id, itemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.SetDataSetPolicies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **itemPolicy** | [**List<ItemPolicy>**](ItemPolicy.md)| The ItemPolicy definitions that will be replaced. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedataset"></a>
# **UpdateDataSet**
> void UpdateDataSet (string id, DataSet dataSet)

Updates the specified DataSet CatalogItem using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateDataSetExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSet = new DataSet(); // DataSet | Definition of the DataSet item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the specified DataSet CatalogItem using the provided definition.
                apiInstance.UpdateDataSet(id, dataSet);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.UpdateDataSet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSet** | [**DataSet**](DataSet.md)| Definition of the DataSet item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedatasetparameterdefinitions"></a>
# **UpdateDataSetParameterDefinitions**
> void UpdateDataSetParameterDefinitions (string id, List<ReportParameterDefinitionPatch> parameterDefinitions)

Updates the ParameterDefinitions associated with the DataSet specified.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateDataSetParameterDefinitionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var parameterDefinitions = new List<ReportParameterDefinitionPatch>(); // List<ReportParameterDefinitionPatch> | Updated definitions for the ParameterDefinitions associated with the DataSet, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property valueswill be left unchanged.

            try
            {
                // Updates the ParameterDefinitions associated with the DataSet specified.
                apiInstance.UpdateDataSetParameterDefinitions(id, parameterDefinitions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.UpdateDataSetParameterDefinitions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **parameterDefinitions** | [**List<ReportParameterDefinitionPatch>**](ReportParameterDefinitionPatch.md)| Updated definitions for the ParameterDefinitions associated with the DataSet, represented as ParameterDefinitionsPatch objects. It is only necessary to include properties to be updated. All other property valueswill be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedatasetproperties"></a>
# **UpdateDatasetProperties**
> void UpdateDatasetProperties (string id, List<Property> properties)

Updates the DataSet Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class UpdateDatasetPropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSetsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the DataSet Properties included in the given list.
                apiInstance.UpdateDatasetProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSetsApi.UpdateDatasetProperties: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **properties** | [**List<Property>**](Property.md)| The Properties that will be updated. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

