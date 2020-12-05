# swagger_client.CostAllocationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**costallocations_get**](CostAllocationApi.md#costallocations_get) | **GET** /costallocations | 
[**costallocations_id_delete**](CostAllocationApi.md#costallocations_id_delete) | **DELETE** /costallocations/{id} | 
[**costallocations_id_get**](CostAllocationApi.md#costallocations_id_get) | **GET** /costallocations/{id} | 
[**costallocations_id_put**](CostAllocationApi.md#costallocations_id_put) | **PUT** /costallocations/{id} | 
[**costallocations_post**](CostAllocationApi.md#costallocations_post) | **POST** /costallocations | 
[**costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get**](CostAllocationApi.md#costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get) | **GET** /costallocations?action&#x3D;create-journalentrylinedrafts-from-account-costallocation | 
[**costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get**](CostAllocationApi.md#costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get) | **GET** /costallocations?action&#x3D;create-journalentrylinedrafts-from-costallocation | 
[**costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get**](CostAllocationApi.md#costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get) | **GET** /costallocations?action&#x3D;create-journalentrylinesdrafts-from-supplier-costallocation | 

# **costallocations_get**
> list[CostAllocation] costallocations_get()



Query CostAllocation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()

try:
    api_response = api_instance.costallocations_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocations_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CostAllocation]**](CostAllocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocations_id_delete**
> CostAllocation costallocations_id_delete(id)



Delete CostAllocation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
id = 56 # int | 

try:
    api_response = api_instance.costallocations_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CostAllocation**](CostAllocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocations_id_get**
> CostAllocation costallocations_id_get(id)



Get CostAllocation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
id = 56 # int | 

try:
    api_response = api_instance.costallocations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CostAllocation**](CostAllocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocations_id_put**
> CostAllocation costallocations_id_put(body, id)



Update CostAllocation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
body = swagger_client.CostAllocation() # CostAllocation | 
id = 56 # int | 

try:
    api_response = api_instance.costallocations_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocations_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CostAllocation**](CostAllocation.md)|  | 
 **id** | **int**|  | 

### Return type

[**CostAllocation**](CostAllocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocations_post**
> CostAllocation costallocations_post(body)



Create CostAllocation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
body = swagger_client.CostAllocation() # CostAllocation | 

try:
    api_response = api_instance.costallocations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CostAllocation**](CostAllocation.md)|  | 

### Return type

[**CostAllocation**](CostAllocation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get**
> list[JournalEntryLineDraft] costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get(account_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)



create-journalentrylinedrafts-from-account-costallocation Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
account_id = swagger_client.Object() # Object | 
use_account_id = swagger_client.Object() # Object | 
currency_amount = swagger_client.Object() # Object | 
currency_code_id = swagger_client.Object() # Object | 
exchange_rate = swagger_client.Object() # Object | 
financial_date = swagger_client.Object() # Object | 
vat_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get(account_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocationsactioncreate_journalentrylinedrafts_from_account_costallocation_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 
 **use_account_id** | [**Object**](.md)|  | 
 **currency_amount** | [**Object**](.md)|  | 
 **currency_code_id** | [**Object**](.md)|  | 
 **exchange_rate** | [**Object**](.md)|  | 
 **financial_date** | [**Object**](.md)|  | 
 **vat_date** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLineDraft]**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get**
> list[JournalEntryLineDraft] costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get(cost_allocation_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)



create-journalentrylinedrafts-from-costallocation Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
cost_allocation_id = swagger_client.Object() # Object | 
use_account_id = swagger_client.Object() # Object | 
currency_amount = swagger_client.Object() # Object | 
currency_code_id = swagger_client.Object() # Object | 
exchange_rate = swagger_client.Object() # Object | 
financial_date = swagger_client.Object() # Object | 
vat_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get(cost_allocation_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocationsactioncreate_journalentrylinedrafts_from_costallocation_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cost_allocation_id** | [**Object**](.md)|  | 
 **use_account_id** | [**Object**](.md)|  | 
 **currency_amount** | [**Object**](.md)|  | 
 **currency_code_id** | [**Object**](.md)|  | 
 **exchange_rate** | [**Object**](.md)|  | 
 **financial_date** | [**Object**](.md)|  | 
 **vat_date** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLineDraft]**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get**
> list[JournalEntryLineDraft] costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get(supplier_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)



create-journalentrylinesdrafts-from-supplier-costallocation Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CostAllocationApi()
supplier_id = swagger_client.Object() # Object | 
use_account_id = swagger_client.Object() # Object | 
currency_amount = swagger_client.Object() # Object | 
currency_code_id = swagger_client.Object() # Object | 
exchange_rate = swagger_client.Object() # Object | 
financial_date = swagger_client.Object() # Object | 
vat_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get(supplier_id, use_account_id, currency_amount, currency_code_id, exchange_rate, financial_date, vat_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CostAllocationApi->costallocationsactioncreate_journalentrylinesdrafts_from_supplier_costallocation_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_id** | [**Object**](.md)|  | 
 **use_account_id** | [**Object**](.md)|  | 
 **currency_amount** | [**Object**](.md)|  | 
 **currency_code_id** | [**Object**](.md)|  | 
 **exchange_rate** | [**Object**](.md)|  | 
 **financial_date** | [**Object**](.md)|  | 
 **vat_date** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryLineDraft]**](JournalEntryLineDraft.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

