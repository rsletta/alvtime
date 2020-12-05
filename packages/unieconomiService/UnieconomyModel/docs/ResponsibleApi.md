# swagger_client.ResponsibleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**responsibles_get**](ResponsibleApi.md#responsibles_get) | **GET** /responsibles | 
[**responsibles_id_delete**](ResponsibleApi.md#responsibles_id_delete) | **DELETE** /responsibles/{id} | 
[**responsibles_id_get**](ResponsibleApi.md#responsibles_id_get) | **GET** /responsibles/{id} | 
[**responsibles_id_put**](ResponsibleApi.md#responsibles_id_put) | **PUT** /responsibles/{id} | 
[**responsibles_post**](ResponsibleApi.md#responsibles_post) | **POST** /responsibles | 

# **responsibles_get**
> list[Responsible] responsibles_get()



Query Responsible

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ResponsibleApi()

try:
    api_response = api_instance.responsibles_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ResponsibleApi->responsibles_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Responsible]**](Responsible.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **responsibles_id_delete**
> Responsible responsibles_id_delete(id)



Delete Responsible

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ResponsibleApi()
id = 56 # int | 

try:
    api_response = api_instance.responsibles_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ResponsibleApi->responsibles_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Responsible**](Responsible.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **responsibles_id_get**
> Responsible responsibles_id_get(id)



Get Responsible

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ResponsibleApi()
id = 56 # int | 

try:
    api_response = api_instance.responsibles_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ResponsibleApi->responsibles_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Responsible**](Responsible.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **responsibles_id_put**
> Responsible responsibles_id_put(body, id)



Update Responsible

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ResponsibleApi()
body = swagger_client.Responsible() # Responsible | 
id = 56 # int | 

try:
    api_response = api_instance.responsibles_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ResponsibleApi->responsibles_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Responsible**](Responsible.md)|  | 
 **id** | **int**|  | 

### Return type

[**Responsible**](Responsible.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **responsibles_post**
> Responsible responsibles_post(body)



Create Responsible

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ResponsibleApi()
body = swagger_client.Responsible() # Responsible | 

try:
    api_response = api_instance.responsibles_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ResponsibleApi->responsibles_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Responsible**](Responsible.md)|  | 

### Return type

[**Responsible**](Responsible.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

