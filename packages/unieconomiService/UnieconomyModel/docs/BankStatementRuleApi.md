# swagger_client.BankStatementRuleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankstatementrules_get**](BankStatementRuleApi.md#bankstatementrules_get) | **GET** /bankstatementrules | 
[**bankstatementrules_id_delete**](BankStatementRuleApi.md#bankstatementrules_id_delete) | **DELETE** /bankstatementrules/{id} | 
[**bankstatementrules_id_get**](BankStatementRuleApi.md#bankstatementrules_id_get) | **GET** /bankstatementrules/{id} | 
[**bankstatementrules_id_put**](BankStatementRuleApi.md#bankstatementrules_id_put) | **PUT** /bankstatementrules/{id} | 
[**bankstatementrules_post**](BankStatementRuleApi.md#bankstatementrules_post) | **POST** /bankstatementrules | 
[**bankstatementrulesactionapply_rule_post**](BankStatementRuleApi.md#bankstatementrulesactionapply_rule_post) | **POST** /bankstatementrules?action&#x3D;apply-rule | 
[**bankstatementrulesactionapply_rules_post**](BankStatementRuleApi.md#bankstatementrulesactionapply_rules_post) | **POST** /bankstatementrules?action&#x3D;apply-rules | 

# **bankstatementrules_get**
> list[BankStatementRule] bankstatementrules_get()



Query BankStatementRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()

try:
    api_response = api_instance.bankstatementrules_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrules_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankStatementRule]**](BankStatementRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrules_id_delete**
> BankStatementRule bankstatementrules_id_delete(id)



Delete BankStatementRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatementrules_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrules_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementRule**](BankStatementRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrules_id_get**
> BankStatementRule bankstatementrules_id_get(id)



Get BankStatementRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatementrules_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrules_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementRule**](BankStatementRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrules_id_put**
> BankStatementRule bankstatementrules_id_put(body, id)



Update BankStatementRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
body = swagger_client.BankStatementRule() # BankStatementRule | 
id = 56 # int | 

try:
    api_response = api_instance.bankstatementrules_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrules_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatementRule**](BankStatementRule.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankStatementRule**](BankStatementRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrules_post**
> BankStatementRule bankstatementrules_post(body)



Create BankStatementRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
body = swagger_client.BankStatementRule() # BankStatementRule | 

try:
    api_response = api_instance.bankstatementrules_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatementRule**](BankStatementRule.md)|  | 

### Return type

[**BankStatementRule**](BankStatementRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrulesactionapply_rule_post**
> list[JournalSuggestion] bankstatementrulesactionapply_rule_post(id, body=body)



apply-rule Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
id = swagger_client.Object() # Object | 
body = [swagger_client.BankStatementEntry()] # list[BankStatementEntry] |  (optional)

try:
    api_response = api_instance.bankstatementrulesactionapply_rule_post(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrulesactionapply_rule_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **body** | [**list[BankStatementEntry]**](BankStatementEntry.md)|  | [optional] 

### Return type

[**list[JournalSuggestion]**](JournalSuggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementrulesactionapply_rules_post**
> list[JournalSuggestion] bankstatementrulesactionapply_rules_post(active, body=body)



apply-rules Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementRuleApi()
active = swagger_client.Object() # Object | 
body = [swagger_client.BankStatementEntry()] # list[BankStatementEntry] |  (optional)

try:
    api_response = api_instance.bankstatementrulesactionapply_rules_post(active, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementRuleApi->bankstatementrulesactionapply_rules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **active** | [**Object**](.md)|  | 
 **body** | [**list[BankStatementEntry]**](BankStatementEntry.md)|  | [optional] 

### Return type

[**list[JournalSuggestion]**](JournalSuggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

