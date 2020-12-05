# swagger_client.ContractAddressApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contractaddresses_get**](ContractAddressApi.md#contractaddresses_get) | **GET** /contractaddresses | 
[**contractaddresses_id_delete**](ContractAddressApi.md#contractaddresses_id_delete) | **DELETE** /contractaddresses/{id} | 
[**contractaddresses_id_get**](ContractAddressApi.md#contractaddresses_id_get) | **GET** /contractaddresses/{id} | 
[**contractaddresses_id_put**](ContractAddressApi.md#contractaddresses_id_put) | **PUT** /contractaddresses/{id} | 
[**contractaddresses_post**](ContractAddressApi.md#contractaddresses_post) | **POST** /contractaddresses | 

# **contractaddresses_get**
> list[ContractAddress] contractaddresses_get()



Query ContractAddress

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAddressApi()

try:
    api_response = api_instance.contractaddresses_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAddressApi->contractaddresses_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractAddress]**](ContractAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractaddresses_id_delete**
> ContractAddress contractaddresses_id_delete(id)



Delete ContractAddress

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAddressApi()
id = 56 # int | 

try:
    api_response = api_instance.contractaddresses_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAddressApi->contractaddresses_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractAddress**](ContractAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractaddresses_id_get**
> ContractAddress contractaddresses_id_get(id)



Get ContractAddress

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAddressApi()
id = 56 # int | 

try:
    api_response = api_instance.contractaddresses_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAddressApi->contractaddresses_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractAddress**](ContractAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractaddresses_id_put**
> ContractAddress contractaddresses_id_put(body, id)



Update ContractAddress

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAddressApi()
body = swagger_client.ContractAddress() # ContractAddress | 
id = 56 # int | 

try:
    api_response = api_instance.contractaddresses_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAddressApi->contractaddresses_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractAddress**](ContractAddress.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractAddress**](ContractAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractaddresses_post**
> ContractAddress contractaddresses_post(body)



Create ContractAddress

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractAddressApi()
body = swagger_client.ContractAddress() # ContractAddress | 

try:
    api_response = api_instance.contractaddresses_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractAddressApi->contractaddresses_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractAddress**](ContractAddress.md)|  | 

### Return type

[**ContractAddress**](ContractAddress.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

