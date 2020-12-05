# swagger_client.RecurringInvoiceLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**recurring_invoicelogs_get**](RecurringInvoiceLogApi.md#recurring_invoicelogs_get) | **GET** /RecurringInvoicelogs | 
[**recurring_invoicelogs_id_delete**](RecurringInvoiceLogApi.md#recurring_invoicelogs_id_delete) | **DELETE** /RecurringInvoicelogs/{id} | 
[**recurring_invoicelogs_id_get**](RecurringInvoiceLogApi.md#recurring_invoicelogs_id_get) | **GET** /RecurringInvoicelogs/{id} | 

# **recurring_invoicelogs_get**
> list[RecurringInvoiceLog] recurring_invoicelogs_get()



Query RecurringInvoiceLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceLogApi()

try:
    api_response = api_instance.recurring_invoicelogs_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceLogApi->recurring_invoicelogs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[RecurringInvoiceLog]**](RecurringInvoiceLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurring_invoicelogs_id_delete**
> RecurringInvoiceLog recurring_invoicelogs_id_delete(id)



Delete RecurringInvoiceLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceLogApi()
id = 56 # int | 

try:
    api_response = api_instance.recurring_invoicelogs_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceLogApi->recurring_invoicelogs_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RecurringInvoiceLog**](RecurringInvoiceLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **recurring_invoicelogs_id_get**
> RecurringInvoiceLog recurring_invoicelogs_id_get(id)



Get RecurringInvoiceLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RecurringInvoiceLogApi()
id = 56 # int | 

try:
    api_response = api_instance.recurring_invoicelogs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RecurringInvoiceLogApi->recurring_invoicelogs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RecurringInvoiceLog**](RecurringInvoiceLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

