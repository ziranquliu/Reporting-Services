# SqlServer2017ReportingServicesRestApi.DataSource

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**isEnabled** | **Boolean** | A Boolean value that specifies whether the DataSource is enabled for use. | [optional] 
**connectionString** | **String** | A string value that can be passed to a data source in order to begin the process of establishing connection. | [optional] 
**dataSourceType** | **String** | DataSource extension such as 'SQL'. | [optional] 
**isOriginalConnectionStringExpressionBased** | **Boolean** | Indicates whether the original connection string for the data source was expression-based. | [optional] 
**isConnectionStringOverridden** | **Boolean** | Specifies whether the original connection string is overridden. | [optional] 
**credentialsByUser** | [**CredentialsSuppliedByUser**](CredentialsSuppliedByUser.md) |  | [optional] 
**credentialsInServer** | [**CredentialsStoredInServer**](CredentialsStoredInServer.md) |  | [optional] 
**isReference** | **Boolean** | Indicates whether this is a reference to a shared data source or an embedded data source. | [optional] 
**subscriptions** | [**Subscription**](Subscription.md) |  | [optional] 


