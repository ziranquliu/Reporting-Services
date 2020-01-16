# IO.PBIRS.Swagger.Model.ReportParameterDefinition
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowBlank** | **bool?** | A boolean value that indicates whether the ReportParamter is allowed to be blank. | [optional] 
**DefaultValues** | **List&lt;string&gt;** | An array of string values that specify the ReportParameter&#39;s default values. If the parameter is multi-valued then the array can have more than one entry. | [optional] 
**DefaultValuesIsNull** | **bool?** |  A boolean value that indicates whether the DefaultValues property is NULL. | [optional] 
**DefaultValuesQueryBased** | **bool?** | A boolean value that indicates whether the ReportParamter&#39;s default values are obtained from a query (instead of being static specified values). | [optional] 
**Dependencies** | **List&lt;string&gt;** | An array of string values that specify the dependencies for the ReportParameter. | [optional] 
**ErrorMessage** | **string** | Error returned when validating parameters. | [optional] 
**MultiValue** | **bool?** | A boolean value that indicates whether the ReportParameter is multivalued. | [optional] 
**Name** | **string** | A string value that specifies the name for the ReportParameter. This name will typically be displayed in the user interface. | [optional] 
**Nullable** | **bool?** | A boolean value that indicates whether the ReportParameter is allowed to be null. | [optional] 
**ParameterState** | **ReportParameterState** |  | [optional] 
**ParameterType** | **ReportParameterType** |  | [optional] 
**ParameterVisibility** | **ReportParameterVisibility** |  | [optional] 
**Prompt** | **string** | A string value that specifies text used to prompt a user for the value of the ReportParameter. | [optional] 
**PromptUser** | **bool?** | A boolean value that indicates whether the user should be prompted for the value for the ReportParameter. | [optional] 
**QueryParameter** | **bool?** | A boolean value that indicates whether the ReportParamter is query based. | [optional] 
**ValidValues** | [**List&lt;ValidValue&gt;**](ValidValue.md) |  | [optional] 
**ValidValuesIsNull** | **bool?** | A boolean value that indicates whether the ValidValues property is NULL. | [optional] 
**ValidValuesQueryBased** | **bool?** | A boolean value that indicates whether the ReportParameter&#39;s valid values are obtained from a query (instead of being static specified values). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

