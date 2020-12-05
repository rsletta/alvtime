# swagger_client.UniQueryDefinitionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**uniquerydefinitions_get**](UniQueryDefinitionApi.md#uniquerydefinitions_get) | **GET** /uniquerydefinitions | 
[**uniquerydefinitions_id_delete**](UniQueryDefinitionApi.md#uniquerydefinitions_id_delete) | **DELETE** /uniquerydefinitions/{id} | 
[**uniquerydefinitions_id_get**](UniQueryDefinitionApi.md#uniquerydefinitions_id_get) | **GET** /uniquerydefinitions/{id} | 
[**uniquerydefinitions_id_put**](UniQueryDefinitionApi.md#uniquerydefinitions_id_put) | **PUT** /uniquerydefinitions/{id} | 
[**uniquerydefinitions_post**](UniQueryDefinitionApi.md#uniquerydefinitions_post) | **POST** /uniquerydefinitions | 
[**uniquerydefinitionsactionget_distinct_querydefinition_categories_get**](UniQueryDefinitionApi.md#uniquerydefinitionsactionget_distinct_querydefinition_categories_get) | **GET** /uniquerydefinitions?action&#x3D;get-distinct-querydefinition-categories | 

# **uniquerydefinitions_get**
> list[UniQueryDefinition] uniquerydefinitions_get()



Query UniQueryDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()

try:
    api_response = api_instance.uniquerydefinitions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[UniQueryDefinition]**](UniQueryDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniquerydefinitions_id_delete**
> UniQueryDefinition uniquerydefinitions_id_delete(id)



Delete UniQueryDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()
id = 56 # int | 

try:
    api_response = api_instance.uniquerydefinitions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryDefinition**](UniQueryDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniquerydefinitions_id_get**
> UniQueryDefinition uniquerydefinitions_id_get(id)



Get UniQueryDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()
id = 56 # int | 

try:
    api_response = api_instance.uniquerydefinitions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryDefinition**](UniQueryDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniquerydefinitions_id_put**
> UniQueryDefinition uniquerydefinitions_id_put(body, id)



Update UniQueryDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()
body = swagger_client.UniQueryDefinition() # UniQueryDefinition | 
id = 56 # int | 

try:
    api_response = api_instance.uniquerydefinitions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryDefinition**](UniQueryDefinition.md)|  | 
 **id** | **int**|  | 

### Return type

[**UniQueryDefinition**](UniQueryDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniquerydefinitions_post**
> UniQueryDefinition uniquerydefinitions_post(body)



Create UniQueryDefinition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()
body = swagger_client.UniQueryDefinition() # UniQueryDefinition | 

try:
    api_response = api_instance.uniquerydefinitions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryDefinition**](UniQueryDefinition.md)|  | 

### Return type

[**UniQueryDefinition**](UniQueryDefinition.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniquerydefinitionsactionget_distinct_querydefinition_categories_get**
> str uniquerydefinitionsactionget_distinct_querydefinition_categories_get()



get-distinct-querydefinition-categories Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryDefinitionApi()

try:
    api_response = api_instance.uniquerydefinitionsactionget_distinct_querydefinition_categories_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryDefinitionApi->uniquerydefinitionsactionget_distinct_querydefinition_categories_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

