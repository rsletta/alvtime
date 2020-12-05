# swagger_client.RoleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**roles_get**](RoleApi.md#roles_get) | **GET** /roles | 
[**roles_id_delete**](RoleApi.md#roles_id_delete) | **DELETE** /roles/{id} | 
[**roles_id_get**](RoleApi.md#roles_id_get) | **GET** /roles/{id} | 
[**roles_id_put**](RoleApi.md#roles_id_put) | **PUT** /roles/{id} | 
[**roles_post**](RoleApi.md#roles_post) | **POST** /roles | 

# **roles_get**
> list[Role] roles_get()



Query Role

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RoleApi()

try:
    api_response = api_instance.roles_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RoleApi->roles_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Role]**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **roles_id_delete**
> Role roles_id_delete(id)



Delete Role

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RoleApi()
id = 56 # int | 

try:
    api_response = api_instance.roles_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RoleApi->roles_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **roles_id_get**
> Role roles_id_get(id)



Get Role

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RoleApi()
id = 56 # int | 

try:
    api_response = api_instance.roles_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RoleApi->roles_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **roles_id_put**
> Role roles_id_put(body, id)



Update Role

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RoleApi()
body = swagger_client.Role() # Role | 
id = 56 # int | 

try:
    api_response = api_instance.roles_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RoleApi->roles_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Role**](Role.md)|  | 
 **id** | **int**|  | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **roles_post**
> Role roles_post(body)



Create Role

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RoleApi()
body = swagger_client.Role() # Role | 

try:
    api_response = api_instance.roles_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RoleApi->roles_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Role**](Role.md)|  | 

### Return type

[**Role**](Role.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

