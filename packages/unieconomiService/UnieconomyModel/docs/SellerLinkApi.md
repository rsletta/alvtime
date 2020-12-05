# swagger_client.SellerLinkApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sellerlinks_get**](SellerLinkApi.md#sellerlinks_get) | **GET** /sellerlinks | 
[**sellerlinks_id_delete**](SellerLinkApi.md#sellerlinks_id_delete) | **DELETE** /sellerlinks/{id} | 
[**sellerlinks_id_get**](SellerLinkApi.md#sellerlinks_id_get) | **GET** /sellerlinks/{id} | 
[**sellerlinks_id_put**](SellerLinkApi.md#sellerlinks_id_put) | **PUT** /sellerlinks/{id} | 
[**sellerlinks_post**](SellerLinkApi.md#sellerlinks_post) | **POST** /sellerlinks | 

# **sellerlinks_get**
> list[SellerLink] sellerlinks_get()



Query SellerLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerLinkApi()

try:
    api_response = api_instance.sellerlinks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerLinkApi->sellerlinks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SellerLink]**](SellerLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellerlinks_id_delete**
> SellerLink sellerlinks_id_delete(id)



Delete SellerLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerLinkApi()
id = 56 # int | 

try:
    api_response = api_instance.sellerlinks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerLinkApi->sellerlinks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SellerLink**](SellerLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellerlinks_id_get**
> SellerLink sellerlinks_id_get(id)



Get SellerLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerLinkApi()
id = 56 # int | 

try:
    api_response = api_instance.sellerlinks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerLinkApi->sellerlinks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SellerLink**](SellerLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellerlinks_id_put**
> SellerLink sellerlinks_id_put(body, id)



Update SellerLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerLinkApi()
body = swagger_client.SellerLink() # SellerLink | 
id = 56 # int | 

try:
    api_response = api_instance.sellerlinks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerLinkApi->sellerlinks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SellerLink**](SellerLink.md)|  | 
 **id** | **int**|  | 

### Return type

[**SellerLink**](SellerLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sellerlinks_post**
> SellerLink sellerlinks_post(body)



Create SellerLink

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SellerLinkApi()
body = swagger_client.SellerLink() # SellerLink | 

try:
    api_response = api_instance.sellerlinks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SellerLinkApi->sellerlinks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SellerLink**](SellerLink.md)|  | 

### Return type

[**SellerLink**](SellerLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

