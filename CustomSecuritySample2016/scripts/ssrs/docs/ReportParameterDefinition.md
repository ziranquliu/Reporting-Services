# SqlServer2017ReportingServicesRestApi.ReportParameterDefinition

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**allowBlank** | **Boolean** | A boolean value that indicates whether the ReportParamter is allowed to be blank. | [optional] 
**defaultValues** | **[String]** | An array of string values that specify the ReportParameter's default values. If the parameter is multi-valued then the array can have more than one entry. | [optional] 
**defaultValuesIsNull** | **Boolean** |  A boolean value that indicates whether the DefaultValues property is NULL. | [optional] 
**defaultValuesQueryBased** | **Boolean** | A boolean value that indicates whether the ReportParamter's default values are obtained from a query (instead of being static specified values). | [optional] 
**dependencies** | **[String]** | An array of string values that specify the dependencies for the ReportParameter. | [optional] 
**errorMessage** | **String** | Error returned when validating parameters. | [optional] 
**multiValue** | **Boolean** | A boolean value that indicates whether the ReportParameter is multivalued. | [optional] 
**name** | **String** | A string value that specifies the name for the ReportParameter. This name will typically be displayed in the user interface. | [optional] 
**nullable** | **Boolean** | A boolean value that indicates whether the ReportParameter is allowed to be null. | [optional] 
**parameterState** | [**ReportParameterState**](ReportParameterState.md) |  | [optional] 
**parameterType** | [**ReportParameterType**](ReportParameterType.md) |  | [optional] 
**parameterVisibility** | [**ReportParameterVisibility**](ReportParameterVisibility.md) |  | [optional] 
**prompt** | **String** | A string value that specifies text used to prompt a user for the value of the ReportParameter. | [optional] 
**promptUser** | **Boolean** | A boolean value that indicates whether the user should be prompted for the value for the ReportParameter. | [optional] 
**queryParameter** | **Boolean** | A boolean value that indicates whether the ReportParamter is query based. | [optional] 
**validValues** | [**[ValidValue]**](ValidValue.md) |  | [optional] 
**validValuesIsNull** | **Boolean** | A boolean value that indicates whether the ValidValues property is NULL. | [optional] 
**validValuesQueryBased** | **Boolean** | A boolean value that indicates whether the ReportParameter's valid values are obtained from a query (instead of being static specified values). | [optional] 


