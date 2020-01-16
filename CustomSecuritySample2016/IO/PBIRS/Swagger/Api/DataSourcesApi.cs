using System;
using System.Collections.Generic;
using RestSharp;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace IO.PBIRS.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataSourcesApi
    {
        /// <summary>
        /// Creates a new DataSource CatalogItem. 
        /// </summary>
        /// <param name="dataSource">The definition of the new DataSource CatalogItem.</param>
        /// <returns>DataSource</returns>
        DataSource AddDataSource (DataSource dataSource);
        /// <summary>
        /// Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>DataSourceCheckResult</returns>
        DataSourceCheckResult CheckExistingDataSourceConnection (string id);
        /// <summary>
        /// Tests the connection for a data source. This method supports the direct testing of the unsaved data source. 
        /// </summary>
        /// <param name="dataSource">The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. In case of embedded data sources, Name will be null.</param>
        /// <returns>DataSourceCheckResult</returns>
        DataSourceCheckResult CheckNewDataSourceConnection (DataSource dataSource);
        /// <summary>
        /// Deletes the specified DataSource. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeleteDataSource (string id);
        /// <summary>
        /// Gets a DataSource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>DataSource</returns>
        DataSource GetDataSource (string id);
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetDataSourceAllowedActions (string id);
        /// <summary>
        /// Gets the content of the DataSource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetDataSourceContent (string id);
        /// <summary>
        /// Returns a list of CatalogItems that reference the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataDependentItems</returns>
        ODataDependentItems GetDataSourceDependentItems (string id);
        /// <summary>
        /// Gets ItemPolicies associated with the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ItemPolicy&gt;</returns>
        List<ItemPolicy> GetDataSourcePolicies (string id);
        /// <summary>
        /// Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription. 
        /// </summary>
        /// <param name="queryFieldsRequest"></param>
        /// <returns>ODataQueryFields</returns>
        ODataQueryFields GetDataSourceQueryFields (QueryFieldsRequest queryFieldsRequest);
        /// <summary>
        /// Gets an array of DataSource CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>ODataDataSources</returns>
        ODataDataSources GetDataSources (int? top, int? skip, string filter, string count, string orderBy, string select);
        /// <summary>
        /// Gets DataSource Properties (takes list of property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetDatasourceProperties (string id, List<string> properties);
        /// <summary>
        /// Replaces ItemPolicies associated with the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="itemPolicy">The ItemPolicy definitions that will be replaced.</param>
        /// <returns></returns>
        void SetDataSourcePolicies (string id, List<ItemPolicy> itemPolicy);
        /// <summary>
        /// Updates the DataSource CatalogItem specified by the Id using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="dataSource">Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param>
        /// <returns></returns>
        void UpdateDataSource (string id, DataSource dataSource);
        /// <summary>
        /// Updates the DataSource Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">The Properties that will be updated.</param>
        /// <returns></returns>
        void UpdateDatasourceProperties (string id, List<Property> properties);
        /// <summary>
        /// Does an efficient binary upload of a new or existing DataSource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="_file">The file contents.</param>
        /// <returns>DataSource</returns>
        DataSource UploadDataSource (string id, System.IO.Stream _file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DataSourcesApi : IDataSourcesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourcesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DataSourcesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataSourcesApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Creates a new DataSource CatalogItem. 
        /// </summary>
        /// <param name="dataSource">The definition of the new DataSource CatalogItem.</param> 
        /// <returns>DataSource</returns>            
        public DataSource AddDataSource (DataSource dataSource)
        {
            
            // verify the required parameter 'dataSource' is set
            if (dataSource == null) throw new ApiException(400, "Missing required parameter 'dataSource' when calling AddDataSource");
            
    
            var path = "/DataSources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSource) ApiClient.Deserialize(response.Content, typeof(DataSource), response.Headers);
        }
    
        /// <summary>
        /// Tests the connection for a data source. This method supports the testing of published data sources that are used by reports and shared data sources 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>DataSourceCheckResult</returns>            
        public DataSourceCheckResult CheckExistingDataSourceConnection (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling CheckExistingDataSourceConnection");
            
    
            var path = "/DataSources({Id})/Model.CheckConnection";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckExistingDataSourceConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckExistingDataSourceConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSourceCheckResult) ApiClient.Deserialize(response.Content, typeof(DataSourceCheckResult), response.Headers);
        }
    
        /// <summary>
        /// Tests the connection for a data source. This method supports the direct testing of the unsaved data source. 
        /// </summary>
        /// <param name="dataSource">The definition of data source.  Must contain connectionstring, data provider, and credentials to connect to the data source. In case of embedded data sources, Name will be null.</param> 
        /// <returns>DataSourceCheckResult</returns>            
        public DataSourceCheckResult CheckNewDataSourceConnection (DataSource dataSource)
        {
            
            // verify the required parameter 'dataSource' is set
            if (dataSource == null) throw new ApiException(400, "Missing required parameter 'dataSource' when calling CheckNewDataSourceConnection");
            
    
            var path = "/DataSources/Model.CheckConnection";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckNewDataSourceConnection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CheckNewDataSourceConnection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSourceCheckResult) ApiClient.Deserialize(response.Content, typeof(DataSourceCheckResult), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified DataSource. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeleteDataSource (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteDataSource");
            
    
            var path = "/DataSources({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a DataSource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>DataSource</returns>            
        public DataSource GetDataSource (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDataSource");
            
    
            var path = "/DataSources({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSource) ApiClient.Deserialize(response.Content, typeof(DataSource), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetDataSourceAllowedActions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDataSourceAllowedActions");
            
    
            var path = "/DataSources({Id})/AllowedActions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Gets the content of the DataSource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetDataSourceContent (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDataSourceContent");
            
    
            var path = "/DataSources({Id})/Content/$value";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Returns a list of CatalogItems that reference the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataDependentItems</returns>            
        public ODataDependentItems GetDataSourceDependentItems (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDataSourceDependentItems");
            
    
            var path = "/DataSources({Id})/DependentItems";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceDependentItems: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceDependentItems: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDependentItems) ApiClient.Deserialize(response.Content, typeof(ODataDependentItems), response.Headers);
        }
    
        /// <summary>
        /// Gets ItemPolicies associated with the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ItemPolicy&gt;</returns>            
        public List<ItemPolicy> GetDataSourcePolicies (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDataSourcePolicies");
            
    
            var path = "/DataSources({Id})/Policies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourcePolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourcePolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ItemPolicy>) ApiClient.Deserialize(response.Content, typeof(List<ItemPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Retrieves a dataset that contains the fields retrieved by the delivery query for a data-driven subscription. 
        /// </summary>
        /// <param name="queryFieldsRequest"></param> 
        /// <returns>ODataQueryFields</returns>            
        public ODataQueryFields GetDataSourceQueryFields (QueryFieldsRequest queryFieldsRequest)
        {
            
    
            var path = "/DataSources/Model.GetQueryFields";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(queryFieldsRequest); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceQueryFields: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSourceQueryFields: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataQueryFields) ApiClient.Deserialize(response.Content, typeof(ODataQueryFields), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of DataSource CatalogItems. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>ODataDataSources</returns>            
        public ODataDataSources GetDataSources (int? top, int? skip, string filter, string count, string orderBy, string select)
        {
            
    
            var path = "/DataSources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (top != null) queryParams.Add("$top", ApiClient.ParameterToString(top)); // query parameter
 if (skip != null) queryParams.Add("$skip", ApiClient.ParameterToString(skip)); // query parameter
 if (filter != null) queryParams.Add("$filter", ApiClient.ParameterToString(filter)); // query parameter
 if (count != null) queryParams.Add("$count", ApiClient.ParameterToString(count)); // query parameter
 if (orderBy != null) queryParams.Add("$orderBy", ApiClient.ParameterToString(orderBy)); // query parameter
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDataSources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataDataSources) ApiClient.Deserialize(response.Content, typeof(ODataDataSources), response.Headers);
        }
    
        /// <summary>
        /// Gets DataSource Properties (takes list of property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetDatasourceProperties (string id, List<string> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetDatasourceProperties");
            
    
            var path = "/DataSources({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (properties != null) queryParams.Add("properties", ApiClient.ParameterToString(properties)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDatasourceProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetDatasourceProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Replaces ItemPolicies associated with the DataSource specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="itemPolicy">The ItemPolicy definitions that will be replaced.</param> 
        /// <returns></returns>            
        public void SetDataSourcePolicies (string id, List<ItemPolicy> itemPolicy)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetDataSourcePolicies");
            
            // verify the required parameter 'itemPolicy' is set
            if (itemPolicy == null) throw new ApiException(400, "Missing required parameter 'itemPolicy' when calling SetDataSourcePolicies");
            
    
            var path = "/DataSources({Id})/Policies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(itemPolicy); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetDataSourcePolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetDataSourcePolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the DataSource CatalogItem specified by the Id using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="dataSource">Definition of the DataSource item that updates the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateDataSource (string id, DataSource dataSource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDataSource");
            
            // verify the required parameter 'dataSource' is set
            if (dataSource == null) throw new ApiException(400, "Missing required parameter 'dataSource' when calling UpdateDataSource");
            
    
            var path = "/DataSources({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(dataSource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the DataSource Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">The Properties that will be updated.</param> 
        /// <returns></returns>            
        public void UpdateDatasourceProperties (string id, List<Property> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateDatasourceProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateDatasourceProperties");
            
    
            var path = "/DataSources({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(properties); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDatasourceProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateDatasourceProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Does an efficient binary upload of a new or existing DataSource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="_file">The file contents.</param> 
        /// <returns>DataSource</returns>            
        public DataSource UploadDataSource (string id, System.IO.Stream _file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UploadDataSource");
            
            // verify the required parameter '_file' is set
            if (_file == null) throw new ApiException(400, "Missing required parameter '_file' when calling UploadDataSource");
            
    
            var path = "/DataSources({Id})/Model.Upload";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (_file != null) fileParams.Add("File", ApiClient.ParameterToFile("File", _file));
                
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadDataSource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadDataSource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DataSource) ApiClient.Deserialize(response.Content, typeof(DataSource), response.Headers);
        }
    
    }
}
