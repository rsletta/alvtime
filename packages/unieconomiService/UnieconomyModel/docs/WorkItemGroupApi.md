# swagger_client.WorkItemGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workitemgroups_get**](WorkItemGroupApi.md#workitemgroups_get) | **GET** /workitemgroups | 
[**workitemgroups_id_delete**](WorkItemGroupApi.md#workitemgroups_id_delete) | **DELETE** /workitemgroups/{id} | 
[**workitemgroups_id_get**](WorkItemGroupApi.md#workitemgroups_id_get) | **GET** /workitemgroups/{id} | 
[**workitemgroups_id_put**](WorkItemGroupApi.md#workitemgroups_id_put) | **PUT** /workitemgroups/{id} | 
[**workitemgroups_idaction_approve_post**](WorkItemGroupApi.md#workitemgroups_idaction_approve_post) | **POST** /workitemgroups/{id}?action&#x3D;Approve | 
[**workitemgroups_idaction_assign_post**](WorkItemGroupApi.md#workitemgroups_idaction_assign_post) | **POST** /workitemgroups/{id}?action&#x3D;Assign | 
[**workitemgroups_idaction_assign_to_post**](WorkItemGroupApi.md#workitemgroups_idaction_assign_to_post) | **POST** /workitemgroups/{id}?action&#x3D;AssignTo | 
[**workitemgroups_idaction_reject_post**](WorkItemGroupApi.md#workitemgroups_idaction_reject_post) | **POST** /workitemgroups/{id}?action&#x3D;Reject | 
[**workitemgroups_post**](WorkItemGroupApi.md#workitemgroups_post) | **POST** /workitemgroups | 
[**workitemgroupsactioncreate_from_items_post**](WorkItemGroupApi.md#workitemgroupsactioncreate_from_items_post) | **POST** /workitemgroups?action&#x3D;create-from-items | 

# **workitemgroups_get**
> list[WorkItemGroup] workitemgroups_get()



Query WorkItemGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()

try:
    api_response = api_instance.workitemgroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkItemGroup]**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroups_id_delete**
> WorkItemGroup workitemgroups_id_delete(id)



Delete WorkItemGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.workitemgroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkItemGroup**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroups_id_get**
> WorkItemGroup workitemgroups_id_get(id)



Get WorkItemGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.workitemgroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkItemGroup**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroups_id_put**
> WorkItemGroup workitemgroups_id_put(body, id)



Update WorkItemGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
body = swagger_client.WorkItemGroup() # WorkItemGroup | 
id = 56 # int | 

try:
    api_response = api_instance.workitemgroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkItemGroup**](WorkItemGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkItemGroup**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroups_idaction_approve_post**
> object workitemgroups_idaction_approve_post(id, id)



Approve Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.workitemgroups_idaction_approve_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_idaction_approve_post: %s\n" % e)
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

# **workitemgroups_idaction_assign_post**
> object workitemgroups_idaction_assign_post(id, id)



Assign Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.workitemgroups_idaction_assign_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_idaction_assign_post: %s\n" % e)
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

# **workitemgroups_idaction_assign_to_post**
> object workitemgroups_idaction_assign_to_post(id2, id, body=body)



AssignTo Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.AssignmentDetails() # AssignmentDetails |  (optional)

try:
    api_response = api_instance.workitemgroups_idaction_assign_to_post(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_idaction_assign_to_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**AssignmentDetails**](AssignmentDetails.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroups_idaction_reject_post**
> object workitemgroups_idaction_reject_post(id, id)



Reject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.workitemgroups_idaction_reject_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_idaction_reject_post: %s\n" % e)
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

# **workitemgroups_post**
> WorkItemGroup workitemgroups_post(body)



Create WorkItemGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()
body = swagger_client.WorkItemGroup() # WorkItemGroup | 

try:
    api_response = api_instance.workitemgroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkItemGroup**](WorkItemGroup.md)|  | 

### Return type

[**WorkItemGroup**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitemgroupsactioncreate_from_items_post**
> WorkItemGroup workitemgroupsactioncreate_from_items_post()



create-from-items Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemGroupApi()

try:
    api_response = api_instance.workitemgroupsactioncreate_from_items_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemGroupApi->workitemgroupsactioncreate_from_items_post: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WorkItemGroup**](WorkItemGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

