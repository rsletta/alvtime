# swagger_client.BankRuleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankrules_get**](BankRuleApi.md#bankrules_get) | **GET** /bankrules | 
[**bankrules_id_delete**](BankRuleApi.md#bankrules_id_delete) | **DELETE** /bankrules/{id} | 
[**bankrules_id_get**](BankRuleApi.md#bankrules_id_get) | **GET** /bankrules/{id} | 
[**bankrules_id_put**](BankRuleApi.md#bankrules_id_put) | **PUT** /bankrules/{id} | 
[**bankrules_post**](BankRuleApi.md#bankrules_post) | **POST** /bankrules | 

# **bankrules_get**
> list[BankRule] bankrules_get()



Query BankRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankRuleApi()

try:
    api_response = api_instance.bankrules_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankRuleApi->bankrules_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankRule]**](BankRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankrules_id_delete**
> BankRule bankrules_id_delete(id)



Delete BankRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.bankrules_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankRuleApi->bankrules_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankRule**](BankRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankrules_id_get**
> BankRule bankrules_id_get(id)



Get BankRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.bankrules_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankRuleApi->bankrules_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankRule**](BankRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankrules_id_put**
> BankRule bankrules_id_put(body, id)



Update BankRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankRuleApi()
body = swagger_client.BankRule() # BankRule | 
id = 56 # int | 

try:
    api_response = api_instance.bankrules_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankRuleApi->bankrules_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankRule**](BankRule.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankRule**](BankRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankrules_post**
> BankRule bankrules_post(body)



Create BankRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankRuleApi()
body = swagger_client.BankRule() # BankRule | 

try:
    api_response = api_instance.bankrules_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankRuleApi->bankrules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankRule**](BankRule.md)|  | 

### Return type

[**BankRule**](BankRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

