# swagger_client.BankStatementEntryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankstatemententries_get**](BankStatementEntryApi.md#bankstatemententries_get) | **GET** /bankstatemententries | 
[**bankstatemententries_id_delete**](BankStatementEntryApi.md#bankstatemententries_id_delete) | **DELETE** /bankstatemententries/{id} | 
[**bankstatemententries_id_get**](BankStatementEntryApi.md#bankstatemententries_id_get) | **GET** /bankstatemententries/{id} | 
[**bankstatemententries_id_put**](BankStatementEntryApi.md#bankstatemententries_id_put) | **PUT** /bankstatemententries/{id} | 
[**bankstatemententries_post**](BankStatementEntryApi.md#bankstatemententries_post) | **POST** /bankstatemententries | 
[**bankstatemententriesactionentries_for_account_get**](BankStatementEntryApi.md#bankstatemententriesactionentries_for_account_get) | **GET** /bankstatemententries?action&#x3D;entries-for-account | 

# **bankstatemententries_get**
> list[BankStatementEntry] bankstatemententries_get()



Query BankStatementEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()

try:
    api_response = api_instance.bankstatemententries_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententries_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankStatementEntry]**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatemententries_id_delete**
> BankStatementEntry bankstatemententries_id_delete(id)



Delete BankStatementEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatemententries_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententries_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementEntry**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatemententries_id_get**
> BankStatementEntry bankstatemententries_id_get(id)



Get BankStatementEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatemententries_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententries_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatementEntry**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatemententries_id_put**
> BankStatementEntry bankstatemententries_id_put(body, id)



Update BankStatementEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()
body = swagger_client.BankStatementEntry() # BankStatementEntry | 
id = 56 # int | 

try:
    api_response = api_instance.bankstatemententries_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententries_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatementEntry**](BankStatementEntry.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankStatementEntry**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatemententries_post**
> BankStatementEntry bankstatemententries_post(body)



Create BankStatementEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()
body = swagger_client.BankStatementEntry() # BankStatementEntry | 

try:
    api_response = api_instance.bankstatemententries_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententries_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatementEntry**](BankStatementEntry.md)|  | 

### Return type

[**BankStatementEntry**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatemententriesactionentries_for_account_get**
> list[BankStatementEntry] bankstatemententriesactionentries_for_account_get(accountid, fromdate, todate)



entries-for-account Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementEntryApi()
accountid = swagger_client.Object() # Object | 
fromdate = swagger_client.Object() # Object | 
todate = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatemententriesactionentries_for_account_get(accountid, fromdate, todate)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementEntryApi->bankstatemententriesactionentries_for_account_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **fromdate** | [**Object**](.md)|  | 
 **todate** | [**Object**](.md)|  | 

### Return type

[**list[BankStatementEntry]**](BankStatementEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

