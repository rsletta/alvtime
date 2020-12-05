# swagger_client.TransitionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transitions_get**](TransitionApi.md#transitions_get) | **GET** /transitions | 
[**transitions_id_get**](TransitionApi.md#transitions_id_get) | **GET** /transitions/{id} | 

# **transitions_get**
> list[Transition] transitions_get()



Query Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionApi()

try:
    api_response = api_instance.transitions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionApi->transitions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Transition]**](Transition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transitions_id_get**
> Transition transitions_id_get(id)



Get Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionApi()
id = 56 # int | 

try:
    api_response = api_instance.transitions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionApi->transitions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Transition**](Transition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

