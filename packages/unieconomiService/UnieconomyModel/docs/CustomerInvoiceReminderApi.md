# swagger_client.CustomerInvoiceReminderApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoicereminders_get**](CustomerInvoiceReminderApi.md#invoicereminders_get) | **GET** /invoicereminders | 
[**invoicereminders_id_delete**](CustomerInvoiceReminderApi.md#invoicereminders_id_delete) | **DELETE** /invoicereminders/{id} | 
[**invoicereminders_id_get**](CustomerInvoiceReminderApi.md#invoicereminders_id_get) | **GET** /invoicereminders/{id} | 
[**invoicereminders_id_put**](CustomerInvoiceReminderApi.md#invoicereminders_id_put) | **PUT** /invoicereminders/{id} | 
[**invoicereminders_idactionsend_post**](CustomerInvoiceReminderApi.md#invoicereminders_idactionsend_post) | **POST** /invoicereminders/{id}?action&#x3D;send | 
[**invoicereminders_post**](CustomerInvoiceReminderApi.md#invoicereminders_post) | **POST** /invoicereminders | 
[**invoiceremindersactioncreate_invoicereminders_for_invoicelist_post**](CustomerInvoiceReminderApi.md#invoiceremindersactioncreate_invoicereminders_for_invoicelist_post) | **POST** /invoicereminders?action&#x3D;create-invoicereminders-for-invoicelist | 
[**invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post**](CustomerInvoiceReminderApi.md#invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post) | **POST** /invoicereminders?action&#x3D;create-invoicereminders-from-reminder-rules | 
[**invoiceremindersactioncreate_notification_ready_for_debt_collection_post**](CustomerInvoiceReminderApi.md#invoiceremindersactioncreate_notification_ready_for_debt_collection_post) | **POST** /invoicereminders?action&#x3D;create-notification-ready-for-debt-collection | 
[**invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get) | **GET** /invoicereminders?action&#x3D;get-customer-invoices-ready-for-debt-collection | 
[**invoiceremindersactionget_customer_invoices_ready_for_reminding_get**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_customer_invoices_ready_for_reminding_get) | **GET** /invoicereminders?action&#x3D;get-customer-invoices-ready-for-reminding | 
[**invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get) | **GET** /invoicereminders?action&#x3D;get-customer-invoices-sent-to-debt-collection | 
[**invoiceremindersactionget_invoicereminders_for_invoicelist_post**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_invoicereminders_for_invoicelist_post) | **POST** /invoicereminders?action&#x3D;get-invoicereminders-for-invoicelist | 
[**invoiceremindersactionget_invoicereminders_from_reminder_rules_post**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_invoicereminders_from_reminder_rules_post) | **POST** /invoicereminders?action&#x3D;get-invoicereminders-from-reminder-rules | 
[**invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get) | **GET** /invoicereminders?action&#x3D;get-sum-customer-invoices-ready-for-reminding | 
[**invoiceremindersactionget_sum_reminders_to_debt_collection_get**](CustomerInvoiceReminderApi.md#invoiceremindersactionget_sum_reminders_to_debt_collection_get) | **GET** /invoicereminders?action&#x3D;get-sum-reminders-to-debt-collection | 
[**invoiceremindersactionqueue_for_debt_collection_put**](CustomerInvoiceReminderApi.md#invoiceremindersactionqueue_for_debt_collection_put) | **PUT** /invoicereminders?action&#x3D;queue-for-debt-collection | 
[**invoiceremindersactionsend_invoice_print_put**](CustomerInvoiceReminderApi.md#invoiceremindersactionsend_invoice_print_put) | **PUT** /invoicereminders?action&#x3D;send-invoice-print | 
[**invoiceremindersactionsend_put**](CustomerInvoiceReminderApi.md#invoiceremindersactionsend_put) | **PUT** /invoicereminders?action&#x3D;send | 
[**invoiceremindersactionset_status_to_sent_put**](CustomerInvoiceReminderApi.md#invoiceremindersactionset_status_to_sent_put) | **PUT** /invoicereminders?action&#x3D;set-status-to-sent | 

# **invoicereminders_get**
> list[CustomerInvoiceReminder] invoicereminders_get()



Query CustomerInvoiceReminder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoicereminders_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceReminder]**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminders_id_delete**
> CustomerInvoiceReminder invoicereminders_id_delete(id)



Delete CustomerInvoiceReminder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
id = 56 # int | 

try:
    api_response = api_instance.invoicereminders_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminders_id_get**
> CustomerInvoiceReminder invoicereminders_id_get(id)



Get CustomerInvoiceReminder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
id = 56 # int | 

try:
    api_response = api_instance.invoicereminders_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminders_id_put**
> CustomerInvoiceReminder invoicereminders_id_put(body, id)



Update CustomerInvoiceReminder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = swagger_client.CustomerInvoiceReminder() # CustomerInvoiceReminder | 
id = 56 # int | 

try:
    api_response = api_instance.invoicereminders_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminders_idactionsend_post**
> object invoicereminders_idactionsend_post(id, id)



send Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicereminders_idactionsend_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_idactionsend_post: %s\n" % e)
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

# **invoicereminders_post**
> CustomerInvoiceReminder invoicereminders_post(body)



Create CustomerInvoiceReminder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = swagger_client.CustomerInvoiceReminder() # CustomerInvoiceReminder | 

try:
    api_response = api_instance.invoicereminders_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoicereminders_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)|  | 

### Return type

[**CustomerInvoiceReminder**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactioncreate_invoicereminders_for_invoicelist_post**
> list[CustomerInvoiceReminder] invoiceremindersactioncreate_invoicereminders_for_invoicelist_post(body=body)



create-invoicereminders-for-invoicelist Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactioncreate_invoicereminders_for_invoicelist_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactioncreate_invoicereminders_for_invoicelist_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[CustomerInvoiceReminder]**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post**
> list[CustomerInvoiceReminder] invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post()



create-invoicereminders-from-reminder-rules Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactioncreate_invoicereminders_from_reminder_rules_post: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceReminder]**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactioncreate_notification_ready_for_debt_collection_post**
> object invoiceremindersactioncreate_notification_ready_for_debt_collection_post(body=body)



create-notification-ready-for-debt-collection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactioncreate_notification_ready_for_debt_collection_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactioncreate_notification_ready_for_debt_collection_post: %s\n" % e)
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

# **invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get**
> object invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get(include_invoice_with_reminder_stop)



get-customer-invoices-ready-for-debt-collection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
include_invoice_with_reminder_stop = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get(include_invoice_with_reminder_stop)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_customer_invoices_ready_for_debt_collection_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include_invoice_with_reminder_stop** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactionget_customer_invoices_ready_for_reminding_get**
> object invoiceremindersactionget_customer_invoices_ready_for_reminding_get(include_invoice_with_reminder_stop)



get-customer-invoices-ready-for-reminding Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
include_invoice_with_reminder_stop = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoiceremindersactionget_customer_invoices_ready_for_reminding_get(include_invoice_with_reminder_stop)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_customer_invoices_ready_for_reminding_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **include_invoice_with_reminder_stop** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get**
> object invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get()



get-customer-invoices-sent-to-debt-collection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_customer_invoices_sent_to_debt_collection_get: %s\n" % e)
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

# **invoiceremindersactionget_invoicereminders_for_invoicelist_post**
> list[CustomerInvoiceReminder] invoiceremindersactionget_invoicereminders_for_invoicelist_post(body=body)



get-invoicereminders-for-invoicelist Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactionget_invoicereminders_for_invoicelist_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_invoicereminders_for_invoicelist_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[CustomerInvoiceReminder]**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactionget_invoicereminders_from_reminder_rules_post**
> list[CustomerInvoiceReminder] invoiceremindersactionget_invoicereminders_from_reminder_rules_post()



get-invoicereminders-from-reminder-rules Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoiceremindersactionget_invoicereminders_from_reminder_rules_post()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_invoicereminders_from_reminder_rules_post: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceReminder]**](CustomerInvoiceReminder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get**
> object invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get()



get-sum-customer-invoices-ready-for-reminding Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_sum_customer_invoices_ready_for_reminding_get: %s\n" % e)
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

# **invoiceremindersactionget_sum_reminders_to_debt_collection_get**
> object invoiceremindersactionget_sum_reminders_to_debt_collection_get()



get-sum-reminders-to-debt-collection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()

try:
    api_response = api_instance.invoiceremindersactionget_sum_reminders_to_debt_collection_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionget_sum_reminders_to_debt_collection_get: %s\n" % e)
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

# **invoiceremindersactionqueue_for_debt_collection_put**
> object invoiceremindersactionqueue_for_debt_collection_put(body=body)



queue-for-debt-collection Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactionqueue_for_debt_collection_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionqueue_for_debt_collection_put: %s\n" % e)
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

# **invoiceremindersactionsend_invoice_print_put**
> object invoiceremindersactionsend_invoice_print_put(body=body)



send-invoice-print Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactionsend_invoice_print_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionsend_invoice_print_put: %s\n" % e)
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

# **invoiceremindersactionsend_put**
> object invoiceremindersactionsend_put(body=body)



send Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactionsend_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionsend_put: %s\n" % e)
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

# **invoiceremindersactionset_status_to_sent_put**
> object invoiceremindersactionset_status_to_sent_put(body=body)



set-status-to-sent Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoiceremindersactionset_status_to_sent_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderApi->invoiceremindersactionset_status_to_sent_put: %s\n" % e)
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

