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
    ///  Class for testing KpiValues
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class KpiValuesTests
    {
        // TODO uncomment below to declare an instance variable for KpiValues
        //private KpiValues instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of KpiValues
            //instance = new KpiValues();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of KpiValues
        /// </summary>
        [Test]
        public void KpiValuesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" KpiValues
            //Assert.IsInstanceOfType<KpiValues> (instance, "variable 'instance' is a KpiValues");
        }


        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }
        /// <summary>
        /// Test the property 'Goal'
        /// </summary>
        [Test]
        public void GoalTest()
        {
            // TODO unit test for the property 'Goal'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Test]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }
        /// <summary>
        /// Test the property 'TrendSet'
        /// </summary>
        [Test]
        public void TrendSetTest()
        {
            // TODO unit test for the property 'TrendSet'
        }

    }

}
