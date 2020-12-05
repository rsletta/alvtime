# swagger_client.Dimension7Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension7_get**](Dimension7Api.md#dimension7_get) | **GET** /Dimension7 | 
[**dimension7_id_delete**](Dimension7Api.md#dimension7_id_delete) | **DELETE** /Dimension7/{id} | 
[**dimension7_id_get**](Dimension7Api.md#dimension7_id_get) | **GET** /Dimension7/{id} | 
[**dimension7_id_put**](Dimension7Api.md#dimension7_id_put) | **PUT** /Dimension7/{id} | 
[**dimension7_idactionis_used_get**](Dimension7Api.md#dimension7_idactionis_used_get) | **GET** /Dimension7/{id}?action&#x3D;is-used | 
[**dimension7_post**](Dimension7Api.md#dimension7_post) | **POST** /Dimension7 | 

# **dimension7_get**
> list[Dimension7] dimension7_get()



Query Dimension7

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()

try:
    api_response = api_instance.dimension7_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension7]**](Dimension7.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension7_id_delete**
> Dimension7 dimension7_id_delete(id)



Delete Dimension7

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension7_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension7**](Dimension7.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension7_id_get**
> Dimension7 dimension7_id_get(id)



Get Dimension7

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension7_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension7**](Dimension7.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension7_id_put**
> Dimension7 dimension7_id_put(body, id)



Update Dimension7

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()
body = swagger_client.Dimension7() # Dimension7 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension7_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension7**](Dimension7.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension7**](Dimension7.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension7_idactionis_used_get**
> bool dimension7_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension7_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_idactionis_used_get: %s\n" % e)
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

# **dimension7_post**
> Dimension7 dimension7_post(body)



Create Dimension7

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension7Api()
body = swagger_client.Dimension7() # Dimension7 | 

try:
    api_response = api_instance.dimension7_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension7Api->dimension7_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension7**](Dimension7.md)|  | 

### Return type

[**Dimension7**](Dimension7.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

