# swagger_client.JournalEntryLineApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**journalentrylines_get**](JournalEntryLineApi.md#journalentrylines_get) | **GET** /journalentrylines | 
[**journalentrylines_id_get**](JournalEntryLineApi.md#journalentrylines_id_get) | **GET** /journalentrylines/{id} | 
[**journalentrylines_id_put**](JournalEntryLineApi.md#journalentrylines_id_put) | **PUT** /journalentrylines/{id} | 
[**journalentrylines_idactionmark_post**](JournalEntryLineApi.md#journalentrylines_idactionmark_post) | **POST** /journalentrylines/{id}?action&#x3D;mark | 
[**journalentrylinesactionget_journal_entry_period_data_get**](JournalEntryLineApi.md#journalentrylinesactionget_journal_entry_period_data_get) | **GET** /journalentrylines?action&#x3D;get-journal-entry-period-data | 
[**journalentrylinesactionget_journal_entry_postpost_data_get**](JournalEntryLineApi.md#journalentrylinesactionget_journal_entry_postpost_data_get) | **GET** /journalentrylines?action&#x3D;get-journal-entry-postpost-data | 

# **journalentrylines_get**
> list[JournalEntryLine] journalentrylines_get()



Query JournalEntryLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()

try:
    api_response = api_instance.journalentrylines_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylines_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[JournalEntryLine]**](JournalEntryLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylines_id_get**
> JournalEntryLine journalentrylines_id_get(id)



Get JournalEntryLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentrylines_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylines_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntryLine**](JournalEntryLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylines_id_put**
> JournalEntryLine journalentrylines_id_put(body, id)



Update JournalEntryLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()
body = swagger_client.JournalEntryLine() # JournalEntryLine | 
id = 56 # int | 

try:
    api_response = api_instance.journalentrylines_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylines_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryLine**](JournalEntryLine.md)|  | 
 **id** | **int**|  | 

### Return type

[**JournalEntryLine**](JournalEntryLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylines_idactionmark_post**
> object journalentrylines_idactionmark_post(id, id)



mark Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentrylines_idactionmark_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylines_idactionmark_post: %s\n" % e)
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

# **journalentrylinesactionget_journal_entry_period_data_get**
> JournalEntryLineRequestSummary journalentrylinesactionget_journal_entry_period_data_get(odata_filter)



get-journal-entry-period-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()
odata_filter = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentrylinesactionget_journal_entry_period_data_get(odata_filter)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylinesactionget_journal_entry_period_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **odata_filter** | [**Object**](.md)|  | 

### Return type

[**JournalEntryLineRequestSummary**](JournalEntryLineRequestSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentrylinesactionget_journal_entry_postpost_data_get**
> list[JournalEntryLinePostPostData] journalentrylinesactionget_journal_entry_postpost_data_get(include_open_posts, include_marked_posts, customer_id, supplier_id, account_id, point_in_time)



get-journal-entry-postpost-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryLineApi()
include_open_posts = swagger_client.Object() # Object | 
include_marked_posts = swagger_client.Object() # Object | 
customer_id = swagger_client.Object() # Object | 
supplier_id = swagger_client.Object() # Object | 
account_id = swagger_client.Object() # Object | 
point_in_time = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentrylinesactionget_journal_entry_postpost_data_get(include_open_posts, include_marked_posts, customer_id, supplier_id, account_id, point_in_time)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryLineApi->journalentrylinesactionget_journal_entry_postpost_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include_open_posts** | [**Object**](.md)|  | 
 **include_marked_posts** | [**Object**](.md)|  | 
 **customer_id** | [**Object**](.md)|  | 
 **supplier_id** | [**Object**](.md)|  | 
 **account_id** | [**Object**](.md)|  | 
 **point_in_time** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLinePostPostData]**](JournalEntryLinePostPostData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

