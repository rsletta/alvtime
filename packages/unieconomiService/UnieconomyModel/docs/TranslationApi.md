# swagger_client.TranslationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translations_get**](TranslationApi.md#translations_get) | **GET** /translations | 
[**translations_id_delete**](TranslationApi.md#translations_id_delete) | **DELETE** /translations/{id} | 
[**translations_id_get**](TranslationApi.md#translations_id_get) | **GET** /translations/{id} | 
[**translations_id_put**](TranslationApi.md#translations_id_put) | **PUT** /translations/{id} | 
[**translations_post**](TranslationApi.md#translations_post) | **POST** /translations | 

# **translations_get**
> list[Translation] translations_get()



Query Translation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslationApi()

try:
    api_response = api_instance.translations_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslationApi->translations_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Translation]**](Translation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translations_id_delete**
> Translation translations_id_delete(id)



Delete Translation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslationApi()
id = 56 # int | 

try:
    api_response = api_instance.translations_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslationApi->translations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Translation**](Translation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translations_id_get**
> Translation translations_id_get(id)



Get Translation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslationApi()
id = 56 # int | 

try:
    api_response = api_instance.translations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslationApi->translations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Translation**](Translation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translations_id_put**
> Translation translations_id_put(body, id)



Update Translation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslationApi()
body = swagger_client.Translation() # Translation | 
id = 56 # int | 

try:
    api_response = api_instance.translations_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslationApi->translations_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Translation**](Translation.md)|  | 
 **id** | **int**|  | 

### Return type

[**Translation**](Translation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translations_post**
> Translation translations_post(body)



Create Translation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslationApi()
body = swagger_client.Translation() # Translation | 

try:
    api_response = api_instance.translations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslationApi->translations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Translation**](Translation.md)|  | 

### Return type

[**Translation**](Translation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

