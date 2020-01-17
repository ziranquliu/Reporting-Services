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
    define(['ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.PowerBiReportServerRestApi) {
      root.PowerBiReportServerRestApi = {};
    }
    root.PowerBiReportServerRestApi.User = factory(root.PowerBiReportServerRestApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The User model module.
   * @module model/User
   * @version 2.0
   */

  /**
   * Constructs a new <code>User</code>.
   * An object that contains information about the Report Server user.
   * @alias module:model/User
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>User</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/User} obj Optional instance to populate.
   * @return {module:model/User} The populated <code>User</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('Id'))
        obj.id = ApiClient.convertToType(data['Id'], 'String');
      if (data.hasOwnProperty('Username'))
        obj.username = ApiClient.convertToType(data['Username'], 'String');
      if (data.hasOwnProperty('DisplayName'))
        obj.displayName = ApiClient.convertToType(data['DisplayName'], 'String');
      if (data.hasOwnProperty('HasFavoriteItems'))
        obj.hasFavoriteItems = ApiClient.convertToType(data['HasFavoriteItems'], 'Boolean');
      if (data.hasOwnProperty('MyReportsPath'))
        obj.myReportsPath = ApiClient.convertToType(data['MyReportsPath'], 'String');
    }
    return obj;
  }

  /**
   * A unique UUID value that specifies the identifier by which this User object can be referenced in requests or in other defined objects.
   * @member {String} id
   */
  exports.prototype.id = undefined;

  /**
   * A string value that specifies the network user name for the user.
   * @member {String} username
   */
  exports.prototype.username = undefined;

  /**
   * A string value that specifies the name to display for the network user.
   * @member {String} displayName
   */
  exports.prototype.displayName = undefined;

  /**
   * A boolean value that indicates whether the user has items that are designated as favorite items.
   * @member {Boolean} hasFavoriteItems
   */
  exports.prototype.hasFavoriteItems = undefined;

  /**
   * A string value that specifies a path to a folder where a user's reports are stored by default. (This feature must be enabled by the server administrator).
   * @member {String} myReportsPath
   */
  exports.prototype.myReportsPath = undefined;

  return exports;

}));
