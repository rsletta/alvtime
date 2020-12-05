# swagger_client.VatDeductionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vatdeductions_get**](VatDeductionApi.md#vatdeductions_get) | **GET** /vatdeductions | 
[**vatdeductions_id_delete**](VatDeductionApi.md#vatdeductions_id_delete) | **DELETE** /vatdeductions/{id} | 
[**vatdeductions_id_get**](VatDeductionApi.md#vatdeductions_id_get) | **GET** /vatdeductions/{id} | 
[**vatdeductions_id_put**](VatDeductionApi.md#vatdeductions_id_put) | **PUT** /vatdeductions/{id} | 
[**vatdeductions_post**](VatDeductionApi.md#vatdeductions_post) | **POST** /vatdeductions | 

# **vatdeductions_get**
> list[VatDeduction] vatdeductions_get()



Query VatDeduction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionApi()

try:
    api_response = api_instance.vatdeductions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionApi->vatdeductions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatDeduction]**](VatDeduction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductions_id_delete**
> VatDeduction vatdeductions_id_delete(id)



Delete VatDeduction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionApi()
id = 56 # int | 

try:
    api_response = api_instance.vatdeductions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionApi->vatdeductions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatDeduction**](VatDeduction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductions_id_get**
> VatDeduction vatdeductions_id_get(id)



Get VatDeduction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionApi()
id = 56 # int | 

try:
    api_response = api_instance.vatdeductions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionApi->vatdeductions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatDeduction**](VatDeduction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductions_id_put**
> VatDeduction vatdeductions_id_put(body, id)



Update VatDeduction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionApi()
body = swagger_client.VatDeduction() # VatDeduction | 
id = 56 # int | 

try:
    api_response = api_instance.vatdeductions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionApi->vatdeductions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatDeduction**](VatDeduction.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatDeduction**](VatDeduction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vatdeductions_post**
> VatDeduction vatdeductions_post(body)



Create VatDeduction

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatDeductionApi()
body = swagger_client.VatDeduction() # VatDeduction | 

try:
    api_response = api_instance.vatdeductions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatDeductionApi->vatdeductions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatDeduction**](VatDeduction.md)|  | 

### Return type

[**VatDeduction**](VatDeduction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

