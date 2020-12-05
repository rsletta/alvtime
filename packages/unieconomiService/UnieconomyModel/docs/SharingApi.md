# swagger_client.SharingApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sharings_get**](SharingApi.md#sharings_get) | **GET** /sharings | 
[**sharings_id_get**](SharingApi.md#sharings_id_get) | **GET** /sharings/{id} | 
[**sharings_id_put**](SharingApi.md#sharings_id_put) | **PUT** /sharings/{id} | 
[**sharings_idaction_cancel_post**](SharingApi.md#sharings_idaction_cancel_post) | **POST** /sharings/{id}?action&#x3D;Cancel | 
[**sharings_post**](SharingApi.md#sharings_post) | **POST** /sharings | 
[**sharingsactionbulkupdate_put**](SharingApi.md#sharingsactionbulkupdate_put) | **PUT** /sharings?action&#x3D;bulkupdate | 

# **sharings_get**
> list[Sharing] sharings_get()



Query Sharing

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()

try:
    api_response = api_instance.sharings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Sharing]**](Sharing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sharings_id_get**
> Sharing sharings_id_get(id)



Get Sharing

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()
id = 56 # int | 

try:
    api_response = api_instance.sharings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Sharing**](Sharing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sharings_id_put**
> Sharing sharings_id_put(body, id)



Update Sharing

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()
body = swagger_client.Sharing() # Sharing | 
id = 56 # int | 

try:
    api_response = api_instance.sharings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Sharing**](Sharing.md)|  | 
 **id** | **int**|  | 

### Return type

[**Sharing**](Sharing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sharings_idaction_cancel_post**
> object sharings_idaction_cancel_post(id, id)



Cancel Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.sharings_idaction_cancel_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharings_idaction_cancel_post: %s\n" % e)
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

# **sharings_post**
> Sharing sharings_post(body)



Create Sharing

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()
body = swagger_client.Sharing() # Sharing | 

try:
    api_response = api_instance.sharings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Sharing**](Sharing.md)|  | 

### Return type

[**Sharing**](Sharing.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sharingsactionbulkupdate_put**
> object sharingsactionbulkupdate_put(body=body)



bulkupdate Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SharingApi()
body = swagger_client.SharingUpdates() # SharingUpdates |  (optional)

try:
    api_response = api_instance.sharingsactionbulkupdate_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SharingApi->sharingsactionbulkupdate_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SharingUpdates**](SharingUpdates.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

