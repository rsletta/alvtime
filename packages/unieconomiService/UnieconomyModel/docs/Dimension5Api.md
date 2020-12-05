# swagger_client.Dimension5Api

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dimension5_get**](Dimension5Api.md#dimension5_get) | **GET** /Dimension5 | 
[**dimension5_id_delete**](Dimension5Api.md#dimension5_id_delete) | **DELETE** /Dimension5/{id} | 
[**dimension5_id_get**](Dimension5Api.md#dimension5_id_get) | **GET** /Dimension5/{id} | 
[**dimension5_id_put**](Dimension5Api.md#dimension5_id_put) | **PUT** /Dimension5/{id} | 
[**dimension5_idactionis_used_get**](Dimension5Api.md#dimension5_idactionis_used_get) | **GET** /Dimension5/{id}?action&#x3D;is-used | 
[**dimension5_post**](Dimension5Api.md#dimension5_post) | **POST** /Dimension5 | 

# **dimension5_get**
> list[Dimension5] dimension5_get()



Query Dimension5

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()

try:
    api_response = api_instance.dimension5_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Dimension5]**](Dimension5.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension5_id_delete**
> Dimension5 dimension5_id_delete(id)



Delete Dimension5

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension5_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension5**](Dimension5.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension5_id_get**
> Dimension5 dimension5_id_get(id)



Get Dimension5

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension5_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Dimension5**](Dimension5.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension5_id_put**
> Dimension5 dimension5_id_put(body, id)



Update Dimension5

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()
body = swagger_client.Dimension5() # Dimension5 | 
id = 56 # int | 

try:
    api_response = api_instance.dimension5_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension5**](Dimension5.md)|  | 
 **id** | **int**|  | 

### Return type

[**Dimension5**](Dimension5.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dimension5_idactionis_used_get**
> bool dimension5_idactionis_used_get(id)



is-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()
id = 56 # int | 

try:
    api_response = api_instance.dimension5_idactionis_used_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_idactionis_used_get: %s\n" % e)
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

# **dimension5_post**
> Dimension5 dimension5_post(body)



Create Dimension5

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.Dimension5Api()
body = swagger_client.Dimension5() # Dimension5 | 

try:
    api_response = api_instance.dimension5_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling Dimension5Api->dimension5_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Dimension5**](Dimension5.md)|  | 

### Return type

[**Dimension5**](Dimension5.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

