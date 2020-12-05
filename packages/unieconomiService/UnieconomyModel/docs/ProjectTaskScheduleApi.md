# swagger_client.ProjectTaskScheduleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**projects_tasks_schedules_get**](ProjectTaskScheduleApi.md#projects_tasks_schedules_get) | **GET** /projects-tasks-schedules | 
[**projects_tasks_schedules_id_delete**](ProjectTaskScheduleApi.md#projects_tasks_schedules_id_delete) | **DELETE** /projects-tasks-schedules/{id} | 
[**projects_tasks_schedules_id_get**](ProjectTaskScheduleApi.md#projects_tasks_schedules_id_get) | **GET** /projects-tasks-schedules/{id} | 
[**projects_tasks_schedules_id_put**](ProjectTaskScheduleApi.md#projects_tasks_schedules_id_put) | **PUT** /projects-tasks-schedules/{id} | 
[**projects_tasks_schedules_post**](ProjectTaskScheduleApi.md#projects_tasks_schedules_post) | **POST** /projects-tasks-schedules | 

# **projects_tasks_schedules_get**
> list[ProjectTaskSchedule] projects_tasks_schedules_get()



Query ProjectTaskSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskScheduleApi()

try:
    api_response = api_instance.projects_tasks_schedules_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskScheduleApi->projects_tasks_schedules_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProjectTaskSchedule]**](ProjectTaskSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_schedules_id_delete**
> ProjectTaskSchedule projects_tasks_schedules_id_delete(id)



Delete ProjectTaskSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskScheduleApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_schedules_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskScheduleApi->projects_tasks_schedules_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectTaskSchedule**](ProjectTaskSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_schedules_id_get**
> ProjectTaskSchedule projects_tasks_schedules_id_get(id)



Get ProjectTaskSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskScheduleApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_schedules_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskScheduleApi->projects_tasks_schedules_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectTaskSchedule**](ProjectTaskSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_schedules_id_put**
> ProjectTaskSchedule projects_tasks_schedules_id_put(body, id)



Update ProjectTaskSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskScheduleApi()
body = swagger_client.ProjectTaskSchedule() # ProjectTaskSchedule | 
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_schedules_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskScheduleApi->projects_tasks_schedules_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectTaskSchedule**](ProjectTaskSchedule.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProjectTaskSchedule**](ProjectTaskSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_schedules_post**
> ProjectTaskSchedule projects_tasks_schedules_post(body)



Create ProjectTaskSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskScheduleApi()
body = swagger_client.ProjectTaskSchedule() # ProjectTaskSchedule | 

try:
    api_response = api_instance.projects_tasks_schedules_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskScheduleApi->projects_tasks_schedules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectTaskSchedule**](ProjectTaskSchedule.md)|  | 

### Return type

[**ProjectTaskSchedule**](ProjectTaskSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

