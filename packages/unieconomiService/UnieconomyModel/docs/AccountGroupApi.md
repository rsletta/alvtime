# swagger_client.AccountGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountgroups_get**](AccountGroupApi.md#accountgroups_get) | **GET** /accountgroups | 
[**accountgroups_id_delete**](AccountGroupApi.md#accountgroups_id_delete) | **DELETE** /accountgroups/{id} | 
[**accountgroups_id_get**](AccountGroupApi.md#accountgroups_id_get) | **GET** /accountgroups/{id} | 
[**accountgroups_id_put**](AccountGroupApi.md#accountgroups_id_put) | **PUT** /accountgroups/{id} | 
[**accountgroups_post**](AccountGroupApi.md#accountgroups_post) | **POST** /accountgroups | 

# **accountgroups_get**
> list[AccountGroup] accountgroups_get()



Query AccountGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupApi()

try:
    api_response = api_instance.accountgroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupApi->accountgroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AccountGroup]**](AccountGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroups_id_delete**
> AccountGroup accountgroups_id_delete(id)



Delete AccountGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.accountgroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupApi->accountgroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountGroup**](AccountGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroups_id_get**
> AccountGroup accountgroups_id_get(id)



Get AccountGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.accountgroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupApi->accountgroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountGroup**](AccountGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroups_id_put**
> AccountGroup accountgroups_id_put(body, id)



Update AccountGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupApi()
body = swagger_client.AccountGroup() # AccountGroup | 
id = 56 # int | 

try:
    api_response = api_instance.accountgroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupApi->accountgroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountGroup**](AccountGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**AccountGroup**](AccountGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroups_post**
> AccountGroup accountgroups_post(body)



Create AccountGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupApi()
body = swagger_client.AccountGroup() # AccountGroup | 

try:
    api_response = api_instance.accountgroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupApi->accountgroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountGroup**](AccountGroup.md)|  | 

### Return type

[**AccountGroup**](AccountGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

