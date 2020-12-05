# swagger_client.TravelLineApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**travellines_get**](TravelLineApi.md#travellines_get) | **GET** /travellines | 
[**travellines_id_delete**](TravelLineApi.md#travellines_id_delete) | **DELETE** /travellines/{id} | 
[**travellines_id_get**](TravelLineApi.md#travellines_id_get) | **GET** /travellines/{id} | 
[**travellines_id_put**](TravelLineApi.md#travellines_id_put) | **PUT** /travellines/{id} | 
[**travellines_idactionattachment_put**](TravelLineApi.md#travellines_idactionattachment_put) | **PUT** /travellines/{id}?action&#x3D;attachment | 
[**travellines_post**](TravelLineApi.md#travellines_post) | **POST** /travellines | 

# **travellines_get**
> list[TravelLine] travellines_get()



Query TravelLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()

try:
    api_response = api_instance.travellines_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[TravelLine]**](TravelLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travellines_id_delete**
> TravelLine travellines_id_delete(id)



Delete TravelLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()
id = 56 # int | 

try:
    api_response = api_instance.travellines_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TravelLine**](TravelLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travellines_id_get**
> TravelLine travellines_id_get(id)



Get TravelLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()
id = 56 # int | 

try:
    api_response = api_instance.travellines_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TravelLine**](TravelLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travellines_id_put**
> TravelLine travellines_id_put(body, id)



Update TravelLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()
body = swagger_client.TravelLine() # TravelLine | 
id = 56 # int | 

try:
    api_response = api_instance.travellines_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TravelLine**](TravelLine.md)|  | 
 **id** | **int**|  | 

### Return type

[**TravelLine**](TravelLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travellines_idactionattachment_put**
> File travellines_idactionattachment_put(id, id)



attachment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.travellines_idactionattachment_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_idactionattachment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**File**](File.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **travellines_post**
> TravelLine travellines_post(body)



Create TravelLine

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TravelLineApi()
body = swagger_client.TravelLine() # TravelLine | 

try:
    api_response = api_instance.travellines_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TravelLineApi->travellines_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TravelLine**](TravelLine.md)|  | 

### Return type

[**TravelLine**](TravelLine.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

