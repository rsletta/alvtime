# swagger_client.ContractTriggerApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contracttriggers_get**](ContractTriggerApi.md#contracttriggers_get) | **GET** /contracttriggers | 
[**contracttriggers_id_delete**](ContractTriggerApi.md#contracttriggers_id_delete) | **DELETE** /contracttriggers/{id} | 
[**contracttriggers_id_get**](ContractTriggerApi.md#contracttriggers_id_get) | **GET** /contracttriggers/{id} | 
[**contracttriggers_id_put**](ContractTriggerApi.md#contracttriggers_id_put) | **PUT** /contracttriggers/{id} | 
[**contracttriggers_post**](ContractTriggerApi.md#contracttriggers_post) | **POST** /contracttriggers | 

# **contracttriggers_get**
> list[ContractTrigger] contracttriggers_get()



Query ContractTrigger

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTriggerApi()

try:
    api_response = api_instance.contracttriggers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTriggerApi->contracttriggers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractTrigger]**](ContractTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttriggers_id_delete**
> ContractTrigger contracttriggers_id_delete(id)



Delete ContractTrigger

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTriggerApi()
id = 56 # int | 

try:
    api_response = api_instance.contracttriggers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTriggerApi->contracttriggers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractTrigger**](ContractTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttriggers_id_get**
> ContractTrigger contracttriggers_id_get(id)



Get ContractTrigger

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTriggerApi()
id = 56 # int | 

try:
    api_response = api_instance.contracttriggers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTriggerApi->contracttriggers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractTrigger**](ContractTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttriggers_id_put**
> ContractTrigger contracttriggers_id_put(body, id)



Update ContractTrigger

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTriggerApi()
body = swagger_client.ContractTrigger() # ContractTrigger | 
id = 56 # int | 

try:
    api_response = api_instance.contracttriggers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTriggerApi->contracttriggers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractTrigger**](ContractTrigger.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractTrigger**](ContractTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttriggers_post**
> ContractTrigger contracttriggers_post(body)



Create ContractTrigger

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTriggerApi()
body = swagger_client.ContractTrigger() # ContractTrigger | 

try:
    api_response = api_instance.contracttriggers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTriggerApi->contracttriggers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractTrigger**](ContractTrigger.md)|  | 

### Return type

[**ContractTrigger**](ContractTrigger.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

