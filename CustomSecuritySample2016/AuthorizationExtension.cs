#region
// Copyright (c) 2016 Microsoft Corporation. All Rights Reserved.
// Licensed under the MIT License (MIT)
/*============================================================================
  File:     Authorization.cs

  Summary:  Demonstrates an implementation of an authorization 
            extension.
------------------------------------------------------------------------------
  This file is part of Microsoft SQL Server Code Samples.
    
 This source code is intended only as a supplement to Microsoft
 Development Tools and/or on-line documentation. See these other
 materials for detailed information regarding Microsoft code 
 samples.

 THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF 
 ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
 THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
 PARTICULAR PURPOSE.
===========================================================================*/
#endregion

using System;
using System.IO;
using System.Collections;
using System.Collections.Specialized;
using System.Globalization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.ReportingServices.Interfaces;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using NLog;
using System.Web;
using System.Security.Principal;
using Microsoft.Samples.ReportingServices.CustomSecurity.Data;

namespace Microsoft.Samples.ReportingServices.CustomSecurity
{
    public class AuthorizationExtension : IAuthorizationExtension, IExtension
    {
        private static string m_adminUserName;
        private static readonly Logger logger = LogManager.GetCurrentClassLogger(typeof(AuthorizationExtension));
        private static readonly List<BiOper> BiOpers = new List<BiOper>();
        private static readonly List<BiUserOper> BiUserOpers = new List<BiUserOper>();
        private static readonly List<User> BiUsers = new List<User>();
        private static readonly System.Timers.Timer timer = new System.Timers.Timer(10000);

        static AuthorizationExtension()
        {
            LoadAuthorization();
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private static void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                LoadAuthorization();
            }
            catch (Exception ex)
            {
                logger.ErrorEx(new Exception("初始化权限列表失败！", ex));
            }
        }

        private static void LoadAuthorization()
        {
            BiOpers.Clear();
            BiOpers.AddRange(SqlHelper.DbRSInstance.BiOpers);
            BiUserOpers.Clear();
            BiUserOpers.AddRange(SqlHelper.DbRSInstance.BiUserOpers);
            BiUsers.Clear();
            BiUsers.AddRange(SqlHelper.DbRSInstance.Users);
        }

