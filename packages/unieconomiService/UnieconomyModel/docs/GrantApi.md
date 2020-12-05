# swagger_client.GrantApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**grants_get**](GrantApi.md#grants_get) | **GET** /grants | 
[**grants_id_delete**](GrantApi.md#grants_id_delete) | **DELETE** /grants/{id} | 
[**grants_id_get**](GrantApi.md#grants_id_get) | **GET** /grants/{id} | 
[**grants_id_put**](GrantApi.md#grants_id_put) | **PUT** /grants/{id} | 
[**grants_post**](GrantApi.md#grants_post) | **POST** /grants | 

# **grants_get**
> list[Grant] grants_get()



Query Grant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GrantApi()

try:
    api_response = api_instance.grants_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling GrantApi->grants_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Grant]**](Grant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **grants_id_delete**
> Grant grants_id_delete(id)



Delete Grant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GrantApi()
id = 56 # int | 

try:
    api_response = api_instance.grants_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling GrantApi->grants_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Grant**](Grant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **grants_id_get**
> Grant grants_id_get(id)



Get Grant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GrantApi()
id = 56 # int | 

try:
    api_response = api_instance.grants_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling GrantApi->grants_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Grant**](Grant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **grants_id_put**
> Grant grants_id_put(body, id)



Update Grant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GrantApi()
body = swagger_client.Grant() # Grant | 
id = 56 # int | 

try:
    api_response = api_instance.grants_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling GrantApi->grants_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Grant**](Grant.md)|  | 
 **id** | **int**|  | 

### Return type

[**Grant**](Grant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **grants_post**
> Grant grants_post(body)



Create Grant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.GrantApi()
body = swagger_client.Grant() # Grant | 

try:
    api_response = api_instance.grants_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling GrantApi->grants_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Grant**](Grant.md)|  | 

### Return type

[**Grant**](Grant.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

