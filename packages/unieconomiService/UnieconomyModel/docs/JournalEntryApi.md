# swagger_client.JournalEntryApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**journalentries_get**](JournalEntryApi.md#journalentries_get) | **GET** /journalentries | 
[**journalentries_id_delete**](JournalEntryApi.md#journalentries_id_delete) | **DELETE** /journalentries/{id} | 
[**journalentries_id_get**](JournalEntryApi.md#journalentries_id_get) | **GET** /journalentries/{id} | 
[**journalentries_id_put**](JournalEntryApi.md#journalentries_id_put) | **PUT** /journalentries/{id} | 
[**journalentries_post**](JournalEntryApi.md#journalentries_post) | **POST** /journalentries | 
[**journalentriesactionbook_journal_entries_post**](JournalEntryApi.md#journalentriesactionbook_journal_entries_post) | **POST** /journalentries?action&#x3D;book-journal-entries | 
[**journalentriesactionbook_journal_entry_against_payment_post**](JournalEntryApi.md#journalentriesactionbook_journal_entry_against_payment_post) | **POST** /journalentries?action&#x3D;book-journal-entry-against-payment | 
[**journalentriesactionbook_payment_against_customer_put**](JournalEntryApi.md#journalentriesactionbook_payment_against_customer_put) | **PUT** /journalentries?action&#x3D;book-payment-against-customer | 
[**journalentriesactionbook_payment_against_main_account_put**](JournalEntryApi.md#journalentriesactionbook_payment_against_main_account_put) | **PUT** /journalentries?action&#x3D;book-payment-against-main-account | 
[**journalentriesactionbook_payment_against_supplier_put**](JournalEntryApi.md#journalentriesactionbook_payment_against_supplier_put) | **PUT** /journalentries?action&#x3D;book-payment-against-supplier | 
[**journalentriesactioncredit_and_book_journal_entry_post**](JournalEntryApi.md#journalentriesactioncredit_and_book_journal_entry_post) | **POST** /journalentries?action&#x3D;credit-and-book-journal-entry | 
[**journalentriesactioncredit_and_book_journalentry_post**](JournalEntryApi.md#journalentriesactioncredit_and_book_journalentry_post) | **POST** /journalentries?action&#x3D;credit-and-book-journalentry | 
[**journalentriesactioncredit_journal_entry_post**](JournalEntryApi.md#journalentriesactioncredit_journal_entry_post) | **POST** /journalentries?action&#x3D;credit-journal-entry | 
[**journalentriesactioncredit_journalentry_post**](JournalEntryApi.md#journalentriesactioncredit_journalentry_post) | **POST** /journalentries?action&#x3D;credit-journalentry | 
[**journalentriesactiondelete_journal_entry_draft_group_delete**](JournalEntryApi.md#journalentriesactiondelete_journal_entry_draft_group_delete) | **DELETE** /journalentries?action&#x3D;delete-journal-entry-draft-group | 
[**journalentriesactionget_journal_entry_data_get**](JournalEntryApi.md#journalentriesactionget_journal_entry_data_get) | **GET** /journalentries?action&#x3D;get-journal-entry-data | 
[**journalentriesactionget_journal_entry_period_data_get**](JournalEntryApi.md#journalentriesactionget_journal_entry_period_data_get) | **GET** /journalentries?action&#x3D;get-journal-entry-period-data | 
[**journalentriesactionget_or_create_financial_year_get**](JournalEntryApi.md#journalentriesactionget_or_create_financial_year_get) | **GET** /journalentries?action&#x3D;get-or-create-financial-year | 
[**journalentriesactionnextjournalentrynumber_post**](JournalEntryApi.md#journalentriesactionnextjournalentrynumber_post) | **POST** /journalentries?action&#x3D;nextjournalentrynumber | 
[**journalentriesactionsave_journal_entries_as_draft_post**](JournalEntryApi.md#journalentriesactionsave_journal_entries_as_draft_post) | **POST** /journalentries?action&#x3D;save-journal-entries-as-draft | 

# **journalentries_get**
> list[JournalEntry] journalentries_get()



Query JournalEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()

try:
    api_response = api_instance.journalentries_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentries_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[JournalEntry]**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentries_id_delete**
> JournalEntry journalentries_id_delete(id)



Delete JournalEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentries_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentries_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentries_id_get**
> JournalEntry journalentries_id_get(id)



Get JournalEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
id = 56 # int | 

try:
    api_response = api_instance.journalentries_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentries_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentries_id_put**
> JournalEntry journalentries_id_put(body, id)



Update JournalEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
body = swagger_client.JournalEntry() # JournalEntry | 
id = 56 # int | 

try:
    api_response = api_instance.journalentries_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentries_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntry**](JournalEntry.md)|  | 
 **id** | **int**|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentries_post**
> JournalEntry journalentries_post(body)



Create JournalEntry

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
body = swagger_client.JournalEntry() # JournalEntry | 

try:
    api_response = api_instance.journalentries_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentries_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntry**](JournalEntry.md)|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionbook_journal_entries_post**
> object journalentriesactionbook_journal_entries_post(body=body)



book-journal-entries Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
body = [swagger_client.JournalEntry()] # list[JournalEntry] |  (optional)

try:
    api_response = api_instance.journalentriesactionbook_journal_entries_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionbook_journal_entries_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[JournalEntry]**](JournalEntry.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionbook_journal_entry_against_payment_post**
> JournalEntry journalentriesactionbook_journal_entry_against_payment_post(journal_entry_id, payment_id)



book-journal-entry-against-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_id = swagger_client.Object() # Object | 
payment_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionbook_journal_entry_against_payment_post(journal_entry_id, payment_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionbook_journal_entry_against_payment_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_id** | [**Object**](.md)|  | 
 **payment_id** | [**Object**](.md)|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionbook_payment_against_customer_put**
> object journalentriesactionbook_payment_against_customer_put(customer_id, payment_id, is_balance_kid)



book-payment-against-customer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
customer_id = swagger_client.Object() # Object | 
payment_id = swagger_client.Object() # Object | 
is_balance_kid = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionbook_payment_against_customer_put(customer_id, payment_id, is_balance_kid)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionbook_payment_against_customer_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customer_id** | [**Object**](.md)|  | 
 **payment_id** | [**Object**](.md)|  | 
 **is_balance_kid** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionbook_payment_against_main_account_put**
> object journalentriesactionbook_payment_against_main_account_put(payment_id, account_id)



book-payment-against-main-account Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
payment_id = swagger_client.Object() # Object | 
account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionbook_payment_against_main_account_put(payment_id, account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionbook_payment_against_main_account_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payment_id** | [**Object**](.md)|  | 
 **account_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionbook_payment_against_supplier_put**
> object journalentriesactionbook_payment_against_supplier_put(supplier_id, payment_id)



book-payment-against-supplier Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
supplier_id = swagger_client.Object() # Object | 
payment_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionbook_payment_against_supplier_put(supplier_id, payment_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionbook_payment_against_supplier_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_id** | [**Object**](.md)|  | 
 **payment_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactioncredit_and_book_journal_entry_post**
> list[JournalEntry] journalentriesactioncredit_and_book_journal_entry_post(journal_entry_id, credit_date, body=body)



credit-and-book-journal-entry Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_id = swagger_client.Object() # Object | 
credit_date = swagger_client.Object() # Object | 
body = [swagger_client.JournalEntry()] # list[JournalEntry] |  (optional)

try:
    api_response = api_instance.journalentriesactioncredit_and_book_journal_entry_post(journal_entry_id, credit_date, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactioncredit_and_book_journal_entry_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_id** | [**Object**](.md)|  | 
 **credit_date** | [**Object**](.md)|  | 
 **body** | [**list[JournalEntry]**](JournalEntry.md)|  | [optional] 

### Return type

[**list[JournalEntry]**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactioncredit_and_book_journalentry_post**
> list[JournalEntry] journalentriesactioncredit_and_book_journalentry_post(journal_entry_id, body=body)



credit-and-book-journalentry Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_id = swagger_client.Object() # Object | 
body = [swagger_client.JournalEntry()] # list[JournalEntry] |  (optional)

try:
    api_response = api_instance.journalentriesactioncredit_and_book_journalentry_post(journal_entry_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactioncredit_and_book_journalentry_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_id** | [**Object**](.md)|  | 
 **body** | [**list[JournalEntry]**](JournalEntry.md)|  | [optional] 

### Return type

[**list[JournalEntry]**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactioncredit_journal_entry_post**
> object journalentriesactioncredit_journal_entry_post(journal_entry_number, credit_date)



credit-journal-entry Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_number = swagger_client.Object() # Object | 
credit_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactioncredit_journal_entry_post(journal_entry_number, credit_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactioncredit_journal_entry_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_number** | [**Object**](.md)|  | 
 **credit_date** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactioncredit_journalentry_post**
> object journalentriesactioncredit_journalentry_post(journal_entry_number)



credit-journalentry Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactioncredit_journalentry_post(journal_entry_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactioncredit_journalentry_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_number** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactiondelete_journal_entry_draft_group_delete**
> object journalentriesactiondelete_journal_entry_draft_group_delete(journal_entry_draft_group)



delete-journal-entry-draft-group Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
journal_entry_draft_group = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactiondelete_journal_entry_draft_group_delete(journal_entry_draft_group)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactiondelete_journal_entry_draft_group_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_draft_group** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionget_journal_entry_data_get**
> list[JournalEntryData] journalentriesactionget_journal_entry_data_get(batch_number, journal_entry_id, supplier_invoice_id, journal_entry_draft_group)



get-journal-entry-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
batch_number = swagger_client.Object() # Object | 
journal_entry_id = swagger_client.Object() # Object | 
supplier_invoice_id = swagger_client.Object() # Object | 
journal_entry_draft_group = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionget_journal_entry_data_get(batch_number, journal_entry_id, supplier_invoice_id, journal_entry_draft_group)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionget_journal_entry_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch_number** | [**Object**](.md)|  | 
 **journal_entry_id** | [**Object**](.md)|  | 
 **supplier_invoice_id** | [**Object**](.md)|  | 
 **journal_entry_draft_group** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryData]**](JournalEntryData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionget_journal_entry_period_data_get**
> list[JournalEntryPeriodData] journalentriesactionget_journal_entry_period_data_get(account_id)



get-journal-entry-period-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
account_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionget_journal_entry_period_data_get(account_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionget_journal_entry_period_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | [**Object**](.md)|  | 

### Return type

[**list[JournalEntryPeriodData]**](JournalEntryPeriodData.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionget_or_create_financial_year_get**
> FinancialYear journalentriesactionget_or_create_financial_year_get(current)



get-or-create-financial-year Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
current = swagger_client.Object() # Object | 

try:
    api_response = api_instance.journalentriesactionget_or_create_financial_year_get(current)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionget_or_create_financial_year_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **current** | [**Object**](.md)|  | 

### Return type

[**FinancialYear**](FinancialYear.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionnextjournalentrynumber_post**
> str journalentriesactionnextjournalentrynumber_post(body=body)



nextjournalentrynumber Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
body = swagger_client.JournalEntryData() # JournalEntryData |  (optional)

try:
    api_response = api_instance.journalentriesactionnextjournalentrynumber_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionnextjournalentrynumber_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**JournalEntryData**](JournalEntryData.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **journalentriesactionsave_journal_entries_as_draft_post**
> object journalentriesactionsave_journal_entries_as_draft_post(body=body)



save-journal-entries-as-draft Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.JournalEntryApi()
body = [swagger_client.JournalEntry()] # list[JournalEntry] |  (optional)

try:
    api_response = api_instance.journalentriesactionsave_journal_entries_as_draft_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling JournalEntryApi->journalentriesactionsave_journal_entries_as_draft_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[JournalEntry]**](JournalEntry.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

