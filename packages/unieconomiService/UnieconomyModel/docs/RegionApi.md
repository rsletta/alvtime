# swagger_client.RegionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**regions_get**](RegionApi.md#regions_get) | **GET** /regions | 
[**regions_id_delete**](RegionApi.md#regions_id_delete) | **DELETE** /regions/{id} | 
[**regions_id_get**](RegionApi.md#regions_id_get) | **GET** /regions/{id} | 
[**regions_id_put**](RegionApi.md#regions_id_put) | **PUT** /regions/{id} | 
[**regions_post**](RegionApi.md#regions_post) | **POST** /regions | 

# **regions_get**
> list[Region] regions_get()



Query Region

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegionApi()

try:
    api_response = api_instance.regions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegionApi->regions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Region]**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regions_id_delete**
> Region regions_id_delete(id)



Delete Region

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegionApi()
id = 56 # int | 

try:
    api_response = api_instance.regions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegionApi->regions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regions_id_get**
> Region regions_id_get(id)



Get Region

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegionApi()
id = 56 # int | 

try:
    api_response = api_instance.regions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegionApi->regions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regions_id_put**
> Region regions_id_put(body, id)



Update Region

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegionApi()
body = swagger_client.Region() # Region | 
id = 56 # int | 

try:
    api_response = api_instance.regions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegionApi->regions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Region**](Region.md)|  | 
 **id** | **int**|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regions_post**
> Region regions_post(body)



Create Region

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegionApi()
body = swagger_client.Region() # Region | 

try:
    api_response = api_instance.regions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegionApi->regions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Region**](Region.md)|  | 

### Return type

[**Region**](Region.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

