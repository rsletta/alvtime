# swagger_client.LanguageApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**languages_get**](LanguageApi.md#languages_get) | **GET** /languages | 
[**languages_id_delete**](LanguageApi.md#languages_id_delete) | **DELETE** /languages/{id} | 
[**languages_id_get**](LanguageApi.md#languages_id_get) | **GET** /languages/{id} | 
[**languages_id_put**](LanguageApi.md#languages_id_put) | **PUT** /languages/{id} | 
[**languages_post**](LanguageApi.md#languages_post) | **POST** /languages | 

# **languages_get**
> list[Language] languages_get()



Query Language

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LanguageApi()

try:
    api_response = api_instance.languages_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LanguageApi->languages_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Language]**](Language.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **languages_id_delete**
> Language languages_id_delete(id)



Delete Language

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LanguageApi()
id = 56 # int | 

try:
    api_response = api_instance.languages_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LanguageApi->languages_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Language**](Language.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **languages_id_get**
> Language languages_id_get(id)



Get Language

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LanguageApi()
id = 56 # int | 

try:
    api_response = api_instance.languages_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LanguageApi->languages_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Language**](Language.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **languages_id_put**
> Language languages_id_put(body, id)



Update Language

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LanguageApi()
body = swagger_client.Language() # Language | 
id = 56 # int | 

try:
    api_response = api_instance.languages_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LanguageApi->languages_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Language**](Language.md)|  | 
 **id** | **int**|  | 

### Return type

[**Language**](Language.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **languages_post**
> Language languages_post(body)



Create Language

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.LanguageApi()
body = swagger_client.Language() # Language | 

try:
    api_response = api_instance.languages_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LanguageApi->languages_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Language**](Language.md)|  | 

### Return type

[**Language**](Language.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

