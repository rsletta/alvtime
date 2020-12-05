# swagger_client.ContractParameterApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contractparameters_get**](ContractParameterApi.md#contractparameters_get) | **GET** /contractparameters | 
[**contractparameters_id_delete**](ContractParameterApi.md#contractparameters_id_delete) | **DELETE** /contractparameters/{id} | 
[**contractparameters_id_get**](ContractParameterApi.md#contractparameters_id_get) | **GET** /contractparameters/{id} | 
[**contractparameters_id_put**](ContractParameterApi.md#contractparameters_id_put) | **PUT** /contractparameters/{id} | 
[**contractparameters_post**](ContractParameterApi.md#contractparameters_post) | **POST** /contractparameters | 

# **contractparameters_get**
> list[ContractParameter] contractparameters_get()



Query ContractParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractParameterApi()

try:
    api_response = api_instance.contractparameters_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractParameterApi->contractparameters_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractParameter]**](ContractParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractparameters_id_delete**
> ContractParameter contractparameters_id_delete(id)



Delete ContractParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractParameterApi()
id = 56 # int | 

try:
    api_response = api_instance.contractparameters_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractParameterApi->contractparameters_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractParameter**](ContractParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractparameters_id_get**
> ContractParameter contractparameters_id_get(id)



Get ContractParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractParameterApi()
id = 56 # int | 

try:
    api_response = api_instance.contractparameters_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractParameterApi->contractparameters_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractParameter**](ContractParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractparameters_id_put**
> ContractParameter contractparameters_id_put(body, id)



Update ContractParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractParameterApi()
body = swagger_client.ContractParameter() # ContractParameter | 
id = 56 # int | 

try:
    api_response = api_instance.contractparameters_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractParameterApi->contractparameters_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractParameter**](ContractParameter.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractParameter**](ContractParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractparameters_post**
> ContractParameter contractparameters_post(body)



Create ContractParameter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractParameterApi()
body = swagger_client.ContractParameter() # ContractParameter | 

try:
    api_response = api_instance.contractparameters_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractParameterApi->contractparameters_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractParameter**](ContractParameter.md)|  | 

### Return type

[**ContractParameter**](ContractParameter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