        /// <summary>
        /// Returns a security descriptor that is stored with an individual 
        /// item in the report server database. 
        /// </summary>
        /// <param name="acl">The access code list (ACL) created by the report 
        /// server for the item. It contains a collection of access code entry 
        /// (ACE) structures.</param>
        /// <param name="itemType">The type of item for which the security 
        /// descriptor is created.</param>
        /// <param name="stringSecDesc">Optional. A user-friendly description 
        /// of the security descriptor, used for debugging. This is not stored
        /// by the report server.</param>
        /// <returns>Should be implemented to return a serialized access code 
        /// list for the item.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        public byte[] CreateSecurityDescriptor(
          AceCollection acl,
          SecurityItemType itemType,
          out string stringSecDesc)
        {
            return SerializeAcl(acl, out stringSecDesc);
        }

        public bool CheckAccess(
          string userName,
          IntPtr userToken,
          byte[] secDesc,
          ModelItemOperation modelItemOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            // Because SQL Server defaults to case-insensitive, we have to
            // perform a case insensitive comparison. Ideally you would check
            // the SQL Server instance CaseSensitivity property before making
            // a case-insensitive comparison.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                // First check to see if the user or group has an access control 
                //  entry for the item
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    // If an entry is found, 
                    // return true if the given required operation
                    // is contained in the ACE structure
                    foreach (ModelItemOperation aclOperation in ace.ModelItemOperations)
                    {
                        if (aclOperation == modelItemOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        public bool CheckAccess(
         string userName,
         IntPtr userToken,
         byte[] secDesc,
         ModelOperation modelOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            // Because SQL Server defaults to case-insensitive, we have to
            // perform a case insensitive comparison. Ideally you would check
            // the SQL Server instance CaseSensitivity property before making
            // a case-insensitive comparison.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                // First check to see if the user or group has an access control 
                //  entry for the item
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    // If an entry is found, 
                    // return true if the given required operation
                    // is contained in the ACE structure
                    foreach (ModelOperation aclOperation in ace.ModelOperations)
                    {
                        if (aclOperation == modelOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Indicates whether a given user is authorized to access the item 
        /// for a given catalog operation.
        /// </summary>
        /// <param name="userName">The name of the user as returned by the 
        /// GetUserInfo method.</param>
        /// <param name="userToken">Pointer to the user ID returned by 
        /// GetUserInfo.</param>
        /// <param name="secDesc">The security descriptor returned by 
        /// CreateSecurityDescriptor.</param>
        /// <param name="requiredOperation">The operation being requested by 
        /// the report server for a given user.</param>
        /// <returns>True if the user is authorized.</returns>
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           CatalogOperation requiredOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            // Because SQL Server defaults to case-insensitive, we have to
            // perform a case insensitive comparison. Ideally you would check
            // the SQL Server instance CaseSensitivity property before making
            // a case-insensitive comparison.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                // First check to see if the user or group has an access control 
                //  entry for the item
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    // If an entry is found, 
                    // return true if the given required operation
                    // is contained in the ACE structure
                    foreach (CatalogOperation aclOperation in ace.CatalogOperations)
                    {
                        if (aclOperation == requiredOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        // Overload for array of catalog operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           CatalogOperation[] requiredOperations)
        {
            foreach (CatalogOperation operation in requiredOperations)
            {
                if (!CheckAccess(userName, userToken, secDesc, operation))
                    return false;
            }
            return true;
        }

        // Overload for Report operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           ReportOperation requiredOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    foreach (ReportOperation aclOperation in
                       ace.ReportOperations)
                    {
                        if (aclOperation == requiredOperation)
                            return true;
                    }
                }
            }
            return false;
        }

        // Overload for Folder operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           FolderOperation requiredOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    foreach (FolderOperation aclOperation in
                       ace.FolderOperations)
                    {
                        if (aclOperation == requiredOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        // Overload for an array of Folder operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           FolderOperation[] requiredOperations)
        {
            foreach (FolderOperation operation in requiredOperations)
            {
                if (!CheckAccess(userName, userToken, secDesc, operation))
                    return false;
            }
            return true;
        }

        // Overload for Resource operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           ResourceOperation requiredOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    foreach (ResourceOperation aclOperation in
                       ace.ResourceOperations)
                    {
                        if (aclOperation == requiredOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        // Overload for an array of Resource operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           ResourceOperation[] requiredOperations)
        {
            // If the user is the administrator, allow unrestricted access.
            if (IsAdmin(userName))
                return true;

            foreach (ResourceOperation operation in requiredOperations)
            {
                if (!CheckAccess(userName, userToken, secDesc, operation))
                    return false;
            }
            return true;
        }

        // Overload for Datasource operations
        public bool CheckAccess(
           string userName,
           IntPtr userToken,
           byte[] secDesc,
           DatasourceOperation requiredOperation)
        {
            // If the user is the administrator, allow unrestricted access.
            if (IsAdmin(userName))
                return true;

            AceCollection acl = DeserializeAcl(userName, secDesc);
            foreach (AceStruct ace in acl)
            {
                if (0 == String.Compare(userName, ace.PrincipalName, true,
                   CultureInfo.CurrentCulture))
                {
                    foreach (DatasourceOperation aclOperation in
                       ace.DatasourceOperations)
                    {
                        if (aclOperation == requiredOperation)
                            return true;
                    }
                }
            }

            return false;
        }

        private bool IsAdmin(string userName)
        {
            return (0 == String.Compare(userName, m_adminUserName, true, CultureInfo.CurrentCulture));
        }

        /// <summary>
        /// Returns the set of permissions a specific user has for a specific 
        /// item managed in the report server database. This provides underlying 
        /// support for the Web service method GetPermissions().
        /// </summary>
        /// <param name="userName">The name of the user as returned by the 
        /// GetUserInfo method.</param>
        /// <param name="userToken">Pointer to the user ID returned by 
        /// GetUserInfo.</param>
        /// <param name="itemType">The type of item for which the permissions 
        /// are returned.</param>
        /// <param name="secDesc">The security descriptor associated with the 
        /// item.</param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public StringCollection GetPermissions(string userName, IntPtr userToken,
          SecurityItemType itemType, byte[] secDesc)
        {
            StringCollection permissions = new StringCollection();
            if (IsAdmin(userName))
            {
                permissions.AddRange(BiOpers.Select(item => item.OperationDesc).ToArray());
            }
            else
            {
                permissions.AddRange(BiUserOpers.Where(item => 0 == String.Compare(userName, item.User.UserName, true, CultureInfo.CurrentCulture))
                    .Select(item => item.BiOper.OperationDesc).ToArray());
            }

            return permissions;
        }

        // Used to deserialize the ACL that is stored by the report server.
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
        private AceCollection DeserializeAcl(string userName, byte[] secDesc)
        {
            AceCollection acl = new AceCollection();
            foreach (User user in BiUsers.Where(item => 0 == String.Compare(userName, item.UserName, true, CultureInfo.CurrentCulture)))
            {
                if (user != null && user.BiUserOpers.Count > 0)
                {
                    AceStruct ace = new AceStruct(userName);
                    ace.PrincipalName = userName;
                    ace.CatalogOperations = new CatalogOperationsCollection();
                    ace.DatasourceOperations = new DatasourceOperationsCollection();
                    ace.FolderOperations = new FolderOperationsCollection();
                    ace.ModelItemOperations = new ModelItemOperationsCollection();
                    ace.ModelOperations = new ModelOperationsCollection();
                    ace.ReportOperations = new ReportOperationsCollection();
                    ace.ResourceOperations = new ResourceOperationsCollection();
                    foreach (BiOper biOper in user.BiUserOpers.Select(item => item.BiOper))
                    {
                        switch ((OperType)biOper.OperType)
                        {
                            case OperType.CatalogOperation:
                                ace.CatalogOperations.Add((CatalogOperation)Enum.Parse(typeof(CatalogOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.DatasourceOperation:
                                ace.DatasourceOperations.Add((DatasourceOperation)Enum.Parse(typeof(DatasourceOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.FolderOperation:
                                ace.FolderOperations.Add((FolderOperation)Enum.Parse(typeof(FolderOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.ModelItemOperation:
                                ace.ModelItemOperations.Add((ModelItemOperation)Enum.Parse(typeof(ModelItemOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.ModelOperation:
                                ace.ModelOperations.Add((ModelOperation)Enum.Parse(typeof(ModelOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.ReportOperation:
                                ace.ReportOperations.Add((ReportOperation)Enum.Parse(typeof(ReportOperation), biOper.OperTypeDesc));
                                break;
                            case OperType.ResourceOperation:
                                ace.ResourceOperations.Add((ResourceOperation)Enum.Parse(typeof(ResourceOperation), biOper.OperTypeDesc));
                                break;
                        }
                    }
                    acl.Add(ace);
                }
            }
            //if (secDesc != null)
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    using (MemoryStream sdStream = new MemoryStream(secDesc))
            //    {
            //        acl = (AceCollection)bf.Deserialize(sdStream);
            //        string stringSecDesc = JsonConvert.SerializeObject(acl);
            //    }
            //}
            return acl;
        }

        private byte[] SerializeAcl(AceCollection acl, out string stringSecDesc)
        {
            SqlHelper.DbRSInstance.SaveAcl(acl);

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            byte[] buffer;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                binaryFormatter.Serialize(memoryStream, acl);
                stringSecDesc = JsonConvert.SerializeObject(acl);
                buffer = memoryStream.GetBuffer();
            }
            return buffer;
        }

        /// <summary>
        /// You must implement SetConfiguration as required by IExtension
        /// </summary>
        /// <param name="configuration">Configuration data as an XML
        /// string that is stored along with the Extension element in
        /// the configuration file.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2201:DoNotRaiseReservedExceptionTypes")]
        public void SetConfiguration(string configuration)
        {
            // Retrieve admin user and password from the config settings
            // and verify
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(configuration);
            if (doc.DocumentElement.Name == "AdminConfiguration")
            {
                foreach (XmlNode child in doc.DocumentElement.ChildNodes)
                {
                    if (child.Name == "UserName")
                    {
                        m_adminUserName = child.InnerText;
                    }
                    else
                    {
                        throw new Exception(string.Format(CultureInfo.InvariantCulture,
                          CustomSecurity.UnrecognizedElement));
                    }
                }
            }
            else
                throw new Exception(string.Format(CultureInfo.InvariantCulture,
                   CustomSecurity.AdminConfiguration));
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        public string LocalizedName
        {
            get
            {
                // Return a localized name for this extension
                return null;
            }
        }
    }
}
