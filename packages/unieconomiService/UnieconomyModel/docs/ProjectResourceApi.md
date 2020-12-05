# swagger_client.ProjectResourceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**projects_resources_get**](ProjectResourceApi.md#projects_resources_get) | **GET** /projects-resources | 
[**projects_resources_id_delete**](ProjectResourceApi.md#projects_resources_id_delete) | **DELETE** /projects-resources/{id} | 
[**projects_resources_id_get**](ProjectResourceApi.md#projects_resources_id_get) | **GET** /projects-resources/{id} | 
[**projects_resources_id_put**](ProjectResourceApi.md#projects_resources_id_put) | **PUT** /projects-resources/{id} | 
[**projects_resources_post**](ProjectResourceApi.md#projects_resources_post) | **POST** /projects-resources | 

# **projects_resources_get**
> list[ProjectResource] projects_resources_get()



Query ProjectResource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceApi()

try:
    api_response = api_instance.projects_resources_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceApi->projects_resources_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ProjectResource]**](ProjectResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_resources_id_delete**
> ProjectResource projects_resources_id_delete(id)



Delete ProjectResource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_resources_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceApi->projects_resources_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectResource**](ProjectResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_resources_id_get**
> ProjectResource projects_resources_id_get(id)



Get ProjectResource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_resources_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceApi->projects_resources_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ProjectResource**](ProjectResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_resources_id_put**
> ProjectResource projects_resources_id_put(body, id)



Update ProjectResource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceApi()
body = swagger_client.ProjectResource() # ProjectResource | 
id = 56 # int | 

try:
    api_response = api_instance.projects_resources_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceApi->projects_resources_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectResource**](ProjectResource.md)|  | 
 **id** | **int**|  | 

### Return type

[**ProjectResource**](ProjectResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_resources_post**
> ProjectResource projects_resources_post(body)



Create ProjectResource

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectResourceApi()
body = swagger_client.ProjectResource() # ProjectResource | 

try:
    api_response = api_instance.projects_resources_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectResourceApi->projects_resources_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProjectResource**](ProjectResource.md)|  | 

### Return type

[**ProjectResource**](ProjectResource.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

