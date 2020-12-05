# swagger_client.TranslatableApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translatables_get**](TranslatableApi.md#translatables_get) | **GET** /translatables | 
[**translatables_id_delete**](TranslatableApi.md#translatables_id_delete) | **DELETE** /translatables/{id} | 
[**translatables_id_get**](TranslatableApi.md#translatables_id_get) | **GET** /translatables/{id} | 
[**translatables_id_put**](TranslatableApi.md#translatables_id_put) | **PUT** /translatables/{id} | 
[**translatables_post**](TranslatableApi.md#translatables_post) | **POST** /translatables | 

# **translatables_get**
> list[Translatable] translatables_get()



Query Translatable

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslatableApi()

try:
    api_response = api_instance.translatables_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslatableApi->translatables_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Translatable]**](Translatable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translatables_id_delete**
> Translatable translatables_id_delete(id)



Delete Translatable

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslatableApi()
id = 56 # int | 

try:
    api_response = api_instance.translatables_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslatableApi->translatables_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Translatable**](Translatable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translatables_id_get**
> Translatable translatables_id_get(id)



Get Translatable

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslatableApi()
id = 56 # int | 

try:
    api_response = api_instance.translatables_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslatableApi->translatables_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Translatable**](Translatable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translatables_id_put**
> Translatable translatables_id_put(body, id)



Update Translatable

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslatableApi()
body = swagger_client.Translatable() # Translatable | 
id = 56 # int | 

try:
    api_response = api_instance.translatables_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslatableApi->translatables_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Translatable**](Translatable.md)|  | 
 **id** | **int**|  | 

### Return type

[**Translatable**](Translatable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **translatables_post**
> Translatable translatables_post(body)



Create Translatable

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TranslatableApi()
body = swagger_client.Translatable() # Translatable | 

try:
    api_response = api_instance.translatables_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TranslatableApi->translatables_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Translatable**](Translatable.md)|  | 

### Return type

[**Translatable**](Translatable.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

