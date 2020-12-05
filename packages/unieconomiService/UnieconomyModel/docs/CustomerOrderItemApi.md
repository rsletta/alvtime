# swagger_client.CustomerOrderItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orderitems_get**](CustomerOrderItemApi.md#orderitems_get) | **GET** /orderitems | 
[**orderitems_id_delete**](CustomerOrderItemApi.md#orderitems_id_delete) | **DELETE** /orderitems/{id} | 
[**orderitems_id_get**](CustomerOrderItemApi.md#orderitems_id_get) | **GET** /orderitems/{id} | 
[**orderitems_id_put**](CustomerOrderItemApi.md#orderitems_id_put) | **PUT** /orderitems/{id} | 
[**orderitems_idactioncomplete_post**](CustomerOrderItemApi.md#orderitems_idactioncomplete_post) | **POST** /orderitems/{id}?action&#x3D;complete | 
[**orderitems_idactionregister_post**](CustomerOrderItemApi.md#orderitems_idactionregister_post) | **POST** /orderitems/{id}?action&#x3D;register | 
[**orderitems_idactionto_invoice_post**](CustomerOrderItemApi.md#orderitems_idactionto_invoice_post) | **POST** /orderitems/{id}?action&#x3D;toInvoice | 
[**orderitems_post**](CustomerOrderItemApi.md#orderitems_post) | **POST** /orderitems | 

# **orderitems_get**
> list[CustomerOrderItem] orderitems_get()



Query CustomerOrderItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()

try:
    api_response = api_instance.orderitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerOrderItem]**](CustomerOrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_id_delete**
> CustomerOrderItem orderitems_id_delete(id)



Delete CustomerOrderItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
id = 56 # int | 

try:
    api_response = api_instance.orderitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrderItem**](CustomerOrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_id_get**
> CustomerOrderItem orderitems_id_get(id)



Get CustomerOrderItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
id = 56 # int | 

try:
    api_response = api_instance.orderitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrderItem**](CustomerOrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_id_put**
> CustomerOrderItem orderitems_id_put(body, id)



Update CustomerOrderItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
body = swagger_client.CustomerOrderItem() # CustomerOrderItem | 
id = 56 # int | 

try:
    api_response = api_instance.orderitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerOrderItem**](CustomerOrderItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerOrderItem**](CustomerOrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_idactioncomplete_post**
> object orderitems_idactioncomplete_post(id, id)



complete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orderitems_idactioncomplete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_idactioncomplete_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_idactionregister_post**
> object orderitems_idactionregister_post(id, id)



register Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orderitems_idactionregister_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_idactionregister_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_idactionto_invoice_post**
> object orderitems_idactionto_invoice_post(id, id)



toInvoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orderitems_idactionto_invoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_idactionto_invoice_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orderitems_post**
> CustomerOrderItem orderitems_post(body)



Create CustomerOrderItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderItemApi()
body = swagger_client.CustomerOrderItem() # CustomerOrderItem | 

try:
    api_response = api_instance.orderitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderItemApi->orderitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerOrderItem**](CustomerOrderItem.md)|  | 

### Return type

[**CustomerOrderItem**](CustomerOrderItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

