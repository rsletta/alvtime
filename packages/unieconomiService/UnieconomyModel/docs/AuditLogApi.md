# swagger_client.AuditLogApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**auditlogs_get**](AuditLogApi.md#auditlogs_get) | **GET** /auditlogs | 
[**auditlogs_id_get**](AuditLogApi.md#auditlogs_id_get) | **GET** /auditlogs/{id} | 

# **auditlogs_get**
> list[AuditLog] auditlogs_get()



Query AuditLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AuditLogApi()

try:
    api_response = api_instance.auditlogs_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AuditLogApi->auditlogs_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AuditLog]**](AuditLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **auditlogs_id_get**
> AuditLog auditlogs_id_get(id)



Get AuditLog

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AuditLogApi()
id = 56 # int | 

try:
    api_response = api_instance.auditlogs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AuditLogApi->auditlogs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AuditLog**](AuditLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

