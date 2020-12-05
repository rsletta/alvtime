# swagger_client.ExpressionFilterApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**expressionfilters_get**](ExpressionFilterApi.md#expressionfilters_get) | **GET** /expressionfilters | 
[**expressionfilters_id_delete**](ExpressionFilterApi.md#expressionfilters_id_delete) | **DELETE** /expressionfilters/{id} | 
[**expressionfilters_id_get**](ExpressionFilterApi.md#expressionfilters_id_get) | **GET** /expressionfilters/{id} | 
[**expressionfilters_id_put**](ExpressionFilterApi.md#expressionfilters_id_put) | **PUT** /expressionfilters/{id} | 
[**expressionfilters_post**](ExpressionFilterApi.md#expressionfilters_post) | **POST** /expressionfilters | 

# **expressionfilters_get**
> list[ExpressionFilter] expressionfilters_get()



Query ExpressionFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ExpressionFilterApi()

try:
    api_response = api_instance.expressionfilters_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ExpressionFilterApi->expressionfilters_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ExpressionFilter]**](ExpressionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **expressionfilters_id_delete**
> ExpressionFilter expressionfilters_id_delete(id)



Delete ExpressionFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ExpressionFilterApi()
id = 56 # int | 

try:
    api_response = api_instance.expressionfilters_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ExpressionFilterApi->expressionfilters_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ExpressionFilter**](ExpressionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **expressionfilters_id_get**
> ExpressionFilter expressionfilters_id_get(id)



Get ExpressionFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ExpressionFilterApi()
id = 56 # int | 

try:
    api_response = api_instance.expressionfilters_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ExpressionFilterApi->expressionfilters_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ExpressionFilter**](ExpressionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **expressionfilters_id_put**
> ExpressionFilter expressionfilters_id_put(body, id)



Update ExpressionFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ExpressionFilterApi()
body = swagger_client.ExpressionFilter() # ExpressionFilter | 
id = 56 # int | 

try:
    api_response = api_instance.expressionfilters_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ExpressionFilterApi->expressionfilters_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExpressionFilter**](ExpressionFilter.md)|  | 
 **id** | **int**|  | 

### Return type

[**ExpressionFilter**](ExpressionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **expressionfilters_post**
> ExpressionFilter expressionfilters_post(body)



Create ExpressionFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ExpressionFilterApi()
body = swagger_client.ExpressionFilter() # ExpressionFilter | 

try:
    api_response = api_instance.expressionfilters_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ExpressionFilterApi->expressionfilters_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExpressionFilter**](ExpressionFilter.md)|  | 

### Return type

[**ExpressionFilter**](ExpressionFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

