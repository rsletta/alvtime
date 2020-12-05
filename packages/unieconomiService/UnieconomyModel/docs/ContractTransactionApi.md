# swagger_client.ContractTransactionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contracttransactions_get**](ContractTransactionApi.md#contracttransactions_get) | **GET** /contracttransactions | 
[**contracttransactions_id_delete**](ContractTransactionApi.md#contracttransactions_id_delete) | **DELETE** /contracttransactions/{id} | 
[**contracttransactions_id_get**](ContractTransactionApi.md#contracttransactions_id_get) | **GET** /contracttransactions/{id} | 
[**contracttransactions_id_put**](ContractTransactionApi.md#contracttransactions_id_put) | **PUT** /contracttransactions/{id} | 
[**contracttransactions_post**](ContractTransactionApi.md#contracttransactions_post) | **POST** /contracttransactions | 

# **contracttransactions_get**
> list[ContractTransaction] contracttransactions_get()



Query ContractTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTransactionApi()

try:
    api_response = api_instance.contracttransactions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTransactionApi->contracttransactions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractTransaction]**](ContractTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttransactions_id_delete**
> ContractTransaction contracttransactions_id_delete(id)



Delete ContractTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTransactionApi()
id = 56 # int | 

try:
    api_response = api_instance.contracttransactions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTransactionApi->contracttransactions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractTransaction**](ContractTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttransactions_id_get**
> ContractTransaction contracttransactions_id_get(id)



Get ContractTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTransactionApi()
id = 56 # int | 

try:
    api_response = api_instance.contracttransactions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTransactionApi->contracttransactions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractTransaction**](ContractTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttransactions_id_put**
> ContractTransaction contracttransactions_id_put(body, id)



Update ContractTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTransactionApi()
body = swagger_client.ContractTransaction() # ContractTransaction | 
id = 56 # int | 

try:
    api_response = api_instance.contracttransactions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTransactionApi->contracttransactions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractTransaction**](ContractTransaction.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractTransaction**](ContractTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracttransactions_post**
> ContractTransaction contracttransactions_post(body)



Create ContractTransaction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractTransactionApi()
body = swagger_client.ContractTransaction() # ContractTransaction | 

try:
    api_response = api_instance.contracttransactions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractTransactionApi->contracttransactions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractTransaction**](ContractTransaction.md)|  | 

### Return type

[**ContractTransaction**](ContractTransaction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

