# swagger_client.NotificationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notifications_get**](NotificationApi.md#notifications_get) | **GET** /notifications | 
[**notifications_id_delete**](NotificationApi.md#notifications_id_delete) | **DELETE** /notifications/{id} | 
[**notifications_id_get**](NotificationApi.md#notifications_id_get) | **GET** /notifications/{id} | 
[**notifications_idactionmark_as_marked_put**](NotificationApi.md#notifications_idactionmark_as_marked_put) | **PUT** /notifications/{id}?action&#x3D;mark-as-marked | 
[**notifications_idactionmark_as_read_put**](NotificationApi.md#notifications_idactionmark_as_read_put) | **PUT** /notifications/{id}?action&#x3D;mark-as-read | 
[**notifications_idactionmark_as_unread_put**](NotificationApi.md#notifications_idactionmark_as_unread_put) | **PUT** /notifications/{id}?action&#x3D;mark-as-unread | 
[**notifications_post**](NotificationApi.md#notifications_post) | **POST** /notifications | 
[**notificationsactioncount_get**](NotificationApi.md#notificationsactioncount_get) | **GET** /notifications?action&#x3D;count | 

# **notifications_get**
> list[Notification] notifications_get()



Query Notification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()

try:
    api_response = api_instance.notifications_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Notification]**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_id_delete**
> Notification notifications_id_delete(id)



Delete Notification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
id = 56 # int | 

try:
    api_response = api_instance.notifications_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_id_get**
> Notification notifications_id_get(id)



Get Notification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
id = 56 # int | 

try:
    api_response = api_instance.notifications_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_idactionmark_as_marked_put**
> Notification notifications_idactionmark_as_marked_put(id, id)



mark-as-marked Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.notifications_idactionmark_as_marked_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_idactionmark_as_marked_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_idactionmark_as_read_put**
> Notification notifications_idactionmark_as_read_put(id, id)



mark-as-read Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.notifications_idactionmark_as_read_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_idactionmark_as_read_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_idactionmark_as_unread_put**
> Notification notifications_idactionmark_as_unread_put(id, id)



mark-as-unread Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.notifications_idactionmark_as_unread_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_idactionmark_as_unread_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notifications_post**
> Notification notifications_post(body)



Create Notification

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()
body = swagger_client.Notification() # Notification | 

try:
    api_response = api_instance.notifications_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notifications_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Notification**](Notification.md)|  | 

### Return type

[**Notification**](Notification.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationsactioncount_get**
> object notificationsactioncount_get()



count Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.NotificationApi()

try:
    api_response = api_instance.notificationsactioncount_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling NotificationApi->notificationsactioncount_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

