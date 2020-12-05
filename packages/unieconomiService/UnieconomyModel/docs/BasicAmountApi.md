# swagger_client.BasicAmountApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**basicamounts_get**](BasicAmountApi.md#basicamounts_get) | **GET** /basicamounts | 
[**basicamounts_id_get**](BasicAmountApi.md#basicamounts_id_get) | **GET** /basicamounts/{id} | 

# **basicamounts_get**
> list[BasicAmount] basicamounts_get()



Query BasicAmount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BasicAmountApi()

try:
    api_response = api_instance.basicamounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BasicAmountApi->basicamounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BasicAmount]**](BasicAmount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **basicamounts_id_get**
> BasicAmount basicamounts_id_get(id)



Get BasicAmount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BasicAmountApi()
id = 56 # int | 

try:
    api_response = api_instance.basicamounts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BasicAmountApi->basicamounts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BasicAmount**](BasicAmount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

