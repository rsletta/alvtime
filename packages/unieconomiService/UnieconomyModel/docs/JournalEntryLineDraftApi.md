# swagger_client.JournalEntryLineDraftApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**journalentrylinedrafts_get**](JournalEntryLineDraftApi.md#journalentrylinedrafts_get) | **GET** /journalentrylinedrafts | 
[**journalentrylinedrafts_id_delete**](JournalEntryLineDraftApi.md#journalentrylinedrafts_id_delete) | **DELETE** /journalentrylinedrafts/{id} | 
[**journalentrylinedrafts_id_get**](JournalEntryLineDraftApi.md#journalentrylinedrafts_id_get) | **GET** /journalentrylinedrafts/{id} | 
[**journalentrylinedrafts_id_put**](JournalEntryLineDraftApi.md#journalentrylinedrafts_id_put) | **PUT** /journalentrylinedrafts/{id} | 
[**journalentrylinedrafts_post**](JournalEntryLineDraftApi.md#journalentrylinedrafts_post) | **POST** /journalentrylinedrafts | 

# **journalentrylinedrafts_get**
> list[JournalEntryLineDraft] journalentrylinedrafts_get()



Query JournalEntryLineDraft

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineDraftApi()

try:
    api_response = api_instance.journalentrylinedrafts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineDraftApi->journalentrylinedrafts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[JournalEntryLineDraft]**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylinedrafts_id_delete**
> JournalEntryLineDraft journalentrylinedrafts_id_delete(id)



Delete JournalEntryLineDraft

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineDraftApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentrylinedrafts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineDraftApi->journalentrylinedrafts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryLineDraft**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylinedrafts_id_get**
> JournalEntryLineDraft journalentrylinedrafts_id_get(id)



Get JournalEntryLineDraft

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineDraftApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentrylinedrafts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineDraftApi->journalentrylinedrafts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryLineDraft**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylinedrafts_id_put**
> JournalEntryLineDraft journalentrylinedrafts_id_put(body, id)



Update JournalEntryLineDraft

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineDraftApi()
body = swagger_client.JournalEntryLineDraft() # JournalEntryLineDraft | 
id = 56 # int | 

try:
    api_response = api_instance.journalentrylinedrafts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineDraftApi->journalentrylinedrafts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryLineDraft**](JournalEntryLineDraft.md)|  | 
 **id** | **int**|  | 

### Return type

[**JournalEntryLineDraft**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylinedrafts_post**
> JournalEntryLineDraft journalentrylinedrafts_post(body)



Create JournalEntryLineDraft

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineDraftApi()
body = swagger_client.JournalEntryLineDraft() # JournalEntryLineDraft | 

try:
    api_response = api_instance.journalentrylinedrafts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineDraftApi->journalentrylinedrafts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryLineDraft**](JournalEntryLineDraft.md)|  | 

### Return type

[**JournalEntryLineDraft**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

