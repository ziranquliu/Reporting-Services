# IO.PBIRS.Swagger.Model.SubscriptionHistory
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | A unique identifier by which this Subscription History record can be referenced in requests or in other defined objects. | [optional] 
**SubscriptionID** | **Guid?** | A unique UUID value that identifies the Subscription that this record is associated with. | [optional] 
**Type** | **string** | A string value that specifies the type of subscription execution. | [optional] 
**StartTime** | **DateTime?** | A string that contains the date-time for when the subscription execution started. | [optional] 
**EndTime** | **DateTime?** | A string that contains the date-time for when the subscription execution ended. | [optional] 
**SubscriptionStatus** | **string** | A string value that represents the status of the subscription execution. | [optional] 
**Message** | **string** | A string value that contains message that describes the status of the subscription execution. | [optional] 
**Details** | **string** | A JSON string value that contains the session information and error details when a subscription execution fails. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

