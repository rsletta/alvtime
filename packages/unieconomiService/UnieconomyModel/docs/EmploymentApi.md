# swagger_client.EmploymentApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**employments_get**](EmploymentApi.md#employments_get) | **GET** /employments | 
[**employments_id_delete**](EmploymentApi.md#employments_id_delete) | **DELETE** /employments/{id} | 
[**employments_id_get**](EmploymentApi.md#employments_id_get) | **GET** /employments/{id} | 
[**employments_id_put**](EmploymentApi.md#employments_id_put) | **PUT** /employments/{id} | 
[**employments_idactionhistory_get**](EmploymentApi.md#employments_idactionhistory_get) | **GET** /employments/{id}?action&#x3D;history | 
[**employments_post**](EmploymentApi.md#employments_post) | **POST** /employments | 

# **employments_get**
> list[Employment] employments_get()



Query Employment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()

try:
    api_response = api_instance.employments_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Employment]**](Employment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employments_id_delete**
> Employment employments_id_delete(id)



Delete Employment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()
id = 56 # int | 

try:
    api_response = api_instance.employments_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employment**](Employment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employments_id_get**
> Employment employments_id_get(id)



Get Employment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()
id = 56 # int | 

try:
    api_response = api_instance.employments_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Employment**](Employment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employments_id_put**
> Employment employments_id_put(body, id)



Update Employment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()
body = swagger_client.Employment() # Employment | 
id = 56 # int | 

try:
    api_response = api_instance.employments_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Employment**](Employment.md)|  | 
 **id** | **int**|  | 

### Return type

[**Employment**](Employment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employments_idactionhistory_get**
> list[EmploymentHistoryRecord] employments_idactionhistory_get(id, id)



history Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.employments_idactionhistory_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_idactionhistory_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**list[EmploymentHistoryRecord]**](EmploymentHistoryRecord.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **employments_post**
> Employment employments_post(body)



Create Employment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EmploymentApi()
body = swagger_client.Employment() # Employment | 

try:
    api_response = api_instance.employments_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EmploymentApi->employments_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Employment**](Employment.md)|  | 

### Return type

[**Employment**](Employment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

