# swagger_client.ContractRunLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contractrunlogs_get**](ContractRunLogApi.md#contractrunlogs_get) | **GET** /contractrunlogs | 
[**contractrunlogs_id_delete**](ContractRunLogApi.md#contractrunlogs_id_delete) | **DELETE** /contractrunlogs/{id} | 
[**contractrunlogs_id_get**](ContractRunLogApi.md#contractrunlogs_id_get) | **GET** /contractrunlogs/{id} | 
[**contractrunlogs_id_put**](ContractRunLogApi.md#contractrunlogs_id_put) | **PUT** /contractrunlogs/{id} | 
[**contractrunlogs_post**](ContractRunLogApi.md#contractrunlogs_post) | **POST** /contractrunlogs | 

# **contractrunlogs_get**
> list[ContractRunLog] contractrunlogs_get()



Query ContractRunLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractRunLogApi()

try:
    api_response = api_instance.contractrunlogs_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractRunLogApi->contractrunlogs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ContractRunLog]**](ContractRunLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractrunlogs_id_delete**
> ContractRunLog contractrunlogs_id_delete(id)



Delete ContractRunLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractRunLogApi()
id = 56 # int | 

try:
    api_response = api_instance.contractrunlogs_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractRunLogApi->contractrunlogs_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractRunLog**](ContractRunLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractrunlogs_id_get**
> ContractRunLog contractrunlogs_id_get(id)



Get ContractRunLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractRunLogApi()
id = 56 # int | 

try:
    api_response = api_instance.contractrunlogs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractRunLogApi->contractrunlogs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ContractRunLog**](ContractRunLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractrunlogs_id_put**
> ContractRunLog contractrunlogs_id_put(body, id)



Update ContractRunLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractRunLogApi()
body = swagger_client.ContractRunLog() # ContractRunLog | 
id = 56 # int | 

try:
    api_response = api_instance.contractrunlogs_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractRunLogApi->contractrunlogs_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractRunLog**](ContractRunLog.md)|  | 
 **id** | **int**|  | 

### Return type

[**ContractRunLog**](ContractRunLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contractrunlogs_post**
> ContractRunLog contractrunlogs_post(body)



Create ContractRunLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractRunLogApi()
body = swagger_client.ContractRunLog() # ContractRunLog | 

try:
    api_response = api_instance.contractrunlogs_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractRunLogApi->contractrunlogs_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ContractRunLog**](ContractRunLog.md)|  | 

### Return type

[**ContractRunLog**](ContractRunLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

