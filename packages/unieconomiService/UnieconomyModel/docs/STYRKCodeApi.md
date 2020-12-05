# swagger_client.STYRKCodeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**s_tyr_kactionrefresh_put**](STYRKCodeApi.md#s_tyr_kactionrefresh_put) | **PUT** /STYRK?action&#x3D;refresh | 
[**s_tyrk_get**](STYRKCodeApi.md#s_tyrk_get) | **GET** /STYRK | 
[**s_tyrk_id_get**](STYRKCodeApi.md#s_tyrk_id_get) | **GET** /STYRK/{id} | 

# **s_tyr_kactionrefresh_put**
> bool s_tyr_kactionrefresh_put()



refresh Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.STYRKCodeApi()

try:
    api_response = api_instance.s_tyr_kactionrefresh_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling STYRKCodeApi->s_tyr_kactionrefresh_put: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **s_tyrk_get**
> list[STYRKCode] s_tyrk_get()



Query STYRKCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.STYRKCodeApi()

try:
    api_response = api_instance.s_tyrk_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling STYRKCodeApi->s_tyrk_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[STYRKCode]**](STYRKCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **s_tyrk_id_get**
> STYRKCode s_tyrk_id_get(id)



Get STYRKCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.STYRKCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.s_tyrk_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling STYRKCodeApi->s_tyrk_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**STYRKCode**](STYRKCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

