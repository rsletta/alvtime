# swagger_client.AmeldingSumUpApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ameldingsums_idactionget_sumup_get**](AmeldingSumUpApi.md#ameldingsums_idactionget_sumup_get) | **GET** /ameldingsums/{id}?action&#x3D;get-sumup | 

# **ameldingsums_idactionget_sumup_get**
> AmeldingSumUp ameldingsums_idactionget_sumup_get(id, id)



get-sumup Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AmeldingSumUpApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ameldingsums_idactionget_sumup_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AmeldingSumUpApi->ameldingsums_idactionget_sumup_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**AmeldingSumUp**](AmeldingSumUp.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

