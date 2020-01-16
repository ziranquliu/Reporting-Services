/*
 * SQL Server 2017 Reporting Services REST API
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
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
    define(['ApiClient', 'model/ScheduleRecurrence'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ScheduleRecurrence'));
  } else {
    // Browser globals (root is window)
    if (!root.SqlServer2017ReportingServicesRestApi) {
      root.SqlServer2017ReportingServicesRestApi = {};
    }
    root.SqlServer2017ReportingServicesRestApi.ScheduleDefinition = factory(root.SqlServer2017ReportingServicesRestApi.ApiClient, root.SqlServer2017ReportingServicesRestApi.ScheduleRecurrence);
  }
}(this, function(ApiClient, ScheduleRecurrence) {
  'use strict';

  /**
   * The ScheduleDefinition model module.
   * @module model/ScheduleDefinition
   * @version 2.0
   */

  /**
   * Constructs a new <code>ScheduleDefinition</code>.
   * An object that defines a schedule including a start date-time and an optional end date-time.
   * @alias module:model/ScheduleDefinition
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>ScheduleDefinition</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ScheduleDefinition} obj Optional instance to populate.
   * @return {module:model/ScheduleDefinition} The populated <code>ScheduleDefinition</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('StartDateTime'))
        obj.startDateTime = ApiClient.convertToType(data['StartDateTime'], 'Date');
      if (data.hasOwnProperty('EndDate'))
        obj.endDate = ApiClient.convertToType(data['EndDate'], 'Date');
      if (data.hasOwnProperty('EndDateSpecified'))
        obj.endDateSpecified = ApiClient.convertToType(data['EndDateSpecified'], 'Boolean');
      if (data.hasOwnProperty('Recurrence'))
        obj.recurrence = ScheduleRecurrence.constructFromObject(data['Recurrence']);
    }
    return obj;
  }

  /**
   * A string that specifies the date-time of the start of the schedule.
   * @member {Date} startDateTime
   */
  exports.prototype.startDateTime = undefined;

  /**
   * A string that specifies the date-time of the end of the schedule.
   * @member {Date} endDate
   */
  exports.prototype.endDate = undefined;

  /**
   * A boolean value that indicates whether the schedule end is specified.
   * @member {Boolean} endDateSpecified
   */
  exports.prototype.endDateSpecified = undefined;

  /**
   * @member {module:model/ScheduleRecurrence} recurrence
   */
  exports.prototype.recurrence = undefined;

  return exports;

}));
