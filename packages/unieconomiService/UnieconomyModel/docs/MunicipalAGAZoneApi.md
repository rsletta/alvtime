# swagger_client.MunicipalAGAZoneApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**municipal_aga_zones_get**](MunicipalAGAZoneApi.md#municipal_aga_zones_get) | **GET** /MunicipalAGAZones | 
[**municipal_aga_zones_id_delete**](MunicipalAGAZoneApi.md#municipal_aga_zones_id_delete) | **DELETE** /MunicipalAGAZones/{id} | 
[**municipal_aga_zones_id_get**](MunicipalAGAZoneApi.md#municipal_aga_zones_id_get) | **GET** /MunicipalAGAZones/{id} | 
[**municipal_aga_zones_id_put**](MunicipalAGAZoneApi.md#municipal_aga_zones_id_put) | **PUT** /MunicipalAGAZones/{id} | 
[**municipal_aga_zones_post**](MunicipalAGAZoneApi.md#municipal_aga_zones_post) | **POST** /MunicipalAGAZones | 

# **municipal_aga_zones_get**
> list[MunicipalAGAZone] municipal_aga_zones_get()



Query MunicipalAGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalAGAZoneApi()

try:
    api_response = api_instance.municipal_aga_zones_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalAGAZoneApi->municipal_aga_zones_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[MunicipalAGAZone]**](MunicipalAGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipal_aga_zones_id_delete**
> MunicipalAGAZone municipal_aga_zones_id_delete(id)



Delete MunicipalAGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalAGAZoneApi()
id = 56 # int | 

try:
    api_response = api_instance.municipal_aga_zones_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalAGAZoneApi->municipal_aga_zones_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**MunicipalAGAZone**](MunicipalAGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipal_aga_zones_id_get**
> MunicipalAGAZone municipal_aga_zones_id_get(id)



Get MunicipalAGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalAGAZoneApi()
id = 56 # int | 

try:
    api_response = api_instance.municipal_aga_zones_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalAGAZoneApi->municipal_aga_zones_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**MunicipalAGAZone**](MunicipalAGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipal_aga_zones_id_put**
> MunicipalAGAZone municipal_aga_zones_id_put(body, id)



Update MunicipalAGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalAGAZoneApi()
body = swagger_client.MunicipalAGAZone() # MunicipalAGAZone | 
id = 56 # int | 

try:
    api_response = api_instance.municipal_aga_zones_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalAGAZoneApi->municipal_aga_zones_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MunicipalAGAZone**](MunicipalAGAZone.md)|  | 
 **id** | **int**|  | 

### Return type

[**MunicipalAGAZone**](MunicipalAGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **municipal_aga_zones_post**
> MunicipalAGAZone municipal_aga_zones_post(body)



Create MunicipalAGAZone

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.MunicipalAGAZoneApi()
body = swagger_client.MunicipalAGAZone() # MunicipalAGAZone | 

try:
    api_response = api_instance.municipal_aga_zones_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MunicipalAGAZoneApi->municipal_aga_zones_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MunicipalAGAZone**](MunicipalAGAZone.md)|  | 

### Return type

[**MunicipalAGAZone**](MunicipalAGAZone.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

