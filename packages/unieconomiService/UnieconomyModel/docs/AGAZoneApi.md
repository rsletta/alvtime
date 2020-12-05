# swagger_client.AGAZoneApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**a_ga_zones_get**](AGAZoneApi.md#a_ga_zones_get) | **GET** /AGAZones | 
[**a_ga_zones_id_get**](AGAZoneApi.md#a_ga_zones_id_get) | **GET** /AGAZones/{id} | 
[**a_ga_zones_id_put**](AGAZoneApi.md#a_ga_zones_id_put) | **PUT** /AGAZones/{id} | 
[**a_ga_zones_post**](AGAZoneApi.md#a_ga_zones_post) | **POST** /AGAZones | 
[**a_ga_zonesactionget_agasectors_get**](AGAZoneApi.md#a_ga_zonesactionget_agasectors_get) | **GET** /AGAZones?action&#x3D;get-agasectors | 

# **a_ga_zones_get**
> list[AGAZone] a_ga_zones_get()



Query AGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGAZoneApi()

try:
    api_response = api_instance.a_ga_zones_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGAZoneApi->a_ga_zones_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AGAZone]**](AGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **a_ga_zones_id_get**
> AGAZone a_ga_zones_id_get(id)



Get AGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGAZoneApi()
id = 56 # int | 

try:
    api_response = api_instance.a_ga_zones_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGAZoneApi->a_ga_zones_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AGAZone**](AGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **a_ga_zones_id_put**
> AGAZone a_ga_zones_id_put(body, id)



Update AGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGAZoneApi()
body = swagger_client.AGAZone() # AGAZone | 
id = 56 # int | 

try:
    api_response = api_instance.a_ga_zones_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGAZoneApi->a_ga_zones_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AGAZone**](AGAZone.md)|  | 
 **id** | **int**|  | 

### Return type

[**AGAZone**](AGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **a_ga_zones_post**
> AGAZone a_ga_zones_post(body)



Create AGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGAZoneApi()
body = swagger_client.AGAZone() # AGAZone | 

try:
    api_response = api_instance.a_ga_zones_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGAZoneApi->a_ga_zones_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AGAZone**](AGAZone.md)|  | 

### Return type

[**AGAZone**](AGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **a_ga_zonesactionget_agasectors_get**
> list[AGASector] a_ga_zonesactionget_agasectors_get()



get-agasectors Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGAZoneApi()

try:
    api_response = api_instance.a_ga_zonesactionget_agasectors_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGAZoneApi->a_ga_zonesactionget_agasectors_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AGASector]**](AGASector.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

