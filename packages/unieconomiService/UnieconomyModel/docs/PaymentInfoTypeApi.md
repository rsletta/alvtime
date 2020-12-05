# swagger_client.PaymentInfoTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**paymentinfotype_get**](PaymentInfoTypeApi.md#paymentinfotype_get) | **GET** /paymentinfotype | 
[**paymentinfotype_id_delete**](PaymentInfoTypeApi.md#paymentinfotype_id_delete) | **DELETE** /paymentinfotype/{id} | 
[**paymentinfotype_id_get**](PaymentInfoTypeApi.md#paymentinfotype_id_get) | **GET** /paymentinfotype/{id} | 
[**paymentinfotype_id_put**](PaymentInfoTypeApi.md#paymentinfotype_id_put) | **PUT** /paymentinfotype/{id} | 
[**paymentinfotype_post**](PaymentInfoTypeApi.md#paymentinfotype_post) | **POST** /paymentinfotype | 
[**paymentinfotypeactionactivate_paymentinfotype_put**](PaymentInfoTypeApi.md#paymentinfotypeactionactivate_paymentinfotype_put) | **PUT** /paymentinfotype?action&#x3D;activate-paymentinfotype | 
[**paymentinfotypeactiondeactivate_paymentinfotype_put**](PaymentInfoTypeApi.md#paymentinfotypeactiondeactivate_paymentinfotype_put) | **PUT** /paymentinfotype?action&#x3D;deactivate-paymentinfotype | 
[**paymentinfotypeactionget_paymentinfotype_parts_macros_get**](PaymentInfoTypeApi.md#paymentinfotypeactionget_paymentinfotype_parts_macros_get) | **GET** /paymentinfotype?action&#x3D;get-paymentinfotype-parts-macros | 
[**paymentinfotypeactionvalidate_get_paymentinfo_get**](PaymentInfoTypeApi.md#paymentinfotypeactionvalidate_get_paymentinfo_get) | **GET** /paymentinfotype?action&#x3D;validate-get-paymentinfo | 

# **paymentinfotype_get**
> list[PaymentInfoType] paymentinfotype_get()



Query PaymentInfoType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()

try:
    api_response = api_instance.paymentinfotype_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotype_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PaymentInfoType]**](PaymentInfoType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotype_id_delete**
> PaymentInfoType paymentinfotype_id_delete(id)



Delete PaymentInfoType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.paymentinfotype_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotype_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentInfoType**](PaymentInfoType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotype_id_get**
> PaymentInfoType paymentinfotype_id_get(id)



Get PaymentInfoType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.paymentinfotype_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotype_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentInfoType**](PaymentInfoType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotype_id_put**
> PaymentInfoType paymentinfotype_id_put(body, id)



Update PaymentInfoType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
body = swagger_client.PaymentInfoType() # PaymentInfoType | 
id = 56 # int | 

try:
    api_response = api_instance.paymentinfotype_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotype_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentInfoType**](PaymentInfoType.md)|  | 
 **id** | **int**|  | 

### Return type

[**PaymentInfoType**](PaymentInfoType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotype_post**
> PaymentInfoType paymentinfotype_post(body)



Create PaymentInfoType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
body = swagger_client.PaymentInfoType() # PaymentInfoType | 

try:
    api_response = api_instance.paymentinfotype_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotype_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentInfoType**](PaymentInfoType.md)|  | 

### Return type

[**PaymentInfoType**](PaymentInfoType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotypeactionactivate_paymentinfotype_put**
> object paymentinfotypeactionactivate_paymentinfotype_put(id)



activate-paymentinfotype Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentinfotypeactionactivate_paymentinfotype_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotypeactionactivate_paymentinfotype_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotypeactiondeactivate_paymentinfotype_put**
> object paymentinfotypeactiondeactivate_paymentinfotype_put(id)



deactivate-paymentinfotype Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentinfotypeactiondeactivate_paymentinfotype_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotypeactiondeactivate_paymentinfotype_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotypeactionget_paymentinfotype_parts_macros_get**
> str paymentinfotypeactionget_paymentinfotype_parts_macros_get()



get-paymentinfotype-parts-macros Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()

try:
    api_response = api_instance.paymentinfotypeactionget_paymentinfotype_parts_macros_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotypeactionget_paymentinfotype_parts_macros_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentinfotypeactionvalidate_get_paymentinfo_get**
> str paymentinfotypeactionvalidate_get_paymentinfo_get(customer_invoice, payment_info_type_id)



validate-get-paymentinfo Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentInfoTypeApi()
customer_invoice = swagger_client.Object() # Object | 
payment_info_type_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentinfotypeactionvalidate_get_paymentinfo_get(customer_invoice, payment_info_type_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentInfoTypeApi->paymentinfotypeactionvalidate_get_paymentinfo_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_invoice** | [**Object**](.md)|  | 
 **payment_info_type_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

