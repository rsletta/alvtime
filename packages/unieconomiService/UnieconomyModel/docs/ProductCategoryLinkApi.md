# swagger_client.ProductCategoryLinkApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**productcategorylinks_get**](ProductCategoryLinkApi.md#productcategorylinks_get) | **GET** /productcategorylinks | 
[**productcategorylinks_id_delete**](ProductCategoryLinkApi.md#productcategorylinks_id_delete) | **DELETE** /productcategorylinks/{id} | 
[**productcategorylinks_id_get**](ProductCategoryLinkApi.md#productcategorylinks_id_get) | **GET** /productcategorylinks/{id} | 
[**productcategorylinks_id_put**](ProductCategoryLinkApi.md#productcategorylinks_id_put) | **PUT** /productcategorylinks/{id} | 
[**productcategorylinks_post**](ProductCategoryLinkApi.md#productcategorylinks_post) | **POST** /productcategorylinks | 

# **productcategorylinks_get**
> list[ProductCategoryLink] productcategorylinks_get()



Query ProductCategoryLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryLinkApi()

try:
    api_response = api_instance.productcategorylinks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryLinkApi->productcategorylinks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProductCategoryLink]**](ProductCategoryLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategorylinks_id_delete**
> ProductCategoryLink productcategorylinks_id_delete(id)



Delete ProductCategoryLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryLinkApi()
id = 56 # int | 

try:
    api_response = api_instance.productcategorylinks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryLinkApi->productcategorylinks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProductCategoryLink**](ProductCategoryLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategorylinks_id_get**
> ProductCategoryLink productcategorylinks_id_get(id)



Get ProductCategoryLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryLinkApi()
id = 56 # int | 

try:
    api_response = api_instance.productcategorylinks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryLinkApi->productcategorylinks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProductCategoryLink**](ProductCategoryLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategorylinks_id_put**
> ProductCategoryLink productcategorylinks_id_put(body, id)



Update ProductCategoryLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryLinkApi()
body = swagger_client.ProductCategoryLink() # ProductCategoryLink | 
id = 56 # int | 

try:
    api_response = api_instance.productcategorylinks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryLinkApi->productcategorylinks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCategoryLink**](ProductCategoryLink.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProductCategoryLink**](ProductCategoryLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **productcategorylinks_post**
> ProductCategoryLink productcategorylinks_post(body)



Create ProductCategoryLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProductCategoryLinkApi()
body = swagger_client.ProductCategoryLink() # ProductCategoryLink | 

try:
    api_response = api_instance.productcategorylinks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProductCategoryLinkApi->productcategorylinks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductCategoryLink**](ProductCategoryLink.md)|  | 

### Return type

[**ProductCategoryLink**](ProductCategoryLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

