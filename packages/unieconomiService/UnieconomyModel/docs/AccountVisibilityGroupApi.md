# swagger_client.AccountVisibilityGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountvisibilitygroups_get**](AccountVisibilityGroupApi.md#accountvisibilitygroups_get) | **GET** /accountvisibilitygroups | 
[**accountvisibilitygroups_id_delete**](AccountVisibilityGroupApi.md#accountvisibilitygroups_id_delete) | **DELETE** /accountvisibilitygroups/{id} | 
[**accountvisibilitygroups_id_get**](AccountVisibilityGroupApi.md#accountvisibilitygroups_id_get) | **GET** /accountvisibilitygroups/{id} | 
[**accountvisibilitygroups_id_put**](AccountVisibilityGroupApi.md#accountvisibilitygroups_id_put) | **PUT** /accountvisibilitygroups/{id} | 
[**accountvisibilitygroups_post**](AccountVisibilityGroupApi.md#accountvisibilitygroups_post) | **POST** /accountvisibilitygroups | 

# **accountvisibilitygroups_get**
> list[AccountVisibilityGroup] accountvisibilitygroups_get()



Query AccountVisibilityGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountVisibilityGroupApi()

try:
    api_response = api_instance.accountvisibilitygroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountVisibilityGroupApi->accountvisibilitygroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AccountVisibilityGroup]**](AccountVisibilityGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountvisibilitygroups_id_delete**
> AccountVisibilityGroup accountvisibilitygroups_id_delete(id)



Delete AccountVisibilityGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountVisibilityGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.accountvisibilitygroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountVisibilityGroupApi->accountvisibilitygroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountVisibilityGroup**](AccountVisibilityGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountvisibilitygroups_id_get**
> AccountVisibilityGroup accountvisibilitygroups_id_get(id)



Get AccountVisibilityGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountVisibilityGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.accountvisibilitygroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountVisibilityGroupApi->accountvisibilitygroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountVisibilityGroup**](AccountVisibilityGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountvisibilitygroups_id_put**
> AccountVisibilityGroup accountvisibilitygroups_id_put(body, id)



Update AccountVisibilityGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountVisibilityGroupApi()
body = swagger_client.AccountVisibilityGroup() # AccountVisibilityGroup | 
id = 56 # int | 

try:
    api_response = api_instance.accountvisibilitygroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountVisibilityGroupApi->accountvisibilitygroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountVisibilityGroup**](AccountVisibilityGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**AccountVisibilityGroup**](AccountVisibilityGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountvisibilitygroups_post**
> AccountVisibilityGroup accountvisibilitygroups_post(body)



Create AccountVisibilityGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountVisibilityGroupApi()
body = swagger_client.AccountVisibilityGroup() # AccountVisibilityGroup | 

try:
    api_response = api_instance.accountvisibilitygroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountVisibilityGroupApi->accountvisibilitygroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountVisibilityGroup**](AccountVisibilityGroup.md)|  | 

### Return type

[**AccountVisibilityGroup**](AccountVisibilityGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

