# swagger_client.ProductCategoryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**productcategories_get**](ProductCategoryApi.md#productcategories_get) | **GET** /productcategories | 
[**productcategories_id_delete**](ProductCategoryApi.md#productcategories_id_delete) | **DELETE** /productcategories/{id} | 
[**productcategories_id_get**](ProductCategoryApi.md#productcategories_id_get) | **GET** /productcategories/{id} | 
[**productcategories_id_put**](ProductCategoryApi.md#productcategories_id_put) | **PUT** /productcategories/{id} | 
[**productcategories_post**](ProductCategoryApi.md#productcategories_post) | **POST** /productcategories | 

# **productcategories_get**
> list[ProductCategory] productcategories_get()



Query ProductCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryApi()

try:
    api_response = api_instance.productcategories_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryApi->productcategories_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProductCategory]**](ProductCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategories_id_delete**
> ProductCategory productcategories_id_delete(id)



Delete ProductCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.productcategories_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryApi->productcategories_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProductCategory**](ProductCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategories_id_get**
> ProductCategory productcategories_id_get(id)



Get ProductCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryApi()
id = 56 # int | 

try:
    api_response = api_instance.productcategories_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryApi->productcategories_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProductCategory**](ProductCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategories_id_put**
> ProductCategory productcategories_id_put(body, id)



Update ProductCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryApi()
body = swagger_client.ProductCategory() # ProductCategory | 
id = 56 # int | 

try:
    api_response = api_instance.productcategories_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryApi->productcategories_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCategory**](ProductCategory.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProductCategory**](ProductCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategories_post**
> ProductCategory productcategories_post(body)



Create ProductCategory

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryApi()
body = swagger_client.ProductCategory() # ProductCategory | 

try:
    api_response = api_instance.productcategories_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryApi->productcategories_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCategory**](ProductCategory.md)|  | 

### Return type

[**ProductCategory**](ProductCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

