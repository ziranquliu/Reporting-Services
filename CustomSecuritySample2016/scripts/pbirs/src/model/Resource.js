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
    define(['ApiClient', 'model/CatalogItem', 'model/CatalogItemType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CatalogItem'), require('./CatalogItemType'));
  } else {
    // Browser globals (root is window)
    if (!root.PowerBiReportServerRestApi) {
      root.PowerBiReportServerRestApi = {};
    }
    root.PowerBiReportServerRestApi.Resource = factory(root.PowerBiReportServerRestApi.ApiClient, root.PowerBiReportServerRestApi.CatalogItem, root.PowerBiReportServerRestApi.CatalogItemType);
  }
}(this, function(ApiClient, CatalogItem, CatalogItemType) {
  'use strict';

  /**
   * The Resource model module.
   * @module model/Resource
   * @version 2.0
   */

  /**
   * Constructs a new <code>Resource</code>.
   * @alias module:model/Resource
   * @class
   * @extends module:model/CatalogItem
   */
  var exports = function() {
    CatalogItem.call(this);
  };

  /**
   * Constructs a <code>Resource</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/Resource} obj Optional instance to populate.
   * @return {module:model/Resource} The populated <code>Resource</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      CatalogItem.constructFromObject(data, obj);
    }
    return obj;
  }

  exports.prototype = Object.create(CatalogItem.prototype);
  exports.prototype.constructor = exports;
  return exports;

}));
