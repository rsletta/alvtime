# swagger_client.AGASumsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**agasums_get**](AGASumsApi.md#agasums_get) | **GET** /agasums | 
[**agasums_id_delete**](AGASumsApi.md#agasums_id_delete) | **DELETE** /agasums/{id} | 
[**agasums_id_get**](AGASumsApi.md#agasums_id_get) | **GET** /agasums/{id} | 
[**agasums_id_put**](AGASumsApi.md#agasums_id_put) | **PUT** /agasums/{id} | 
[**agasums_post**](AGASumsApi.md#agasums_post) | **POST** /agasums | 
[**agasumsactionfree_amount_summary_get**](AGASumsApi.md#agasumsactionfree_amount_summary_get) | **GET** /agasums?action&#x3D;free-amount-summary | 

# **agasums_get**
> list[AGASums] agasums_get()



Query AGASums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()

try:
    api_response = api_instance.agasums_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasums_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AGASums]**](AGASums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agasums_id_delete**
> AGASums agasums_id_delete(id)



Delete AGASums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()
id = 56 # int | 

try:
    api_response = api_instance.agasums_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasums_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AGASums**](AGASums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agasums_id_get**
> AGASums agasums_id_get(id)



Get AGASums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()
id = 56 # int | 

try:
    api_response = api_instance.agasums_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasums_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AGASums**](AGASums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agasums_id_put**
> AGASums agasums_id_put(body, id)



Update AGASums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()
body = swagger_client.AGASums() # AGASums | 
id = 56 # int | 

try:
    api_response = api_instance.agasums_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasums_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AGASums**](AGASums.md)|  | 
 **id** | **int**|  | 

### Return type

[**AGASums**](AGASums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agasums_post**
> AGASums agasums_post(body)



Create AGASums

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()
body = swagger_client.AGASums() # AGASums | 

try:
    api_response = api_instance.agasums_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasums_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AGASums**](AGASums.md)|  | 

### Return type

[**AGASums**](AGASums.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **agasumsactionfree_amount_summary_get**
> FreeAmountSummary agasumsactionfree_amount_summary_get()



free-amount-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AGASumsApi()

try:
    api_response = api_instance.agasumsactionfree_amount_summary_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AGASumsApi->agasumsactionfree_amount_summary_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**FreeAmountSummary**](FreeAmountSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

