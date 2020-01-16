/* 
 * Power BI Report Server REST API
 *
 * The Power BI Report Server REST API provides programmatic access to the report server catalog.  For example, basic CRUD operations can be done on folders, reports, KPIs, data sources, datasets, refresh plans, subscriptions, etc.     The REST API can also be used to provide more advanced functionality, such as: * Navigate the folder hierarchy * Discover the contents of a folder * Download a report definition * Modify default report parameters * Change or execute a refresh plan * A whole lot more  The REST API is a RESTful successor to the legacy [SOAP API](https://msdn.microsoft.com/library/reportservice2010.reportingservice2010.aspx).  Since Power BI Report Server is a superset of SQL Server Reporting Services, the Power BI Report Server REST API is a superset of the  [SQL Server Reporting Services REST API](https://app.swaggerhub.com/apis/microsoft-rs/SSRS/2.0).  __Power BI Report Server API Additions__ * January 2019 Release   * /PowerBIReports({Id})/DataModelRoles (GET)   * /PowerBIReports({Id})/DataModelRoleAssignments (GET & PUT)  Happy coding!  __API samples:__ https://github.com/Microsoft/Reporting-Services  __Developer documentation:__ https://powerbi.microsoft.com/documentation/reportserver-developer-handbook-overview/  __Team Blog:__  https://powerbi.microsoft.com/blog/  __Support forums:__  https://community.powerbi.com/t5/Report-Server/bd-p/ReportServer 
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

using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Model;

namespace IO.PBIRS.Swagger.Test
{
    /// <summary>
    ///  Class for testing CacheRefreshPlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CacheRefreshPlansApiTests
    {
        private CacheRefreshPlansApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CacheRefreshPlansApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CacheRefreshPlansApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CacheRefreshPlansApi
            //Assert.IsInstanceOfType(typeof(CacheRefreshPlansApi), instance, "instance is a CacheRefreshPlansApi");
        }

        
        /// <summary>
        /// Test AddCacheRefreshPlan
        /// </summary>
        [Test]
        public void AddCacheRefreshPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CacheRefreshPlan cacheRefreshPlan = null;
            //var response = instance.AddCacheRefreshPlan(cacheRefreshPlan);
            //Assert.IsInstanceOf<CacheRefreshPlan> (response, "response is CacheRefreshPlan");
        }
        
        /// <summary>
        /// Test DeleteCacheRefreshPlan
        /// </summary>
        [Test]
        public void DeleteCacheRefreshPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.DeleteCacheRefreshPlan(id);
            
        }
        
        /// <summary>
        /// Test ExecuteCacheRefreshPlan
        /// </summary>
        [Test]
        public void ExecuteCacheRefreshPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //instance.ExecuteCacheRefreshPlan(id);
            
        }
        
        /// <summary>
        /// Test GetCacheRefreshPlan
        /// </summary>
        [Test]
        public void GetCacheRefreshPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCacheRefreshPlan(id);
            //Assert.IsInstanceOf<CacheRefreshPlan> (response, "response is CacheRefreshPlan");
        }
        
        /// <summary>
        /// Test GetCacheRefreshPlanHistory
        /// </summary>
        [Test]
        public void GetCacheRefreshPlanHistoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetCacheRefreshPlanHistory(id);
            //Assert.IsInstanceOf<ODataSubscriptionHistory> (response, "response is ODataSubscriptionHistory");
        }
        
        /// <summary>
        /// Test SetCacheRefreshPlan
        /// </summary>
        [Test]
        public void SetCacheRefreshPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //CacheRefreshPlan cacheRefreshPlan = null;
            //var response = instance.SetCacheRefreshPlan(id, cacheRefreshPlan);
            //Assert.IsInstanceOf<CacheRefreshPlan> (response, "response is CacheRefreshPlan");
        }
        
    }

}
