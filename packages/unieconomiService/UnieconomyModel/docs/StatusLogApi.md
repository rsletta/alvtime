# swagger_client.StatusLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**statuslogs_get**](StatusLogApi.md#statuslogs_get) | **GET** /statuslogs | 
[**statuslogs_id_get**](StatusLogApi.md#statuslogs_id_get) | **GET** /statuslogs/{id} | 

# **statuslogs_get**
> list[StatusLog] statuslogs_get()



Query StatusLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StatusLogApi()

try:
    api_response = api_instance.statuslogs_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StatusLogApi->statuslogs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[StatusLog]**](StatusLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **statuslogs_id_get**
> StatusLog statuslogs_id_get(id)



Get StatusLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StatusLogApi()
id = 56 # int | 

try:
    api_response = api_instance.statuslogs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StatusLogApi->statuslogs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**StatusLog**](StatusLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

