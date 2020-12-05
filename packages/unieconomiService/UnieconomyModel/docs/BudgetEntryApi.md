# swagger_client.BudgetEntryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**budgetentries_get**](BudgetEntryApi.md#budgetentries_get) | **GET** /budgetentries | 
[**budgetentries_id_delete**](BudgetEntryApi.md#budgetentries_id_delete) | **DELETE** /budgetentries/{id} | 
[**budgetentries_id_get**](BudgetEntryApi.md#budgetentries_id_get) | **GET** /budgetentries/{id} | 
[**budgetentries_id_put**](BudgetEntryApi.md#budgetentries_id_put) | **PUT** /budgetentries/{id} | 
[**budgetentries_post**](BudgetEntryApi.md#budgetentries_post) | **POST** /budgetentries | 

# **budgetentries_get**
> list[BudgetEntry] budgetentries_get()



Query BudgetEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetEntryApi()

try:
    api_response = api_instance.budgetentries_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetEntryApi->budgetentries_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[BudgetEntry]**](BudgetEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetentries_id_delete**
> BudgetEntry budgetentries_id_delete(id)



Delete BudgetEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.budgetentries_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetEntryApi->budgetentries_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BudgetEntry**](BudgetEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetentries_id_get**
> BudgetEntry budgetentries_id_get(id)



Get BudgetEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.budgetentries_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetEntryApi->budgetentries_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**BudgetEntry**](BudgetEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetentries_id_put**
> BudgetEntry budgetentries_id_put(body, id)



Update BudgetEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetEntryApi()
body = swagger_client.BudgetEntry() # BudgetEntry | 
id = 56 # int | 

try:
    api_response = api_instance.budgetentries_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetEntryApi->budgetentries_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BudgetEntry**](BudgetEntry.md)|  | 
 **id** | **int**|  | 

### Return type

[**BudgetEntry**](BudgetEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **budgetentries_post**
> BudgetEntry budgetentries_post(body)



Create BudgetEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.BudgetEntryApi()
body = swagger_client.BudgetEntry() # BudgetEntry | 

try:
    api_response = api_instance.budgetentries_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling BudgetEntryApi->budgetentries_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BudgetEntry**](BudgetEntry.md)|  | 

### Return type

[**BudgetEntry**](BudgetEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

