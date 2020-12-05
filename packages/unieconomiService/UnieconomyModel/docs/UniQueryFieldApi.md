# swagger_client.UniQueryFieldApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**uniqueryfields_get**](UniQueryFieldApi.md#uniqueryfields_get) | **GET** /uniqueryfields | 
[**uniqueryfields_id_delete**](UniQueryFieldApi.md#uniqueryfields_id_delete) | **DELETE** /uniqueryfields/{id} | 
[**uniqueryfields_id_get**](UniQueryFieldApi.md#uniqueryfields_id_get) | **GET** /uniqueryfields/{id} | 
[**uniqueryfields_id_put**](UniQueryFieldApi.md#uniqueryfields_id_put) | **PUT** /uniqueryfields/{id} | 
[**uniqueryfields_post**](UniQueryFieldApi.md#uniqueryfields_post) | **POST** /uniqueryfields | 

# **uniqueryfields_get**
> list[UniQueryField] uniqueryfields_get()



Query UniQueryField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFieldApi()

try:
    api_response = api_instance.uniqueryfields_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFieldApi->uniqueryfields_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[UniQueryField]**](UniQueryField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfields_id_delete**
> UniQueryField uniqueryfields_id_delete(id)



Delete UniQueryField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFieldApi()
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfields_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFieldApi->uniqueryfields_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryField**](UniQueryField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfields_id_get**
> UniQueryField uniqueryfields_id_get(id)



Get UniQueryField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFieldApi()
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfields_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFieldApi->uniqueryfields_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryField**](UniQueryField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfields_id_put**
> UniQueryField uniqueryfields_id_put(body, id)



Update UniQueryField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFieldApi()
body = swagger_client.UniQueryField() # UniQueryField | 
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfields_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFieldApi->uniqueryfields_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryField**](UniQueryField.md)|  | 
 **id** | **int**|  | 

### Return type

[**UniQueryField**](UniQueryField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfields_post**
> UniQueryField uniqueryfields_post(body)



Create UniQueryField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFieldApi()
body = swagger_client.UniQueryField() # UniQueryField | 

try:
    api_response = api_instance.uniqueryfields_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFieldApi->uniqueryfields_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryField**](UniQueryField.md)|  | 

### Return type

[**UniQueryField**](UniQueryField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

