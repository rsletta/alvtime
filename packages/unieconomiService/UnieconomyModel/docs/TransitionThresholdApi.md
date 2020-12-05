# swagger_client.TransitionThresholdApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**thresholds_get**](TransitionThresholdApi.md#thresholds_get) | **GET** /thresholds | 
[**thresholds_id_delete**](TransitionThresholdApi.md#thresholds_id_delete) | **DELETE** /thresholds/{id} | 
[**thresholds_id_get**](TransitionThresholdApi.md#thresholds_id_get) | **GET** /thresholds/{id} | 
[**thresholds_id_put**](TransitionThresholdApi.md#thresholds_id_put) | **PUT** /thresholds/{id} | 
[**thresholds_post**](TransitionThresholdApi.md#thresholds_post) | **POST** /thresholds | 

# **thresholds_get**
> list[TransitionThreshold] thresholds_get()



Query TransitionThreshold

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionThresholdApi()

try:
    api_response = api_instance.thresholds_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionThresholdApi->thresholds_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[TransitionThreshold]**](TransitionThreshold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **thresholds_id_delete**
> TransitionThreshold thresholds_id_delete(id)



Delete TransitionThreshold

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionThresholdApi()
id = 56 # int | 

try:
    api_response = api_instance.thresholds_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionThresholdApi->thresholds_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TransitionThreshold**](TransitionThreshold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **thresholds_id_get**
> TransitionThreshold thresholds_id_get(id)



Get TransitionThreshold

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionThresholdApi()
id = 56 # int | 

try:
    api_response = api_instance.thresholds_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionThresholdApi->thresholds_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**TransitionThreshold**](TransitionThreshold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **thresholds_id_put**
> TransitionThreshold thresholds_id_put(body, id)



Update TransitionThreshold

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionThresholdApi()
body = swagger_client.TransitionThreshold() # TransitionThreshold | 
id = 56 # int | 

try:
    api_response = api_instance.thresholds_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionThresholdApi->thresholds_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransitionThreshold**](TransitionThreshold.md)|  | 
 **id** | **int**|  | 

### Return type

[**TransitionThreshold**](TransitionThreshold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **thresholds_post**
> TransitionThreshold thresholds_post(body)



Create TransitionThreshold

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.TransitionThresholdApi()
body = swagger_client.TransitionThreshold() # TransitionThreshold | 

try:
    api_response = api_instance.thresholds_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransitionThresholdApi->thresholds_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransitionThreshold**](TransitionThreshold.md)|  | 

### Return type

[**TransitionThreshold**](TransitionThreshold.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

