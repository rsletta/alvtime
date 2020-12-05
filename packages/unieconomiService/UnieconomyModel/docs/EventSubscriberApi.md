# swagger_client.EventSubscriberApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventsubscribers_get**](EventSubscriberApi.md#eventsubscribers_get) | **GET** /eventsubscribers | 
[**eventsubscribers_id_delete**](EventSubscriberApi.md#eventsubscribers_id_delete) | **DELETE** /eventsubscribers/{id} | 
[**eventsubscribers_id_get**](EventSubscriberApi.md#eventsubscribers_id_get) | **GET** /eventsubscribers/{id} | 
[**eventsubscribers_id_put**](EventSubscriberApi.md#eventsubscribers_id_put) | **PUT** /eventsubscribers/{id} | 
[**eventsubscribers_post**](EventSubscriberApi.md#eventsubscribers_post) | **POST** /eventsubscribers | 

# **eventsubscribers_get**
> list[EventSubscriber] eventsubscribers_get()



Query EventSubscriber

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventSubscriberApi()

try:
    api_response = api_instance.eventsubscribers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventSubscriberApi->eventsubscribers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[EventSubscriber]**](EventSubscriber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsubscribers_id_delete**
> EventSubscriber eventsubscribers_id_delete(id)



Delete EventSubscriber

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventSubscriberApi()
id = 56 # int | 

try:
    api_response = api_instance.eventsubscribers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventSubscriberApi->eventsubscribers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EventSubscriber**](EventSubscriber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsubscribers_id_get**
> EventSubscriber eventsubscribers_id_get(id)



Get EventSubscriber

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventSubscriberApi()
id = 56 # int | 

try:
    api_response = api_instance.eventsubscribers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventSubscriberApi->eventsubscribers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**EventSubscriber**](EventSubscriber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsubscribers_id_put**
> EventSubscriber eventsubscribers_id_put(body, id)



Update EventSubscriber

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventSubscriberApi()
body = swagger_client.EventSubscriber() # EventSubscriber | 
id = 56 # int | 

try:
    api_response = api_instance.eventsubscribers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventSubscriberApi->eventsubscribers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventSubscriber**](EventSubscriber.md)|  | 
 **id** | **int**|  | 

### Return type

[**EventSubscriber**](EventSubscriber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventsubscribers_post**
> EventSubscriber eventsubscribers_post(body)



Create EventSubscriber

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventSubscriberApi()
body = swagger_client.EventSubscriber() # EventSubscriber | 

try:
    api_response = api_instance.eventsubscribers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventSubscriberApi->eventsubscribers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventSubscriber**](EventSubscriber.md)|  | 

### Return type

[**EventSubscriber**](EventSubscriber.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

