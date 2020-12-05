# swagger_client.VacationRateEmployeeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employeevacationrates_get**](VacationRateEmployeeApi.md#employeevacationrates_get) | **GET** /employeevacationrates | 
[**employeevacationrates_id_delete**](VacationRateEmployeeApi.md#employeevacationrates_id_delete) | **DELETE** /employeevacationrates/{id} | 
[**employeevacationrates_id_get**](VacationRateEmployeeApi.md#employeevacationrates_id_get) | **GET** /employeevacationrates/{id} | 
[**employeevacationrates_id_put**](VacationRateEmployeeApi.md#employeevacationrates_id_put) | **PUT** /employeevacationrates/{id} | 
[**employeevacationrates_post**](VacationRateEmployeeApi.md#employeevacationrates_post) | **POST** /employeevacationrates | 

# **employeevacationrates_get**
> list[VacationRateEmployee] employeevacationrates_get()



Query VacationRateEmployee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationRateEmployeeApi()

try:
    api_response = api_instance.employeevacationrates_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationRateEmployeeApi->employeevacationrates_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VacationRateEmployee]**](VacationRateEmployee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeevacationrates_id_delete**
> VacationRateEmployee employeevacationrates_id_delete(id)



Delete VacationRateEmployee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationRateEmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employeevacationrates_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationRateEmployeeApi->employeevacationrates_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VacationRateEmployee**](VacationRateEmployee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeevacationrates_id_get**
> VacationRateEmployee employeevacationrates_id_get(id)



Get VacationRateEmployee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationRateEmployeeApi()
id = 56 # int | 

try:
    api_response = api_instance.employeevacationrates_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationRateEmployeeApi->employeevacationrates_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VacationRateEmployee**](VacationRateEmployee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeevacationrates_id_put**
> VacationRateEmployee employeevacationrates_id_put(body, id)



Update VacationRateEmployee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationRateEmployeeApi()
body = swagger_client.VacationRateEmployee() # VacationRateEmployee | 
id = 56 # int | 

try:
    api_response = api_instance.employeevacationrates_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationRateEmployeeApi->employeevacationrates_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VacationRateEmployee**](VacationRateEmployee.md)|  | 
 **id** | **int**|  | 

### Return type

[**VacationRateEmployee**](VacationRateEmployee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employeevacationrates_post**
> VacationRateEmployee employeevacationrates_post(body)



Create VacationRateEmployee

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VacationRateEmployeeApi()
body = swagger_client.VacationRateEmployee() # VacationRateEmployee | 

try:
    api_response = api_instance.employeevacationrates_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VacationRateEmployeeApi->employeevacationrates_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VacationRateEmployee**](VacationRateEmployee.md)|  | 

### Return type

[**VacationRateEmployee**](VacationRateEmployee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

