# swagger_client.WorkBalanceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workbalances_get**](WorkBalanceApi.md#workbalances_get) | **GET** /workbalances | 
[**workbalances_id_delete**](WorkBalanceApi.md#workbalances_id_delete) | **DELETE** /workbalances/{id} | 
[**workbalances_id_get**](WorkBalanceApi.md#workbalances_id_get) | **GET** /workbalances/{id} | 
[**workbalances_id_put**](WorkBalanceApi.md#workbalances_id_put) | **PUT** /workbalances/{id} | 
[**workbalances_post**](WorkBalanceApi.md#workbalances_post) | **POST** /workbalances | 

# **workbalances_get**
> list[WorkBalance] workbalances_get()



Query WorkBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkBalanceApi()

try:
    api_response = api_instance.workbalances_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkBalanceApi->workbalances_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkBalance]**](WorkBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workbalances_id_delete**
> WorkBalance workbalances_id_delete(id)



Delete WorkBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkBalanceApi()
id = 56 # int | 

try:
    api_response = api_instance.workbalances_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkBalanceApi->workbalances_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkBalance**](WorkBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workbalances_id_get**
> WorkBalance workbalances_id_get(id)



Get WorkBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkBalanceApi()
id = 56 # int | 

try:
    api_response = api_instance.workbalances_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkBalanceApi->workbalances_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkBalance**](WorkBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workbalances_id_put**
> WorkBalance workbalances_id_put(body, id)



Update WorkBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkBalanceApi()
body = swagger_client.WorkBalance() # WorkBalance | 
id = 56 # int | 

try:
    api_response = api_instance.workbalances_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkBalanceApi->workbalances_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkBalance**](WorkBalance.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkBalance**](WorkBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workbalances_post**
> WorkBalance workbalances_post(body)



Create WorkBalance

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkBalanceApi()
body = swagger_client.WorkBalance() # WorkBalance | 

try:
    api_response = api_instance.workbalances_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkBalanceApi->workbalances_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkBalance**](WorkBalance.md)|  | 

### Return type

[**WorkBalance**](WorkBalance.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

