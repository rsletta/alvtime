# swagger_client.EventplanApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventplans_get**](EventplanApi.md#eventplans_get) | **GET** /eventplans | 
[**eventplans_id_delete**](EventplanApi.md#eventplans_id_delete) | **DELETE** /eventplans/{id} | 
[**eventplans_id_get**](EventplanApi.md#eventplans_id_get) | **GET** /eventplans/{id} | 
[**eventplans_id_put**](EventplanApi.md#eventplans_id_put) | **PUT** /eventplans/{id} | 
[**eventplans_post**](EventplanApi.md#eventplans_post) | **POST** /eventplans | 

# **eventplans_get**
> list[Eventplan] eventplans_get()



Query Eventplan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventplanApi()

try:
    api_response = api_instance.eventplans_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventplanApi->eventplans_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Eventplan]**](Eventplan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventplans_id_delete**
> Eventplan eventplans_id_delete(id)



Delete Eventplan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventplanApi()
id = 56 # int | 

try:
    api_response = api_instance.eventplans_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventplanApi->eventplans_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Eventplan**](Eventplan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventplans_id_get**
> Eventplan eventplans_id_get(id)



Get Eventplan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventplanApi()
id = 56 # int | 

try:
    api_response = api_instance.eventplans_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventplanApi->eventplans_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Eventplan**](Eventplan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventplans_id_put**
> Eventplan eventplans_id_put(body, id)



Update Eventplan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventplanApi()
body = swagger_client.Eventplan() # Eventplan | 
id = 56 # int | 

try:
    api_response = api_instance.eventplans_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventplanApi->eventplans_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Eventplan**](Eventplan.md)|  | 
 **id** | **int**|  | 

### Return type

[**Eventplan**](Eventplan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventplans_post**
> Eventplan eventplans_post(body)



Create Eventplan

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.EventplanApi()
body = swagger_client.Eventplan() # Eventplan | 

try:
    api_response = api_instance.eventplans_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling EventplanApi->eventplans_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Eventplan**](Eventplan.md)|  | 

### Return type

[**Eventplan**](Eventplan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

