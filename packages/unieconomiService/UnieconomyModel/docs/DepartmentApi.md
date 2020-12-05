# swagger_client.DepartmentApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**departments_get**](DepartmentApi.md#departments_get) | **GET** /departments | 
[**departments_id_delete**](DepartmentApi.md#departments_id_delete) | **DELETE** /departments/{id} | 
[**departments_id_get**](DepartmentApi.md#departments_id_get) | **GET** /departments/{id} | 
[**departments_id_put**](DepartmentApi.md#departments_id_put) | **PUT** /departments/{id} | 
[**departments_idactionis_used_get**](DepartmentApi.md#departments_idactionis_used_get) | **GET** /departments/{id}?action&#x3D;is-used | 
[**departments_post**](DepartmentApi.md#departments_post) | **POST** /departments | 

# **departments_get**
> list[Department] departments_get()



Query Department

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()

try:
    api_response = api_instance.departments_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Department]**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departments_id_delete**
> Department departments_id_delete(id)



Delete Department

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()
id = 56 # int | 

try:
    api_response = api_instance.departments_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departments_id_get**
> Department departments_id_get(id)



Get Department

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()
id = 56 # int | 

try:
    api_response = api_instance.departments_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departments_id_put**
> Department departments_id_put(body, id)



Update Department

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()
body = swagger_client.Department() # Department | 
id = 56 # int | 

try:
    api_response = api_instance.departments_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Department**](Department.md)|  | 
 **id** | **int**|  | 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **departments_idactionis_used_get**
> bool departments_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()
id = 56 # int | 

try:
    api_response = api_instance.departments_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_idactionis_used_get: %s\n" % e)
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

# **departments_post**
> Department departments_post(body)



Create Department

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DepartmentApi()
body = swagger_client.Department() # Department | 

try:
    api_response = api_instance.departments_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DepartmentApi->departments_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Department**](Department.md)|  | 

### Return type

[**Department**](Department.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

