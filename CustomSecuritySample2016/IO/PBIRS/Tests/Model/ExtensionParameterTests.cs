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
    ///  Class for testing ExtensionParameter
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ExtensionParameterTests
    {
        // TODO uncomment below to declare an instance variable for ExtensionParameter
        //private ExtensionParameter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ExtensionParameter
            //instance = new ExtensionParameter();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExtensionParameter
        /// </summary>
        [Test]
        public void ExtensionParameterInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ExtensionParameter
            //Assert.IsInstanceOfType<ExtensionParameter> (instance, "variable 'instance' is a ExtensionParameter");
        }


        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO unit test for the property 'DisplayName'
        }
        /// <summary>
        /// Test the property 'Required'
        /// </summary>
        [Test]
        public void RequiredTest()
        {
            // TODO unit test for the property 'Required'
        }
        /// <summary>
        /// Test the property 'ReadOnly'
        /// </summary>
        [Test]
        public void ReadOnlyTest()
        {
            // TODO unit test for the property 'ReadOnly'
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
        /// Test the property 'Error'
        /// </summary>
        [Test]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }
        /// <summary>
        /// Test the property 'Encrypted'
        /// </summary>
        [Test]
        public void EncryptedTest()
        {
            // TODO unit test for the property 'Encrypted'
        }
        /// <summary>
        /// Test the property 'IsPassword'
        /// </summary>
        [Test]
        public void IsPasswordTest()
        {
            // TODO unit test for the property 'IsPassword'
        }
        /// <summary>
        /// Test the property 'ValidValues'
        /// </summary>
        [Test]
        public void ValidValuesTest()
        {
            // TODO unit test for the property 'ValidValues'
        }
        /// <summary>
        /// Test the property 'ValidValuesIsNull'
        /// </summary>
        [Test]
        public void ValidValuesIsNullTest()
        {
            // TODO unit test for the property 'ValidValuesIsNull'
        }

    }

}
