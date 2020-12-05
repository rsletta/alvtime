# swagger_client.CostAllocationItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**costallocationitems_get**](CostAllocationItemApi.md#costallocationitems_get) | **GET** /costallocationitems | 
[**costallocationitems_id_delete**](CostAllocationItemApi.md#costallocationitems_id_delete) | **DELETE** /costallocationitems/{id} | 
[**costallocationitems_id_get**](CostAllocationItemApi.md#costallocationitems_id_get) | **GET** /costallocationitems/{id} | 
[**costallocationitems_id_put**](CostAllocationItemApi.md#costallocationitems_id_put) | **PUT** /costallocationitems/{id} | 
[**costallocationitems_post**](CostAllocationItemApi.md#costallocationitems_post) | **POST** /costallocationitems | 

# **costallocationitems_get**
> list[CostAllocationItem] costallocationitems_get()



Query CostAllocationItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationItemApi()

try:
    api_response = api_instance.costallocationitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationItemApi->costallocationitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CostAllocationItem]**](CostAllocationItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationitems_id_delete**
> CostAllocationItem costallocationitems_id_delete(id)



Delete CostAllocationItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationItemApi()
id = 56 # int | 

try:
    api_response = api_instance.costallocationitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationItemApi->costallocationitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CostAllocationItem**](CostAllocationItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationitems_id_get**
> CostAllocationItem costallocationitems_id_get(id)



Get CostAllocationItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationItemApi()
id = 56 # int | 

try:
    api_response = api_instance.costallocationitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationItemApi->costallocationitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CostAllocationItem**](CostAllocationItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationitems_id_put**
> CostAllocationItem costallocationitems_id_put(body, id)



Update CostAllocationItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationItemApi()
body = swagger_client.CostAllocationItem() # CostAllocationItem | 
id = 56 # int | 

try:
    api_response = api_instance.costallocationitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationItemApi->costallocationitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CostAllocationItem**](CostAllocationItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**CostAllocationItem**](CostAllocationItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationitems_post**
> CostAllocationItem costallocationitems_post(body)



Create CostAllocationItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationItemApi()
body = swagger_client.CostAllocationItem() # CostAllocationItem | 

try:
    api_response = api_instance.costallocationitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationItemApi->costallocationitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CostAllocationItem**](CostAllocationItem.md)|  | 

### Return type

[**CostAllocationItem**](CostAllocationItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

