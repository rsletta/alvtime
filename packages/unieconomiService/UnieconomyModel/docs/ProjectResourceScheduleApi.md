# swagger_client.ProjectResourceScheduleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**projects_schedules_resources_get**](ProjectResourceScheduleApi.md#projects_schedules_resources_get) | **GET** /projects-schedules-resources | 
[**projects_schedules_resources_id_delete**](ProjectResourceScheduleApi.md#projects_schedules_resources_id_delete) | **DELETE** /projects-schedules-resources/{id} | 
[**projects_schedules_resources_id_get**](ProjectResourceScheduleApi.md#projects_schedules_resources_id_get) | **GET** /projects-schedules-resources/{id} | 
[**projects_schedules_resources_id_put**](ProjectResourceScheduleApi.md#projects_schedules_resources_id_put) | **PUT** /projects-schedules-resources/{id} | 
[**projects_schedules_resources_post**](ProjectResourceScheduleApi.md#projects_schedules_resources_post) | **POST** /projects-schedules-resources | 

# **projects_schedules_resources_get**
> list[ProjectResourceSchedule] projects_schedules_resources_get()



Query ProjectResourceSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceScheduleApi()

try:
    api_response = api_instance.projects_schedules_resources_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceScheduleApi->projects_schedules_resources_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProjectResourceSchedule]**](ProjectResourceSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_schedules_resources_id_delete**
> ProjectResourceSchedule projects_schedules_resources_id_delete(id)



Delete ProjectResourceSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceScheduleApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_schedules_resources_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceScheduleApi->projects_schedules_resources_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectResourceSchedule**](ProjectResourceSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_schedules_resources_id_get**
> ProjectResourceSchedule projects_schedules_resources_id_get(id)



Get ProjectResourceSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceScheduleApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_schedules_resources_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceScheduleApi->projects_schedules_resources_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectResourceSchedule**](ProjectResourceSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_schedules_resources_id_put**
> ProjectResourceSchedule projects_schedules_resources_id_put(body, id)



Update ProjectResourceSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceScheduleApi()
body = swagger_client.ProjectResourceSchedule() # ProjectResourceSchedule | 
id = 56 # int | 

try:
    api_response = api_instance.projects_schedules_resources_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceScheduleApi->projects_schedules_resources_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectResourceSchedule**](ProjectResourceSchedule.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProjectResourceSchedule**](ProjectResourceSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_schedules_resources_post**
> ProjectResourceSchedule projects_schedules_resources_post(body)



Create ProjectResourceSchedule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceScheduleApi()
body = swagger_client.ProjectResourceSchedule() # ProjectResourceSchedule | 

try:
    api_response = api_instance.projects_schedules_resources_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceScheduleApi->projects_schedules_resources_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectResourceSchedule**](ProjectResourceSchedule.md)|  | 

### Return type

[**ProjectResourceSchedule**](ProjectResourceSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

