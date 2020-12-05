# swagger_client.Dimension10Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension10_get**](Dimension10Api.md#dimension10_get) | **GET** /Dimension10 | 
[**dimension10_id_delete**](Dimension10Api.md#dimension10_id_delete) | **DELETE** /Dimension10/{id} | 
[**dimension10_id_get**](Dimension10Api.md#dimension10_id_get) | **GET** /Dimension10/{id} | 
[**dimension10_id_put**](Dimension10Api.md#dimension10_id_put) | **PUT** /Dimension10/{id} | 
[**dimension10_idactionis_used_get**](Dimension10Api.md#dimension10_idactionis_used_get) | **GET** /Dimension10/{id}?action&#x3D;is-used | 
[**dimension10_post**](Dimension10Api.md#dimension10_post) | **POST** /Dimension10 | 

# **dimension10_get**
> list[Dimension10] dimension10_get()



Query Dimension10

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()

try:
    api_response = api_instance.dimension10_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension10]**](Dimension10.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension10_id_delete**
> Dimension10 dimension10_id_delete(id)



Delete Dimension10

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension10_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension10**](Dimension10.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension10_id_get**
> Dimension10 dimension10_id_get(id)



Get Dimension10

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension10_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension10**](Dimension10.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension10_id_put**
> Dimension10 dimension10_id_put(body, id)



Update Dimension10

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()
body = swagger_client.Dimension10() # Dimension10 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension10_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension10**](Dimension10.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension10**](Dimension10.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension10_idactionis_used_get**
> bool dimension10_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension10_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_idactionis_used_get: %s\n" % e)
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

# **dimension10_post**
> Dimension10 dimension10_post(body)



Create Dimension10

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension10Api()
body = swagger_client.Dimension10() # Dimension10 | 

try:
    api_response = api_instance.dimension10_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension10Api->dimension10_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension10**](Dimension10.md)|  | 

### Return type

[**Dimension10**](Dimension10.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

