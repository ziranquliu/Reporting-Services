/* 
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
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
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Model;
using IO.SSRS.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.SSRS.Swagger.Test
{
    /// <summary>
    ///  Class for testing Subscription
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SubscriptionTests
    {
        // TODO uncomment below to declare an instance variable for Subscription
        //private Subscription instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Subscription
            //instance = new Subscription();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Subscription
        /// </summary>
        [Test]
        public void SubscriptionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Subscription
            //Assert.IsInstanceOfType<Subscription> (instance, "variable 'instance' is a Subscription");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'Owner'
        /// </summary>
        [Test]
        public void OwnerTest()
        {
            // TODO unit test for the property 'Owner'
        }
        /// <summary>
        /// Test the property 'IsDataDriven'
        /// </summary>
        [Test]
        public void IsDataDrivenTest()
        {
            // TODO unit test for the property 'IsDataDriven'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Report'
        /// </summary>
        [Test]
        public void ReportTest()
        {
            // TODO unit test for the property 'Report'
        }
        /// <summary>
        /// Test the property 'IsActive'
        /// </summary>
        [Test]
        public void IsActiveTest()
        {
            // TODO unit test for the property 'IsActive'
        }
        /// <summary>
        /// Test the property 'EventType'
        /// </summary>
        [Test]
        public void EventTypeTest()
        {
            // TODO unit test for the property 'EventType'
        }
        /// <summary>
        /// Test the property 'ScheduleDescription'
        /// </summary>
        [Test]
        public void ScheduleDescriptionTest()
        {
            // TODO unit test for the property 'ScheduleDescription'
        }
        /// <summary>
        /// Test the property 'LastRunTime'
        /// </summary>
        [Test]
        public void LastRunTimeTest()
        {
            // TODO unit test for the property 'LastRunTime'
        }
        /// <summary>
        /// Test the property 'LastStatus'
        /// </summary>
        [Test]
        public void LastStatusTest()
        {
            // TODO unit test for the property 'LastStatus'
        }
        /// <summary>
        /// Test the property 'ExtensionSettings'
        /// </summary>
        [Test]
        public void ExtensionSettingsTest()
        {
            // TODO unit test for the property 'ExtensionSettings'
        }
        /// <summary>
        /// Test the property 'DeliveryExtension'
        /// </summary>
        [Test]
        public void DeliveryExtensionTest()
        {
            // TODO unit test for the property 'DeliveryExtension'
        }
        /// <summary>
        /// Test the property 'LocalizedDeliveryExtensionName'
        /// </summary>
        [Test]
        public void LocalizedDeliveryExtensionNameTest()
        {
            // TODO unit test for the property 'LocalizedDeliveryExtensionName'
        }
        /// <summary>
        /// Test the property 'ModifiedBy'
        /// </summary>
        [Test]
        public void ModifiedByTest()
        {
            // TODO unit test for the property 'ModifiedBy'
        }
        /// <summary>
        /// Test the property 'ModifiedDate'
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO unit test for the property 'ModifiedDate'
        }
        /// <summary>
        /// Test the property 'ParameterValues'
        /// </summary>
        [Test]
        public void ParameterValuesTest()
        {
            // TODO unit test for the property 'ParameterValues'
        }

    }

}
