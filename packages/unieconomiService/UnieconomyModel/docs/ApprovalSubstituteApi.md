# swagger_client.ApprovalSubstituteApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**approvalsubstitutes_get**](ApprovalSubstituteApi.md#approvalsubstitutes_get) | **GET** /approvalsubstitutes | 
[**approvalsubstitutes_id_delete**](ApprovalSubstituteApi.md#approvalsubstitutes_id_delete) | **DELETE** /approvalsubstitutes/{id} | 
[**approvalsubstitutes_id_get**](ApprovalSubstituteApi.md#approvalsubstitutes_id_get) | **GET** /approvalsubstitutes/{id} | 
[**approvalsubstitutes_id_put**](ApprovalSubstituteApi.md#approvalsubstitutes_id_put) | **PUT** /approvalsubstitutes/{id} | 
[**approvalsubstitutes_post**](ApprovalSubstituteApi.md#approvalsubstitutes_post) | **POST** /approvalsubstitutes | 

# **approvalsubstitutes_get**
> list[ApprovalSubstitute] approvalsubstitutes_get()



Query ApprovalSubstitute

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalSubstituteApi()

try:
    api_response = api_instance.approvalsubstitutes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalSubstituteApi->approvalsubstitutes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ApprovalSubstitute]**](ApprovalSubstitute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalsubstitutes_id_delete**
> ApprovalSubstitute approvalsubstitutes_id_delete(id)



Delete ApprovalSubstitute

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalSubstituteApi()
id = 56 # int | 

try:
    api_response = api_instance.approvalsubstitutes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalSubstituteApi->approvalsubstitutes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApprovalSubstitute**](ApprovalSubstitute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalsubstitutes_id_get**
> ApprovalSubstitute approvalsubstitutes_id_get(id)



Get ApprovalSubstitute

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalSubstituteApi()
id = 56 # int | 

try:
    api_response = api_instance.approvalsubstitutes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalSubstituteApi->approvalsubstitutes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApprovalSubstitute**](ApprovalSubstitute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalsubstitutes_id_put**
> ApprovalSubstitute approvalsubstitutes_id_put(body, id)



Update ApprovalSubstitute

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalSubstituteApi()
body = swagger_client.ApprovalSubstitute() # ApprovalSubstitute | 
id = 56 # int | 

try:
    api_response = api_instance.approvalsubstitutes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalSubstituteApi->approvalsubstitutes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApprovalSubstitute**](ApprovalSubstitute.md)|  | 
 **id** | **int**|  | 

### Return type

[**ApprovalSubstitute**](ApprovalSubstitute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalsubstitutes_post**
> ApprovalSubstitute approvalsubstitutes_post(body)



Create ApprovalSubstitute

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalSubstituteApi()
body = swagger_client.ApprovalSubstitute() # ApprovalSubstitute | 

try:
    api_response = api_instance.approvalsubstitutes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalSubstituteApi->approvalsubstitutes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApprovalSubstitute**](ApprovalSubstitute.md)|  | 

### Return type

[**ApprovalSubstitute**](ApprovalSubstitute.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

