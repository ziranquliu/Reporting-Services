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
    ///  Class for testing DataSource
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class DataSourceTests
    {
        // TODO uncomment below to declare an instance variable for DataSource
        //private DataSource instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of DataSource
            //instance = new DataSource();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DataSource
        /// </summary>
        [Test]
        public void DataSourceInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" DataSource
            //Assert.IsInstanceOfType<DataSource> (instance, "variable 'instance' is a DataSource");
        }


        /// <summary>
        /// Test the property 'IsEnabled'
        /// </summary>
        [Test]
        public void IsEnabledTest()
        {
            // TODO unit test for the property 'IsEnabled'
        }
        /// <summary>
        /// Test the property 'ConnectionString'
        /// </summary>
        [Test]
        public void ConnectionStringTest()
        {
            // TODO unit test for the property 'ConnectionString'
        }
        /// <summary>
        /// Test the property 'DataModelDataSource'
        /// </summary>
        [Test]
        public void DataModelDataSourceTest()
        {
            // TODO unit test for the property 'DataModelDataSource'
        }
        /// <summary>
        /// Test the property 'DataSourceSubType'
        /// </summary>
        [Test]
        public void DataSourceSubTypeTest()
        {
            // TODO unit test for the property 'DataSourceSubType'
        }
        /// <summary>
        /// Test the property 'DataSourceType'
        /// </summary>
        [Test]
        public void DataSourceTypeTest()
        {
            // TODO unit test for the property 'DataSourceType'
        }
        /// <summary>
        /// Test the property 'IsOriginalConnectionStringExpressionBased'
        /// </summary>
        [Test]
        public void IsOriginalConnectionStringExpressionBasedTest()
        {
            // TODO unit test for the property 'IsOriginalConnectionStringExpressionBased'
        }
        /// <summary>
        /// Test the property 'IsConnectionStringOverridden'
        /// </summary>
        [Test]
        public void IsConnectionStringOverriddenTest()
        {
            // TODO unit test for the property 'IsConnectionStringOverridden'
        }
        /// <summary>
        /// Test the property 'CredentialsByUser'
        /// </summary>
        [Test]
        public void CredentialsByUserTest()
        {
            // TODO unit test for the property 'CredentialsByUser'
        }
        /// <summary>
        /// Test the property 'CredentialsInServer'
        /// </summary>
        [Test]
        public void CredentialsInServerTest()
        {
            // TODO unit test for the property 'CredentialsInServer'
        }
        /// <summary>
        /// Test the property 'IsReference'
        /// </summary>
        [Test]
        public void IsReferenceTest()
        {
            // TODO unit test for the property 'IsReference'
        }
        /// <summary>
        /// Test the property 'Subscriptions'
        /// </summary>
        [Test]
        public void SubscriptionsTest()
        {
            // TODO unit test for the property 'Subscriptions'
        }

    }

}
