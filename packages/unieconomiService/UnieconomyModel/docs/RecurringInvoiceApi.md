# swagger_client.RecurringInvoiceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**recurringinvoices_get**](RecurringInvoiceApi.md#recurringinvoices_get) | **GET** /recurringinvoices | 
[**recurringinvoices_id_delete**](RecurringInvoiceApi.md#recurringinvoices_id_delete) | **DELETE** /recurringinvoices/{id} | 
[**recurringinvoices_id_get**](RecurringInvoiceApi.md#recurringinvoices_id_get) | **GET** /recurringinvoices/{id} | 
[**recurringinvoices_id_put**](RecurringInvoiceApi.md#recurringinvoices_id_put) | **PUT** /recurringinvoices/{id} | 
[**recurringinvoices_idactionactivate_post**](RecurringInvoiceApi.md#recurringinvoices_idactionactivate_post) | **POST** /recurringinvoices/{id}?action&#x3D;activate | 
[**recurringinvoices_idactiondeactivate_post**](RecurringInvoiceApi.md#recurringinvoices_idactiondeactivate_post) | **POST** /recurringinvoices/{id}?action&#x3D;deactivate | 
[**recurringinvoices_idactionexecute_post**](RecurringInvoiceApi.md#recurringinvoices_idactionexecute_post) | **POST** /recurringinvoices/{id}?action&#x3D;execute | 
[**recurringinvoices_post**](RecurringInvoiceApi.md#recurringinvoices_post) | **POST** /recurringinvoices | 

# **recurringinvoices_get**
> list[RecurringInvoice] recurringinvoices_get()



Query RecurringInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()

try:
    api_response = api_instance.recurringinvoices_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[RecurringInvoice]**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoices_id_delete**
> RecurringInvoice recurringinvoices_id_delete(id)



Delete RecurringInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.recurringinvoices_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoices_id_get**
> RecurringInvoice recurringinvoices_id_get(id)



Get RecurringInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.recurringinvoices_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoices_id_put**
> RecurringInvoice recurringinvoices_id_put(body, id)



Update RecurringInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
body = swagger_client.RecurringInvoice() # RecurringInvoice | 
id = 56 # int | 

try:
    api_response = api_instance.recurringinvoices_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecurringInvoice**](RecurringInvoice.md)|  | 
 **id** | **int**|  | 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoices_idactionactivate_post**
> object recurringinvoices_idactionactivate_post(id, id)



activate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.recurringinvoices_idactionactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_idactionactivate_post: %s\n" % e)
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

# **recurringinvoices_idactiondeactivate_post**
> object recurringinvoices_idactiondeactivate_post(id, id)



deactivate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.recurringinvoices_idactiondeactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_idactiondeactivate_post: %s\n" % e)
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

# **recurringinvoices_idactionexecute_post**
> RecurringInvoiceLog recurringinvoices_idactionexecute_post(id, id)



execute Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.recurringinvoices_idactionexecute_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_idactionexecute_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**RecurringInvoiceLog**](RecurringInvoiceLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoices_post**
> RecurringInvoice recurringinvoices_post(body)



Create RecurringInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceApi()
body = swagger_client.RecurringInvoice() # RecurringInvoice | 

try:
    api_response = api_instance.recurringinvoices_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceApi->recurringinvoices_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RecurringInvoice**](RecurringInvoice.md)|  | 

### Return type

[**RecurringInvoice**](RecurringInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

