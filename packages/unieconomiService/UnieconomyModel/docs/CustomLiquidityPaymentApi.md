# swagger_client.CustomLiquidityPaymentApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**liquiditypayment_get**](CustomLiquidityPaymentApi.md#liquiditypayment_get) | **GET** /liquiditypayment | 
[**liquiditypayment_id_delete**](CustomLiquidityPaymentApi.md#liquiditypayment_id_delete) | **DELETE** /liquiditypayment/{id} | 
[**liquiditypayment_id_get**](CustomLiquidityPaymentApi.md#liquiditypayment_id_get) | **GET** /liquiditypayment/{id} | 
[**liquiditypayment_id_put**](CustomLiquidityPaymentApi.md#liquiditypayment_id_put) | **PUT** /liquiditypayment/{id} | 
[**liquiditypayment_post**](CustomLiquidityPaymentApi.md#liquiditypayment_post) | **POST** /liquiditypayment | 
[**liquiditypaymentactionget_liquidity_table_data_get**](CustomLiquidityPaymentApi.md#liquiditypaymentactionget_liquidity_table_data_get) | **GET** /liquiditypayment?action&#x3D;getLiquidityTableData | 

# **liquiditypayment_get**
> list[CustomLiquidityPayment] liquiditypayment_get()



Query CustomLiquidityPayment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()

try:
    api_response = api_instance.liquiditypayment_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypayment_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomLiquidityPayment]**](CustomLiquidityPayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **liquiditypayment_id_delete**
> CustomLiquidityPayment liquiditypayment_id_delete(id)



Delete CustomLiquidityPayment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()
id = 56 # int | 

try:
    api_response = api_instance.liquiditypayment_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypayment_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomLiquidityPayment**](CustomLiquidityPayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **liquiditypayment_id_get**
> CustomLiquidityPayment liquiditypayment_id_get(id)



Get CustomLiquidityPayment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()
id = 56 # int | 

try:
    api_response = api_instance.liquiditypayment_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypayment_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomLiquidityPayment**](CustomLiquidityPayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **liquiditypayment_id_put**
> CustomLiquidityPayment liquiditypayment_id_put(body, id)



Update CustomLiquidityPayment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()
body = swagger_client.CustomLiquidityPayment() # CustomLiquidityPayment | 
id = 56 # int | 

try:
    api_response = api_instance.liquiditypayment_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypayment_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomLiquidityPayment**](CustomLiquidityPayment.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomLiquidityPayment**](CustomLiquidityPayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **liquiditypayment_post**
> CustomLiquidityPayment liquiditypayment_post(body)



Create CustomLiquidityPayment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()
body = swagger_client.CustomLiquidityPayment() # CustomLiquidityPayment | 

try:
    api_response = api_instance.liquiditypayment_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypayment_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomLiquidityPayment**](CustomLiquidityPayment.md)|  | 

### Return type

[**CustomLiquidityPayment**](CustomLiquidityPayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **liquiditypaymentactionget_liquidity_table_data_get**
> LiquidityTableDTO liquiditypaymentactionget_liquidity_table_data_get()



getLiquidityTableData Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomLiquidityPaymentApi()

try:
    api_response = api_instance.liquiditypaymentactionget_liquidity_table_data_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomLiquidityPaymentApi->liquiditypaymentactionget_liquidity_table_data_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**LiquidityTableDTO**](LiquidityTableDTO.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

