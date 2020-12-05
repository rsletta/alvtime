# swagger_client.CurrencyCodeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**currencycodes_get**](CurrencyCodeApi.md#currencycodes_get) | **GET** /currencycodes | 
[**currencycodes_id_delete**](CurrencyCodeApi.md#currencycodes_id_delete) | **DELETE** /currencycodes/{id} | 
[**currencycodes_id_get**](CurrencyCodeApi.md#currencycodes_id_get) | **GET** /currencycodes/{id} | 
[**currencycodes_id_put**](CurrencyCodeApi.md#currencycodes_id_put) | **PUT** /currencycodes/{id} | 
[**currencycodes_post**](CurrencyCodeApi.md#currencycodes_post) | **POST** /currencycodes | 

# **currencycodes_get**
> list[CurrencyCode] currencycodes_get()



Query CurrencyCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyCodeApi()

try:
    api_response = api_instance.currencycodes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyCodeApi->currencycodes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CurrencyCode]**](CurrencyCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencycodes_id_delete**
> CurrencyCode currencycodes_id_delete(id)



Delete CurrencyCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.currencycodes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyCodeApi->currencycodes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CurrencyCode**](CurrencyCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencycodes_id_get**
> CurrencyCode currencycodes_id_get(id)



Get CurrencyCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.currencycodes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyCodeApi->currencycodes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CurrencyCode**](CurrencyCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencycodes_id_put**
> CurrencyCode currencycodes_id_put(body, id)



Update CurrencyCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyCodeApi()
body = swagger_client.CurrencyCode() # CurrencyCode | 
id = 56 # int | 

try:
    api_response = api_instance.currencycodes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyCodeApi->currencycodes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CurrencyCode**](CurrencyCode.md)|  | 
 **id** | **int**|  | 

### Return type

[**CurrencyCode**](CurrencyCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencycodes_post**
> CurrencyCode currencycodes_post(body)



Create CurrencyCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyCodeApi()
body = swagger_client.CurrencyCode() # CurrencyCode | 

try:
    api_response = api_instance.currencycodes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyCodeApi->currencycodes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CurrencyCode**](CurrencyCode.md)|  | 

### Return type

[**CurrencyCode**](CurrencyCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

