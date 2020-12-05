# swagger_client.SellerApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sellers_get**](SellerApi.md#sellers_get) | **GET** /sellers | 
[**sellers_id_delete**](SellerApi.md#sellers_id_delete) | **DELETE** /sellers/{id} | 
[**sellers_id_get**](SellerApi.md#sellers_id_get) | **GET** /sellers/{id} | 
[**sellers_id_put**](SellerApi.md#sellers_id_put) | **PUT** /sellers/{id} | 
[**sellers_post**](SellerApi.md#sellers_post) | **POST** /sellers | 

# **sellers_get**
> list[Seller] sellers_get()



Query Seller

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerApi()

try:
    api_response = api_instance.sellers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerApi->sellers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Seller]**](Seller.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellers_id_delete**
> Seller sellers_id_delete(id)



Delete Seller

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerApi()
id = 56 # int | 

try:
    api_response = api_instance.sellers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerApi->sellers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Seller**](Seller.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellers_id_get**
> Seller sellers_id_get(id)



Get Seller

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerApi()
id = 56 # int | 

try:
    api_response = api_instance.sellers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerApi->sellers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Seller**](Seller.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellers_id_put**
> Seller sellers_id_put(body, id)



Update Seller

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerApi()
body = swagger_client.Seller() # Seller | 
id = 56 # int | 

try:
    api_response = api_instance.sellers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerApi->sellers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Seller**](Seller.md)|  | 
 **id** | **int**|  | 

### Return type

[**Seller**](Seller.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellers_post**
> Seller sellers_post(body)



Create Seller

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerApi()
body = swagger_client.Seller() # Seller | 

try:
    api_response = api_instance.sellers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerApi->sellers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Seller**](Seller.md)|  | 

### Return type

[**Seller**](Seller.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

