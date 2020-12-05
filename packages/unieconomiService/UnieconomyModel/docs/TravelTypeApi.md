# swagger_client.TravelTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**traveltype_get**](TravelTypeApi.md#traveltype_get) | **GET** /traveltype | 
[**traveltype_id_delete**](TravelTypeApi.md#traveltype_id_delete) | **DELETE** /traveltype/{id} | 
[**traveltype_id_get**](TravelTypeApi.md#traveltype_id_get) | **GET** /traveltype/{id} | 
[**traveltype_id_put**](TravelTypeApi.md#traveltype_id_put) | **PUT** /traveltype/{id} | 
[**traveltype_post**](TravelTypeApi.md#traveltype_post) | **POST** /traveltype | 

# **traveltype_get**
> list[TravelType] traveltype_get()



Query TravelType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelTypeApi()

try:
    api_response = api_instance.traveltype_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelTypeApi->traveltype_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[TravelType]**](TravelType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **traveltype_id_delete**
> TravelType traveltype_id_delete(id)



Delete TravelType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.traveltype_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelTypeApi->traveltype_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TravelType**](TravelType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **traveltype_id_get**
> TravelType traveltype_id_get(id)



Get TravelType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.traveltype_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelTypeApi->traveltype_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TravelType**](TravelType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **traveltype_id_put**
> TravelType traveltype_id_put(body, id)



Update TravelType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelTypeApi()
body = swagger_client.TravelType() # TravelType | 
id = 56 # int | 

try:
    api_response = api_instance.traveltype_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelTypeApi->traveltype_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TravelType**](TravelType.md)|  | 
 **id** | **int**|  | 

### Return type

[**TravelType**](TravelType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **traveltype_post**
> TravelType traveltype_post(body)



Create TravelType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelTypeApi()
body = swagger_client.TravelType() # TravelType | 

try:
    api_response = api_instance.traveltype_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelTypeApi->traveltype_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TravelType**](TravelType.md)|  | 

### Return type

[**TravelType**](TravelType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

