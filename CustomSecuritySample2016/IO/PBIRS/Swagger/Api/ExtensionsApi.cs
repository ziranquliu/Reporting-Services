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
    public interface IExtensionsApi
    {
        /// <summary>
        /// Retrieves the ExtensionParameter list for given extension. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param>
        /// <returns>List&lt;ExtensionParameter&gt;</returns>
        List<ExtensionParameter> GetExtensionParameters (string id);
        /// <summary>
        /// Retreives all Extension items. 
        /// </summary>
        /// <returns>List&lt;Extension&gt;</returns>
        List<Extension> GetExtensions ();
        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter. 
        /// </summary>
        /// <param name="extensionSettings"></param>
        /// <returns>List&lt;ExtensionParameter&gt;</returns>
        List<ExtensionParameter> ValidateExtensionParameters (ExtensionSettings extensionSettings);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ExtensionsApi : IExtensionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ExtensionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExtensionsApi(String basePath)
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
        /// Retrieves the ExtensionParameter list for given extension. 
        /// </summary>
        /// <param name="id">The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote.</param> 
        /// <returns>List&lt;ExtensionParameter&gt;</returns>            
        public List<ExtensionParameter> GetExtensionParameters (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetExtensionParameters");
            
    
            var path = "/Extensions({Id})/Parameters";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensionParameters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensionParameters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ExtensionParameter>) ApiClient.Deserialize(response.Content, typeof(List<ExtensionParameter>), response.Headers);
        }
    
        /// <summary>
        /// Retreives all Extension items. 
        /// </summary>
        /// <returns>List&lt;Extension&gt;</returns>            
        public List<Extension> GetExtensions ()
        {
            
    
            var path = "/Extensions";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetExtensions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Extension>) ApiClient.Deserialize(response.Content, typeof(List<Extension>), response.Headers);
        }
    
        /// <summary>
        /// Validates extension parameters and returns collection of ExtensionParameter. 
        /// </summary>
        /// <param name="extensionSettings"></param> 
        /// <returns>List&lt;ExtensionParameter&gt;</returns>            
        public List<ExtensionParameter> ValidateExtensionParameters (ExtensionSettings extensionSettings)
        {
            
    
            var path = "/Extensions/Model.ValidateExtensionSettings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(extensionSettings); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateExtensionParameters: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ValidateExtensionParameters: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<ExtensionParameter>) ApiClient.Deserialize(response.Content, typeof(List<ExtensionParameter>), response.Headers);
        }
    
    }
}
