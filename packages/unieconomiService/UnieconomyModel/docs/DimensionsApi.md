# swagger_client.DimensionsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimensions_get**](DimensionsApi.md#dimensions_get) | **GET** /dimensions | 
[**dimensions_id_get**](DimensionsApi.md#dimensions_id_get) | **GET** /dimensions/{id} | 

# **dimensions_get**
> list[Dimensions] dimensions_get()



Query Dimensions

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionsApi()

try:
    api_response = api_instance.dimensions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionsApi->dimensions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimensions]**](Dimensions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimensions_id_get**
> Dimensions dimensions_id_get(id)



Get Dimensions

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionsApi()
id = 56 # int | 

try:
    api_response = api_instance.dimensions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionsApi->dimensions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimensions**](Dimensions.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

