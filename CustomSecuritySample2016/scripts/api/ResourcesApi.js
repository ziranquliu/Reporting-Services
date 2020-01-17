/*
 * Power BI Report Server REST API
 * The Power BI Report Server REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Since Power BI Report Server is a superset of SQL Server Reporting Services, the Power BI Report Server REST API is a superset of the  [SQL Server Reporting Services REST API](https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0).  __Power BI Report Server API Additions__ * January 2019 Release   * /PowerBIReports({Id})/DataModelRoles (GET)   * /PowerBIReports({Id})/DataModelRoleAssignments (GET & PUT)  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://powerbi.microsoft.com/documentation/reportserver-developer-handbook-overview/  __Team Blog:__  https://powerbi.microsoft.com/blog/  __Support forums:__  https://community.powerbi.com/t5/Report-Server/bd-p/ReportServer 
 *
 * OpenAPI spec version: 2.0
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.10
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/ItemPolicy', 'model/ODataAllowedActions', 'model/ODataProperties', 'model/ODataResources', 'model/OdataError', 'model/Property', 'model/Resource'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/ItemPolicy'), require('../model/ODataAllowedActions'), require('../model/ODataProperties'), require('../model/ODataResources'), require('../model/OdataError'), require('../model/Property'), require('../model/Resource'));
  } else {
    // Browser globals (root is window)
    if (!root.PowerBiReportServerRestApi) {
      root.PowerBiReportServerRestApi = {};
    }
    root.PowerBiReportServerRestApi.ResourcesApi = factory(root.PowerBiReportServerRestApi.ApiClient, root.PowerBiReportServerRestApi.ItemPolicy, root.PowerBiReportServerRestApi.ODataAllowedActions, root.PowerBiReportServerRestApi.ODataProperties, root.PowerBiReportServerRestApi.ODataResources, root.PowerBiReportServerRestApi.OdataError, root.PowerBiReportServerRestApi.Property, root.PowerBiReportServerRestApi.Resource);
  }
}(this, function(ApiClient, ItemPolicy, ODataAllowedActions, ODataProperties, ODataResources, OdataError, Property, Resource) {
  'use strict';

  /**
   * Resources service.
   * @module api/ResourcesApi
   * @version 2.0
   */

  /**
   * Constructs a new ResourcesApi. 
   * @alias module:api/ResourcesApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the addResource operation.
     * @callback module:api/ResourcesApi~addResourceCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Resource} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Creates new Resource item
     * @param {module:model/Resource} resource The definition of the new Resource item.
     * @param {module:api/ResourcesApi~addResourceCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Resource}
     */
    this.addResource = function(resource, callback) {
      var postBody = resource;

      // verify the required parameter 'resource' is set
      if (resource === undefined || resource === null) {
        throw new Error("Missing the required parameter 'resource' when calling addResource");
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Resource;

      return this.apiClient.callApi(
        '/Resources', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the deleteResource operation.
     * @callback module:api/ResourcesApi~deleteResourceCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete the specified Resource catalog item.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:api/ResourcesApi~deleteResourceCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.deleteResource = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling deleteResource");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/Resources({Id})', 'DELETE',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResource operation.
     * @callback module:api/ResourcesApi~getResourceCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Resource} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get the specified Resource.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:api/ResourcesApi~getResourceCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Resource}
     */
    this.getResource = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling getResource");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Resource;

      return this.apiClient.callApi(
        '/Resources({Id})', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResourceAllowedActions operation.
     * @callback module:api/ResourcesApi~getResourceAllowedActionsCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ODataAllowedActions} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets a list of actions allowed in the current session; considering user permissions and product edition capabilities.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:api/ResourcesApi~getResourceAllowedActionsCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/ODataAllowedActions}
     */
    this.getResourceAllowedActions = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling getResourceAllowedActions");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = ODataAllowedActions;

      return this.apiClient.callApi(
        '/Resources({Id})/AllowedActions', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResourceContent operation.
     * @callback module:api/ResourcesApi~getResourceContentCallback
     * @param {String} error Error message, if any.
     * @param {File} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets the content of the specified Resource CatalogItem specified by the Id.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:api/ResourcesApi~getResourceContentCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link File}
     */
    this.getResourceContent = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling getResourceContent");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/octet-stream'];
      var returnType = File;

      return this.apiClient.callApi(
        '/Resources({Id})/Content/$value', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResourcePolicies operation.
     * @callback module:api/ResourcesApi~getResourcePoliciesCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/ItemPolicy>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets ItemPolicies on the Resource item.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:api/ResourcesApi~getResourcePoliciesCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:model/ItemPolicy>}
     */
    this.getResourcePolicies = function(id, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling getResourcePolicies");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = [ItemPolicy];

      return this.apiClient.callApi(
        '/Resources({Id})/Policies', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResourceProperties operation.
     * @callback module:api/ResourcesApi~getResourcePropertiesCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ODataProperties} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets the specified Resources Properties (takes list of Property names to retrieve the values)
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {Object} opts Optional parameters
     * @param {Array.<String>} opts.properties Names for the Properties to be returned.
     * @param {module:api/ResourcesApi~getResourcePropertiesCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/ODataProperties}
     */
    this.getResourceProperties = function(id, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling getResourceProperties");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
        'Properties': {
          value: opts['properties'],
          collectionFormat: 'multi'
        },
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = ODataProperties;

      return this.apiClient.callApi(
        '/Resources({Id})/Properties', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getResources operation.
     * @callback module:api/ResourcesApi~getResourcesCallback
     * @param {String} error Error message, if any.
     * @param {module:model/ODataResources} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets an array of Resource catalog items
     * @param {Object} opts Optional parameters
     * @param {Number} opts.top Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630)
     * @param {Number} opts.skip Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631)
     * @param {String} opts.filter Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625)
     * @param {String} opts.count Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632)
     * @param {module:api/ResourcesApi~getResourcesCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/ODataResources}
     */
    this.getResources = function(opts, callback) {
      opts = opts || {};
      var postBody = null;


      var pathParams = {
      };
      var queryParams = {
        '$top': opts['top'],
        '$skip': opts['skip'],
        '$filter': opts['filter'],
        '$count': opts['count'],
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = ODataResources;

      return this.apiClient.callApi(
        '/Resources', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the setResourcePolicies operation.
     * @callback module:api/ResourcesApi~setResourcePoliciesCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Replaces ItemPolicies on the Resource item.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {Array.<module:model/ItemPolicy>} policies Array of ItemPolicies to set on the Resource CatalogItem.
     * @param {module:api/ResourcesApi~setResourcePoliciesCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.setResourcePolicies = function(id, policies, callback) {
      var postBody = policies;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling setResourcePolicies");
      }

      // verify the required parameter 'policies' is set
      if (policies === undefined || policies === null) {
        throw new Error("Missing the required parameter 'policies' when calling setResourcePolicies");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/Resources({Id})/Policies', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateResource operation.
     * @callback module:api/ResourcesApi~updateResourceCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Resource} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Updates the specified Resource catalog item.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {module:model/Resource} resource Definition of the Resource item that replaces the current item on the server. It is only necessary to include properties to be updated. All other property values on the CatalogItem will be left unchanged.
     * @param {module:api/ResourcesApi~updateResourceCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Resource}
     */
    this.updateResource = function(id, resource, callback) {
      var postBody = resource;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling updateResource");
      }

      // verify the required parameter 'resource' is set
      if (resource === undefined || resource === null) {
        throw new Error("Missing the required parameter 'resource' when calling updateResource");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = Resource;

      return this.apiClient.callApi(
        '/Resources({Id})', 'PATCH',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the updateResourceProperties operation.
     * @callback module:api/ResourcesApi~updateResourcePropertiesCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Updates the Resource Properties included in the given list.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {Array.<module:model/Property>} properties The Properties that will be updated.
     * @param {module:api/ResourcesApi~updateResourcePropertiesCallback} callback The callback function, accepting three arguments: error, data, response
     */
    this.updateResourceProperties = function(id, properties, callback) {
      var postBody = properties;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling updateResourceProperties");
      }

      // verify the required parameter 'properties' is set
      if (properties === undefined || properties === null) {
        throw new Error("Missing the required parameter 'properties' when calling updateResourceProperties");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = ['application/json'];
      var accepts = ['application/json'];
      var returnType = null;

      return this.apiClient.callApi(
        '/Resources({Id})/Properties', 'PUT',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the uploadResource operation.
     * @callback module:api/ResourcesApi~uploadResourceCallback
     * @param {String} error Error message, if any.
     * @param {module:model/Resource} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Does an efficient binary upload of a new or existing Resource CatalogItem from a multipart/form-data request. Use of this API is recommended for files larger than 25 MB in size.
     * @param {String} id The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.
     * @param {File} file The file contents.
     * @param {module:api/ResourcesApi~uploadResourceCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:model/Resource}
     */
    this.uploadResource = function(id, file, callback) {
      var postBody = null;

      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling uploadResource");
      }

      // verify the required parameter 'file' is set
      if (file === undefined || file === null) {
        throw new Error("Missing the required parameter 'file' when calling uploadResource");
      }


      var pathParams = {
        'Id': id
      };
      var queryParams = {
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
        'File': file
      };

      var authNames = [];
      var contentTypes = ['multipart/form-data'];
      var accepts = ['application/json'];
      var returnType = Resource;

      return this.apiClient.callApi(
        '/Resources({Id})/Model.Upload', 'POST',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
