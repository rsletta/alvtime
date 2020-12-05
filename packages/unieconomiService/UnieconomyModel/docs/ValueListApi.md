# swagger_client.ValueListApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**valuelists_get**](ValueListApi.md#valuelists_get) | **GET** /valuelists | 
[**valuelists_id_delete**](ValueListApi.md#valuelists_id_delete) | **DELETE** /valuelists/{id} | 
[**valuelists_id_get**](ValueListApi.md#valuelists_id_get) | **GET** /valuelists/{id} | 
[**valuelists_id_put**](ValueListApi.md#valuelists_id_put) | **PUT** /valuelists/{id} | 
[**valuelists_post**](ValueListApi.md#valuelists_post) | **POST** /valuelists | 

# **valuelists_get**
> list[ValueList] valuelists_get()



Query ValueList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueListApi()

try:
    api_response = api_instance.valuelists_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueListApi->valuelists_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ValueList]**](ValueList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valuelists_id_delete**
> ValueList valuelists_id_delete(id)



Delete ValueList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueListApi()
id = 56 # int | 

try:
    api_response = api_instance.valuelists_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueListApi->valuelists_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ValueList**](ValueList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valuelists_id_get**
> ValueList valuelists_id_get(id)



Get ValueList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueListApi()
id = 56 # int | 

try:
    api_response = api_instance.valuelists_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueListApi->valuelists_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ValueList**](ValueList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valuelists_id_put**
> ValueList valuelists_id_put(body, id)



Update ValueList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueListApi()
body = swagger_client.ValueList() # ValueList | 
id = 56 # int | 

try:
    api_response = api_instance.valuelists_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueListApi->valuelists_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ValueList**](ValueList.md)|  | 
 **id** | **int**|  | 

### Return type

[**ValueList**](ValueList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **valuelists_post**
> ValueList valuelists_post(body)



Create ValueList

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ValueListApi()
body = swagger_client.ValueList() # ValueList | 

try:
    api_response = api_instance.valuelists_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ValueListApi->valuelists_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ValueList**](ValueList.md)|  | 

### Return type

[**ValueList**](ValueList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

