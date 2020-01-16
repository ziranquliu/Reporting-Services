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
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.PowerBiReportServerRestApi);
  }
}(this, function(expect, PowerBiReportServerRestApi) {
  'use strict';

  var instance;

  describe('(package)', function() {
    describe('ReportParameterDefinition', function() {
      beforeEach(function() {
        instance = new PowerBiReportServerRestApi.ReportParameterDefinition();
      });

      it('should create an instance of ReportParameterDefinition', function() {
        // TODO: update the code to test ReportParameterDefinition
        expect(instance).to.be.a(PowerBiReportServerRestApi.ReportParameterDefinition);
      });

      it('should have the property allowBlank (base name: "AllowBlank")', function() {
        // TODO: update the code to test the property allowBlank
        expect(instance).to.have.property('allowBlank');
        // expect(instance.allowBlank).to.be(expectedValueLiteral);
      });

      it('should have the property defaultValues (base name: "DefaultValues")', function() {
        // TODO: update the code to test the property defaultValues
        expect(instance).to.have.property('defaultValues');
        // expect(instance.defaultValues).to.be(expectedValueLiteral);
      });

      it('should have the property defaultValuesIsNull (base name: "DefaultValuesIsNull")', function() {
        // TODO: update the code to test the property defaultValuesIsNull
        expect(instance).to.have.property('defaultValuesIsNull');
        // expect(instance.defaultValuesIsNull).to.be(expectedValueLiteral);
      });

      it('should have the property defaultValuesQueryBased (base name: "DefaultValuesQueryBased")', function() {
        // TODO: update the code to test the property defaultValuesQueryBased
        expect(instance).to.have.property('defaultValuesQueryBased');
        // expect(instance.defaultValuesQueryBased).to.be(expectedValueLiteral);
      });

      it('should have the property dependencies (base name: "Dependencies")', function() {
        // TODO: update the code to test the property dependencies
        expect(instance).to.have.property('dependencies');
        // expect(instance.dependencies).to.be(expectedValueLiteral);
      });

      it('should have the property errorMessage (base name: "ErrorMessage")', function() {
        // TODO: update the code to test the property errorMessage
        expect(instance).to.have.property('errorMessage');
        // expect(instance.errorMessage).to.be(expectedValueLiteral);
      });

      it('should have the property multiValue (base name: "MultiValue")', function() {
        // TODO: update the code to test the property multiValue
        expect(instance).to.have.property('multiValue');
        // expect(instance.multiValue).to.be(expectedValueLiteral);
      });

      it('should have the property name (base name: "Name")', function() {
        // TODO: update the code to test the property name
        expect(instance).to.have.property('name');
        // expect(instance.name).to.be(expectedValueLiteral);
      });

      it('should have the property nullable (base name: "Nullable")', function() {
        // TODO: update the code to test the property nullable
        expect(instance).to.have.property('nullable');
        // expect(instance.nullable).to.be(expectedValueLiteral);
      });

      it('should have the property parameterState (base name: "ParameterState")', function() {
        // TODO: update the code to test the property parameterState
        expect(instance).to.have.property('parameterState');
        // expect(instance.parameterState).to.be(expectedValueLiteral);
      });

      it('should have the property parameterType (base name: "ParameterType")', function() {
        // TODO: update the code to test the property parameterType
        expect(instance).to.have.property('parameterType');
        // expect(instance.parameterType).to.be(expectedValueLiteral);
      });

      it('should have the property parameterVisibility (base name: "ParameterVisibility")', function() {
        // TODO: update the code to test the property parameterVisibility
        expect(instance).to.have.property('parameterVisibility');
        // expect(instance.parameterVisibility).to.be(expectedValueLiteral);
      });

      it('should have the property prompt (base name: "Prompt")', function() {
        // TODO: update the code to test the property prompt
        expect(instance).to.have.property('prompt');
        // expect(instance.prompt).to.be(expectedValueLiteral);
      });

      it('should have the property promptUser (base name: "PromptUser")', function() {
        // TODO: update the code to test the property promptUser
        expect(instance).to.have.property('promptUser');
        // expect(instance.promptUser).to.be(expectedValueLiteral);
      });

      it('should have the property queryParameter (base name: "QueryParameter")', function() {
        // TODO: update the code to test the property queryParameter
        expect(instance).to.have.property('queryParameter');
        // expect(instance.queryParameter).to.be(expectedValueLiteral);
      });

      it('should have the property validValues (base name: "ValidValues")', function() {
        // TODO: update the code to test the property validValues
        expect(instance).to.have.property('validValues');
        // expect(instance.validValues).to.be(expectedValueLiteral);
      });

      it('should have the property validValuesIsNull (base name: "ValidValuesIsNull")', function() {
        // TODO: update the code to test the property validValuesIsNull
        expect(instance).to.have.property('validValuesIsNull');
        // expect(instance.validValuesIsNull).to.be(expectedValueLiteral);
      });

      it('should have the property validValuesQueryBased (base name: "ValidValuesQueryBased")', function() {
        // TODO: update the code to test the property validValuesQueryBased
        expect(instance).to.have.property('validValuesQueryBased');
        // expect(instance.validValuesQueryBased).to.be(expectedValueLiteral);
      });

    });
  });

}));
