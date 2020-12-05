# swagger_client.ModelApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**models_get**](ModelApi.md#models_get) | **GET** /models | 
[**models_id_get**](ModelApi.md#models_id_get) | **GET** /models/{id} | 
[**models_id_put**](ModelApi.md#models_id_put) | **PUT** /models/{id} | 

# **models_get**
> list[Model] models_get()



Query Model

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ModelApi()

try:
    api_response = api_instance.models_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ModelApi->models_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Model]**](Model.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **models_id_get**
> Model models_id_get(id)



Get Model

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ModelApi()
id = 56 # int | 

try:
    api_response = api_instance.models_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ModelApi->models_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Model**](Model.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **models_id_put**
> Model models_id_put(body, id)



Update Model

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ModelApi()
body = swagger_client.Model() # Model | 
id = 56 # int | 

try:
    api_response = api_instance.models_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ModelApi->models_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Model**](Model.md)|  | 
 **id** | **int**|  | 

### Return type

[**Model**](Model.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

