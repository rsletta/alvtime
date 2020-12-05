# swagger_client.BankAccountApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankaccounts_get**](BankAccountApi.md#bankaccounts_get) | **GET** /bankaccounts | 
[**bankaccounts_id_delete**](BankAccountApi.md#bankaccounts_id_delete) | **DELETE** /bankaccounts/{id} | 
[**bankaccounts_id_get**](BankAccountApi.md#bankaccounts_id_get) | **GET** /bankaccounts/{id} | 
[**bankaccounts_id_put**](BankAccountApi.md#bankaccounts_id_put) | **PUT** /bankaccounts/{id} | 
[**bankaccounts_idactionbank_balance_get**](BankAccountApi.md#bankaccounts_idactionbank_balance_get) | **GET** /bankaccounts/{id}?action&#x3D;bank-balance | 
[**bankaccounts_idactionlock_put**](BankAccountApi.md#bankaccounts_idactionlock_put) | **PUT** /bankaccounts/{id}?action&#x3D;lock | 
[**bankaccounts_idactionunlock_put**](BankAccountApi.md#bankaccounts_idactionunlock_put) | **PUT** /bankaccounts/{id}?action&#x3D;unlock | 
[**bankaccounts_post**](BankAccountApi.md#bankaccounts_post) | **POST** /bankaccounts | 
[**bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post**](BankAccountApi.md#bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post) | **POST** /bankaccounts?action&#x3D;create-bankaccounts-from-bankservice-bankaccounts | 
[**bankaccountsactionget_all_bank_balances_get**](BankAccountApi.md#bankaccountsactionget_all_bank_balances_get) | **GET** /bankaccounts?action&#x3D;get-all-bank-balances | 
[**bankaccountsactionget_bankservice_bankaccounts_get**](BankAccountApi.md#bankaccountsactionget_bankservice_bankaccounts_get) | **GET** /bankaccounts?action&#x3D;get-bankservice-bankaccounts | 
[**bankaccountsactionget_connected_bankaccounts_to_account_get**](BankAccountApi.md#bankaccountsactionget_connected_bankaccounts_to_account_get) | **GET** /bankaccounts?action&#x3D;get-connected-bankaccounts-to-account | 

# **bankaccounts_get**
> list[BankAccount] bankaccounts_get()



Query BankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()

try:
    api_response = api_instance.bankaccounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankAccount]**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_id_delete**
> BankAccount bankaccounts_id_delete(id)



Delete BankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.bankaccounts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_id_get**
> BankAccount bankaccounts_id_get(id)



Get BankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.bankaccounts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_id_put**
> BankAccount bankaccounts_id_put(body, id)



Update BankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
body = swagger_client.BankAccount() # BankAccount | 
id = 56 # int | 

try:
    api_response = api_instance.bankaccounts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankAccount**](BankAccount.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_idactionbank_balance_get**
> object bankaccounts_idactionbank_balance_get(id, id)



bank-balance Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankaccounts_idactionbank_balance_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_idactionbank_balance_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_idactionlock_put**
> object bankaccounts_idactionlock_put(id)



lock Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.bankaccounts_idactionlock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_idactionlock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_idactionunlock_put**
> object bankaccounts_idactionunlock_put(id)



unlock Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
id = 56 # int | 

try:
    api_response = api_instance.bankaccounts_idactionunlock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_idactionunlock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccounts_post**
> BankAccount bankaccounts_post(body)



Create BankAccount

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
body = swagger_client.BankAccount() # BankAccount | 

try:
    api_response = api_instance.bankaccounts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccounts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankAccount**](BankAccount.md)|  | 

### Return type

[**BankAccount**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post**
> object bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post(body=body)



create-bankaccounts-from-bankservice-bankaccounts Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
body = NULL # object |  (optional)

try:
    api_response = api_instance.bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccountsactioncreate_bankaccounts_from_bankservice_bankaccounts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**object**](object.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccountsactionget_all_bank_balances_get**
> list[BankBalanceDto] bankaccountsactionget_all_bank_balances_get()



get-all-bank-balances Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()

try:
    api_response = api_instance.bankaccountsactionget_all_bank_balances_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccountsactionget_all_bank_balances_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankBalanceDto]**](BankBalanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccountsactionget_bankservice_bankaccounts_get**
> object bankaccountsactionget_bankservice_bankaccounts_get()



get-bankservice-bankaccounts Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()

try:
    api_response = api_instance.bankaccountsactionget_bankservice_bankaccounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccountsactionget_bankservice_bankaccounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankaccountsactionget_connected_bankaccounts_to_account_get**
> list[BankAccount] bankaccountsactionget_connected_bankaccounts_to_account_get(account_id, skip_bank_account_id)



get-connected-bankaccounts-to-account Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankAccountApi()
account_id = swagger_client.Object() # Object | 
skip_bank_account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankaccountsactionget_connected_bankaccounts_to_account_get(account_id, skip_bank_account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankAccountApi->bankaccountsactionget_connected_bankaccounts_to_account_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **skip_bank_account_id** | [**Object**](.md)|  | 

### Return type

[**list[BankAccount]**](BankAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

