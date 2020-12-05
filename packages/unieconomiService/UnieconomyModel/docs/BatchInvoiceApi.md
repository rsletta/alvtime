# swagger_client.BatchInvoiceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**batchinvoices_get**](BatchInvoiceApi.md#batchinvoices_get) | **GET** /batchinvoices | 
[**batchinvoices_id_delete**](BatchInvoiceApi.md#batchinvoices_id_delete) | **DELETE** /batchinvoices/{id} | 
[**batchinvoices_id_get**](BatchInvoiceApi.md#batchinvoices_id_get) | **GET** /batchinvoices/{id} | 
[**batchinvoices_id_put**](BatchInvoiceApi.md#batchinvoices_id_put) | **PUT** /batchinvoices/{id} | 
[**batchinvoices_idactionadd_customer_invoice_put**](BatchInvoiceApi.md#batchinvoices_idactionadd_customer_invoice_put) | **PUT** /batchinvoices/{id}?action&#x3D;addCustomerInvoice | 
[**batchinvoices_idactionadd_customer_order_put**](BatchInvoiceApi.md#batchinvoices_idactionadd_customer_order_put) | **PUT** /batchinvoices/{id}?action&#x3D;addCustomerOrder | 
[**batchinvoices_idactioninvoice_put**](BatchInvoiceApi.md#batchinvoices_idactioninvoice_put) | **PUT** /batchinvoices/{id}?action&#x3D;invoice | 
[**batchinvoices_post**](BatchInvoiceApi.md#batchinvoices_post) | **POST** /batchinvoices | 

# **batchinvoices_get**
> list[BatchInvoice] batchinvoices_get()



Query BatchInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()

try:
    api_response = api_instance.batchinvoices_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BatchInvoice]**](BatchInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_id_delete**
> BatchInvoice batchinvoices_id_delete(id)



Delete BatchInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.batchinvoices_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BatchInvoice**](BatchInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_id_get**
> BatchInvoice batchinvoices_id_get(id)



Get BatchInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.batchinvoices_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BatchInvoice**](BatchInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_id_put**
> BatchInvoice batchinvoices_id_put(body, id)



Update BatchInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
body = swagger_client.BatchInvoice() # BatchInvoice | 
id = 56 # int | 

try:
    api_response = api_instance.batchinvoices_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchInvoice**](BatchInvoice.md)|  | 
 **id** | **int**|  | 

### Return type

[**BatchInvoice**](BatchInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_idactionadd_customer_invoice_put**
> object batchinvoices_idactionadd_customer_invoice_put(id2, id, body=body)



addCustomerInvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.batchinvoices_idactionadd_customer_invoice_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_idactionadd_customer_invoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_idactionadd_customer_order_put**
> object batchinvoices_idactionadd_customer_order_put(id2, id, body=body)



addCustomerOrder Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.batchinvoices_idactionadd_customer_order_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_idactionadd_customer_order_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **batchinvoices_idactioninvoice_put**
> object batchinvoices_idactioninvoice_put(id, id)



invoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.batchinvoices_idactioninvoice_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_idactioninvoice_put: %s\n" % e)
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

# **batchinvoices_post**
> BatchInvoice batchinvoices_post(body)



Create BatchInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BatchInvoiceApi()
body = swagger_client.BatchInvoice() # BatchInvoice | 

try:
    api_response = api_instance.batchinvoices_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BatchInvoiceApi->batchinvoices_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BatchInvoice**](BatchInvoice.md)|  | 

### Return type

[**BatchInvoice**](BatchInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

