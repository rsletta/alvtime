# swagger_client.WorkTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**worktypes_get**](WorkTypeApi.md#worktypes_get) | **GET** /worktypes | 
[**worktypes_id_delete**](WorkTypeApi.md#worktypes_id_delete) | **DELETE** /worktypes/{id} | 
[**worktypes_id_get**](WorkTypeApi.md#worktypes_id_get) | **GET** /worktypes/{id} | 
[**worktypes_id_put**](WorkTypeApi.md#worktypes_id_put) | **PUT** /worktypes/{id} | 
[**worktypes_post**](WorkTypeApi.md#worktypes_post) | **POST** /worktypes | 

# **worktypes_get**
> list[WorkType] worktypes_get()



Query WorkType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTypeApi()

try:
    api_response = api_instance.worktypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTypeApi->worktypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkType]**](WorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktypes_id_delete**
> WorkType worktypes_id_delete(id)



Delete WorkType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.worktypes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTypeApi->worktypes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkType**](WorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktypes_id_get**
> WorkType worktypes_id_get(id)



Get WorkType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.worktypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTypeApi->worktypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkType**](WorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktypes_id_put**
> WorkType worktypes_id_put(body, id)



Update WorkType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTypeApi()
body = swagger_client.WorkType() # WorkType | 
id = 56 # int | 

try:
    api_response = api_instance.worktypes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTypeApi->worktypes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkType**](WorkType.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkType**](WorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **worktypes_post**
> WorkType worktypes_post(body)



Create WorkType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkTypeApi()
body = swagger_client.WorkType() # WorkType | 

try:
    api_response = api_instance.worktypes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkTypeApi->worktypes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkType**](WorkType.md)|  | 

### Return type

[**WorkType**](WorkType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

