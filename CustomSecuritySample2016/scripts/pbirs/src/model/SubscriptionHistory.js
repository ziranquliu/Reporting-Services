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
    root.PowerBiReportServerRestApi.SubscriptionHistory = factory(root.PowerBiReportServerRestApi.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The SubscriptionHistory model module.
   * @module model/SubscriptionHistory
   * @version 2.0
   */

  /**
   * Constructs a new <code>SubscriptionHistory</code>.
   * An object that defines a subscription history or execution record.
   * @alias module:model/SubscriptionHistory
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>SubscriptionHistory</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/SubscriptionHistory} obj Optional instance to populate.
   * @return {module:model/SubscriptionHistory} The populated <code>SubscriptionHistory</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('Id'))
        obj.id = ApiClient.convertToType(data['Id'], 'Number');
      if (data.hasOwnProperty('SubscriptionID'))
        obj.subscriptionID = ApiClient.convertToType(data['SubscriptionID'], 'String');
      if (data.hasOwnProperty('Type'))
        obj.type = ApiClient.convertToType(data['Type'], 'String');
      if (data.hasOwnProperty('StartTime'))
        obj.startTime = ApiClient.convertToType(data['StartTime'], 'Date');
      if (data.hasOwnProperty('EndTime'))
        obj.endTime = ApiClient.convertToType(data['EndTime'], 'Date');
      if (data.hasOwnProperty('SubscriptionStatus'))
        obj.subscriptionStatus = ApiClient.convertToType(data['SubscriptionStatus'], 'String');
      if (data.hasOwnProperty('Message'))
        obj.message = ApiClient.convertToType(data['Message'], 'String');
      if (data.hasOwnProperty('Details'))
        obj.details = ApiClient.convertToType(data['Details'], 'String');
    }
    return obj;
  }

  /**
   * A unique identifier by which this Subscription History record can be referenced in requests or in other defined objects.
   * @member {Number} id
   */
  exports.prototype.id = undefined;

  /**
   * A unique UUID value that identifies the Subscription that this record is associated with.
   * @member {String} subscriptionID
   */
  exports.prototype.subscriptionID = undefined;

  /**
   * A string value that specifies the type of subscription execution.
   * @member {module:model/SubscriptionHistory.TypeEnum} type
   */
  exports.prototype.type = undefined;

  /**
   * A string that contains the date-time for when the subscription execution started.
   * @member {Date} startTime
   */
  exports.prototype.startTime = undefined;

  /**
   * A string that contains the date-time for when the subscription execution ended.
   * @member {Date} endTime
   */
  exports.prototype.endTime = undefined;

  /**
   * A string value that represents the status of the subscription execution.
   * @member {module:model/SubscriptionHistory.SubscriptionStatusEnum} subscriptionStatus
   */
  exports.prototype.subscriptionStatus = undefined;

  /**
   * A string value that contains message that describes the status of the subscription execution.
   * @member {String} message
   */
  exports.prototype.message = undefined;

  /**
   * A JSON string value that contains the session information and error details when a subscription execution fails.
   * @member {String} details
   */
  exports.prototype.details = undefined;


  /**
   * Allowed values for the <code>type</code> property.
   * @enum {String}
   * @readonly
   */
  exports.TypeEnum = {
    /**
     * value: "Scheduled"
     * @const
     */
    scheduled: "Scheduled",

    /**
     * value: "OnDemand"
     * @const
     */
    onDemand: "OnDemand"
  };


  /**
   * Allowed values for the <code>subscriptionStatus</code> property.
   * @enum {String}
   * @readonly
   */
  exports.SubscriptionStatusEnum = {
    /**
     * value: "Completed"
     * @const
     */
    completed: "Completed",

    /**
     * value: "InProgress"
     * @const
     */
    inProgress: "InProgress",

    /**
     * value: "Failed"
     * @const
     */
    failed: "Failed"
  };

  return exports;

}));
