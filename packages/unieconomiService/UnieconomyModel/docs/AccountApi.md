# swagger_client.AccountApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accounts_accountid_subaccounts_get**](AccountApi.md#accounts_accountid_subaccounts_get) | **GET** /accounts/{accountid}/subaccounts | 
[**accounts_accountid_subaccounts_id_delete**](AccountApi.md#accounts_accountid_subaccounts_id_delete) | **DELETE** /accounts/{accountid}/subaccounts/{id} | 
[**accounts_accountid_subaccounts_id_get**](AccountApi.md#accounts_accountid_subaccounts_id_get) | **GET** /accounts/{accountid}/subaccounts/{id} | 
[**accounts_accountid_subaccounts_id_put**](AccountApi.md#accounts_accountid_subaccounts_id_put) | **PUT** /accounts/{accountid}/subaccounts/{id} | 
[**accounts_accountid_subaccounts_post**](AccountApi.md#accounts_accountid_subaccounts_post) | **POST** /accounts/{accountid}/subaccounts | 
[**accounts_get**](AccountApi.md#accounts_get) | **GET** /accounts | 
[**accounts_id_delete**](AccountApi.md#accounts_id_delete) | **DELETE** /accounts/{id} | 
[**accounts_id_get**](AccountApi.md#accounts_id_get) | **GET** /accounts/{id} | 
[**accounts_id_put**](AccountApi.md#accounts_id_put) | **PUT** /accounts/{id} | 
[**accounts_idactionis_account_used_get**](AccountApi.md#accounts_idactionis_account_used_get) | **GET** /accounts/{id}?action&#x3D;is-account-used | 
[**accounts_post**](AccountApi.md#accounts_post) | **POST** /accounts | 
[**accountsactionbalance_get**](AccountApi.md#accountsactionbalance_get) | **GET** /accounts?action&#x3D;balance | 
[**accountsactionbalance_grouped_get**](AccountApi.md#accountsactionbalance_grouped_get) | **GET** /accounts?action&#x3D;balance-grouped | 
[**accountsactionbulk_save_put**](AccountApi.md#accountsactionbulk_save_put) | **PUT** /accounts?action&#x3D;bulk-save | 
[**accountsactionget_account_usage_detailed_get**](AccountApi.md#accountsactionget_account_usage_detailed_get) | **GET** /accounts?action&#x3D;get-account-usage-detailed | 
[**accountsactionget_account_usage_get**](AccountApi.md#accountsactionget_account_usage_get) | **GET** /accounts?action&#x3D;get-account-usage | 
[**accountsactionpayables_by_age_detailed_get**](AccountApi.md#accountsactionpayables_by_age_detailed_get) | **GET** /accounts?action&#x3D;payables-by-age-detailed | 
[**accountsactionpayables_by_age_get**](AccountApi.md#accountsactionpayables_by_age_get) | **GET** /accounts?action&#x3D;payables-by-age | 
[**accountsactionprofit_and_loss_grouped_get**](AccountApi.md#accountsactionprofit_and_loss_grouped_get) | **GET** /accounts?action&#x3D;profit-and-loss-grouped | 
[**accountsactionprofit_and_loss_periodical_get**](AccountApi.md#accountsactionprofit_and_loss_periodical_get) | **GET** /accounts?action&#x3D;profit-and-loss-periodical | 
[**accountsactionsaftmapping_accounts_get**](AccountApi.md#accountsactionsaftmapping_accounts_get) | **GET** /accounts?action&#x3D;saftmapping-accounts | 
[**accountsactionset_account_visibility_group_post**](AccountApi.md#accountsactionset_account_visibility_group_post) | **POST** /accounts?action&#x3D;set-account-visibility-group | 
[**accountsactionset_saftmappings_put**](AccountApi.md#accountsactionset_saftmappings_put) | **PUT** /accounts?action&#x3D;set-saftmappings | 
[**accountsactionsynchronize_ns4102_as_put**](AccountApi.md#accountsactionsynchronize_ns4102_as_put) | **PUT** /accounts?action&#x3D;synchronize-ns4102-as | 
[**accountsactionvalid_get**](AccountApi.md#accountsactionvalid_get) | **GET** /accounts?action&#x3D;valid | 
[**accountsactionvalid_with_hidden_get**](AccountApi.md#accountsactionvalid_with_hidden_get) | **GET** /accounts?action&#x3D;valid-with-hidden | 

# **accounts_accountid_subaccounts_get**
> list[Account] accounts_accountid_subaccounts_get()



Query Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accounts_accountid_subaccounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_accountid_subaccounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Account]**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_accountid_subaccounts_id_delete**
> Account accounts_accountid_subaccounts_id_delete(id)



Delete Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
id = 56 # int | 

try:
    api_response = api_instance.accounts_accountid_subaccounts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_accountid_subaccounts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_accountid_subaccounts_id_get**
> Account accounts_accountid_subaccounts_id_get(id)



Get Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
id = 56 # int | 

try:
    api_response = api_instance.accounts_accountid_subaccounts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_accountid_subaccounts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_accountid_subaccounts_id_put**
> Account accounts_accountid_subaccounts_id_put(body, id)



Update Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = swagger_client.Account() # Account | 
id = 56 # int | 

try:
    api_response = api_instance.accounts_accountid_subaccounts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_accountid_subaccounts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Account**](Account.md)|  | 
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_accountid_subaccounts_post**
> Account accounts_accountid_subaccounts_post(body)



Create Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = swagger_client.Account() # Account | 

try:
    api_response = api_instance.accounts_accountid_subaccounts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_accountid_subaccounts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Account**](Account.md)|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_get**
> list[Account] accounts_get()



Query Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Account]**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_id_delete**
> Account accounts_id_delete(id)



Delete Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
id = 56 # int | 

try:
    api_response = api_instance.accounts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_id_get**
> Account accounts_id_get(id)



Get Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
id = 56 # int | 

try:
    api_response = api_instance.accounts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_id_put**
> Account accounts_id_put(body, id)



Update Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = swagger_client.Account() # Account | 
id = 56 # int | 

try:
    api_response = api_instance.accounts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Account**](Account.md)|  | 
 **id** | **int**|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_idactionis_account_used_get**
> bool accounts_idactionis_account_used_get(id, id)



is-account-used Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accounts_idactionis_account_used_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_idactionis_account_used_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

**bool**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accounts_post**
> Account accounts_post(body)



Create Account

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = swagger_client.Account() # Account | 

try:
    api_response = api_instance.accounts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accounts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Account**](Account.md)|  | 

### Return type

[**Account**](Account.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionbalance_get**
> object accountsactionbalance_get(financial_year)



balance Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionbalance_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionbalance_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionbalance_grouped_get**
> object accountsactionbalance_grouped_get(financial_year)



balance-grouped Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionbalance_grouped_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionbalance_grouped_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionbulk_save_put**
> object accountsactionbulk_save_put(body=body)



bulk-save Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = [swagger_client.Account()] # list[Account] |  (optional)

try:
    api_response = api_instance.accountsactionbulk_save_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionbulk_save_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[Account]**](Account.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionget_account_usage_detailed_get**
> list[AccountUsageReference] accountsactionget_account_usage_detailed_get(account_id, max_hit_per_entity)



get-account-usage-detailed Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
account_id = swagger_client.Object() # Object | 
max_hit_per_entity = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionget_account_usage_detailed_get(account_id, max_hit_per_entity)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionget_account_usage_detailed_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **max_hit_per_entity** | [**Object**](.md)|  | 

### Return type

[**list[AccountUsageReference]**](AccountUsageReference.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionget_account_usage_get**
> str accountsactionget_account_usage_get(account_id)



get-account-usage Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionget_account_usage_get(account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionget_account_usage_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionpayables_by_age_detailed_get**
> object accountsactionpayables_by_age_detailed_get(_date, account_from, account_to, use_due_date, account_type)



payables-by-age-detailed Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
_date = swagger_client.Object() # Object | 
account_from = swagger_client.Object() # Object | 
account_to = swagger_client.Object() # Object | 
use_due_date = swagger_client.Object() # Object | 
account_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionpayables_by_age_detailed_get(_date, account_from, account_to, use_due_date, account_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionpayables_by_age_detailed_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 
 **account_from** | [**Object**](.md)|  | 
 **account_to** | [**Object**](.md)|  | 
 **use_due_date** | [**Object**](.md)|  | 
 **account_type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionpayables_by_age_get**
> object accountsactionpayables_by_age_get(_date, account_from, account_to, use_due_date, account_type)



payables-by-age Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
_date = swagger_client.Object() # Object | 
account_from = swagger_client.Object() # Object | 
account_to = swagger_client.Object() # Object | 
use_due_date = swagger_client.Object() # Object | 
account_type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionpayables_by_age_get(_date, account_from, account_to, use_due_date, account_type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionpayables_by_age_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_date** | [**Object**](.md)|  | 
 **account_from** | [**Object**](.md)|  | 
 **account_to** | [**Object**](.md)|  | 
 **use_due_date** | [**Object**](.md)|  | 
 **account_type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionprofit_and_loss_grouped_get**
> object accountsactionprofit_and_loss_grouped_get(financial_year)



profit-and-loss-grouped Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionprofit_and_loss_grouped_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionprofit_and_loss_grouped_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionprofit_and_loss_periodical_get**
> object accountsactionprofit_and_loss_periodical_get(financial_year)



profit-and-loss-periodical Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionprofit_and_loss_periodical_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionprofit_and_loss_periodical_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionsaftmapping_accounts_get**
> list[SaftMappingAccount] accountsactionsaftmapping_accounts_get()



saftmapping-accounts Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accountsactionsaftmapping_accounts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionsaftmapping_accounts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SaftMappingAccount]**](SaftMappingAccount.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionset_account_visibility_group_post**
> object accountsactionset_account_visibility_group_post(account_visibility_group_id)



set-account-visibility-group Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
account_visibility_group_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.accountsactionset_account_visibility_group_post(account_visibility_group_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionset_account_visibility_group_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_visibility_group_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionset_saftmappings_put**
> object accountsactionset_saftmappings_put(body=body)



set-saftmappings Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.accountsactionset_saftmappings_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionset_saftmappings_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **accountsactionsynchronize_ns4102_as_put**
> object accountsactionsynchronize_ns4102_as_put()



synchronize-ns4102-as Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accountsactionsynchronize_ns4102_as_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionsynchronize_ns4102_as_put: %s\n" % e)
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

# **accountsactionvalid_get**
> object accountsactionvalid_get()



valid Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accountsactionvalid_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionvalid_get: %s\n" % e)
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

# **accountsactionvalid_with_hidden_get**
> object accountsactionvalid_with_hidden_get()



valid-with-hidden Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AccountApi()

try:
    api_response = api_instance.accountsactionvalid_with_hidden_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AccountApi->accountsactionvalid_with_hidden_get: %s\n" % e)
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

