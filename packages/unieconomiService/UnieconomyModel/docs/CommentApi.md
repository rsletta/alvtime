# swagger_client.CommentApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**comments_entitytype_entityid_get**](CommentApi.md#comments_entitytype_entityid_get) | **GET** /comments/{entitytype}/{entityid} | 
[**comments_entitytype_entityid_id_delete**](CommentApi.md#comments_entitytype_entityid_id_delete) | **DELETE** /comments/{entitytype}/{entityid}/{id} | 
[**comments_entitytype_entityid_post**](CommentApi.md#comments_entitytype_entityid_post) | **POST** /comments/{entitytype}/{entityid} | 
[**comments_get**](CommentApi.md#comments_get) | **GET** /comments | 
[**comments_id_delete**](CommentApi.md#comments_id_delete) | **DELETE** /comments/{id} | 
[**comments_id_get**](CommentApi.md#comments_id_get) | **GET** /comments/{id} | 
[**comments_id_put**](CommentApi.md#comments_id_put) | **PUT** /comments/{id} | 

# **comments_entitytype_entityid_get**
> list[Comment] comments_entitytype_entityid_get()



Query Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()

try:
    api_response = api_instance.comments_entitytype_entityid_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_entitytype_entityid_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Comment]**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_entitytype_entityid_id_delete**
> Comment comments_entitytype_entityid_id_delete(id)



Delete Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()
id = 56 # int | 

try:
    api_response = api_instance.comments_entitytype_entityid_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_entitytype_entityid_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_entitytype_entityid_post**
> Comment comments_entitytype_entityid_post(body)



Create Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()
body = swagger_client.Comment() # Comment | 

try:
    api_response = api_instance.comments_entitytype_entityid_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_entitytype_entityid_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Comment**](Comment.md)|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_get**
> list[Comment] comments_get()



Query Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()

try:
    api_response = api_instance.comments_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Comment]**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_id_delete**
> Comment comments_id_delete(id)



Delete Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()
id = 56 # int | 

try:
    api_response = api_instance.comments_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_id_get**
> Comment comments_id_get(id)



Get Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()
id = 56 # int | 

try:
    api_response = api_instance.comments_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **comments_id_put**
> Comment comments_id_put(body, id)



Update Comment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CommentApi()
body = swagger_client.Comment() # Comment | 
id = 56 # int | 

try:
    api_response = api_instance.comments_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CommentApi->comments_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Comment**](Comment.md)|  | 
 **id** | **int**|  | 

### Return type

[**Comment**](Comment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

