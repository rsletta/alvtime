# swagger_client.Dimension9Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension9_get**](Dimension9Api.md#dimension9_get) | **GET** /Dimension9 | 
[**dimension9_id_delete**](Dimension9Api.md#dimension9_id_delete) | **DELETE** /Dimension9/{id} | 
[**dimension9_id_get**](Dimension9Api.md#dimension9_id_get) | **GET** /Dimension9/{id} | 
[**dimension9_id_put**](Dimension9Api.md#dimension9_id_put) | **PUT** /Dimension9/{id} | 
[**dimension9_idactionis_used_get**](Dimension9Api.md#dimension9_idactionis_used_get) | **GET** /Dimension9/{id}?action&#x3D;is-used | 
[**dimension9_post**](Dimension9Api.md#dimension9_post) | **POST** /Dimension9 | 

# **dimension9_get**
> list[Dimension9] dimension9_get()



Query Dimension9

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()

try:
    api_response = api_instance.dimension9_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension9]**](Dimension9.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension9_id_delete**
> Dimension9 dimension9_id_delete(id)



Delete Dimension9

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension9_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension9**](Dimension9.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension9_id_get**
> Dimension9 dimension9_id_get(id)



Get Dimension9

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension9_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension9**](Dimension9.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension9_id_put**
> Dimension9 dimension9_id_put(body, id)



Update Dimension9

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()
body = swagger_client.Dimension9() # Dimension9 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension9_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension9**](Dimension9.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension9**](Dimension9.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension9_idactionis_used_get**
> bool dimension9_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension9_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_idactionis_used_get: %s\n" % e)
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

# **dimension9_post**
> Dimension9 dimension9_post(body)



Create Dimension9

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension9Api()
body = swagger_client.Dimension9() # Dimension9 | 

try:
    api_response = api_instance.dimension9_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension9Api->dimension9_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension9**](Dimension9.md)|  | 

### Return type

[**Dimension9**](Dimension9.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

