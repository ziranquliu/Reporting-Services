# IO.SSRS.Swagger.Api.MeApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetUserDetails**](MeApi.md#getuserdetails) | **GET** /Me | Gets the User object for the current user.


<a name="getuserdetails"></a>
# **GetUserDetails**
> User GetUserDetails ()

Gets the User object for the current user.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetUserDetailsExample
    {
        public void main()
        {
            
            var apiInstance = new MeApi();

            try
            {
                // Gets the User object for the current user.
                User result = apiInstance.GetUserDetails();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MeApi.GetUserDetails: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**User**](User.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

