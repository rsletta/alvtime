# swagger_client.CustomerQuoteItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**quoteitems_get**](CustomerQuoteItemApi.md#quoteitems_get) | **GET** /quoteitems | 
[**quoteitems_id_delete**](CustomerQuoteItemApi.md#quoteitems_id_delete) | **DELETE** /quoteitems/{id} | 
[**quoteitems_id_get**](CustomerQuoteItemApi.md#quoteitems_id_get) | **GET** /quoteitems/{id} | 
[**quoteitems_id_put**](CustomerQuoteItemApi.md#quoteitems_id_put) | **PUT** /quoteitems/{id} | 
[**quoteitems_post**](CustomerQuoteItemApi.md#quoteitems_post) | **POST** /quoteitems | 

# **quoteitems_get**
> list[CustomerQuoteItem] quoteitems_get()



Query CustomerQuoteItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteItemApi()

try:
    api_response = api_instance.quoteitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteItemApi->quoteitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerQuoteItem]**](CustomerQuoteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_id_delete**
> CustomerQuoteItem quoteitems_id_delete(id)



Delete CustomerQuoteItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteItemApi()
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteItemApi->quoteitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuoteItem**](CustomerQuoteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_id_get**
> CustomerQuoteItem quoteitems_id_get(id)



Get CustomerQuoteItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteItemApi()
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteItemApi->quoteitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuoteItem**](CustomerQuoteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_id_put**
> CustomerQuoteItem quoteitems_id_put(body, id)



Update CustomerQuoteItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteItemApi()
body = swagger_client.CustomerQuoteItem() # CustomerQuoteItem | 
id = 56 # int | 

try:
    api_response = api_instance.quoteitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteItemApi->quoteitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerQuoteItem**](CustomerQuoteItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerQuoteItem**](CustomerQuoteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quoteitems_post**
> CustomerQuoteItem quoteitems_post(body)



Create CustomerQuoteItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteItemApi()
body = swagger_client.CustomerQuoteItem() # CustomerQuoteItem | 

try:
    api_response = api_instance.quoteitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteItemApi->quoteitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerQuoteItem**](CustomerQuoteItem.md)|  | 

### Return type

[**CustomerQuoteItem**](CustomerQuoteItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

