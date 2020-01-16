# PowerBiReportServerRestApi.DataSource

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**isEnabled** | **Boolean** | A Boolean value that specifies whether the DataSource is enabled for use. | [optional] 
**connectionString** | **String** | A string value that can be passed to a data source in order to begin the process of establishing connection. | [optional] 
**dataModelDataSource** | [**DataModelDataSource**](DataModelDataSource.md) |  | [optional] 
**dataSourceSubType** | **String** | Subtype of the datasource type. Applies to PowerBIReports. Ignored when used with DataSets, LinkedReports, and Reports. | [optional] 
**dataSourceType** | **String** | DataSource extension such as 'SQL'. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. For PowerBIReports, use DataSourceSubType = DataModel and DataModelDataSource.Type. | [optional] 
**isOriginalConnectionStringExpressionBased** | **Boolean** | Indicates whether the original connection string for the datasource was expression-based. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**isConnectionStringOverridden** | **Boolean** | Specifies whether the original connection string is overridden. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**credentialsByUser** | [**CredentialsSuppliedByUser**](CredentialsSuppliedByUser.md) |  | [optional] 
**credentialsInServer** | [**CredentialsStoredInServer**](CredentialsStoredInServer.md) |  | [optional] 
**isReference** | **Boolean** | Indicates whether this is a reference to a shared data source or an embedded data source. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**subscriptions** | [**Subscription**](Subscription.md) |  | [optional] 


