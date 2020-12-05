# swagger_client.ValueItemApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**valueitems_get**](ValueItemApi.md#valueitems_get) | **GET** /valueitems | 
[**valueitems_id_delete**](ValueItemApi.md#valueitems_id_delete) | **DELETE** /valueitems/{id} | 
[**valueitems_id_get**](ValueItemApi.md#valueitems_id_get) | **GET** /valueitems/{id} | 
[**valueitems_id_put**](ValueItemApi.md#valueitems_id_put) | **PUT** /valueitems/{id} | 
[**valueitems_post**](ValueItemApi.md#valueitems_post) | **POST** /valueitems | 

# **valueitems_get**
> list[ValueItem] valueitems_get()



Query ValueItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueItemApi()

try:
    api_response = api_instance.valueitems_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueItemApi->valueitems_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ValueItem]**](ValueItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valueitems_id_delete**
> ValueItem valueitems_id_delete(id)



Delete ValueItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueItemApi()
id = 56 # int | 

try:
    api_response = api_instance.valueitems_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueItemApi->valueitems_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ValueItem**](ValueItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valueitems_id_get**
> ValueItem valueitems_id_get(id)



Get ValueItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueItemApi()
id = 56 # int | 

try:
    api_response = api_instance.valueitems_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueItemApi->valueitems_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ValueItem**](ValueItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valueitems_id_put**
> ValueItem valueitems_id_put(body, id)



Update ValueItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueItemApi()
body = swagger_client.ValueItem() # ValueItem | 
id = 56 # int | 

try:
    api_response = api_instance.valueitems_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueItemApi->valueitems_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ValueItem**](ValueItem.md)|  | 
 **id** | **int**|  | 

### Return type

[**ValueItem**](ValueItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valueitems_post**
> ValueItem valueitems_post(body)



Create ValueItem

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueItemApi()
body = swagger_client.ValueItem() # ValueItem | 

try:
    api_response = api_instance.valueitems_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueItemApi->valueitems_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ValueItem**](ValueItem.md)|  | 

### Return type

[**ValueItem**](ValueItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

