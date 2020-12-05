# swagger_client.ProjectApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**projects_get**](ProjectApi.md#projects_get) | **GET** /projects | 
[**projects_id_delete**](ProjectApi.md#projects_id_delete) | **DELETE** /projects/{id} | 
[**projects_id_get**](ProjectApi.md#projects_id_get) | **GET** /projects/{id} | 
[**projects_id_put**](ProjectApi.md#projects_id_put) | **PUT** /projects/{id} | 
[**projects_idaction_complete_project_post**](ProjectApi.md#projects_idaction_complete_project_post) | **POST** /projects/{id}?action&#x3D;CompleteProject | 
[**projects_idaction_discard_project_post**](ProjectApi.md#projects_idaction_discard_project_post) | **POST** /projects/{id}?action&#x3D;DiscardProject | 
[**projects_idaction_initiate_project_post**](ProjectApi.md#projects_idaction_initiate_project_post) | **POST** /projects/{id}?action&#x3D;InitiateProject | 
[**projects_idaction_start_project_post**](ProjectApi.md#projects_idaction_start_project_post) | **POST** /projects/{id}?action&#x3D;StartProject | 
[**projects_idactionis_used_get**](ProjectApi.md#projects_idactionis_used_get) | **GET** /projects/{id}?action&#x3D;is-used | 
[**projects_post**](ProjectApi.md#projects_post) | **POST** /projects | 
[**projectsactionall_with_is_used_prop_get**](ProjectApi.md#projectsactionall_with_is_used_prop_get) | **GET** /projects?action&#x3D;all-with-isUsed-prop | 

# **projects_get**
> list[Project] projects_get()



Query Project

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()

try:
    api_response = api_instance.projects_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Project]**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_id_delete**
> Project projects_id_delete(id)



Delete Project

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_id_get**
> Project projects_id_get(id)



Get Project

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_id_put**
> Project projects_id_put(body, id)



Update Project

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
body = swagger_client.Project() # Project | 
id = 56 # int | 

try:
    api_response = api_instance.projects_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 
 **id** | **int**|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_idaction_complete_project_post**
> object projects_idaction_complete_project_post(id, project_id)



CompleteProject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 
project_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_idaction_complete_project_post(id, project_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_idaction_complete_project_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_idaction_discard_project_post**
> object projects_idaction_discard_project_post(id, project_id)



DiscardProject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 
project_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_idaction_discard_project_post(id, project_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_idaction_discard_project_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_idaction_initiate_project_post**
> object projects_idaction_initiate_project_post(id, project_id)



InitiateProject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 
project_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_idaction_initiate_project_post(id, project_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_idaction_initiate_project_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_idaction_start_project_post**
> object projects_idaction_start_project_post(id, project_id)



StartProject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 
project_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.projects_idaction_start_project_post(id, project_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_idaction_start_project_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **project_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_idactionis_used_get**
> bool projects_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
id = 56 # int | 

try:
    api_response = api_instance.projects_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_idactionis_used_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projects_post**
> Project projects_post(body)



Create Project

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()
body = swagger_client.Project() # Project | 

try:
    api_response = api_instance.projects_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projects_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Project**](Project.md)|  | 

### Return type

[**Project**](Project.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **projectsactionall_with_is_used_prop_get**
> object projectsactionall_with_is_used_prop_get()



all-with-isUsed-prop Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ProjectApi()

try:
    api_response = api_instance.projectsactionall_with_is_used_prop_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ProjectApi->projectsactionall_with_is_used_prop_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

