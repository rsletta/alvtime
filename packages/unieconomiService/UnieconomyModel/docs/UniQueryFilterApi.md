# swagger_client.UniQueryFilterApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**uniqueryfilters_get**](UniQueryFilterApi.md#uniqueryfilters_get) | **GET** /uniqueryfilters | 
[**uniqueryfilters_id_delete**](UniQueryFilterApi.md#uniqueryfilters_id_delete) | **DELETE** /uniqueryfilters/{id} | 
[**uniqueryfilters_id_get**](UniQueryFilterApi.md#uniqueryfilters_id_get) | **GET** /uniqueryfilters/{id} | 
[**uniqueryfilters_id_put**](UniQueryFilterApi.md#uniqueryfilters_id_put) | **PUT** /uniqueryfilters/{id} | 
[**uniqueryfilters_post**](UniQueryFilterApi.md#uniqueryfilters_post) | **POST** /uniqueryfilters | 

# **uniqueryfilters_get**
> list[UniQueryFilter] uniqueryfilters_get()



Query UniQueryFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFilterApi()

try:
    api_response = api_instance.uniqueryfilters_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFilterApi->uniqueryfilters_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[UniQueryFilter]**](UniQueryFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfilters_id_delete**
> UniQueryFilter uniqueryfilters_id_delete(id)



Delete UniQueryFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFilterApi()
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfilters_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFilterApi->uniqueryfilters_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryFilter**](UniQueryFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfilters_id_get**
> UniQueryFilter uniqueryfilters_id_get(id)



Get UniQueryFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFilterApi()
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfilters_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFilterApi->uniqueryfilters_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**UniQueryFilter**](UniQueryFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfilters_id_put**
> UniQueryFilter uniqueryfilters_id_put(body, id)



Update UniQueryFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFilterApi()
body = swagger_client.UniQueryFilter() # UniQueryFilter | 
id = 56 # int | 

try:
    api_response = api_instance.uniqueryfilters_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFilterApi->uniqueryfilters_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryFilter**](UniQueryFilter.md)|  | 
 **id** | **int**|  | 

### Return type

[**UniQueryFilter**](UniQueryFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **uniqueryfilters_post**
> UniQueryFilter uniqueryfilters_post(body)



Create UniQueryFilter

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UniQueryFilterApi()
body = swagger_client.UniQueryFilter() # UniQueryFilter | 

try:
    api_response = api_instance.uniqueryfilters_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UniQueryFilterApi->uniqueryfilters_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UniQueryFilter**](UniQueryFilter.md)|  | 

### Return type

[**UniQueryFilter**](UniQueryFilter.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

