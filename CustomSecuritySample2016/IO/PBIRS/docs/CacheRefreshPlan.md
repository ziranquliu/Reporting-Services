# IO.PBIRS.Swagger.Model.CacheRefreshPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | A unique UUID value that specifies the identifier by which this CacheRefreshPlan can be referenced in the definition of other items. | [optional] 
**Owner** | **string** | A string value that specifies the owner of the CacheRefreshPlan. | [optional] 
**Description** | **string** | A string value that contains descriptive text about the CacheRefreshPlan. | [optional] 
**CatalogItemPath** | **string** | A string value that contains the fully qualified URL path location of the CatalogItem that represents the CacheRefreshPlan. | [optional] 
**EventType** | **string** | A string value that specifies which EventType to use for logging. | [optional] 
**Schedule** | [**ScheduleReference**](ScheduleReference.md) |  | [optional] 
**LastRunTime** | **DateTime?** | A date-time value that specifies the date-time of the last run of the CacheRefreshPlan. | [optional] 
**LastStatus** | **string** | A string value that contains the network username of the last user to modify the CacheRefreshPlan. | [optional] 
**ModifiedBy** | **string** | A string value that contains the network user name of the last user to modify the CacheRefreshPlan | [optional] 
**ModifiedDate** | **DateTime?** | A string value that contains the date-time of the last modification to the CacheRefreshPlan. | [optional] 
**ParameterValues** | [**List&lt;ParameterValue&gt;**](ParameterValue.md) | An array of parameter values for the CacheRefreshPlan. All parameters without a default value MUST have a value specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

