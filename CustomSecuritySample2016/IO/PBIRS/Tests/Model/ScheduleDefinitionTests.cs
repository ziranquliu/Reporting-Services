/* 
 * Power BI Report Server REST API
 *
 * The Power BI Report Server REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Since Power BI Report Server is a superset of SQL Server Reporting Services, the Power BI Report Server REST API is a superset of the  [SQL Server Reporting Services REST API](https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0).  __Power BI Report Server API Additions__ * January 2019 Release   * /PowerBIReports({Id})/DataModelRoles (GET)   * /PowerBIReports({Id})/DataModelRoleAssignments (GET & PUT)  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://powerbi.microsoft.com/documentation/reportserver-developer-handbook-overview/  __Team Blog:__  https://powerbi.microsoft.com/blog/  __Support forums:__  https://community.powerbi.com/t5/Report-Server/bd-p/ReportServer 
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Model;
using IO.PBIRS.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.PBIRS.Swagger.Test
{
    /// <summary>
    ///  Class for testing ScheduleDefinition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ScheduleDefinitionTests
    {
        // TODO uncomment below to declare an instance variable for ScheduleDefinition
        //private ScheduleDefinition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ScheduleDefinition
            //instance = new ScheduleDefinition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ScheduleDefinition
        /// </summary>
        [Test]
        public void ScheduleDefinitionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ScheduleDefinition
            //Assert.IsInstanceOfType<ScheduleDefinition> (instance, "variable 'instance' is a ScheduleDefinition");
        }


        /// <summary>
        /// Test the property 'StartDateTime'
        /// </summary>
        [Test]
        public void StartDateTimeTest()
        {
            // TODO unit test for the property 'StartDateTime'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Test]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'EndDateSpecified'
        /// </summary>
        [Test]
        public void EndDateSpecifiedTest()
        {
            // TODO unit test for the property 'EndDateSpecified'
        }
        /// <summary>
        /// Test the property 'Recurrence'
        /// </summary>
        [Test]
        public void RecurrenceTest()
        {
            // TODO unit test for the property 'Recurrence'
        }

    }

}
