# swagger_client.PaymentCodeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**payment_codes_get**](PaymentCodeApi.md#payment_codes_get) | **GET** /paymentCodes | 
[**payment_codes_id_delete**](PaymentCodeApi.md#payment_codes_id_delete) | **DELETE** /paymentCodes/{id} | 
[**payment_codes_id_get**](PaymentCodeApi.md#payment_codes_id_get) | **GET** /paymentCodes/{id} | 
[**payment_codes_id_put**](PaymentCodeApi.md#payment_codes_id_put) | **PUT** /paymentCodes/{id} | 
[**payment_codes_post**](PaymentCodeApi.md#payment_codes_post) | **POST** /paymentCodes | 

# **payment_codes_get**
> list[PaymentCode] payment_codes_get()



Query PaymentCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentCodeApi()

try:
    api_response = api_instance.payment_codes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentCodeApi->payment_codes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PaymentCode]**](PaymentCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payment_codes_id_delete**
> PaymentCode payment_codes_id_delete(id)



Delete PaymentCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.payment_codes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentCodeApi->payment_codes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentCode**](PaymentCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payment_codes_id_get**
> PaymentCode payment_codes_id_get(id)



Get PaymentCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.payment_codes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentCodeApi->payment_codes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentCode**](PaymentCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payment_codes_id_put**
> PaymentCode payment_codes_id_put(body, id)



Update PaymentCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentCodeApi()
body = swagger_client.PaymentCode() # PaymentCode | 
id = 56 # int | 

try:
    api_response = api_instance.payment_codes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentCodeApi->payment_codes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentCode**](PaymentCode.md)|  | 
 **id** | **int**|  | 

### Return type

[**PaymentCode**](PaymentCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payment_codes_post**
> PaymentCode payment_codes_post(body)



Create PaymentCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentCodeApi()
body = swagger_client.PaymentCode() # PaymentCode | 

try:
    api_response = api_instance.payment_codes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentCodeApi->payment_codes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentCode**](PaymentCode.md)|  | 

### Return type

[**PaymentCode**](PaymentCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

