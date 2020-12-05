# swagger_client.NumberSeriesTaskApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**number_series_tasks_get**](NumberSeriesTaskApi.md#number_series_tasks_get) | **GET** /number-series-tasks | 
[**number_series_tasks_id_delete**](NumberSeriesTaskApi.md#number_series_tasks_id_delete) | **DELETE** /number-series-tasks/{id} | 
[**number_series_tasks_id_get**](NumberSeriesTaskApi.md#number_series_tasks_id_get) | **GET** /number-series-tasks/{id} | 
[**number_series_tasks_id_put**](NumberSeriesTaskApi.md#number_series_tasks_id_put) | **PUT** /number-series-tasks/{id} | 
[**number_series_tasks_post**](NumberSeriesTaskApi.md#number_series_tasks_post) | **POST** /number-series-tasks | 
[**number_series_tasksactionget_active_numberseriestasks_get**](NumberSeriesTaskApi.md#number_series_tasksactionget_active_numberseriestasks_get) | **GET** /number-series-tasks?action&#x3D;get-active-numberseriestasks | 

# **number_series_tasks_get**
> list[NumberSeriesTask] number_series_tasks_get()



Query NumberSeriesTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()

try:
    api_response = api_instance.number_series_tasks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[NumberSeriesTask]**](NumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_tasks_id_delete**
> NumberSeriesTask number_series_tasks_id_delete(id)



Delete NumberSeriesTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_tasks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesTask**](NumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_tasks_id_get**
> NumberSeriesTask number_series_tasks_id_get(id)



Get NumberSeriesTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()
id = 56 # int | 

try:
    api_response = api_instance.number_series_tasks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**NumberSeriesTask**](NumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_tasks_id_put**
> NumberSeriesTask number_series_tasks_id_put(body, id)



Update NumberSeriesTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()
body = swagger_client.NumberSeriesTask() # NumberSeriesTask | 
id = 56 # int | 

try:
    api_response = api_instance.number_series_tasks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesTask**](NumberSeriesTask.md)|  | 
 **id** | **int**|  | 

### Return type

[**NumberSeriesTask**](NumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_tasks_post**
> NumberSeriesTask number_series_tasks_post(body)



Create NumberSeriesTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()
body = swagger_client.NumberSeriesTask() # NumberSeriesTask | 

try:
    api_response = api_instance.number_series_tasks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NumberSeriesTask**](NumberSeriesTask.md)|  | 

### Return type

[**NumberSeriesTask**](NumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **number_series_tasksactionget_active_numberseriestasks_get**
> list[ActiveNumberSeriesTask] number_series_tasksactionget_active_numberseriestasks_get(entity_type, year)



get-active-numberseriestasks Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NumberSeriesTaskApi()
entity_type = swagger_client.Object() # Object | 
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.number_series_tasksactionget_active_numberseriestasks_get(entity_type, year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NumberSeriesTaskApi->number_series_tasksactionget_active_numberseriestasks_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entity_type** | [**Object**](.md)|  | 
 **year** | [**Object**](.md)|  | 

### Return type

[**list[ActiveNumberSeriesTask]**](ActiveNumberSeriesTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

