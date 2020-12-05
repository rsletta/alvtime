# swagger_client.JournalEntryModeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**journal_entry_modes_get**](JournalEntryModeApi.md#journal_entry_modes_get) | **GET** /journalEntryModes | 
[**journal_entry_modes_id_delete**](JournalEntryModeApi.md#journal_entry_modes_id_delete) | **DELETE** /journalEntryModes/{id} | 
[**journal_entry_modes_id_get**](JournalEntryModeApi.md#journal_entry_modes_id_get) | **GET** /journalEntryModes/{id} | 
[**journal_entry_modes_id_put**](JournalEntryModeApi.md#journal_entry_modes_id_put) | **PUT** /journalEntryModes/{id} | 
[**journal_entry_modes_post**](JournalEntryModeApi.md#journal_entry_modes_post) | **POST** /journalEntryModes | 

# **journal_entry_modes_get**
> list[JournalEntryMode] journal_entry_modes_get()



Query JournalEntryMode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryModeApi()

try:
    api_response = api_instance.journal_entry_modes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryModeApi->journal_entry_modes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[JournalEntryMode]**](JournalEntryMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journal_entry_modes_id_delete**
> JournalEntryMode journal_entry_modes_id_delete(id)



Delete JournalEntryMode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryModeApi()
id = 56 # int | 

try:
    api_response = api_instance.journal_entry_modes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryModeApi->journal_entry_modes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryMode**](JournalEntryMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journal_entry_modes_id_get**
> JournalEntryMode journal_entry_modes_id_get(id)



Get JournalEntryMode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryModeApi()
id = 56 # int | 

try:
    api_response = api_instance.journal_entry_modes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryModeApi->journal_entry_modes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryMode**](JournalEntryMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journal_entry_modes_id_put**
> JournalEntryMode journal_entry_modes_id_put(body, id)



Update JournalEntryMode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryModeApi()
body = swagger_client.JournalEntryMode() # JournalEntryMode | 
id = 56 # int | 

try:
    api_response = api_instance.journal_entry_modes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryModeApi->journal_entry_modes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryMode**](JournalEntryMode.md)|  | 
 **id** | **int**|  | 

### Return type

[**JournalEntryMode**](JournalEntryMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journal_entry_modes_post**
> JournalEntryMode journal_entry_modes_post(body)



Create JournalEntryMode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryModeApi()
body = swagger_client.JournalEntryMode() # JournalEntryMode | 

try:
    api_response = api_instance.journal_entry_modes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryModeApi->journal_entry_modes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryMode**](JournalEntryMode.md)|  | 

### Return type

[**JournalEntryMode**](JournalEntryMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

