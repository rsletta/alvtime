# swagger_client.RecurringInvoiceItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**recurringinvoiceitems_get**](RecurringInvoiceItemApi.md#recurringinvoiceitems_get) | **GET** /recurringinvoiceitems | 
[**recurringinvoiceitems_id_get**](RecurringInvoiceItemApi.md#recurringinvoiceitems_id_get) | **GET** /recurringinvoiceitems/{id} | 

# **recurringinvoiceitems_get**
> list[RecurringInvoiceItem] recurringinvoiceitems_get()



Query RecurringInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceItemApi()

try:
    api_response = api_instance.recurringinvoiceitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceItemApi->recurringinvoiceitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[RecurringInvoiceItem]**](RecurringInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurringinvoiceitems_id_get**
> RecurringInvoiceItem recurringinvoiceitems_id_get(id)



Get RecurringInvoiceItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceItemApi()
id = 56 # int | 

try:
    api_response = api_instance.recurringinvoiceitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceItemApi->recurringinvoiceitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RecurringInvoiceItem**](RecurringInvoiceItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

