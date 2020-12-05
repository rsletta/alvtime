# swagger_client.EmployeeLeaveApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employee_leave_get**](EmployeeLeaveApi.md#employee_leave_get) | **GET** /EmployeeLeave | 
[**employee_leave_id_delete**](EmployeeLeaveApi.md#employee_leave_id_delete) | **DELETE** /EmployeeLeave/{id} | 
[**employee_leave_id_get**](EmployeeLeaveApi.md#employee_leave_id_get) | **GET** /EmployeeLeave/{id} | 
[**employee_leave_id_put**](EmployeeLeaveApi.md#employee_leave_id_put) | **PUT** /EmployeeLeave/{id} | 
[**employee_leave_post**](EmployeeLeaveApi.md#employee_leave_post) | **POST** /EmployeeLeave | 

# **employee_leave_get**
> list[EmployeeLeave] employee_leave_get()



Query EmployeeLeave

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeLeaveApi()

try:
    api_response = api_instance.employee_leave_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeLeaveApi->employee_leave_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EmployeeLeave]**](EmployeeLeave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employee_leave_id_delete**
> EmployeeLeave employee_leave_id_delete(id)



Delete EmployeeLeave

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeLeaveApi()
id = 56 # int | 

try:
    api_response = api_instance.employee_leave_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeLeaveApi->employee_leave_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeLeave**](EmployeeLeave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employee_leave_id_get**
> EmployeeLeave employee_leave_id_get(id)



Get EmployeeLeave

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeLeaveApi()
id = 56 # int | 

try:
    api_response = api_instance.employee_leave_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeLeaveApi->employee_leave_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EmployeeLeave**](EmployeeLeave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employee_leave_id_put**
> EmployeeLeave employee_leave_id_put(body, id)



Update EmployeeLeave

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeLeaveApi()
body = swagger_client.EmployeeLeave() # EmployeeLeave | 
id = 56 # int | 

try:
    api_response = api_instance.employee_leave_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeLeaveApi->employee_leave_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeLeave**](EmployeeLeave.md)|  | 
 **id** | **int**|  | 

### Return type

[**EmployeeLeave**](EmployeeLeave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employee_leave_post**
> EmployeeLeave employee_leave_post(body)



Create EmployeeLeave

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmployeeLeaveApi()
body = swagger_client.EmployeeLeave() # EmployeeLeave | 

try:
    api_response = api_instance.employee_leave_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmployeeLeaveApi->employee_leave_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EmployeeLeave**](EmployeeLeave.md)|  | 

### Return type

[**EmployeeLeave**](EmployeeLeave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

