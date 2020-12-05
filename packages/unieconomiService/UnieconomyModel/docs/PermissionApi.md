# swagger_client.PermissionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**permissions_get**](PermissionApi.md#permissions_get) | **GET** /permissions | 
[**permissions_id_delete**](PermissionApi.md#permissions_id_delete) | **DELETE** /permissions/{id} | 
[**permissions_id_get**](PermissionApi.md#permissions_id_get) | **GET** /permissions/{id} | 

# **permissions_get**
> list[Permission] permissions_get()



Query Permission

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PermissionApi()

try:
    api_response = api_instance.permissions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PermissionApi->permissions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Permission]**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **permissions_id_delete**
> Permission permissions_id_delete(id)



Delete Permission

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PermissionApi()
id = 56 # int | 

try:
    api_response = api_instance.permissions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PermissionApi->permissions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Permission**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **permissions_id_get**
> Permission permissions_id_get(id)



Get Permission

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PermissionApi()
id = 56 # int | 

try:
    api_response = api_instance.permissions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PermissionApi->permissions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Permission**](Permission.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

