# IO.PBIRS.Swagger.Model.Subscription
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | A unique UUID value that specifies the identifier by which this Subscription can be referenced in requests or in other defined objects. | [optional] 
**Owner** | **string** | A string value that specifies the owner of the Subscription. | [optional] 
**IsDataDriven** | **bool?** | A boolean value that specifies whether the members of the distribution list for the subscription are computed based on data. | [optional] 
**Description** | **string** | A string value that contains descriptive text about the Subscription. | [optional] 
**Report** | **string** | A string value that specifies the path of the report for this Subscription. | [optional] 
**IsActive** | **bool?** | A boolean value that specifies whether the Subscription is currently active. | [optional] 
**EventType** | **string** | A string specifying the type of event that triggers the Subscription. | [optional] 
**ScheduleDescription** | **string** | A string value that contains descriptive text about the schedule referenced in the Schedule property. | [optional] 
**LastRunTime** | **DateTime?** | A string value that contains the date-time that the schedule was last run. | [optional] 
**LastStatus** | **string** | A string specifying the Status of the last run. | [optional] 
**ExtensionSettings** | [**ExtensionSettings**](ExtensionSettings.md) |  | [optional] 
**DeliveryExtension** | **string** | An object that specifies the DeliveryExtension that will be used with this Schedule&#39;s report delivery. | [optional] 
**LocalizedDeliveryExtensionName** | **string** | Localized version of extension name when available. | [optional] 
**ModifiedBy** | **string** | A string value that contains the network user name of the last user to modify the subscription. | [optional] 
**ModifiedDate** | **DateTime?** | A string value that contains the date-time of the last modification to the subscription. | [optional] 
**ParameterValues** | [**List&lt;ParameterValue&gt;**](ParameterValue.md) | An array of items of type ParameterValue that specify the parameter values for the subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

