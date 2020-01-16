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
    public interface ISystemApi
    {
        /// <summary>
        /// Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <returns>ODataAllowedActions</returns>
        ODataAllowedActions GetSystemAllowedActions ();
        /// <summary>
        /// Get SystemInformation 
        /// </summary>
        /// <returns>SystemInfo</returns>
        SystemInfo GetSystemInfo ();
        /// <summary>
        /// Gets the System Policies. 
        /// </summary>
        /// <returns>List&lt;Policy&gt;</returns>
        List<Policy> GetSystemPolicies ();
        /// <summary>
        /// Gets the Systems Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="properties">Names for the Properties to be returned.</param>
        /// <returns>ODataProperties</returns>
        ODataProperties GetSystemProperties (List<string> properties);
        /// <summary>
        /// Updates the System&#39;s Policies. 
        /// </summary>
        /// <param name="systemPolicy">The SystemPolicy object that contains settings to apply.</param>
        /// <returns></returns>
        void SetSystemPolicies (SystemPolicy systemPolicy);
        /// <summary>
        /// Updates the System Properties with the given property list. 
        /// </summary>
        /// <param name="properties">Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param>
        /// <returns></returns>
        void UpdateSystemProperties (List<Property> properties);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SystemApi : ISystemApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SystemApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SystemApi(String basePath)
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
        /// Gets a list of system level actions allowed in the current session; user permissions and product edition capabilities are considered when querying. 
        /// </summary>
        /// <returns>ODataAllowedActions</returns>            
        public ODataAllowedActions GetSystemAllowedActions ()
        {
            
    
            var path = "/System/AllowedActions";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemAllowedActions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemAllowedActions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataAllowedActions) ApiClient.Deserialize(response.Content, typeof(ODataAllowedActions), response.Headers);
        }
    
        /// <summary>
        /// Get SystemInformation 
        /// </summary>
        /// <returns>SystemInfo</returns>            
        public SystemInfo GetSystemInfo ()
        {
            
    
            var path = "/System";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemInfo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemInfo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemInfo) ApiClient.Deserialize(response.Content, typeof(SystemInfo), response.Headers);
        }
    
        /// <summary>
        /// Gets the System Policies. 
        /// </summary>
        /// <returns>List&lt;Policy&gt;</returns>            
        public List<Policy> GetSystemPolicies ()
        {
            
    
            var path = "/System/Policies";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Policy>) ApiClient.Deserialize(response.Content, typeof(List<Policy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the Systems Properties (takes list of Property names to retrieve the values) 
        /// </summary>
        /// <param name="properties">Names for the Properties to be returned.</param> 
        /// <returns>ODataProperties</returns>            
        public ODataProperties GetSystemProperties (List<string> properties)
        {
            
    
            var path = "/System/Properties";
            path = path.Replace("{format}", "json");
                
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSystemProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ODataProperties) ApiClient.Deserialize(response.Content, typeof(ODataProperties), response.Headers);
        }
    
        /// <summary>
        /// Updates the System&#39;s Policies. 
        /// </summary>
        /// <param name="systemPolicy">The SystemPolicy object that contains settings to apply.</param> 
        /// <returns></returns>            
        public void SetSystemPolicies (SystemPolicy systemPolicy)
        {
            
            // verify the required parameter 'systemPolicy' is set
            if (systemPolicy == null) throw new ApiException(400, "Missing required parameter 'systemPolicy' when calling SetSystemPolicies");
            
    
            var path = "/System/Policies";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(systemPolicy); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSystemPolicies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSystemPolicies: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the System Properties with the given property list. 
        /// </summary>
        /// <param name="properties">Definition of the SystemProperties that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateSystemProperties (List<Property> properties)
        {
            
            // verify the required parameter 'properties' is set
            if (properties == null) throw new ApiException(400, "Missing required parameter 'properties' when calling UpdateSystemProperties");
            
    
            var path = "/System/Properties";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(properties); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSystemProperties: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSystemProperties: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
