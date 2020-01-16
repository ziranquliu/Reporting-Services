# IO.SSRS.Swagger.Api.FavoriteItemsApi

All URIs are relative to *http://localhost/reports/api/v2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetFavoriteItems**](FavoriteItemsApi.md#getfavoriteitems) | **GET** /FavoriteItems | Retrieves a collection of items of type CatalogItem which have been designated as favorites. Use the OData $expand option to also get the referenced items.
[**RemoveFavoriteItem**](FavoriteItemsApi.md#removefavoriteitem) | **DELETE** /FavoriteItems({Id}) | Removes a CatalogItem from the list of favorite items.
[**SetFavoriteItem**](FavoriteItemsApi.md#setfavoriteitem) | **POST** /FavoriteItems | Designate a CatalogItem as a favorite.


<a name="getfavoriteitems"></a>
# **GetFavoriteItems**
> List<FavoriteItem> GetFavoriteItems (int? top, int? skip, string filter, string count, string orderBy, string expand, string select)

Retrieves a collection of items of type CatalogItem which have been designated as favorites. Use the OData $expand option to also get the referenced items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class GetFavoriteItemsExample
    {
        public void main()
        {
            
            var apiInstance = new FavoriteItemsApi();
            var top = 56;  // int? | Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) (optional) 
            var skip = 56;  // int? | Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) (optional) 
            var filter = filter_example;  // string | Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) (optional) 
            var count = count_example;  // string | Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) (optional) 
            var orderBy = orderBy_example;  // string | Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) (optional) 
            var expand = expand_example;  // string | Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) (optional) 
            var select = select_example;  // string | Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) (optional) 

            try
            {
                // Retrieves a collection of items of type CatalogItem which have been designated as favorites. Use the OData $expand option to also get the referenced items.
                List&lt;FavoriteItem&gt; result = apiInstance.GetFavoriteItems(top, skip, filter, count, orderBy, expand, select);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoriteItemsApi.GetFavoriteItems: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **top** | **int?**| Show only the first n items, see [OData Paging - Top](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374630) | [optional] 
 **skip** | **int?**| Skip the first n items, see [OData Paging - Skip](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374631) | [optional] 
 **filter** | **string**| Filter items by property values, see [OData Filtering](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374625) | [optional] 
 **count** | **string**| Include count of items, see [OData Count](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374632) | [optional] 
 **orderBy** | **string**| Order items by property values, see [OData Sorting](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374629) | [optional] 
 **expand** | **string**| Expand related entities, see [OData Expand](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374621) | [optional] 
 **select** | **string**| Select properties to be returned, see [OData Select](http://docs.oasis-open.org/odata/odata/v4.0/odata-v4.0-part1-protocol.html#_Toc445374620) | [optional] 

### Return type

[**List<FavoriteItem>**](FavoriteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removefavoriteitem"></a>
# **RemoveFavoriteItem**
> void RemoveFavoriteItem (string id)

Removes a CatalogItem from the list of favorite items.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class RemoveFavoriteItemExample
    {
        public void main()
        {
            
            var apiInstance = new FavoriteItemsApi();
            var id = id_example;  // string | The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path='/folder1/folder2/item' If the path itself contains single quote, it should be escaped - add another single quote.

            try
            {
                // Removes a CatalogItem from the list of favorite items.
                apiInstance.RemoveFavoriteItem(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoriteItemsApi.RemoveFavoriteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The key (GUID or path) that uniquely identifies the object. GUID example: 01234567-89ab-cdef-0123-456789abcdef path example: path&#x3D;&#39;/folder1/folder2/item&#39; If the path itself contains single quote, it should be escaped - add another single quote. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setfavoriteitem"></a>
# **SetFavoriteItem**
> FavoriteItem SetFavoriteItem (FavoriteItem favoriteItem)

Designate a CatalogItem as a favorite.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.SSRS.Swagger.Api;
using IO.SSRS.Swagger.Client;
using IO.SSRS.Swagger.Model;

namespace Example
{
    public class SetFavoriteItemExample
    {
        public void main()
        {
            
            var apiInstance = new FavoriteItemsApi();
            var favoriteItem = new FavoriteItem(); // FavoriteItem | The reference to the CatalogItem to be designated as a favorite. It only needs the Id property. Thus, it is not necessary to provide Item property in the payload.

            try
            {
                // Designate a CatalogItem as a favorite.
                FavoriteItem result = apiInstance.SetFavoriteItem(favoriteItem);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FavoriteItemsApi.SetFavoriteItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **favoriteItem** | [**FavoriteItem**](FavoriteItem.md)| The reference to the CatalogItem to be designated as a favorite. It only needs the Id property. Thus, it is not necessary to provide Item property in the payload. | 

### Return type

[**FavoriteItem**](FavoriteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

