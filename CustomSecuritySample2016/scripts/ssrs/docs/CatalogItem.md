# SqlServer2017ReportingServicesRestApi.CatalogItem

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**id** | **String** | A unique UUID value that specifies the identifier by which this CatalogItem can be referenced in requests or by other defined objects. | [optional] 
**name** | **String** | A string value that specifies the name for the CatalogItem. This name is typically displayed in the user interface. | [optional] 
**description** | **String** | A string value that contains descriptive text about the CatalogItem. | [optional] 
**path** | **String** | A string value that contains the full server path for the CatalogItem. Path is defined as an alternate key on the CatalogItem and can be used as the parameter by which CatalogItem can be referenced in requests or by other defined objects. | [optional] 
**type** | [**CatalogItemType**](CatalogItemType.md) |  | [optional] 
**hidden** | **Boolean** | A boolean value that indicates if the CatalogItem is hidden. If true, the item will generally not appear in listings of CatalogItems within the parent item. | [optional] 
**size** | **Number** | An Int64 value that contains the size of the CatalogItem in bytes. | [optional] 
**modifiedBy** | **String** | A string value that contains the network user name of the last user to modify the CatalogItem. | [optional] 
**modifiedDate** | **Date** | A string value that contains the date-time of the last modification to the CatalogItem. | [optional] 
**createdBy** | **String** | A string value that represents the network user name of the user who originally created the CatalogItem. | [optional] 
**createdDate** | **Date** | A string that contains the date-time of the creation of the CatalogItem. | [optional] 
**parentFolderId** | **String** | A unique UUID value that specifies the identifier of the Folder CatalogItem that contains this CatalogItem. | [optional] 
**contentType** | **String** | A string value that contains a SOAP MIME-type that is associated with the CatalogItem. | [optional] 
**content** | **String** | A string value that contains binary encoding by base64url encoding rules. The value of this property is not processed by the server. In object creation the server receives and stores a value, and in object retrieval the server returns the previously stored value. | [optional] 
**isFavorite** | **Boolean** | A boolean value that specifies whether the CatalogItem is designated as a Favorite. | [optional] 


