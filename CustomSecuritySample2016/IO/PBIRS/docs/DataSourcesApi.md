# IO.PBIRS.Swagger.Api.DataSourcesApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDataSource**](DataSourcesApi.md#adddatasource) | **POST** /DataSources | Creates a new DataSource CatalogItem.
[**CheckExistingDataSourceConnection**](DataSourcesApi.md#checkexistingdatasourceconnection) | **POST** /DataSources({Id})/Model.CheckConnection | Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
[**CheckNewDataSourceConnection**](DataSourcesApi.md#checknewdatasourceconnection) | **POST** /DataSources/Model.CheckConnection | Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
[**DeleteDataSource**](DataSourcesApi.md#deletedatasource) | **DELETE** /DataSources({Id}) | Deletes the specified DataSource.
[**GetDataSource**](DataSourcesApi.md#getdatasource) | **GET** /DataSources({Id}) | Gets a DataSource CatalogItem specified by the Id.
[**GetDataSourceAllowedActions**](DataSourcesApi.md#getdatasourceallowedactions) | **GET** /DataSources({Id})/AllowedActions | Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
[**GetDataSourceContent**](DataSourcesApi.md#getdatasourcecontent) | **GET** /DataSources({Id})/Content/$value | Gets the content of the DataSource CatalogItem specified by the Id.
[**GetDataSourceDependentItems**](DataSourcesApi.md#getdatasourcedependentitems) | **GET** /DataSources({Id})/DependentItems | Returns a list of CatalogItems that reference the DataSource specified by the Id.
[**GetDataSourcePolicies**](DataSourcesApi.md#getdatasourcepolicies) | **GET** /DataSources({Id})/Policies | Gets ItemPolicies associated with the DataSource specified by the Id.
[**GetDataSourceQueryFields**](DataSourcesApi.md#getdatasourcequeryfields) | **POST** /DataSources/Model.GetQueryFields | Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
[**GetDataSources**](DataSourcesApi.md#getdatasources) | **GET** /DataSources | Gets an array of DataSource CatalogItems.
[**GetDatasourceProperties**](DataSourcesApi.md#getdatasourceproperties) | **GET** /DataSources({Id})/Properties | Gets DataSource Properties (takes list of property names to retrieve the values)
[**SetDataSourcePolicies**](DataSourcesApi.md#setdatasourcepolicies) | **PUT** /DataSources({Id})/Policies | Replaces ItemPolicies associated with the DataSource specified by the Id.
[**UpdateDataSource**](DataSourcesApi.md#updatedatasource) | **PATCH** /DataSources({Id}) | Updates the DataSource CatalogItem specified by the Id using the provided definition.
[**UpdateDatasourceProperties**](DataSourcesApi.md#updatedatasourceproperties) | **PUT** /DataSources({Id})/Properties | Updates the DataSource Properties included in the given list.
[**UploadDataSource**](DataSourcesApi.md#uploaddatasource) | **POST** /DataSources({Id})/Model.Upload | Does an efficient binary upload of a new or existing DataSource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.


<a name="adddatasource"></a>
# **AddDataSource**
> DataSource AddDataSource (DataSource dataSource)

Creates a new DataSource CatalogItem.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class AddDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var dataSource = new DataSource(); // DataSource | The definition of the new DataSource CatalogItem.

            try
            {
                // Creates a new DataSource CatalogItem.
                DataSource result = apiInstance.AddDataSource(dataSource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.AddDataSource: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checkexistingdatasourceconnection"></a>
# **CheckExistingDataSourceConnection**
> DataSourceCheckResult CheckExistingDataSourceConnection (string id)

Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class CheckExistingDataSourceConnectionExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources
                DataSourceCheckResult result = apiInstance.CheckExistingDataSourceConnection(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.CheckExistingDataSourceConnection: " + e.Message );
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

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="checknewdatasourceconnection"></a>
# **CheckNewDataSourceConnection**
> DataSourceCheckResult CheckNewDataSourceConnection (DataSource dataSource)

Tests the connection for a data source. This method supports the direct testing of the unsaved data source.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class CheckNewDataSourceConnectionExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var dataSource = new DataSource(); // DataSource | The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. In case of embedded data sources, Name will be null.

            try
            {
                // Tests the connection for a data source. This method supports the direct testing of the unsaved data source.
                DataSourceCheckResult result = apiInstance.CheckNewDataSourceConnection(dataSource);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.CheckNewDataSourceConnection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **dataSource** | [**DataSource**](DataSource.md)| The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. In case of embedded data sources, Name will be null. | 

### Return type

[**DataSourceCheckResult**](DataSourceCheckResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedatasource"></a>
# **DeleteDataSource**
> void DeleteDataSource (string id)

Deletes the specified DataSource.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Deletes the specified DataSource.
                apiInstance.DeleteDataSource(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.DeleteDataSource: " + e.Message );
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

<a name="getdatasource"></a>
# **GetDataSource**
> DataSource GetDataSource (string id)

Gets a DataSource CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a DataSource CatalogItem specified by the Id.
                DataSource result = apiInstance.GetDataSource(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSource: " + e.Message );
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

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourceallowedactions"></a>
# **GetDataSourceAllowedActions**
> ODataAllowedActions GetDataSourceAllowedActions (string id)

Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourceAllowedActionsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying.
                ODataAllowedActions result = apiInstance.GetDataSourceAllowedActions(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceAllowedActions: " + e.Message );
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

<a name="getdatasourcecontent"></a>
# **GetDataSourceContent**
> System.IO.Stream GetDataSourceContent (string id)

Gets the content of the DataSource CatalogItem specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourceContentExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets the content of the DataSource CatalogItem specified by the Id.
                System.IO.Stream result = apiInstance.GetDataSourceContent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceContent: " + e.Message );
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

<a name="getdatasourcedependentitems"></a>
# **GetDataSourceDependentItems**
> ODataDependentItems GetDataSourceDependentItems (string id)

Returns a list of CatalogItems that reference the DataSource specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourceDependentItemsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Returns a list of CatalogItems that reference the DataSource specified by the Id.
                ODataDependentItems result = apiInstance.GetDataSourceDependentItems(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceDependentItems: " + e.Message );
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

<a name="getdatasourcepolicies"></a>
# **GetDataSourcePolicies**
> List<ItemPolicy> GetDataSourcePolicies (string id)

Gets ItemPolicies associated with the DataSource specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourcePoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Gets ItemPolicies associated with the DataSource specified by the Id.
                List&lt;ItemPolicy&gt; result = apiInstance.GetDataSourcePolicies(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourcePolicies: " + e.Message );
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

<a name="getdatasourcequeryfields"></a>
# **GetDataSourceQueryFields**
> ODataQueryFields GetDataSourceQueryFields (QueryFieldsRequest queryFieldsRequest)

Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourceQueryFieldsExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var queryFieldsRequest = new QueryFieldsRequest(); // QueryFieldsRequest |  (optional) 

            try
            {
                // Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription.
                ODataQueryFields result = apiInstance.GetDataSourceQueryFields(queryFieldsRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSourceQueryFields: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasources"></a>
# **GetDataSources**
> ODataDataSources GetDataSources (int? top, int? skip, string filter, string count, string orderBy, string select)

Gets an array of DataSource CatalogItems.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDataSourcesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Gets an array of DataSource CatalogItems.
                ODataDataSources result = apiInstance.GetDataSources(top, skip, filter, count, orderBy, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDataSources: " + e.Message );
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

[**ODataDataSources**](ODataDataSources.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatasourceproperties"></a>
# **GetDatasourceProperties**
> ODataProperties GetDatasourceProperties (string id, List<string> properties)

Gets DataSource Properties (takes list of property names to retrieve the values)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class GetDatasourcePropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<string>(); // List<string> | Names for the Properties to be returned. (optional) 

            try
            {
                // Gets DataSource Properties (takes list of property names to retrieve the values)
                ODataProperties result = apiInstance.GetDatasourceProperties(id, properties);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.GetDatasourceProperties: " + e.Message );
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

<a name="setdatasourcepolicies"></a>
# **SetDataSourcePolicies**
> void SetDataSourcePolicies (string id, List<ItemPolicy> itemPolicy)

Replaces ItemPolicies associated with the DataSource specified by the Id.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class SetDataSourcePoliciesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var itemPolicy = new List<ItemPolicy>(); // List<ItemPolicy> | The ItemPolicy definitions that will be replaced.

            try
            {
                // Replaces ItemPolicies associated with the DataSource specified by the Id.
                apiInstance.SetDataSourcePolicies(id, itemPolicy);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.SetDataSourcePolicies: " + e.Message );
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

<a name="updatedatasource"></a>
# **UpdateDataSource**
> void UpdateDataSource (string id, DataSource dataSource)

Updates the DataSource CatalogItem specified by the Id using the provided definition.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var dataSource = new DataSource(); // DataSource | Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.

            try
            {
                // Updates the DataSource CatalogItem specified by the Id using the provided definition.
                apiInstance.UpdateDataSource(id, dataSource);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.UpdateDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **dataSource** | [**DataSource**](DataSource.md)| Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatedatasourceproperties"></a>
# **UpdateDatasourceProperties**
> void UpdateDatasourceProperties (string id, List<Property> properties)

Updates the DataSource Properties included in the given list.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UpdateDatasourcePropertiesExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var properties = new List<Property>(); // List<Property> | The Properties that will be updated.

            try
            {
                // Updates the DataSource Properties included in the given list.
                apiInstance.UpdateDatasourceProperties(id, properties);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.UpdateDatasourceProperties: " + e.Message );
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

<a name="uploaddatasource"></a>
# **UploadDataSource**
> DataSource UploadDataSource (string id, System.IO.Stream _file)

Does an efficient binary upload of a new or existing DataSource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class UploadDataSourceExample
    {
        public void main()
        {
            
            var apiInstance = new DataSourcesApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
            var _file = new System.IO.Stream(); // System.IO.Stream | The file contents.

            try
            {
                // Does an efficient binary upload of a new or existing DataSource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
                DataSource result = apiInstance.UploadDataSource(id, _file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DataSourcesApi.UploadDataSource: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 
 **_file** | **System.IO.Stream**| The file contents. | 

### Return type

[**DataSource**](DataSource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

