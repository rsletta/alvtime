# swagger_client.UserRoleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userroles_get**](UserRoleApi.md#userroles_get) | **GET** /userroles | 
[**userroles_id_delete**](UserRoleApi.md#userroles_id_delete) | **DELETE** /userroles/{id} | 
[**userroles_id_get**](UserRoleApi.md#userroles_id_get) | **GET** /userroles/{id} | 
[**userroles_id_put**](UserRoleApi.md#userroles_id_put) | **PUT** /userroles/{id} | 
[**userroles_post**](UserRoleApi.md#userroles_post) | **POST** /userroles | 
[**userrolesactionbulk_insert_roles_post**](UserRoleApi.md#userrolesactionbulk_insert_roles_post) | **POST** /userroles?action&#x3D;bulk-insert-roles | 

# **userroles_get**
> list[UserRole] userroles_get()



Query UserRole

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()

try:
    api_response = api_instance.userroles_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userroles_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[UserRole]**](UserRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userroles_id_delete**
> UserRole userroles_id_delete(id)



Delete UserRole

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()
id = 56 # int | 

try:
    api_response = api_instance.userroles_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userroles_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UserRole**](UserRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userroles_id_get**
> UserRole userroles_id_get(id)



Get UserRole

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()
id = 56 # int | 

try:
    api_response = api_instance.userroles_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userroles_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UserRole**](UserRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userroles_id_put**
> UserRole userroles_id_put(body, id)



Update UserRole

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()
body = swagger_client.UserRole() # UserRole | 
id = 56 # int | 

try:
    api_response = api_instance.userroles_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userroles_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRole**](UserRole.md)|  | 
 **id** | **int**|  | 

### Return type

[**UserRole**](UserRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userroles_post**
> UserRole userroles_post(body)



Create UserRole

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()
body = swagger_client.UserRole() # UserRole | 

try:
    api_response = api_instance.userroles_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userroles_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UserRole**](UserRole.md)|  | 

### Return type

[**UserRole**](UserRole.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **userrolesactionbulk_insert_roles_post**
> object userrolesactionbulk_insert_roles_post(body=body)



bulk-insert-roles Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UserRoleApi()
body = [swagger_client.UserRole()] # list[UserRole] |  (optional)

try:
    api_response = api_instance.userrolesactionbulk_insert_roles_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UserRoleApi->userrolesactionbulk_insert_roles_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[UserRole]**](UserRole.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

