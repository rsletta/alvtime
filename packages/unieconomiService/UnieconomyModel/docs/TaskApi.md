# swagger_client.TaskApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tasks_get**](TaskApi.md#tasks_get) | **GET** /tasks | 
[**tasks_id_delete**](TaskApi.md#tasks_id_delete) | **DELETE** /tasks/{id} | 
[**tasks_id_get**](TaskApi.md#tasks_id_get) | **GET** /tasks/{id} | 
[**tasks_id_put**](TaskApi.md#tasks_id_put) | **PUT** /tasks/{id} | 
[**tasks_idactionactivate_post**](TaskApi.md#tasks_idactionactivate_post) | **POST** /tasks/{id}?action&#x3D;activate | 
[**tasks_idactioncomplete_post**](TaskApi.md#tasks_idactioncomplete_post) | **POST** /tasks/{id}?action&#x3D;complete | 
[**tasks_idactionpending_post**](TaskApi.md#tasks_idactionpending_post) | **POST** /tasks/{id}?action&#x3D;pending | 
[**tasks_post**](TaskApi.md#tasks_post) | **POST** /tasks | 

# **tasks_get**
> list[Task] tasks_get()



Query Task

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()

try:
    api_response = api_instance.tasks_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Task]**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tasks_id_delete**
> Task tasks_id_delete(id)



Delete Task

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
id = 56 # int | 

try:
    api_response = api_instance.tasks_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tasks_id_get**
> Task tasks_id_get(id)



Get Task

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
id = 56 # int | 

try:
    api_response = api_instance.tasks_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tasks_id_put**
> Task tasks_id_put(body, id)



Update Task

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
body = swagger_client.Task() # Task | 
id = 56 # int | 

try:
    api_response = api_instance.tasks_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Task**](Task.md)|  | 
 **id** | **int**|  | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tasks_idactionactivate_post**
> object tasks_idactionactivate_post(id, id)



activate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.tasks_idactionactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_idactionactivate_post: %s\n" % e)
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

# **tasks_idactioncomplete_post**
> object tasks_idactioncomplete_post(id, id)



complete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.tasks_idactioncomplete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_idactioncomplete_post: %s\n" % e)
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

# **tasks_idactionpending_post**
> object tasks_idactionpending_post(id, id)



pending Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.tasks_idactionpending_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_idactionpending_post: %s\n" % e)
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

# **tasks_post**
> Task tasks_post(body)



Create Task

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TaskApi()
body = swagger_client.Task() # Task | 

try:
    api_response = api_instance.tasks_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TaskApi->tasks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Task**](Task.md)|  | 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

