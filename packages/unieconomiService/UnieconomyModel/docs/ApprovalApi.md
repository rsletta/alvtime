# swagger_client.ApprovalApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**approvals_get**](ApprovalApi.md#approvals_get) | **GET** /approvals | 
[**approvals_id_get**](ApprovalApi.md#approvals_id_get) | **GET** /approvals/{id} | 
[**approvals_idactionapprove_post**](ApprovalApi.md#approvals_idactionapprove_post) | **POST** /approvals/{id}?action&#x3D;approve | 
[**approvals_idactionreject_post**](ApprovalApi.md#approvals_idactionreject_post) | **POST** /approvals/{id}?action&#x3D;reject | 

# **approvals_get**
> list[Approval] approvals_get()



Query Approval

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalApi()

try:
    api_response = api_instance.approvals_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalApi->approvals_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Approval]**](Approval.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvals_id_get**
> Approval approvals_id_get(id)



Get Approval

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalApi()
id = 56 # int | 

try:
    api_response = api_instance.approvals_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalApi->approvals_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Approval**](Approval.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvals_idactionapprove_post**
> object approvals_idactionapprove_post(id, id)



approve Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.approvals_idactionapprove_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalApi->approvals_idactionapprove_post: %s\n" % e)
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

# **approvals_idactionreject_post**
> object approvals_idactionreject_post(id, id)



reject Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.approvals_idactionreject_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalApi->approvals_idactionreject_post: %s\n" % e)
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

