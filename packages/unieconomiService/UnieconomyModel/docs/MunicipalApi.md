# swagger_client.MunicipalApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**municipals_get**](MunicipalApi.md#municipals_get) | **GET** /Municipals | 
[**municipals_id_delete**](MunicipalApi.md#municipals_id_delete) | **DELETE** /Municipals/{id} | 
[**municipals_id_get**](MunicipalApi.md#municipals_id_get) | **GET** /Municipals/{id} | 
[**municipals_id_put**](MunicipalApi.md#municipals_id_put) | **PUT** /Municipals/{id} | 
[**municipals_post**](MunicipalApi.md#municipals_post) | **POST** /Municipals | 

# **municipals_get**
> list[Municipal] municipals_get()



Query Municipal

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalApi()

try:
    api_response = api_instance.municipals_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalApi->municipals_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Municipal]**](Municipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipals_id_delete**
> Municipal municipals_id_delete(id)



Delete Municipal

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalApi()
id = 56 # int | 

try:
    api_response = api_instance.municipals_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalApi->municipals_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Municipal**](Municipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipals_id_get**
> Municipal municipals_id_get(id)



Get Municipal

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalApi()
id = 56 # int | 

try:
    api_response = api_instance.municipals_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalApi->municipals_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Municipal**](Municipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipals_id_put**
> Municipal municipals_id_put(body, id)



Update Municipal

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalApi()
body = swagger_client.Municipal() # Municipal | 
id = 56 # int | 

try:
    api_response = api_instance.municipals_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalApi->municipals_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Municipal**](Municipal.md)|  | 
 **id** | **int**|  | 

### Return type

[**Municipal**](Municipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipals_post**
> Municipal municipals_post(body)



Create Municipal

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalApi()
body = swagger_client.Municipal() # Municipal | 

try:
    api_response = api_instance.municipals_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalApi->municipals_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Municipal**](Municipal.md)|  | 

### Return type

[**Municipal**](Municipal.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

