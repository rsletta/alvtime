# swagger_client.SubEntityApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**subentities_get**](SubEntityApi.md#subentities_get) | **GET** /subentities | 
[**subentities_id_delete**](SubEntityApi.md#subentities_id_delete) | **DELETE** /subentities/{id} | 
[**subentities_id_get**](SubEntityApi.md#subentities_id_get) | **GET** /subentities/{id} | 
[**subentities_id_put**](SubEntityApi.md#subentities_id_put) | **PUT** /subentities/{id} | 
[**subentities_post**](SubEntityApi.md#subentities_post) | **POST** /subentities | 
[**subentitiesactionsub_entities_from_brreg_get**](SubEntityApi.md#subentitiesactionsub_entities_from_brreg_get) | **GET** /subentities?action&#x3D;sub-entities-from-brreg | 

# **subentities_get**
> list[SubEntity] subentities_get()



Query SubEntity

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()

try:
    api_response = api_instance.subentities_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentities_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SubEntity]**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subentities_id_delete**
> SubEntity subentities_id_delete(id)



Delete SubEntity

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()
id = 56 # int | 

try:
    api_response = api_instance.subentities_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentities_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SubEntity**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subentities_id_get**
> SubEntity subentities_id_get(id)



Get SubEntity

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()
id = 56 # int | 

try:
    api_response = api_instance.subentities_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentities_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SubEntity**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subentities_id_put**
> SubEntity subentities_id_put(body, id)



Update SubEntity

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()
body = swagger_client.SubEntity() # SubEntity | 
id = 56 # int | 

try:
    api_response = api_instance.subentities_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentities_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubEntity**](SubEntity.md)|  | 
 **id** | **int**|  | 

### Return type

[**SubEntity**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subentities_post**
> SubEntity subentities_post(body)



Create SubEntity

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()
body = swagger_client.SubEntity() # SubEntity | 

try:
    api_response = api_instance.subentities_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentities_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubEntity**](SubEntity.md)|  | 

### Return type

[**SubEntity**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subentitiesactionsub_entities_from_brreg_get**
> list[SubEntity] subentitiesactionsub_entities_from_brreg_get(orgno)



sub-entities-from-brreg Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubEntityApi()
orgno = swagger_client.Object() # Object | 

try:
    api_response = api_instance.subentitiesactionsub_entities_from_brreg_get(orgno)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubEntityApi->subentitiesactionsub_entities_from_brreg_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orgno** | [**Object**](.md)|  | 

### Return type

[**list[SubEntity]**](SubEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

