# swagger_client.BudgetApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**budgets_get**](BudgetApi.md#budgets_get) | **GET** /budgets | 
[**budgets_id_delete**](BudgetApi.md#budgets_id_delete) | **DELETE** /budgets/{id} | 
[**budgets_id_get**](BudgetApi.md#budgets_id_get) | **GET** /budgets/{id} | 
[**budgets_id_put**](BudgetApi.md#budgets_id_put) | **PUT** /budgets/{id} | 
[**budgets_idactionactivate_post**](BudgetApi.md#budgets_idactionactivate_post) | **POST** /budgets/{id}?action&#x3D;activate | 
[**budgets_idactiondeactivate_post**](BudgetApi.md#budgets_idactiondeactivate_post) | **POST** /budgets/{id}?action&#x3D;deactivate | 
[**budgets_idactiondetails_get**](BudgetApi.md#budgets_idactiondetails_get) | **GET** /budgets/{id}?action&#x3D;details | 
[**budgets_idactionexcelbudget_post**](BudgetApi.md#budgets_idactionexcelbudget_post) | **POST** /budgets/{id}?action&#x3D;excelbudget | 
[**budgets_idactiongetexcelbudget_get**](BudgetApi.md#budgets_idactiongetexcelbudget_get) | **GET** /budgets/{id}?action&#x3D;getexcelbudget | 
[**budgets_idactionsummary_get**](BudgetApi.md#budgets_idactionsummary_get) | **GET** /budgets/{id}?action&#x3D;summary | 
[**budgets_post**](BudgetApi.md#budgets_post) | **POST** /budgets | 
[**budgetsactiondetails_get**](BudgetApi.md#budgetsactiondetails_get) | **GET** /budgets?action&#x3D;details | 
[**budgetsactionsummary_get**](BudgetApi.md#budgetsactionsummary_get) | **GET** /budgets?action&#x3D;summary | 

# **budgets_get**
> list[Budget] budgets_get()



Query Budget

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()

try:
    api_response = api_instance.budgets_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Budget]**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_id_delete**
> Budget budgets_id_delete(id)



Delete Budget

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 

try:
    api_response = api_instance.budgets_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_id_get**
> Budget budgets_id_get(id)



Get Budget

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 

try:
    api_response = api_instance.budgets_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_id_put**
> Budget budgets_id_put(body, id)



Update Budget

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
body = swagger_client.Budget() # Budget | 
id = 56 # int | 

try:
    api_response = api_instance.budgets_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Budget**](Budget.md)|  | 
 **id** | **int**|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactionactivate_post**
> Budget budgets_idactionactivate_post(id, id)



activate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactionactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactionactivate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactiondeactivate_post**
> Budget budgets_idactiondeactivate_post(id, id)



deactivate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactiondeactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactiondeactivate_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactiondetails_get**
> list[ReportRow] budgets_idactiondetails_get(id, id)



details Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactiondetails_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactiondetails_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**list[ReportRow]**](ReportRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactionexcelbudget_post**
> BudgetImport budgets_idactionexcelbudget_post(id, fileid, departmentid)



excelbudget Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
fileid = swagger_client.Object() # Object | 
departmentid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactionexcelbudget_post(id, fileid, departmentid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactionexcelbudget_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **fileid** | [**Object**](.md)|  | 
 **departmentid** | [**Object**](.md)|  | 

### Return type

[**BudgetImport**](BudgetImport.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactiongetexcelbudget_get**
> IActionResult budgets_idactiongetexcelbudget_get(id, id)



getexcelbudget Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactiongetexcelbudget_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactiongetexcelbudget_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_idactionsummary_get**
> list[ReportRow] budgets_idactionsummary_get(id, id)



summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgets_idactionsummary_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_idactionsummary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**list[ReportRow]**](ReportRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgets_post**
> Budget budgets_post(body)



Create Budget

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
body = swagger_client.Budget() # Budget | 

try:
    api_response = api_instance.budgets_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgets_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Budget**](Budget.md)|  | 

### Return type

[**Budget**](Budget.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetsactiondetails_get**
> list[ReportRow] budgetsactiondetails_get(financial_year)



details Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgetsactiondetails_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgetsactiondetails_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

[**list[ReportRow]**](ReportRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetsactionsummary_get**
> list[ReportRow] budgetsactionsummary_get(financial_year)



summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetApi()
financial_year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.budgetsactionsummary_get(financial_year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetApi->budgetsactionsummary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **financial_year** | [**Object**](.md)|  | 

### Return type

[**list[ReportRow]**](ReportRow.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

