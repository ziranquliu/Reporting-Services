# IO.PBIRS.Swagger.Model.DataSource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsEnabled** | **bool?** | A Boolean value that specifies whether the DataSource is enabled for use. | [optional] 
**ConnectionString** | **string** | A string value that can be passed to a data source in order to begin the process of establishing connection. | [optional] 
**DataModelDataSource** | [**DataModelDataSource**](DataModelDataSource.md) |  | [optional] 
**DataSourceSubType** | **string** | Subtype of the datasource type. Applies to PowerBIReports. Ignored when used with DataSets, LinkedReports, and Reports. | [optional] 
**DataSourceType** | **string** | DataSource extension such as &#39;SQL&#39;. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. For PowerBIReports, use DataSourceSubType &#x3D; DataModel and DataModelDataSource.Type. | [optional] 
**IsOriginalConnectionStringExpressionBased** | **bool?** | Indicates whether the original connection string for the datasource was expression-based. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**IsConnectionStringOverridden** | **bool?** | Specifies whether the original connection string is overridden. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**CredentialsByUser** | [**CredentialsSuppliedByUser**](CredentialsSuppliedByUser.md) |  | [optional] 
**CredentialsInServer** | [**CredentialsStoredInServer**](CredentialsStoredInServer.md) |  | [optional] 
**IsReference** | **bool?** | Indicates whether this is a reference to a shared data source or an embedded data source. Applies to DataSets, LinkedReports, and Reports. Ignored when used with PowerBIReports. | [optional] 
**Subscriptions** | [**Subscription**](Subscription.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

