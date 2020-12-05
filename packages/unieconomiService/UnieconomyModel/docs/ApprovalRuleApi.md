# swagger_client.ApprovalRuleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**approvalrules_get**](ApprovalRuleApi.md#approvalrules_get) | **GET** /approvalrules | 
[**approvalrules_id_delete**](ApprovalRuleApi.md#approvalrules_id_delete) | **DELETE** /approvalrules/{id} | 
[**approvalrules_id_get**](ApprovalRuleApi.md#approvalrules_id_get) | **GET** /approvalrules/{id} | 
[**approvalrules_id_put**](ApprovalRuleApi.md#approvalrules_id_put) | **PUT** /approvalrules/{id} | 
[**approvalrules_post**](ApprovalRuleApi.md#approvalrules_post) | **POST** /approvalrules | 

# **approvalrules_get**
> list[ApprovalRule] approvalrules_get()



Query ApprovalRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalRuleApi()

try:
    api_response = api_instance.approvalrules_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalRuleApi->approvalrules_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ApprovalRule]**](ApprovalRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalrules_id_delete**
> ApprovalRule approvalrules_id_delete(id)



Delete ApprovalRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.approvalrules_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalRuleApi->approvalrules_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApprovalRule**](ApprovalRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalrules_id_get**
> ApprovalRule approvalrules_id_get(id)



Get ApprovalRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.approvalrules_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalRuleApi->approvalrules_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApprovalRule**](ApprovalRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalrules_id_put**
> ApprovalRule approvalrules_id_put(body, id)



Update ApprovalRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalRuleApi()
body = swagger_client.ApprovalRule() # ApprovalRule | 
id = 56 # int | 

try:
    api_response = api_instance.approvalrules_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalRuleApi->approvalrules_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApprovalRule**](ApprovalRule.md)|  | 
 **id** | **int**|  | 

### Return type

[**ApprovalRule**](ApprovalRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **approvalrules_post**
> ApprovalRule approvalrules_post(body)



Create ApprovalRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApprovalRuleApi()
body = swagger_client.ApprovalRule() # ApprovalRule | 

try:
    api_response = api_instance.approvalrules_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApprovalRuleApi->approvalrules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApprovalRule**](ApprovalRule.md)|  | 

### Return type

[**ApprovalRule**](ApprovalRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

