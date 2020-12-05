# swagger_client.FileTagApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**filetags_get**](FileTagApi.md#filetags_get) | **GET** /filetags | 
[**filetags_id_delete**](FileTagApi.md#filetags_id_delete) | **DELETE** /filetags/{id} | 
[**filetags_id_get**](FileTagApi.md#filetags_id_get) | **GET** /filetags/{id} | 
[**filetags_post**](FileTagApi.md#filetags_post) | **POST** /filetags | 

# **filetags_get**
> list[FileTag] filetags_get()



Query FileTag

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileTagApi()

try:
    api_response = api_instance.filetags_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileTagApi->filetags_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[FileTag]**](FileTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_id_delete**
> FileTag filetags_id_delete(id)



Delete FileTag

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileTagApi()
id = 56 # int | 

try:
    api_response = api_instance.filetags_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileTagApi->filetags_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FileTag**](FileTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_id_get**
> FileTag filetags_id_get(id)



Get FileTag

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileTagApi()
id = 56 # int | 

try:
    api_response = api_instance.filetags_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileTagApi->filetags_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**FileTag**](FileTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **filetags_post**
> FileTag filetags_post(body)



Create FileTag

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.FileTagApi()
body = swagger_client.FileTag() # FileTag | 

try:
    api_response = api_instance.filetags_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FileTagApi->filetags_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FileTag**](FileTag.md)|  | 

### Return type

[**FileTag**](FileTag.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

