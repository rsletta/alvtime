# swagger_client.JournalEntryTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**journalentrytypes_get**](JournalEntryTypeApi.md#journalentrytypes_get) | **GET** /journalentrytypes | 
[**journalentrytypes_id_get**](JournalEntryTypeApi.md#journalentrytypes_id_get) | **GET** /journalentrytypes/{id} | 

# **journalentrytypes_get**
> list[JournalEntryType] journalentrytypes_get()



Query JournalEntryType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryTypeApi()

try:
    api_response = api_instance.journalentrytypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryTypeApi->journalentrytypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[JournalEntryType]**](JournalEntryType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrytypes_id_get**
> JournalEntryType journalentrytypes_id_get(id)



Get JournalEntryType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentrytypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryTypeApi->journalentrytypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryType**](JournalEntryType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

