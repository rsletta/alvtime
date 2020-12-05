# swagger_client.AccountGroupSetApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountgroupsets_get**](AccountGroupSetApi.md#accountgroupsets_get) | **GET** /accountgroupsets | 
[**accountgroupsets_id_delete**](AccountGroupSetApi.md#accountgroupsets_id_delete) | **DELETE** /accountgroupsets/{id} | 
[**accountgroupsets_id_get**](AccountGroupSetApi.md#accountgroupsets_id_get) | **GET** /accountgroupsets/{id} | 
[**accountgroupsets_id_put**](AccountGroupSetApi.md#accountgroupsets_id_put) | **PUT** /accountgroupsets/{id} | 
[**accountgroupsets_post**](AccountGroupSetApi.md#accountgroupsets_post) | **POST** /accountgroupsets | 

# **accountgroupsets_get**
> list[AccountGroupSet] accountgroupsets_get()



Query AccountGroupSet

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupSetApi()

try:
    api_response = api_instance.accountgroupsets_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupSetApi->accountgroupsets_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AccountGroupSet]**](AccountGroupSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroupsets_id_delete**
> AccountGroupSet accountgroupsets_id_delete(id)



Delete AccountGroupSet

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupSetApi()
id = 56 # int | 

try:
    api_response = api_instance.accountgroupsets_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupSetApi->accountgroupsets_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountGroupSet**](AccountGroupSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroupsets_id_get**
> AccountGroupSet accountgroupsets_id_get(id)



Get AccountGroupSet

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupSetApi()
id = 56 # int | 

try:
    api_response = api_instance.accountgroupsets_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupSetApi->accountgroupsets_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AccountGroupSet**](AccountGroupSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroupsets_id_put**
> AccountGroupSet accountgroupsets_id_put(body, id)



Update AccountGroupSet

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupSetApi()
body = swagger_client.AccountGroupSet() # AccountGroupSet | 
id = 56 # int | 

try:
    api_response = api_instance.accountgroupsets_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupSetApi->accountgroupsets_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountGroupSet**](AccountGroupSet.md)|  | 
 **id** | **int**|  | 

### Return type

[**AccountGroupSet**](AccountGroupSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountgroupsets_post**
> AccountGroupSet accountgroupsets_post(body)



Create AccountGroupSet

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountGroupSetApi()
body = swagger_client.AccountGroupSet() # AccountGroupSet | 

try:
    api_response = api_instance.accountgroupsets_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountGroupSetApi->accountgroupsets_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountGroupSet**](AccountGroupSet.md)|  | 

### Return type

[**AccountGroupSet**](AccountGroupSet.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

