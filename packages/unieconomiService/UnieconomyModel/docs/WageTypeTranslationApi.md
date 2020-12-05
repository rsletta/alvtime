# swagger_client.WageTypeTranslationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**wagetypetranslations_get**](WageTypeTranslationApi.md#wagetypetranslations_get) | **GET** /wagetypetranslations | 
[**wagetypetranslations_id_delete**](WageTypeTranslationApi.md#wagetypetranslations_id_delete) | **DELETE** /wagetypetranslations/{id} | 
[**wagetypetranslations_id_get**](WageTypeTranslationApi.md#wagetypetranslations_id_get) | **GET** /wagetypetranslations/{id} | 
[**wagetypetranslations_id_put**](WageTypeTranslationApi.md#wagetypetranslations_id_put) | **PUT** /wagetypetranslations/{id} | 
[**wagetypetranslations_post**](WageTypeTranslationApi.md#wagetypetranslations_post) | **POST** /wagetypetranslations | 

# **wagetypetranslations_get**
> list[WageTypeTranslation] wagetypetranslations_get()



Query WageTypeTranslation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeTranslationApi()

try:
    api_response = api_instance.wagetypetranslations_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeTranslationApi->wagetypetranslations_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WageTypeTranslation]**](WageTypeTranslation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypetranslations_id_delete**
> WageTypeTranslation wagetypetranslations_id_delete(id)



Delete WageTypeTranslation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeTranslationApi()
id = 56 # int | 

try:
    api_response = api_instance.wagetypetranslations_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeTranslationApi->wagetypetranslations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WageTypeTranslation**](WageTypeTranslation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypetranslations_id_get**
> WageTypeTranslation wagetypetranslations_id_get(id)



Get WageTypeTranslation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeTranslationApi()
id = 56 # int | 

try:
    api_response = api_instance.wagetypetranslations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeTranslationApi->wagetypetranslations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WageTypeTranslation**](WageTypeTranslation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypetranslations_id_put**
> WageTypeTranslation wagetypetranslations_id_put(body, id)



Update WageTypeTranslation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeTranslationApi()
body = swagger_client.WageTypeTranslation() # WageTypeTranslation | 
id = 56 # int | 

try:
    api_response = api_instance.wagetypetranslations_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeTranslationApi->wagetypetranslations_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WageTypeTranslation**](WageTypeTranslation.md)|  | 
 **id** | **int**|  | 

### Return type

[**WageTypeTranslation**](WageTypeTranslation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **wagetypetranslations_post**
> WageTypeTranslation wagetypetranslations_post(body)



Create WageTypeTranslation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WageTypeTranslationApi()
body = swagger_client.WageTypeTranslation() # WageTypeTranslation | 

try:
    api_response = api_instance.wagetypetranslations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WageTypeTranslationApi->wagetypetranslations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WageTypeTranslation**](WageTypeTranslation.md)|  | 

### Return type

[**WageTypeTranslation**](WageTypeTranslation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

