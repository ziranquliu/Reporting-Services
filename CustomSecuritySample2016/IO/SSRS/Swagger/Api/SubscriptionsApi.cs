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
    public interface ISubscriptionsApi
    {
        /// <summary>
        /// Creates new Subscription item 
        /// </summary>
        /// <param name="subscription">The definition of the new Subscription item.</param>
        /// <returns>Subscription</returns>
        Subscription AddSubscription (Subscription subscription);
        /// <summary>
        /// Deletes the specified Subscription. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <returns></returns>
        void DeleteSubscription (string id);
        /// <summary>
        /// Disables the Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <returns></returns>
        void DisableSubscription (string id);
        /// <summary>
        /// Enables a Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <returns></returns>
        void EnableSubscription (string id);
        /// <summary>
        /// Executes the Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <returns></returns>
        void ExecuteSubscription (string id);
        /// <summary>
        /// Get the specified Subscription. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <returns>Subscription</returns>
        Subscription GetSubscription (string id);
        /// <summary>
        /// Gets an array of Subscriptions. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param>
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param>
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param>
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param>
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param>
        /// <param name="expand">Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621)</param>
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param>
        /// <returns>List&lt;Subscription&gt;</returns>
        List<Subscription> GetSubscriptions (int? top, int? skip, string filter, string count, string orderBy, string expand, string select);
        /// <summary>
        /// Replaces the Subscription item using Id property as key. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <param name="subscription">Subscription item to update.</param>
        /// <returns></returns>
        void SetSubscription (string id, Subscription subscription);
        /// <summary>
        /// Updates the Subscription item using Id property as key. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param>
        /// <param name="subscription">Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param>
        /// <returns></returns>
        void UpdateSubscription (string id, Subscription subscription);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SubscriptionsApi : ISubscriptionsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SubscriptionsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SubscriptionsApi(String basePath)
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
        /// Creates new Subscription item 
        /// </summary>
        /// <param name="subscription">The definition of the new Subscription item.</param> 
        /// <returns>Subscription</returns>            
        public Subscription AddSubscription (Subscription subscription)
        {
            
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling AddSubscription");
            
    
            var path = "/Subscriptions";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscription); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Deletes the specified Subscription. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <returns></returns>            
        public void DeleteSubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSubscription");
            
    
            var path = "/Subscriptions({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Disables the Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <returns></returns>            
        public void DisableSubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DisableSubscription");
            
    
            var path = "/Subscriptions({Id})/Model.Disable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DisableSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DisableSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Enables a Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <returns></returns>            
        public void EnableSubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EnableSubscription");
            
    
            var path = "/Subscriptions({Id})/Model.Enable";
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
                throw new ApiException ((int)response.StatusCode, "Error calling EnableSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EnableSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Executes the Subscription specified by the Id. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <returns></returns>            
        public void ExecuteSubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ExecuteSubscription");
            
    
            var path = "/Subscriptions({Id})/Model.Execute";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ExecuteSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the specified Subscription. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <returns>Subscription</returns>            
        public Subscription GetSubscription (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSubscription");
            
    
            var path = "/Subscriptions({Id})";
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
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Subscription) ApiClient.Deserialize(response.Content, typeof(Subscription), response.Headers);
        }
    
        /// <summary>
        /// Gets an array of Subscriptions. 
        /// </summary>
        /// <param name="top">Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)</param> 
        /// <param name="skip">Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)</param> 
        /// <param name="filter">Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)</param> 
        /// <param name="count">Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)</param> 
        /// <param name="orderBy">Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629)</param> 
        /// <param name="expand">Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621)</param> 
        /// <param name="select">Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620)</param> 
        /// <returns>List&lt;Subscription&gt;</returns>            
        public List<Subscription> GetSubscriptions (int? top, int? skip, string filter, string count, string orderBy, string expand, string select)
        {
            
    
            var path = "/Subscriptions";
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
 if (expand != null) queryParams.Add("$expand", ApiClient.ParameterToString(expand)); // query parameter
 if (select != null) queryParams.Add("$select", ApiClient.ParameterToString(select)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptions: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSubscriptions: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<Subscription>) ApiClient.Deserialize(response.Content, typeof(List<Subscription>), response.Headers);
        }
    
        /// <summary>
        /// Replaces the Subscription item using Id property as key. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <param name="subscription">Subscription item to update.</param> 
        /// <returns></returns>            
        public void SetSubscription (string id, Subscription subscription)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SetSubscription");
            
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling SetSubscription");
            
    
            var path = "/Subscriptions({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscription); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SetSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Updates the Subscription item using Id property as key. 
        /// </summary>
        /// <param name="id">The key (GUID) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef</param> 
        /// <param name="subscription">Definition of the Subscription that updates the current item on the server. It is only necessary to include properties to be updated. All other property values will be left unchanged.</param> 
        /// <returns></returns>            
        public void UpdateSubscription (string id, Subscription subscription)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling UpdateSubscription");
            
            // verify the required parameter 'subscription' is set
            if (subscription == null) throw new ApiException(400, "Missing required parameter 'subscription' when calling UpdateSubscription");
            
    
            var path = "/Subscriptions({Id})";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "Id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(subscription); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscription: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateSubscription: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
