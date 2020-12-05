# swagger_client.ProjectTaskApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**projects_tasks_get**](ProjectTaskApi.md#projects_tasks_get) | **GET** /projects-tasks | 
[**projects_tasks_id_delete**](ProjectTaskApi.md#projects_tasks_id_delete) | **DELETE** /projects-tasks/{id} | 
[**projects_tasks_id_get**](ProjectTaskApi.md#projects_tasks_id_get) | **GET** /projects-tasks/{id} | 
[**projects_tasks_id_put**](ProjectTaskApi.md#projects_tasks_id_put) | **PUT** /projects-tasks/{id} | 
[**projects_tasks_idaction_activate_project_task_post**](ProjectTaskApi.md#projects_tasks_idaction_activate_project_task_post) | **POST** /projects-tasks/{id}?action&#x3D;ActivateProjectTask | 
[**projects_tasks_idaction_complete_project_task_post**](ProjectTaskApi.md#projects_tasks_idaction_complete_project_task_post) | **POST** /projects-tasks/{id}?action&#x3D;CompleteProjectTask | 
[**projects_tasks_post**](ProjectTaskApi.md#projects_tasks_post) | **POST** /projects-tasks | 

# **projects_tasks_get**
> list[ProjectTask] projects_tasks_get()



Query ProjectTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()

try:
    api_response = api_instance.projects_tasks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProjectTask]**](ProjectTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_id_delete**
> ProjectTask projects_tasks_id_delete(id)



Delete ProjectTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectTask**](ProjectTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_id_get**
> ProjectTask projects_tasks_id_get(id)



Get ProjectTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectTask**](ProjectTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_id_put**
> ProjectTask projects_tasks_id_put(body, id)



Update ProjectTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
body = swagger_client.ProjectTask() # ProjectTask | 
id = 56 # int | 

try:
    api_response = api_instance.projects_tasks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectTask**](ProjectTask.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProjectTask**](ProjectTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_idaction_activate_project_task_post**
> object projects_tasks_idaction_activate_project_task_post(id, project_task_id)



ActivateProjectTask Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
id = 56 # int | 
project_task_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_tasks_idaction_activate_project_task_post(id, project_task_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_idaction_activate_project_task_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_task_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_idaction_complete_project_task_post**
> object projects_tasks_idaction_complete_project_task_post(id, project_task_id)



CompleteProjectTask Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
id = 56 # int | 
project_task_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_tasks_idaction_complete_project_task_post(id, project_task_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_idaction_complete_project_task_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_task_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_tasks_post**
> ProjectTask projects_tasks_post(body)



Create ProjectTask

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectTaskApi()
body = swagger_client.ProjectTask() # ProjectTask | 

try:
    api_response = api_instance.projects_tasks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectTaskApi->projects_tasks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectTask**](ProjectTask.md)|  | 

### Return type

[**ProjectTask**](ProjectTask.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

