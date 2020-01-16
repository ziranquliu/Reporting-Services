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
    ///  Class for testing ResourcesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ResourcesApiTests
    {
        private ResourcesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResourcesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ResourcesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ResourcesApi
            //Assert.IsInstanceOfType(typeof(ResourcesApi), instance, "instance is a ResourcesApi");
        }

        
        /// <summary>
        /// Test AddResource
        /// </summary>
        [Test]
        public void AddResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Resource resource = null;
            //var response = instance.AddResource(resource);
            //Assert.IsInstanceOf<Resource> (response, "response is Resource");
        }
        
        /// <summary>
        /// Test DeleteResource
        /// </summary>
        [Test]
        public void DeleteResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteResource(id);
            
        }
        
        /// <summary>
        /// Test GetResource
        /// </summary>
        [Test]
        public void GetResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetResource(id);
            //Assert.IsInstanceOf<Resource> (response, "response is Resource");
        }
        
        /// <summary>
        /// Test GetResourceAllowedActions
        /// </summary>
        [Test]
        public void GetResourceAllowedActionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetResourceAllowedActions(id);
            //Assert.IsInstanceOf<ODataAllowedActions> (response, "response is ODataAllowedActions");
        }
        
        /// <summary>
        /// Test GetResourceContent
        /// </summary>
        [Test]
        public void GetResourceContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetResourceContent(id);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetResourcePolicies
        /// </summary>
        [Test]
        public void GetResourcePoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetResourcePolicies(id);
            //Assert.IsInstanceOf<List<ItemPolicy>> (response, "response is List<ItemPolicy>");
        }
        
        /// <summary>
        /// Test GetResourceProperties
        /// </summary>
        [Test]
        public void GetResourcePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<string> properties = null;
            //var response = instance.GetResourceProperties(id, properties);
            //Assert.IsInstanceOf<ODataProperties> (response, "response is ODataProperties");
        }
        
        /// <summary>
        /// Test GetResources
        /// </summary>
        [Test]
        public void GetResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? top = null;
            //int? skip = null;
            //string filter = null;
            //string count = null;
            //var response = instance.GetResources(top, skip, filter, count);
            //Assert.IsInstanceOf<ODataResources> (response, "response is ODataResources");
        }
        
        /// <summary>
        /// Test SetResourcePolicies
        /// </summary>
        [Test]
        public void SetResourcePoliciesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<ItemPolicy> policies = null;
            //instance.SetResourcePolicies(id, policies);
            
        }
        
        /// <summary>
        /// Test UpdateResource
        /// </summary>
        [Test]
        public void UpdateResourceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //Resource resource = null;
            //var response = instance.UpdateResource(id, resource);
            //Assert.IsInstanceOf<Resource> (response, "response is Resource");
        }
        
        /// <summary>
        /// Test UpdateResourceProperties
        /// </summary>
        [Test]
        public void UpdateResourcePropertiesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //List<Property> properties = null;
            //instance.UpdateResourceProperties(id, properties);
            
        }
        
    }

}
