# swagger_client.RegulativeGroupApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**regulativegroups_get**](RegulativeGroupApi.md#regulativegroups_get) | **GET** /regulativegroups | 
[**regulativegroups_id_delete**](RegulativeGroupApi.md#regulativegroups_id_delete) | **DELETE** /regulativegroups/{id} | 
[**regulativegroups_id_get**](RegulativeGroupApi.md#regulativegroups_id_get) | **GET** /regulativegroups/{id} | 
[**regulativegroups_id_put**](RegulativeGroupApi.md#regulativegroups_id_put) | **PUT** /regulativegroups/{id} | 
[**regulativegroups_post**](RegulativeGroupApi.md#regulativegroups_post) | **POST** /regulativegroups | 

# **regulativegroups_get**
> list[RegulativeGroup] regulativegroups_get()



Query RegulativeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeGroupApi()

try:
    api_response = api_instance.regulativegroups_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeGroupApi->regulativegroups_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[RegulativeGroup]**](RegulativeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulativegroups_id_delete**
> RegulativeGroup regulativegroups_id_delete(id)



Delete RegulativeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.regulativegroups_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeGroupApi->regulativegroups_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RegulativeGroup**](RegulativeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulativegroups_id_get**
> RegulativeGroup regulativegroups_id_get(id)



Get RegulativeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeGroupApi()
id = 56 # int | 

try:
    api_response = api_instance.regulativegroups_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeGroupApi->regulativegroups_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**RegulativeGroup**](RegulativeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulativegroups_id_put**
> RegulativeGroup regulativegroups_id_put(body, id)



Update RegulativeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeGroupApi()
body = swagger_client.RegulativeGroup() # RegulativeGroup | 
id = 56 # int | 

try:
    api_response = api_instance.regulativegroups_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeGroupApi->regulativegroups_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegulativeGroup**](RegulativeGroup.md)|  | 
 **id** | **int**|  | 

### Return type

[**RegulativeGroup**](RegulativeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulativegroups_post**
> RegulativeGroup regulativegroups_post(body)



Create RegulativeGroup

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeGroupApi()
body = swagger_client.RegulativeGroup() # RegulativeGroup | 

try:
    api_response = api_instance.regulativegroups_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeGroupApi->regulativegroups_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RegulativeGroup**](RegulativeGroup.md)|  | 

### Return type

[**RegulativeGroup**](RegulativeGroup.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

