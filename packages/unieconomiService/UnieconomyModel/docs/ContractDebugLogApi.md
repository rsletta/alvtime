# swagger_client.ContractDebugLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contractdebuglogs_get**](ContractDebugLogApi.md#contractdebuglogs_get) | **GET** /contractdebuglogs | 
[**contractdebuglogs_id_delete**](ContractDebugLogApi.md#contractdebuglogs_id_delete) | **DELETE** /contractdebuglogs/{id} | 
[**contractdebuglogs_id_get**](ContractDebugLogApi.md#contractdebuglogs_id_get) | **GET** /contractdebuglogs/{id} | 
[**contractdebuglogs_id_put**](ContractDebugLogApi.md#contractdebuglogs_id_put) | **PUT** /contractdebuglogs/{id} | 
[**contractdebuglogs_post**](ContractDebugLogApi.md#contractdebuglogs_post) | **POST** /contractdebuglogs | 

# **contractdebuglogs_get**
> list[ContractDebugLog] contractdebuglogs_get()



Query ContractDebugLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractDebugLogApi()

try:
    api_response = api_instance.contractdebuglogs_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractDebugLogApi->contractdebuglogs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractDebugLog]**](ContractDebugLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractdebuglogs_id_delete**
> ContractDebugLog contractdebuglogs_id_delete(id)



Delete ContractDebugLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractDebugLogApi()
id = 56 # int | 

try:
    api_response = api_instance.contractdebuglogs_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractDebugLogApi->contractdebuglogs_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractDebugLog**](ContractDebugLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractdebuglogs_id_get**
> ContractDebugLog contractdebuglogs_id_get(id)



Get ContractDebugLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractDebugLogApi()
id = 56 # int | 

try:
    api_response = api_instance.contractdebuglogs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractDebugLogApi->contractdebuglogs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractDebugLog**](ContractDebugLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractdebuglogs_id_put**
> ContractDebugLog contractdebuglogs_id_put(body, id)



Update ContractDebugLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractDebugLogApi()
body = swagger_client.ContractDebugLog() # ContractDebugLog | 
id = 56 # int | 

try:
    api_response = api_instance.contractdebuglogs_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractDebugLogApi->contractdebuglogs_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractDebugLog**](ContractDebugLog.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractDebugLog**](ContractDebugLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractdebuglogs_post**
> ContractDebugLog contractdebuglogs_post(body)



Create ContractDebugLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractDebugLogApi()
body = swagger_client.ContractDebugLog() # ContractDebugLog | 

try:
    api_response = api_instance.contractdebuglogs_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractDebugLogApi->contractdebuglogs_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractDebugLog**](ContractDebugLog.md)|  | 

### Return type

[**ContractDebugLog**](ContractDebugLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

