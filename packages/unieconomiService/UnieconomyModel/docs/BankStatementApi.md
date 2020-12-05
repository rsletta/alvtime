# swagger_client.BankStatementApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bankstatements_get**](BankStatementApi.md#bankstatements_get) | **GET** /bankstatements | 
[**bankstatements_id_delete**](BankStatementApi.md#bankstatements_id_delete) | **DELETE** /bankstatements/{id} | 
[**bankstatements_id_get**](BankStatementApi.md#bankstatements_id_get) | **GET** /bankstatements/{id} | 
[**bankstatements_id_put**](BankStatementApi.md#bankstatements_id_put) | **PUT** /bankstatements/{id} | 
[**bankstatements_idactioncomplete_post**](BankStatementApi.md#bankstatements_idactioncomplete_post) | **POST** /bankstatements/{id}?action&#x3D;complete | 
[**bankstatements_idactionreopen_post**](BankStatementApi.md#bankstatements_idactionreopen_post) | **POST** /bankstatements/{id}?action&#x3D;reopen | 
[**bankstatements_post**](BankStatementApi.md#bankstatements_post) | **POST** /bankstatements | 
[**bankstatementsactionaccount_balance_get**](BankStatementApi.md#bankstatementsactionaccount_balance_get) | **GET** /bankstatements?action&#x3D;account-balance | 
[**bankstatementsactionaccount_status_get**](BankStatementApi.md#bankstatementsactionaccount_status_get) | **GET** /bankstatements?action&#x3D;account-status | 
[**bankstatementsactionaccount_status_monthly_get**](BankStatementApi.md#bankstatementsactionaccount_status_monthly_get) | **GET** /bankstatements?action&#x3D;account-status-monthly | 
[**bankstatementsactionimport_post**](BankStatementApi.md#bankstatementsactionimport_post) | **POST** /bankstatements?action&#x3D;import | 
[**bankstatementsactionmatch_items_post**](BankStatementApi.md#bankstatementsactionmatch_items_post) | **POST** /bankstatements?action&#x3D;match-items | 
[**bankstatementsactionpreview_post**](BankStatementApi.md#bankstatementsactionpreview_post) | **POST** /bankstatements?action&#x3D;preview | 
[**bankstatementsactionsuggest_match_post**](BankStatementApi.md#bankstatementsactionsuggest_match_post) | **POST** /bankstatements?action&#x3D;suggest-match | 
[**bankstatementsactiontemplates_get**](BankStatementApi.md#bankstatementsactiontemplates_get) | **GET** /bankstatements?action&#x3D;templates | 

# **bankstatements_get**
> list[BankStatement] bankstatements_get()



Query BankStatement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()

try:
    api_response = api_instance.bankstatements_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankStatement]**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_id_delete**
> BankStatement bankstatements_id_delete(id)



Delete BankStatement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatements_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_id_get**
> BankStatement bankstatements_id_get(id)



Get BankStatement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
id = 56 # int | 

try:
    api_response = api_instance.bankstatements_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_id_put**
> BankStatement bankstatements_id_put(body, id)



Update BankStatement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
body = swagger_client.BankStatement() # BankStatement | 
id = 56 # int | 

try:
    api_response = api_instance.bankstatements_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatement**](BankStatement.md)|  | 
 **id** | **int**|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_idactioncomplete_post**
> BankStatement bankstatements_idactioncomplete_post(id, id)



complete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatements_idactioncomplete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_idactioncomplete_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_idactionreopen_post**
> BankStatement bankstatements_idactionreopen_post(id, id)



reopen Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatements_idactionreopen_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_idactionreopen_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatements_post**
> BankStatement bankstatements_post(body)



Create BankStatement

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
body = swagger_client.BankStatement() # BankStatement | 

try:
    api_response = api_instance.bankstatements_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatements_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BankStatement**](BankStatement.md)|  | 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionaccount_balance_get**
> BalanceDto bankstatementsactionaccount_balance_get(accountid, _date)



account-balance Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
accountid = swagger_client.Object() # Object | 
_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatementsactionaccount_balance_get(accountid, _date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionaccount_balance_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **_date** | [**Object**](.md)|  | 

### Return type

[**BalanceDto**](BalanceDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionaccount_status_get**
> ReconciliationStatus bankstatementsactionaccount_status_get(accountid, fromdate, todate)



account-status Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
accountid = swagger_client.Object() # Object | 
fromdate = swagger_client.Object() # Object | 
todate = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatementsactionaccount_status_get(accountid, fromdate, todate)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionaccount_status_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **fromdate** | [**Object**](.md)|  | 
 **todate** | [**Object**](.md)|  | 

### Return type

[**ReconciliationStatus**](ReconciliationStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionaccount_status_monthly_get**
> list[ReconciliationStatus] bankstatementsactionaccount_status_monthly_get(accountid, fromdate, todate)



account-status-monthly Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
accountid = swagger_client.Object() # Object | 
fromdate = swagger_client.Object() # Object | 
todate = swagger_client.Object() # Object | 

try:
    api_response = api_instance.bankstatementsactionaccount_status_monthly_get(accountid, fromdate, todate)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionaccount_status_monthly_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **fromdate** | [**Object**](.md)|  | 
 **todate** | [**Object**](.md)|  | 

### Return type

[**list[ReconciliationStatus]**](ReconciliationStatus.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionimport_post**
> BankStatement bankstatementsactionimport_post(accountid, file_id, max_lines, body=body)



import Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
accountid = swagger_client.Object() # Object | 
file_id = swagger_client.Object() # Object | 
max_lines = swagger_client.Object() # Object | 
body = swagger_client.BankfileFormat() # BankfileFormat |  (optional)

try:
    api_response = api_instance.bankstatementsactionimport_post(accountid, file_id, max_lines, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionimport_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **file_id** | [**Object**](.md)|  | 
 **max_lines** | [**Object**](.md)|  | 
 **body** | [**BankfileFormat**](BankfileFormat.md)|  | [optional] 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionmatch_items_post**
> object bankstatementsactionmatch_items_post(body=body)



match-items Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
body = [swagger_client.BankStatementMatch()] # list[BankStatementMatch] |  (optional)

try:
    api_response = api_instance.bankstatementsactionmatch_items_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionmatch_items_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[BankStatementMatch]**](BankStatementMatch.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionpreview_post**
> BankStatement bankstatementsactionpreview_post(accountid, file_id, max_lines, body=body)



preview Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
accountid = swagger_client.Object() # Object | 
file_id = swagger_client.Object() # Object | 
max_lines = swagger_client.Object() # Object | 
body = swagger_client.BankfileFormat() # BankfileFormat |  (optional)

try:
    api_response = api_instance.bankstatementsactionpreview_post(accountid, file_id, max_lines, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionpreview_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountid** | [**Object**](.md)|  | 
 **file_id** | [**Object**](.md)|  | 
 **max_lines** | [**Object**](.md)|  | 
 **body** | [**BankfileFormat**](BankfileFormat.md)|  | [optional] 

### Return type

[**BankStatement**](BankStatement.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactionsuggest_match_post**
> list[BankMatchSuggestion] bankstatementsactionsuggest_match_post(body=body)



suggest-match Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()
body = swagger_client.MatchRequest() # MatchRequest |  (optional)

try:
    api_response = api_instance.bankstatementsactionsuggest_match_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactionsuggest_match_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MatchRequest**](MatchRequest.md)|  | [optional] 

### Return type

[**list[BankMatchSuggestion]**](BankMatchSuggestion.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **bankstatementsactiontemplates_get**
> list[BankfileFormat] bankstatementsactiontemplates_get()



templates Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BankStatementApi()

try:
    api_response = api_instance.bankstatementsactiontemplates_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BankStatementApi->bankstatementsactiontemplates_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BankfileFormat]**](BankfileFormat.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

