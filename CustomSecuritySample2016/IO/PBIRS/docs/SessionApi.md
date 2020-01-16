# IO.PBIRS.Swagger.Api.SessionApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSession**](SessionApi.md#createsession) | **POST** /Session | Creates a new session
[**DeleteSession**](SessionApi.md#deletesession) | **DELETE** /Session | Deletes the currently active session


<a name="createsession"></a>
# **CreateSession**
> void CreateSession (UserCredentials userCredentials)

Creates a new session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class CreateSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();
            var userCredentials = new UserCredentials(); // UserCredentials | The credentials of the user to logon as

            try
            {
                // Creates a new session
                apiInstance.CreateSession(userCredentials);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.CreateSession: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userCredentials** | [**UserCredentials**](UserCredentials.md)| The credentials of the user to logon as | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesession"></a>
# **DeleteSession**
> void DeleteSession ()

Deletes the currently active session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.PBIRS.Swagger.Api;
using IO.PBIRS.Swagger.Client;
using IO.PBIRS.Swagger.Model;

namespace Example
{
    public class DeleteSessionExample
    {
        public void main()
        {
            
            var apiInstance = new SessionApi();

            try
            {
                // Deletes the currently active session
                apiInstance.DeleteSession();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.DeleteSession: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

