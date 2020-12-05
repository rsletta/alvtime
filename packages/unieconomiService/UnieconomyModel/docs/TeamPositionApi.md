# swagger_client.TeamPositionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**teampositions_get**](TeamPositionApi.md#teampositions_get) | **GET** /teampositions | 
[**teampositions_id_delete**](TeamPositionApi.md#teampositions_id_delete) | **DELETE** /teampositions/{id} | 
[**teampositions_id_get**](TeamPositionApi.md#teampositions_id_get) | **GET** /teampositions/{id} | 
[**teampositions_id_put**](TeamPositionApi.md#teampositions_id_put) | **PUT** /teampositions/{id} | 
[**teampositions_post**](TeamPositionApi.md#teampositions_post) | **POST** /teampositions | 

# **teampositions_get**
> list[TeamPosition] teampositions_get()



Query TeamPosition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamPositionApi()

try:
    api_response = api_instance.teampositions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamPositionApi->teampositions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[TeamPosition]**](TeamPosition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teampositions_id_delete**
> TeamPosition teampositions_id_delete(id)



Delete TeamPosition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamPositionApi()
id = 56 # int | 

try:
    api_response = api_instance.teampositions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamPositionApi->teampositions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TeamPosition**](TeamPosition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teampositions_id_get**
> TeamPosition teampositions_id_get(id)



Get TeamPosition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamPositionApi()
id = 56 # int | 

try:
    api_response = api_instance.teampositions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamPositionApi->teampositions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TeamPosition**](TeamPosition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teampositions_id_put**
> TeamPosition teampositions_id_put(body, id)



Update TeamPosition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamPositionApi()
body = swagger_client.TeamPosition() # TeamPosition | 
id = 56 # int | 

try:
    api_response = api_instance.teampositions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamPositionApi->teampositions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamPosition**](TeamPosition.md)|  | 
 **id** | **int**|  | 

### Return type

[**TeamPosition**](TeamPosition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **teampositions_post**
> TeamPosition teampositions_post(body)



Create TeamPosition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TeamPositionApi()
body = swagger_client.TeamPosition() # TeamPosition | 

try:
    api_response = api_instance.teampositions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TeamPositionApi->teampositions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TeamPosition**](TeamPosition.md)|  | 

### Return type

[**TeamPosition**](TeamPosition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

