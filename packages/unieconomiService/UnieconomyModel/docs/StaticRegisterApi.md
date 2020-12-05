# swagger_client.StaticRegisterApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**static_register_get**](StaticRegisterApi.md#static_register_get) | **GET** /StaticRegister | 
[**static_register_id_delete**](StaticRegisterApi.md#static_register_id_delete) | **DELETE** /StaticRegister/{id} | 
[**static_register_id_get**](StaticRegisterApi.md#static_register_id_get) | **GET** /StaticRegister/{id} | 
[**static_register_id_put**](StaticRegisterApi.md#static_register_id_put) | **PUT** /StaticRegister/{id} | 
[**static_register_post**](StaticRegisterApi.md#static_register_post) | **POST** /StaticRegister | 

# **static_register_get**
> list[StaticRegister] static_register_get()



Query StaticRegister

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StaticRegisterApi()

try:
    api_response = api_instance.static_register_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StaticRegisterApi->static_register_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[StaticRegister]**](StaticRegister.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **static_register_id_delete**
> StaticRegister static_register_id_delete(id)



Delete StaticRegister

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StaticRegisterApi()
id = 56 # int | 

try:
    api_response = api_instance.static_register_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StaticRegisterApi->static_register_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**StaticRegister**](StaticRegister.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **static_register_id_get**
> StaticRegister static_register_id_get(id)



Get StaticRegister

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StaticRegisterApi()
id = 56 # int | 

try:
    api_response = api_instance.static_register_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StaticRegisterApi->static_register_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**StaticRegister**](StaticRegister.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **static_register_id_put**
> StaticRegister static_register_id_put(body, id)



Update StaticRegister

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StaticRegisterApi()
body = swagger_client.StaticRegister() # StaticRegister | 
id = 56 # int | 

try:
    api_response = api_instance.static_register_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StaticRegisterApi->static_register_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StaticRegister**](StaticRegister.md)|  | 
 **id** | **int**|  | 

### Return type

[**StaticRegister**](StaticRegister.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **static_register_post**
> StaticRegister static_register_post(body)



Create StaticRegister

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.StaticRegisterApi()
body = swagger_client.StaticRegister() # StaticRegister | 

try:
    api_response = api_instance.static_register_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling StaticRegisterApi->static_register_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**StaticRegister**](StaticRegister.md)|  | 

### Return type

[**StaticRegister**](StaticRegister.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

