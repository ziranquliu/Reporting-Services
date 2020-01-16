# SqlServer2017ReportingServicesRestApi.CacheRefreshPlan

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | A unique UUID value that specifies the identifier by which this CacheRefreshPlan can be referenced in the definition of other items. | [optional] 
**owner** | **String** | A string value that specifies the owner of the CacheRefreshPlan. | [optional] 
**description** | **String** | A string value that contains descriptive text about the CacheRefreshPlan. | [optional] 
**catalogItemPath** | **String** | A string value that contains the fully qualified URL path location of the CatalogItem that represents the CacheRefreshPlan. | [optional] 
**eventType** | **String** | A string value that specifies which EventType to use for logging. | [optional] 
**schedule** | [**ScheduleReference**](ScheduleReference.md) |  | [optional] 
**lastRunTime** | **Date** | A date-time value that specifies the date-time of the last run of the CacheRefreshPlan. | [optional] 
**lastStatus** | **String** | A string value that contains the network username of the last user to modify the CacheRefreshPlan. | [optional] 
**modifiedBy** | **String** | A string value that contains the network user name of the last user to modify the CacheRefreshPlan | [optional] 
**modifiedDate** | **Date** | A string value that contains the date-time of the last modification to the CacheRefreshPlan. | [optional] 
**parameterValues** | [**[ParameterValue]**](ParameterValue.md) | An array of parameter values for the CacheRefreshPlan. All parameters without a default value MUST have a value specified. | [optional] 


