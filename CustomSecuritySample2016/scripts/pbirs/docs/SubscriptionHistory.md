# PowerBiReportServerRestApi.SubscriptionHistory

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **Number** | A unique identifier by which this Subscription History record can be referenced in requests or in other defined objects. | [optional] 
**subscriptionID** | **String** | A unique UUID value that identifies the Subscription that this record is associated with. | [optional] 
**type** | **String** | A string value that specifies the type of subscription execution. | [optional] 
**startTime** | **Date** | A string that contains the date-time for when the subscription execution started. | [optional] 
**endTime** | **Date** | A string that contains the date-time for when the subscription execution ended. | [optional] 
**subscriptionStatus** | **String** | A string value that represents the status of the subscription execution. | [optional] 
**message** | **String** | A string value that contains message that describes the status of the subscription execution. | [optional] 
**details** | **String** | A JSON string value that contains the session information and error details when a subscription execution fails. | [optional] 


<a name="TypeEnum"></a>
## Enum: TypeEnum


* `scheduled` (value: `"Scheduled"`)

* `onDemand` (value: `"OnDemand"`)




<a name="SubscriptionStatusEnum"></a>
## Enum: SubscriptionStatusEnum


* `completed` (value: `"Completed"`)

* `inProgress` (value: `"InProgress"`)

* `failed` (value: `"Failed"`)




