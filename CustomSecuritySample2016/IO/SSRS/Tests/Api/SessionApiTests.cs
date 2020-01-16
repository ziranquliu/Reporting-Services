/* 
 * SQL Server 2017 Reporting Services REST API
 *
 * The SQL Server 2017 Reporting Services REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://docs.microsoft.com/sql/reporting-services/reporting-services-developer-documentation  __Team Blog:__ https://blogs.msdn.microsoft.com/sqlrsteamblog  __Support forums:__ https://social.msdn.microsoft.com/Forums/en-US/home?forum=sqlreportingservices 
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Model;

namespace IO.SSRS.Swagger.Test
{
    /// <summary>
    ///  Class for testing SessionApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SessionApiTests
    {
        private SessionApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SessionApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SessionApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SessionApi
            //Assert.IsInstanceOfType(typeof(SessionApi), instance, "instance is a SessionApi");
        }

        
        /// <summary>
        /// Test CreateSession
        /// </summary>
        [Test]
        public void CreateSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserCredentials userCredentials = null;
            //instance.CreateSession(userCredentials);
            
        }
        
        /// <summary>
        /// Test DeleteSession
        /// </summary>
        [Test]
        public void DeleteSessionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DeleteSession();
            
        }
        
    }

}
