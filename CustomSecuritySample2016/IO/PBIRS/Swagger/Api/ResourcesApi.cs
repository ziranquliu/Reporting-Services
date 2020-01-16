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
    public interface IResourcesApi
    {
        /// <summary>
        /// Creates new Resource item 
        /// </summary>
        /// <param name="resource">The definition of the new Resource item.</param>
        /// <returns>Resource</returns>
        Resource AddResource (Resource resource);
        /// <summary>
        /// Delete the specified Resource catalog item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeleteResource (string id);
        /// <summary>
        /// Get the specified Resource. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>Resource</returns>
        Resource GetResource (string id);
        /// <summary>
        /// Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetResourceAllowedActions (string id);
        /// <summary>
        /// Gets the content of the specified Resource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetResourceContent (string id);
        /// <summary>
        /// Gets ItemPolicies on the Resource item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ItemPolicy&gt;</returns>
        List<ItemPolicy> GetResourcePolicies (string id);
        /// <summary>
        /// Gets the specified Resources Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetResourceProperties (string id, List<string> properties);
        /// <summary>
        /// Gets an array of Resource catalog items 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <returns>ODataResources</returns>
        ODataResources GetResources (int? top, int? skip, string filter, string count);
        /// <summary>
        /// Replaces ItemPolicies on the Resource item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="policies">Array of ItemPolicies to set on the Resource CatalogItem.</param>
        /// <returns></returns>
        void SetResourcePolicies (string id, List<ItemPolicy> policies);
        /// <summary>
        /// Updates the specified Resource catalog item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="resource">Definition of the Resource item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param>
        /// <returns>Resource</returns>
        Resource UpdateResource (string id, Resource resource);
        /// <summary>
        /// Updates the Resource Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="properties">The Properties that will be updated.</param>
        /// <returns></returns>
        void UpdateResourceProperties (string id, List<Property> properties);
        /// <summary>
        /// Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="_file">The file contents.</param>
        /// <returns>Resource</returns>
        Resource UploadResource (string id, System.IO.Stream _file);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ResourcesApi : IResourcesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ResourcesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourcesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ResourcesApi(String basePath)
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
        /// Creates new Resource item 
        /// </summary>
        /// <param name="resource">The definition of the new Resource item.</param> 
        /// <returns>Resource</returns>            
        public Resource AddResource (Resource resource)
        {
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling AddResource");
            
    
            var path = "/Resources";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Resource) ApiClient.Deserialize(response.Content, typeof(Resource), response.Headers);
        }
    
        /// <summary>
        /// Delete the specified Resource catalog item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeleteResource (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteResource");
            
    
            var path = "/Resources({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the specified Resource. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>Resource</returns>            
        public Resource GetResource (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetResource");
            
    
            var path = "/Resources({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Resource) ApiClient.Deserialize(response.Content, typeof(Resource), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetResourceAllowedActions (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetResourceAllowedActions");
            
    
            var path = "/Resources({Id})/AllowedActions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Gets the content of the specified Resource CatalogItem specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>System.IO.Stream</returns>            
        public System.IO.Stream GetResourceContent (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetResourceContent");
            
    
            var path = "/Resources({Id})/Content/$value";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceContent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceContent: " + response.ErrorMessage, response.ErrorMessage);
    
            return (System.IO.Stream) ApiClient.Deserialize(response.Content, typeof(System.IO.Stream), response.Headers);
        }
    
        /// <summary>
        /// Gets ItemPolicies on the Resource item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ItemPolicy&gt;</returns>            
        public List<ItemPolicy> GetResourcePolicies (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetResourcePolicies");
            
    
            var path = "/Resources({Id})/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourcePolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourcePolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ItemPolicy>) ApiClient.Deserialize(response.Content, typeof(List<ItemPolicy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the specified Resources Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetResourceProperties (string id, List<string> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetResourceProperties");
            
    
            var path = "/Resources({Id})/Properties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (properties != null) queryParams.Add("Properties", ApiClient.ParameterToString(properties)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResourceProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of Resource catalog items 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <returns>ODataResources</returns>            
        public ODataResources GetResources (int? top, int? skip, string filter, string count)
        {
            
    
            var path = "/Resources";
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
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResources: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetResources: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataResources) ApiClient.Deserialize(response.Content, typeof(ODataResources), response.Headers);
        }
    
        /// <summary>
        /// Replaces ItemPolicies on the Resource item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="policies">Array of ItemPolicies to set on the Resource CatalogItem.</param> 
        /// <returns></returns>            
        public void SetResourcePolicies (string id, List<ItemPolicy> policies)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetResourcePolicies");
            
            // verify the required parameter 'policies' is set
            if (policies == null) throw new ApiException(400, "Missing required parameter 'policies' when calling SetResourcePolicies");
            
    
            var path = "/Resources({Id})/Policies";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(policies); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetResourcePolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetResourcePolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the specified Resource catalog item. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="resource">Definition of the Resource item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.</param> 
        /// <returns>Resource</returns>            
        public Resource UpdateResource (string id, Resource resource)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateResource");
            
            // verify the required parameter 'resource' is set
            if (resource == null) throw new ApiException(400, "Missing required parameter 'resource' when calling UpdateResource");
            
    
            var path = "/Resources({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(resource); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Resource) ApiClient.Deserialize(response.Content, typeof(Resource), response.Headers);
        }
    
        /// <summary>
        /// Updates the Resource Properties included in the given list. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="properties">The Properties that will be updated.</param> 
        /// <returns></returns>            
        public void UpdateResourceProperties (string id, List<Property> properties)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateResourceProperties");
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateResourceProperties");
            
    
            var path = "/Resources({Id})/Properties";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateResourceProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateResourceProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="_file">The file contents.</param> 
        /// <returns>Resource</returns>            
        public Resource UploadResource (string id, System.IO.Stream _file)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UploadResource");
            
            // verify the required parameter '_file' is set
            if (_file == null) throw new ApiException(400, "Missing required parameter '_file' when calling UploadResource");
            
    
            var path = "/Resources({Id})/Model.Upload";
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
                throw new ApiException ((int)response.StatusCode, "Error calling UploadResource: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UploadResource: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Resource) ApiClient.Deserialize(response.Content, typeof(Resource), response.Headers);
        }
    
    }
}
