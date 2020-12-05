# swagger_client.StringApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**salaryvalidvalue_typesactiongetall_get**](StringApi.md#salaryvalidvalue_typesactiongetall_get) | **GET** /salaryvalidvalue/types?action&#x3D;getall | 

# **salaryvalidvalue_typesactiongetall_get**
> object salaryvalidvalue_typesactiongetall_get()



getall Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StringApi()

try:
    api_response = api_instance.salaryvalidvalue_typesactiongetall_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StringApi->salaryvalidvalue_typesactiongetall_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

