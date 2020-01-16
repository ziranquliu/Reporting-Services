# SqlServer2017ReportingServicesRestApi.Subscription

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | A unique UUID value that specifies the identifier by which this Subscription can be referenced in requests or in other defined objects. | [optional] 
**owner** | **String** | A string value that specifies the owner of the Subscription. | [optional] 
**isDataDriven** | **Boolean** | A boolean value that specifies whether the members of the distribution list for the subscription are computed based on data. | [optional] 
**description** | **String** | A string value that contains descriptive text about the Subscription. | [optional] 
**report** | **String** | A string value that specifies the path of the report for this Subscription. | [optional] 
**isActive** | **Boolean** | A boolean value that specifies whether the Subscription is currently active. | [optional] 
**eventType** | **String** | A string specifying the type of event that triggers the Subscription. | [optional] 
**scheduleDescription** | **String** | A string value that contains descriptive text about the schedule referenced in the Schedule property. | [optional] 
**lastRunTime** | **Date** | A string value that contains the date-time that the schedule was last run. | [optional] 
**lastStatus** | **String** | A string specifying the Status of the last run. | [optional] 
**extensionSettings** | [**ExtensionSettings**](ExtensionSettings.md) |  | [optional] 
**deliveryExtension** | **String** | An object that specifies the DeliveryExtension that will be used with this Schedule's report delivery. | [optional] 
**localizedDeliveryExtensionName** | **String** | Localized version of extension name when available. | [optional] 
**modifiedBy** | **String** | A string value that contains the network user name of the last user to modify the subscription. | [optional] 
**modifiedDate** | **Date** | A string value that contains the date-time of the last modification to the subscription. | [optional] 
**parameterValues** | [**[ParameterValue]**](ParameterValue.md) | An array of items of type ParameterValue that specify the parameter values for the subscription. | [optional] 


