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
    ///  Class for testing UserCredentials
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class UserCredentialsTests
    {
        // TODO uncomment below to declare an instance variable for UserCredentials
        //private UserCredentials instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of UserCredentials
            //instance = new UserCredentials();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UserCredentials
        /// </summary>
        [Test]
        public void UserCredentialsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" UserCredentials
            //Assert.IsInstanceOfType<UserCredentials> (instance, "variable 'instance' is a UserCredentials");
        }


        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Test]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'Password'
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO unit test for the property 'Password'
        }
        /// <summary>
        /// Test the property 'Domain'
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO unit test for the property 'Domain'
        }

    }

}
