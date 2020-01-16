using System;
using System.Collections.Generic;
using RestSharp;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace IO.SSRS.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICacheRefreshPlansApi
    {
        /// <summary>
        /// Creates a new CacheRefreshPlan item. 
        /// </summary>
        /// <param name="cacheRefreshPlan">The definition of the new CacheRefreshPlan item.</param>
        /// <returns>CacheRefreshPlan</returns>
        CacheRefreshPlan AddCacheRefreshPlan (CacheRefreshPlan cacheRefreshPlan);
        /// <summary>
        /// Deletes the specified CacheRefreshPlan. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void DeleteCacheRefreshPlan (string id);
        /// <summary>
        /// Executes given CacheRefreshPlan immediately. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns></returns>
        void ExecuteCacheRefreshPlan (string id);
        /// <summary>
        /// Gets a CacheRefreshPlan item specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>CacheRefreshPlan</returns>
        CacheRefreshPlan GetCacheRefreshPlan (string id);
        /// <summary>
        /// Replaces the specified CacheRefreshPlan item using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <param name="cacheRefreshPlan">Definition of the CacheRefreshPlan item that updates the current item on the server.</param>
        /// <returns>CacheRefreshPlan</returns>
        CacheRefreshPlan SetCacheRefreshPlan (string id, CacheRefreshPlan cacheRefreshPlan);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CacheRefreshPlansApi : ICacheRefreshPlansApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheRefreshPlansApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CacheRefreshPlansApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheRefreshPlansApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CacheRefreshPlansApi(String basePath)
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
        /// Creates a new CacheRefreshPlan item. 
        /// </summary>
        /// <param name="cacheRefreshPlan">The definition of the new CacheRefreshPlan item.</param> 
        /// <returns>CacheRefreshPlan</returns>            
        public CacheRefreshPlan AddCacheRefreshPlan (CacheRefreshPlan cacheRefreshPlan)
        {
            
            // verify the required parameter 'cacheRefreshPlan' is set
            if (cacheRefreshPlan == null) throw new ApiException(400, "Missing required parameter 'cacheRefreshPlan' when calling AddCacheRefreshPlan");
            
    
            var path = "/CacheRefreshPlans";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cacheRefreshPlan); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCacheRefreshPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddCacheRefreshPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CacheRefreshPlan) ApiClient.Deserialize(response.Content, typeof(CacheRefreshPlan), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified CacheRefreshPlan. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void DeleteCacheRefreshPlan (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteCacheRefreshPlan");
            
    
            var path = "/CacheRefreshPlans({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCacheRefreshPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteCacheRefreshPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Executes given CacheRefreshPlan immediately. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns></returns>            
        public void ExecuteCacheRefreshPlan (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ExecuteCacheRefreshPlan");
            
    
            var path = "/CacheRefreshPlans({Id})/Model.Execute";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteCacheRefreshPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteCacheRefreshPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets a CacheRefreshPlan item specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>CacheRefreshPlan</returns>            
        public CacheRefreshPlan GetCacheRefreshPlan (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetCacheRefreshPlan");
            
    
            var path = "/CacheRefreshPlans({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetCacheRefreshPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetCacheRefreshPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CacheRefreshPlan) ApiClient.Deserialize(response.Content, typeof(CacheRefreshPlan), response.Headers);
        }
    
        /// <summary>
        /// Replaces the specified CacheRefreshPlan item using the provided definition. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <param name="cacheRefreshPlan">Definition of the CacheRefreshPlan item that updates the current item on the server.</param> 
        /// <returns>CacheRefreshPlan</returns>            
        public CacheRefreshPlan SetCacheRefreshPlan (string id, CacheRefreshPlan cacheRefreshPlan)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetCacheRefreshPlan");
            
            // verify the required parameter 'cacheRefreshPlan' is set
            if (cacheRefreshPlan == null) throw new ApiException(400, "Missing required parameter 'cacheRefreshPlan' when calling SetCacheRefreshPlan");
            
    
            var path = "/CacheRefreshPlans({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(cacheRefreshPlan); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCacheRefreshPlan: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetCacheRefreshPlan: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CacheRefreshPlan) ApiClient.Deserialize(response.Content, typeof(CacheRefreshPlan), response.Headers);
        }
    
    }
}
