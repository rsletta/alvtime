# swagger_client.AccrualApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accruals_get**](AccrualApi.md#accruals_get) | **GET** /accruals | 
[**accruals_id_delete**](AccrualApi.md#accruals_id_delete) | **DELETE** /accruals/{id} | 
[**accruals_id_get**](AccrualApi.md#accruals_id_get) | **GET** /accruals/{id} | 
[**accruals_id_put**](AccrualApi.md#accruals_id_put) | **PUT** /accruals/{id} | 
[**accruals_post**](AccrualApi.md#accruals_post) | **POST** /accruals | 

# **accruals_get**
> list[Accrual] accruals_get()



Query Accrual

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccrualApi()

try:
    api_response = api_instance.accruals_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccrualApi->accruals_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Accrual]**](Accrual.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accruals_id_delete**
> Accrual accruals_id_delete(id)



Delete Accrual

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccrualApi()
id = 56 # int | 

try:
    api_response = api_instance.accruals_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccrualApi->accruals_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Accrual**](Accrual.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accruals_id_get**
> Accrual accruals_id_get(id)



Get Accrual

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccrualApi()
id = 56 # int | 

try:
    api_response = api_instance.accruals_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccrualApi->accruals_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Accrual**](Accrual.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accruals_id_put**
> Accrual accruals_id_put(body, id)



Update Accrual

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccrualApi()
body = swagger_client.Accrual() # Accrual | 
id = 56 # int | 

try:
    api_response = api_instance.accruals_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccrualApi->accruals_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Accrual**](Accrual.md)|  | 
 **id** | **int**|  | 

### Return type

[**Accrual**](Accrual.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accruals_post**
> Accrual accruals_post(body)



Create Accrual

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccrualApi()
body = swagger_client.Accrual() # Accrual | 

try:
    api_response = api_instance.accruals_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccrualApi->accruals_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Accrual**](Accrual.md)|  | 

### Return type

[**Accrual**](Accrual.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

