# swagger_client.Dimension8Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension8_get**](Dimension8Api.md#dimension8_get) | **GET** /Dimension8 | 
[**dimension8_id_delete**](Dimension8Api.md#dimension8_id_delete) | **DELETE** /Dimension8/{id} | 
[**dimension8_id_get**](Dimension8Api.md#dimension8_id_get) | **GET** /Dimension8/{id} | 
[**dimension8_id_put**](Dimension8Api.md#dimension8_id_put) | **PUT** /Dimension8/{id} | 
[**dimension8_idactionis_used_get**](Dimension8Api.md#dimension8_idactionis_used_get) | **GET** /Dimension8/{id}?action&#x3D;is-used | 
[**dimension8_post**](Dimension8Api.md#dimension8_post) | **POST** /Dimension8 | 

# **dimension8_get**
> list[Dimension8] dimension8_get()



Query Dimension8

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()

try:
    api_response = api_instance.dimension8_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension8]**](Dimension8.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension8_id_delete**
> Dimension8 dimension8_id_delete(id)



Delete Dimension8

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension8_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension8**](Dimension8.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension8_id_get**
> Dimension8 dimension8_id_get(id)



Get Dimension8

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension8_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension8**](Dimension8.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension8_id_put**
> Dimension8 dimension8_id_put(body, id)



Update Dimension8

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()
body = swagger_client.Dimension8() # Dimension8 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension8_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension8**](Dimension8.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension8**](Dimension8.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension8_idactionis_used_get**
> bool dimension8_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension8_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_idactionis_used_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension8_post**
> Dimension8 dimension8_post(body)



Create Dimension8

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension8Api()
body = swagger_client.Dimension8() # Dimension8 | 

try:
    api_response = api_instance.dimension8_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension8Api->dimension8_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension8**](Dimension8.md)|  | 

### Return type

[**Dimension8**](Dimension8.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

