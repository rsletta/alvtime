# swagger_client.BankStatementMatchApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankstatementmatch_get**](BankStatementMatchApi.md#bankstatementmatch_get) | **GET** /bankstatementmatch | 
[**bankstatementmatch_id_delete**](BankStatementMatchApi.md#bankstatementmatch_id_delete) | **DELETE** /bankstatementmatch/{id} | 
[**bankstatementmatch_id_get**](BankStatementMatchApi.md#bankstatementmatch_id_get) | **GET** /bankstatementmatch/{id} | 
[**bankstatementmatch_post**](BankStatementMatchApi.md#bankstatementmatch_post) | **POST** /bankstatementmatch | 
[**bankstatementmatchactiondelete_group_post**](BankStatementMatchApi.md#bankstatementmatchactiondelete_group_post) | **POST** /bankstatementmatch?action&#x3D;delete-group | 

# **bankstatementmatch_get**
> list[BankStatementMatch] bankstatementmatch_get()



Query BankStatementMatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementMatchApi()

try:
    api_response = api_instance.bankstatementmatch_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementMatchApi->bankstatementmatch_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankStatementMatch]**](BankStatementMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementmatch_id_delete**
> BankStatementMatch bankstatementmatch_id_delete(id)



Delete BankStatementMatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementMatchApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatementmatch_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementMatchApi->bankstatementmatch_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementMatch**](BankStatementMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementmatch_id_get**
> BankStatementMatch bankstatementmatch_id_get(id)



Get BankStatementMatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementMatchApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatementmatch_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementMatchApi->bankstatementmatch_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementMatch**](BankStatementMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementmatch_post**
> BankStatementMatch bankstatementmatch_post(body)



Create BankStatementMatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementMatchApi()
body = swagger_client.BankStatementMatch() # BankStatementMatch | 

try:
    api_response = api_instance.bankstatementmatch_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementMatchApi->bankstatementmatch_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatementMatch**](BankStatementMatch.md)|  | 

### Return type

[**BankStatementMatch**](BankStatementMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementmatchactiondelete_group_post**
> object bankstatementmatchactiondelete_group_post(group)



delete-group Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementMatchApi()
group = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatementmatchactiondelete_group_post(group)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementMatchApi->bankstatementmatchactiondelete_group_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

