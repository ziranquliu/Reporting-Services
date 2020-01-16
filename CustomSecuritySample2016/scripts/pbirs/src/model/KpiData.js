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
    define(['ApiClient', 'model/KpiDataItem'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./KpiDataItem'));
  } else {
    // Browser globals (root is window)
    if (!root.PowerBiReportServerRestApi) {
      root.PowerBiReportServerRestApi = {};
    }
    root.PowerBiReportServerRestApi.KpiData = factory(root.PowerBiReportServerRestApi.ApiClient, root.PowerBiReportServerRestApi.KpiDataItem);
  }
}(this, function(ApiClient, KpiDataItem) {
  'use strict';

  /**
   * The KpiData model module.
   * @module model/KpiData
   * @version 2.0
   */

  /**
   * Constructs a new <code>KpiData</code>.
   * An object that specifies the metadata source for the component parts of a KPI.
   * @alias module:model/KpiData
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>KpiData</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/KpiData} obj Optional instance to populate.
   * @return {module:model/KpiData} The populated <code>KpiData</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('Value'))
        obj.value = KpiDataItem.constructFromObject(data['Value']);
      if (data.hasOwnProperty('Goal'))
        obj.goal = KpiDataItem.constructFromObject(data['Goal']);
      if (data.hasOwnProperty('Status'))
        obj.status = KpiDataItem.constructFromObject(data['Status']);
      if (data.hasOwnProperty('TrendSet'))
        obj.trendSet = KpiDataItem.constructFromObject(data['TrendSet']);
    }
    return obj;
  }

  /**
   * @member {module:model/KpiDataItem} value
   */
  exports.prototype.value = undefined;

  /**
   * @member {module:model/KpiDataItem} goal
   */
  exports.prototype.goal = undefined;

  /**
   * @member {module:model/KpiDataItem} status
   */
  exports.prototype.status = undefined;

  /**
   * @member {module:model/KpiDataItem} trendSet
   */
  exports.prototype.trendSet = undefined;

  return exports;

}));
