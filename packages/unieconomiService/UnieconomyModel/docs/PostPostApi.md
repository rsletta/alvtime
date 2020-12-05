# swagger_client.PostPostApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**postposts_get**](PostPostApi.md#postposts_get) | **GET** /postposts | 
[**postposts_id_delete**](PostPostApi.md#postposts_id_delete) | **DELETE** /postposts/{id} | 
[**postposts_id_get**](PostPostApi.md#postposts_id_get) | **GET** /postposts/{id} | 
[**postposts_id_put**](PostPostApi.md#postposts_id_put) | **PUT** /postposts/{id} | 
[**postposts_post**](PostPostApi.md#postposts_post) | **POST** /postposts | 
[**postpostsactionget_suggestions_get**](PostPostApi.md#postpostsactionget_suggestions_get) | **GET** /postposts?action&#x3D;get-suggestions | 
[**postpostsactionmarkposts_post**](PostPostApi.md#postpostsactionmarkposts_post) | **POST** /postposts?action&#x3D;markposts | 
[**postpostsactionreset_journalentryline_postpost_status_to_open_put**](PostPostApi.md#postpostsactionreset_journalentryline_postpost_status_to_open_put) | **PUT** /postposts?action&#x3D;reset-journalentryline-postpost-status-to-open | 
[**postpostsactionreset_journalentrylines_postpost_status_to_open_put**](PostPostApi.md#postpostsactionreset_journalentrylines_postpost_status_to_open_put) | **PUT** /postposts?action&#x3D;reset-journalentrylines-postpost-status-to-open | 
[**postpostsactionrevert_postpost_post**](PostPostApi.md#postpostsactionrevert_postpost_post) | **POST** /postposts?action&#x3D;revert-postpost | 

# **postposts_get**
> list[PostPost] postposts_get()



Query PostPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()

try:
    api_response = api_instance.postposts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postposts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PostPost]**](PostPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postposts_id_delete**
> PostPost postposts_id_delete(id)



Delete PostPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
id = 56 # int | 

try:
    api_response = api_instance.postposts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postposts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PostPost**](PostPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postposts_id_get**
> PostPost postposts_id_get(id)



Get PostPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
id = 56 # int | 

try:
    api_response = api_instance.postposts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postposts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PostPost**](PostPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postposts_id_put**
> PostPost postposts_id_put(body, id)



Update PostPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
body = swagger_client.PostPost() # PostPost | 
id = 56 # int | 

try:
    api_response = api_instance.postposts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postposts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostPost**](PostPost.md)|  | 
 **id** | **int**|  | 

### Return type

[**PostPost**](PostPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postposts_post**
> PostPost postposts_post(body)



Create PostPost

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
body = swagger_client.PostPost() # PostPost | 

try:
    api_response = api_instance.postposts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postposts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostPost**](PostPost.md)|  | 

### Return type

[**PostPost**](PostPost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postpostsactionget_suggestions_get**
> MarkingResult postpostsactionget_suggestions_get(methods, customer_id, supplier_id, account_id)



get-suggestions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
methods = swagger_client.Object() # Object | 
customer_id = swagger_client.Object() # Object | 
supplier_id = swagger_client.Object() # Object | 
account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.postpostsactionget_suggestions_get(methods, customer_id, supplier_id, account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postpostsactionget_suggestions_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **methods** | [**Object**](.md)|  | 
 **customer_id** | [**Object**](.md)|  | 
 **supplier_id** | [**Object**](.md)|  | 
 **account_id** | [**Object**](.md)|  | 

### Return type

[**MarkingResult**](MarkingResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postpostsactionmarkposts_post**
> object postpostsactionmarkposts_post(body=body)



markposts Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
body = [swagger_client.JournalEntryLineCouple()] # list[JournalEntryLineCouple] |  (optional)

try:
    api_response = api_instance.postpostsactionmarkposts_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postpostsactionmarkposts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[JournalEntryLineCouple]**](JournalEntryLineCouple.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postpostsactionreset_journalentryline_postpost_status_to_open_put**
> object postpostsactionreset_journalentryline_postpost_status_to_open_put(line)



reset-journalentryline-postpost-status-to-open Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
line = swagger_client.Object() # Object | 

try:
    api_response = api_instance.postpostsactionreset_journalentryline_postpost_status_to_open_put(line)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postpostsactionreset_journalentryline_postpost_status_to_open_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **line** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postpostsactionreset_journalentrylines_postpost_status_to_open_put**
> object postpostsactionreset_journalentrylines_postpost_status_to_open_put(sub_account_id, sub_account_type)



reset-journalentrylines-postpost-status-to-open Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
sub_account_id = swagger_client.Object() # Object | 
sub_account_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.postpostsactionreset_journalentrylines_postpost_status_to_open_put(sub_account_id, sub_account_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postpostsactionreset_journalentrylines_postpost_status_to_open_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sub_account_id** | [**Object**](.md)|  | 
 **sub_account_type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postpostsactionrevert_postpost_post**
> object postpostsactionrevert_postpost_post(body=body)



revert-postpost Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostPostApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.postpostsactionrevert_postpost_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostPostApi->postpostsactionrevert_postpost_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

