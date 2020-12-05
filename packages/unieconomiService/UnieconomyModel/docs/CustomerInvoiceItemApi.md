# swagger_client.CustomerInvoiceItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoiceitems_get**](CustomerInvoiceItemApi.md#invoiceitems_get) | **GET** /invoiceitems | 
[**invoiceitems_id_delete**](CustomerInvoiceItemApi.md#invoiceitems_id_delete) | **DELETE** /invoiceitems/{id} | 
[**invoiceitems_id_get**](CustomerInvoiceItemApi.md#invoiceitems_id_get) | **GET** /invoiceitems/{id} | 
[**invoiceitems_id_put**](CustomerInvoiceItemApi.md#invoiceitems_id_put) | **PUT** /invoiceitems/{id} | 
[**invoiceitems_idactioninvoice_post**](CustomerInvoiceItemApi.md#invoiceitems_idactioninvoice_post) | **POST** /invoiceitems/{id}?action&#x3D;invoice | 
[**invoiceitems_post**](CustomerInvoiceItemApi.md#invoiceitems_post) | **POST** /invoiceitems | 

# **invoiceitems_get**
> list[CustomerInvoiceItem] invoiceitems_get()



Query CustomerInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()

try:
    api_response = api_instance.invoiceitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceItem]**](CustomerInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_id_delete**
> CustomerInvoiceItem invoiceitems_id_delete(id)



Delete CustomerInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceItem**](CustomerInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_id_get**
> CustomerInvoiceItem invoiceitems_id_get(id)



Get CustomerInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceItem**](CustomerInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_id_put**
> CustomerInvoiceItem invoiceitems_id_put(body, id)



Update CustomerInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()
body = swagger_client.CustomerInvoiceItem() # CustomerInvoiceItem | 
id = 56 # int | 

try:
    api_response = api_instance.invoiceitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceItem**](CustomerInvoiceItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceItem**](CustomerInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceitems_idactioninvoice_post**
> object invoiceitems_idactioninvoice_post(id, id)



invoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoiceitems_idactioninvoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_idactioninvoice_post: %s\n" % e)
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

# **invoiceitems_post**
> CustomerInvoiceItem invoiceitems_post(body)



Create CustomerInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceItemApi()
body = swagger_client.CustomerInvoiceItem() # CustomerInvoiceItem | 

try:
    api_response = api_instance.invoiceitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceItemApi->invoiceitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceItem**](CustomerInvoiceItem.md)|  | 

### Return type

[**CustomerInvoiceItem**](CustomerInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

