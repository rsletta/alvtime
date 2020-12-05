# swagger_client.DimensionSettingsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimensionsettings_get**](DimensionSettingsApi.md#dimensionsettings_get) | **GET** /dimensionsettings | 
[**dimensionsettings_id_delete**](DimensionSettingsApi.md#dimensionsettings_id_delete) | **DELETE** /dimensionsettings/{id} | 
[**dimensionsettings_id_get**](DimensionSettingsApi.md#dimensionsettings_id_get) | **GET** /dimensionsettings/{id} | 
[**dimensionsettings_id_put**](DimensionSettingsApi.md#dimensionsettings_id_put) | **PUT** /dimensionsettings/{id} | 
[**dimensionsettings_post**](DimensionSettingsApi.md#dimensionsettings_post) | **POST** /dimensionsettings | 

# **dimensionsettings_get**
> list[DimensionSettings] dimensionsettings_get()



Query DimensionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionSettingsApi()

try:
    api_response = api_instance.dimensionsettings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionSettingsApi->dimensionsettings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[DimensionSettings]**](DimensionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimensionsettings_id_delete**
> DimensionSettings dimensionsettings_id_delete(id)



Delete DimensionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.dimensionsettings_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionSettingsApi->dimensionsettings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DimensionSettings**](DimensionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimensionsettings_id_get**
> DimensionSettings dimensionsettings_id_get(id)



Get DimensionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.dimensionsettings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionSettingsApi->dimensionsettings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DimensionSettings**](DimensionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimensionsettings_id_put**
> DimensionSettings dimensionsettings_id_put(body, id)



Update DimensionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionSettingsApi()
body = swagger_client.DimensionSettings() # DimensionSettings | 
id = 56 # int | 

try:
    api_response = api_instance.dimensionsettings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionSettingsApi->dimensionsettings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DimensionSettings**](DimensionSettings.md)|  | 
 **id** | **int**|  | 

### Return type

[**DimensionSettings**](DimensionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimensionsettings_post**
> DimensionSettings dimensionsettings_post(body)



Create DimensionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DimensionSettingsApi()
body = swagger_client.DimensionSettings() # DimensionSettings | 

try:
    api_response = api_instance.dimensionsettings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DimensionSettingsApi->dimensionsettings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DimensionSettings**](DimensionSettings.md)|  | 

### Return type

[**DimensionSettings**](DimensionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

