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
    ///  Class for testing ODataResources
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ODataResourcesTests
    {
        // TODO uncomment below to declare an instance variable for ODataResources
        //private ODataResources instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ODataResources
            //instance = new ODataResources();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ODataResources
        /// </summary>
        [Test]
        public void ODataResourcesInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ODataResources
            //Assert.IsInstanceOfType<ODataResources> (instance, "variable 'instance' is a ODataResources");
        }


        /// <summary>
        /// Test the property 'OdataContext'
        /// </summary>
        [Test]
        public void OdataContextTest()
        {
            // TODO unit test for the property 'OdataContext'
        }
        /// <summary>
        /// Test the property 'OdataCount'
        /// </summary>
        [Test]
        public void OdataCountTest()
        {
            // TODO unit test for the property 'OdataCount'
        }
        /// <summary>
        /// Test the property 'Value'
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO unit test for the property 'Value'
        }

    }

}
