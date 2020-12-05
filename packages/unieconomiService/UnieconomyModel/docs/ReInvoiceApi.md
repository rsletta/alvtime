# swagger_client.ReInvoiceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reinvoicing_get**](ReInvoiceApi.md#reinvoicing_get) | **GET** /reinvoicing | 
[**reinvoicing_id_delete**](ReInvoiceApi.md#reinvoicing_id_delete) | **DELETE** /reinvoicing/{id} | 
[**reinvoicing_id_get**](ReInvoiceApi.md#reinvoicing_id_get) | **GET** /reinvoicing/{id} | 
[**reinvoicing_id_put**](ReInvoiceApi.md#reinvoicing_id_put) | **PUT** /reinvoicing/{id} | 
[**reinvoicing_idactionallow_change_get**](ReInvoiceApi.md#reinvoicing_idactionallow_change_get) | **GET** /reinvoicing/{id}?action&#x3D;allow-change | 
[**reinvoicing_idactioncreate_invoices_draft_put**](ReInvoiceApi.md#reinvoicing_idactioncreate_invoices_draft_put) | **PUT** /reinvoicing/{id}?action&#x3D;create-invoices-draft | 
[**reinvoicing_idactioncreate_invoices_put**](ReInvoiceApi.md#reinvoicing_idactioncreate_invoices_put) | **PUT** /reinvoicing/{id}?action&#x3D;create-invoices | 
[**reinvoicing_idactioncreate_orders_put**](ReInvoiceApi.md#reinvoicing_idactioncreate_orders_put) | **PUT** /reinvoicing/{id}?action&#x3D;create-orders | 
[**reinvoicing_idactiondelete_put**](ReInvoiceApi.md#reinvoicing_idactiondelete_put) | **PUT** /reinvoicing/{id}?action&#x3D;delete | 
[**reinvoicing_post**](ReInvoiceApi.md#reinvoicing_post) | **POST** /reinvoicing | 
[**reinvoicingactiondelete_put**](ReInvoiceApi.md#reinvoicingactiondelete_put) | **PUT** /reinvoicing?action&#x3D;delete | 
[**reinvoicingactionmark_create_post**](ReInvoiceApi.md#reinvoicingactionmark_create_post) | **POST** /reinvoicing?action&#x3D;mark-create | 
[**reinvoicingactionvalid_message_put**](ReInvoiceApi.md#reinvoicingactionvalid_message_put) | **PUT** /reinvoicing?action&#x3D;valid-message | 
[**reinvoicingactionvalid_put**](ReInvoiceApi.md#reinvoicingactionvalid_put) | **PUT** /reinvoicing?action&#x3D;valid | 

# **reinvoicing_get**
> list[ReInvoice] reinvoicing_get()



Query ReInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()

try:
    api_response = api_instance.reinvoicing_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ReInvoice]**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_id_delete**
> ReInvoice reinvoicing_id_delete(id)



Delete ReInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.reinvoicing_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReInvoice**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_id_get**
> ReInvoice reinvoicing_id_get(id)



Get ReInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.reinvoicing_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ReInvoice**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_id_put**
> ReInvoice reinvoicing_id_put(body, id)



Update ReInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
body = swagger_client.ReInvoice() # ReInvoice | 
id = 56 # int | 

try:
    api_response = api_instance.reinvoicing_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReInvoice**](ReInvoice.md)|  | 
 **id** | **int**|  | 

### Return type

[**ReInvoice**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_idactionallow_change_get**
> bool reinvoicing_idactionallow_change_get(id)



allow-change Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.reinvoicing_idactionallow_change_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_idactionallow_change_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_idactioncreate_invoices_draft_put**
> int reinvoicing_idactioncreate_invoices_draft_put(id, body=body)



create-invoices-draft Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicing_idactioncreate_invoices_draft_put(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_idactioncreate_invoices_draft_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_idactioncreate_invoices_put**
> int reinvoicing_idactioncreate_invoices_put(id, body=body)



create-invoices Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicing_idactioncreate_invoices_put(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_idactioncreate_invoices_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_idactioncreate_orders_put**
> int reinvoicing_idactioncreate_orders_put(id, body=body)



create-orders Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicing_idactioncreate_orders_put(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_idactioncreate_orders_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_idactiondelete_put**
> str reinvoicing_idactiondelete_put(id)



delete Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.reinvoicing_idactiondelete_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_idactiondelete_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicing_post**
> ReInvoice reinvoicing_post(body)



Create ReInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
body = swagger_client.ReInvoice() # ReInvoice | 

try:
    api_response = api_instance.reinvoicing_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicing_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReInvoice**](ReInvoice.md)|  | 

### Return type

[**ReInvoice**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicingactiondelete_put**
> str reinvoicingactiondelete_put(body=body)



delete Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicingactiondelete_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicingactiondelete_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicingactionmark_create_post**
> ReInvoice reinvoicingactionmark_create_post(supplier_invoice_id, re_invoice_type, body=body)



mark-create Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
supplier_invoice_id = swagger_client.Object() # Object | 
re_invoice_type = swagger_client.Object() # Object | 
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicingactionmark_create_post(supplier_invoice_id, re_invoice_type, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicingactionmark_create_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_invoice_id** | [**Object**](.md)|  | 
 **re_invoice_type** | [**Object**](.md)|  | 
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

[**ReInvoice**](ReInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicingactionvalid_message_put**
> str reinvoicingactionvalid_message_put(body=body)



valid-message Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicingactionvalid_message_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicingactionvalid_message_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **reinvoicingactionvalid_put**
> bool reinvoicingactionvalid_put(body=body)



valid Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ReInvoiceApi()
body = swagger_client.ReInvoice() # ReInvoice |  (optional)

try:
    api_response = api_instance.reinvoicingactionvalid_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ReInvoiceApi->reinvoicingactionvalid_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ReInvoice**](ReInvoice.md)|  | [optional] 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

