# swagger_client.WorkerApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workers_get**](WorkerApi.md#workers_get) | **GET** /workers | 
[**workers_id_delete**](WorkerApi.md#workers_id_delete) | **DELETE** /workers/{id} | 
[**workers_id_get**](WorkerApi.md#workers_id_get) | **GET** /workers/{id} | 
[**workers_id_put**](WorkerApi.md#workers_id_put) | **PUT** /workers/{id} | 
[**workers_post**](WorkerApi.md#workers_post) | **POST** /workers | 
[**workersactioncreate_worker_from_user_post**](WorkerApi.md#workersactioncreate_worker_from_user_post) | **POST** /workers?action&#x3D;create-worker-from-user | 

# **workers_get**
> list[Worker] workers_get()



Query Worker

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()

try:
    api_response = api_instance.workers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Worker]**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workers_id_delete**
> Worker workers_id_delete(id)



Delete Worker

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()
id = 56 # int | 

try:
    api_response = api_instance.workers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Worker**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workers_id_get**
> Worker workers_id_get(id)



Get Worker

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()
id = 56 # int | 

try:
    api_response = api_instance.workers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Worker**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workers_id_put**
> Worker workers_id_put(body, id)



Update Worker

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()
body = swagger_client.Worker() # Worker | 
id = 56 # int | 

try:
    api_response = api_instance.workers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Worker**](Worker.md)|  | 
 **id** | **int**|  | 

### Return type

[**Worker**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workers_post**
> Worker workers_post(body)



Create Worker

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()
body = swagger_client.Worker() # Worker | 

try:
    api_response = api_instance.workers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Worker**](Worker.md)|  | 

### Return type

[**Worker**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workersactioncreate_worker_from_user_post**
> Worker workersactioncreate_worker_from_user_post()



create-worker-from-user Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkerApi()

try:
    api_response = api_instance.workersactioncreate_worker_from_user_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkerApi->workersactioncreate_worker_from_user_post: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**Worker**](Worker.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

