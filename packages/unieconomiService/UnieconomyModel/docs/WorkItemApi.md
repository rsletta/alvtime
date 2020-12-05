# swagger_client.WorkItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workitems_get**](WorkItemApi.md#workitems_get) | **GET** /workitems | 
[**workitems_id_delete**](WorkItemApi.md#workitems_id_delete) | **DELETE** /workitems/{id} | 
[**workitems_id_get**](WorkItemApi.md#workitems_id_get) | **GET** /workitems/{id} | 
[**workitems_id_put**](WorkItemApi.md#workitems_id_put) | **PUT** /workitems/{id} | 
[**workitems_post**](WorkItemApi.md#workitems_post) | **POST** /workitems | 

# **workitems_get**
> list[WorkItem] workitems_get()



Query WorkItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemApi()

try:
    api_response = api_instance.workitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemApi->workitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkItem]**](WorkItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitems_id_delete**
> WorkItem workitems_id_delete(id)



Delete WorkItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemApi()
id = 56 # int | 

try:
    api_response = api_instance.workitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemApi->workitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkItem**](WorkItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitems_id_get**
> WorkItem workitems_id_get(id)



Get WorkItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemApi()
id = 56 # int | 

try:
    api_response = api_instance.workitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemApi->workitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkItem**](WorkItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitems_id_put**
> WorkItem workitems_id_put(body, id)



Update WorkItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemApi()
body = swagger_client.WorkItem() # WorkItem | 
id = 56 # int | 

try:
    api_response = api_instance.workitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemApi->workitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkItem**](WorkItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkItem**](WorkItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workitems_post**
> WorkItem workitems_post(body)



Create WorkItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkItemApi()
body = swagger_client.WorkItem() # WorkItem | 

try:
    api_response = api_instance.workitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkItemApi->workitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkItem**](WorkItem.md)|  | 

### Return type

[**WorkItem**](WorkItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

