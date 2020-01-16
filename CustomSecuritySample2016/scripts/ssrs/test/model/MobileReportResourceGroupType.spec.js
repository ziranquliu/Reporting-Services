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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.SqlServer2017ReportingServicesRestApi);
  }
}(this, function(expect, SqlServer2017ReportingServicesRestApi) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('MobileReportResourceGroupType', function() {
      beforeEach(function() {
        instance = SqlServer2017ReportingServicesRestApi.MobileReportResourceGroupType;
      });

      it('should create an instance of MobileReportResourceGroupType', function() {
        // TODO: update the code to test MobileReportResourceGroupType
        expect(instance).to.be.a('object');
      });

      it('should have the property unknown', function() {
        expect(instance).to.have.property('unknown');
        expect(instance.unknown).to.be("Unknown");
      });

      it('should have the property style', function() {
        expect(instance).to.have.property('style');
        expect(instance.style).to.be("Style");
      });

      it('should have the property map', function() {
        expect(instance).to.have.property('map');
        expect(instance.map).to.be("Map");
      });

    });
  });

}));
