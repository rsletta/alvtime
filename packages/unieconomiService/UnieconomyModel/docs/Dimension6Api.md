# swagger_client.Dimension6Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension6_get**](Dimension6Api.md#dimension6_get) | **GET** /Dimension6 | 
[**dimension6_id_delete**](Dimension6Api.md#dimension6_id_delete) | **DELETE** /Dimension6/{id} | 
[**dimension6_id_get**](Dimension6Api.md#dimension6_id_get) | **GET** /Dimension6/{id} | 
[**dimension6_id_put**](Dimension6Api.md#dimension6_id_put) | **PUT** /Dimension6/{id} | 
[**dimension6_idactionis_used_get**](Dimension6Api.md#dimension6_idactionis_used_get) | **GET** /Dimension6/{id}?action&#x3D;is-used | 
[**dimension6_post**](Dimension6Api.md#dimension6_post) | **POST** /Dimension6 | 

# **dimension6_get**
> list[Dimension6] dimension6_get()



Query Dimension6

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()

try:
    api_response = api_instance.dimension6_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension6]**](Dimension6.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension6_id_delete**
> Dimension6 dimension6_id_delete(id)



Delete Dimension6

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension6_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension6**](Dimension6.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension6_id_get**
> Dimension6 dimension6_id_get(id)



Get Dimension6

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension6_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension6**](Dimension6.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension6_id_put**
> Dimension6 dimension6_id_put(body, id)



Update Dimension6

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()
body = swagger_client.Dimension6() # Dimension6 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension6_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension6**](Dimension6.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension6**](Dimension6.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension6_idactionis_used_get**
> bool dimension6_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension6_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_idactionis_used_get: %s\n" % e)
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

# **dimension6_post**
> Dimension6 dimension6_post(body)



Create Dimension6

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension6Api()
body = swagger_client.Dimension6() # Dimension6 | 

try:
    api_response = api_instance.dimension6_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension6Api->dimension6_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension6**](Dimension6.md)|  | 

### Return type

[**Dimension6**](Dimension6.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

