# swagger_client.WorkTimeOffApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**worktimeoff_get**](WorkTimeOffApi.md#worktimeoff_get) | **GET** /worktimeoff | 
[**worktimeoff_id_delete**](WorkTimeOffApi.md#worktimeoff_id_delete) | **DELETE** /worktimeoff/{id} | 
[**worktimeoff_id_get**](WorkTimeOffApi.md#worktimeoff_id_get) | **GET** /worktimeoff/{id} | 
[**worktimeoff_id_put**](WorkTimeOffApi.md#worktimeoff_id_put) | **PUT** /worktimeoff/{id} | 
[**worktimeoff_post**](WorkTimeOffApi.md#worktimeoff_post) | **POST** /worktimeoff | 

# **worktimeoff_get**
> list[WorkTimeOff] worktimeoff_get()



Query WorkTimeOff

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTimeOffApi()

try:
    api_response = api_instance.worktimeoff_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTimeOffApi->worktimeoff_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkTimeOff]**](WorkTimeOff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktimeoff_id_delete**
> WorkTimeOff worktimeoff_id_delete(id)



Delete WorkTimeOff

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTimeOffApi()
id = 56 # int | 

try:
    api_response = api_instance.worktimeoff_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTimeOffApi->worktimeoff_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkTimeOff**](WorkTimeOff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktimeoff_id_get**
> WorkTimeOff worktimeoff_id_get(id)



Get WorkTimeOff

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTimeOffApi()
id = 56 # int | 

try:
    api_response = api_instance.worktimeoff_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTimeOffApi->worktimeoff_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkTimeOff**](WorkTimeOff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktimeoff_id_put**
> WorkTimeOff worktimeoff_id_put(body, id)



Update WorkTimeOff

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTimeOffApi()
body = swagger_client.WorkTimeOff() # WorkTimeOff | 
id = 56 # int | 

try:
    api_response = api_instance.worktimeoff_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTimeOffApi->worktimeoff_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkTimeOff**](WorkTimeOff.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkTimeOff**](WorkTimeOff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktimeoff_post**
> WorkTimeOff worktimeoff_post(body)



Create WorkTimeOff

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTimeOffApi()
body = swagger_client.WorkTimeOff() # WorkTimeOff | 

try:
    api_response = api_instance.worktimeoff_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTimeOffApi->worktimeoff_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkTimeOff**](WorkTimeOff.md)|  | 

### Return type

[**WorkTimeOff**](WorkTimeOff.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

