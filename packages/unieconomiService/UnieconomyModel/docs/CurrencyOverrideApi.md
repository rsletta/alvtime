# swagger_client.CurrencyOverrideApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**currencyoverrides_get**](CurrencyOverrideApi.md#currencyoverrides_get) | **GET** /currencyoverrides | 
[**currencyoverrides_id_delete**](CurrencyOverrideApi.md#currencyoverrides_id_delete) | **DELETE** /currencyoverrides/{id} | 
[**currencyoverrides_id_get**](CurrencyOverrideApi.md#currencyoverrides_id_get) | **GET** /currencyoverrides/{id} | 
[**currencyoverrides_id_put**](CurrencyOverrideApi.md#currencyoverrides_id_put) | **PUT** /currencyoverrides/{id} | 
[**currencyoverrides_post**](CurrencyOverrideApi.md#currencyoverrides_post) | **POST** /currencyoverrides | 

# **currencyoverrides_get**
> list[CurrencyOverride] currencyoverrides_get()



Query CurrencyOverride

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyOverrideApi()

try:
    api_response = api_instance.currencyoverrides_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyOverrideApi->currencyoverrides_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CurrencyOverride]**](CurrencyOverride.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencyoverrides_id_delete**
> CurrencyOverride currencyoverrides_id_delete(id)



Delete CurrencyOverride

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyOverrideApi()
id = 56 # int | 

try:
    api_response = api_instance.currencyoverrides_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyOverrideApi->currencyoverrides_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CurrencyOverride**](CurrencyOverride.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencyoverrides_id_get**
> CurrencyOverride currencyoverrides_id_get(id)



Get CurrencyOverride

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyOverrideApi()
id = 56 # int | 

try:
    api_response = api_instance.currencyoverrides_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyOverrideApi->currencyoverrides_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CurrencyOverride**](CurrencyOverride.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencyoverrides_id_put**
> CurrencyOverride currencyoverrides_id_put(body, id)



Update CurrencyOverride

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyOverrideApi()
body = swagger_client.CurrencyOverride() # CurrencyOverride | 
id = 56 # int | 

try:
    api_response = api_instance.currencyoverrides_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyOverrideApi->currencyoverrides_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CurrencyOverride**](CurrencyOverride.md)|  | 
 **id** | **int**|  | 

### Return type

[**CurrencyOverride**](CurrencyOverride.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **currencyoverrides_post**
> CurrencyOverride currencyoverrides_post(body)



Create CurrencyOverride

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CurrencyOverrideApi()
body = swagger_client.CurrencyOverride() # CurrencyOverride | 

try:
    api_response = api_instance.currencyoverrides_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CurrencyOverrideApi->currencyoverrides_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CurrencyOverride**](CurrencyOverride.md)|  | 

### Return type

[**CurrencyOverride**](CurrencyOverride.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

