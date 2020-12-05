# swagger_client.SalaryTransactionSupplementApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplements_get**](SalaryTransactionSupplementApi.md#supplements_get) | **GET** /supplements | 
[**supplements_id_get**](SalaryTransactionSupplementApi.md#supplements_id_get) | **GET** /supplements/{id} | 
[**supplements_id_put**](SalaryTransactionSupplementApi.md#supplements_id_put) | **PUT** /supplements/{id} | 

# **supplements_get**
> list[SalaryTransactionSupplement] supplements_get()



Query SalaryTransactionSupplement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSupplementApi()

try:
    api_response = api_instance.supplements_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSupplementApi->supplements_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SalaryTransactionSupplement]**](SalaryTransactionSupplement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplements_id_get**
> SalaryTransactionSupplement supplements_id_get(id)



Get SalaryTransactionSupplement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSupplementApi()
id = 56 # int | 

try:
    api_response = api_instance.supplements_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSupplementApi->supplements_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SalaryTransactionSupplement**](SalaryTransactionSupplement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplements_id_put**
> SalaryTransactionSupplement supplements_id_put(body, id)



Update SalaryTransactionSupplement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SalaryTransactionSupplementApi()
body = swagger_client.SalaryTransactionSupplement() # SalaryTransactionSupplement | 
id = 56 # int | 

try:
    api_response = api_instance.supplements_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SalaryTransactionSupplementApi->supplements_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SalaryTransactionSupplement**](SalaryTransactionSupplement.md)|  | 
 **id** | **int**|  | 

### Return type

[**SalaryTransactionSupplement**](SalaryTransactionSupplement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

