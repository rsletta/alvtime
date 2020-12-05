# swagger_client.SupplierInvoiceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplierinvoices_get**](SupplierInvoiceApi.md#supplierinvoices_get) | **GET** /supplierinvoices | 
[**supplierinvoices_id_delete**](SupplierInvoiceApi.md#supplierinvoices_id_delete) | **DELETE** /supplierinvoices/{id} | 
[**supplierinvoices_id_get**](SupplierInvoiceApi.md#supplierinvoices_id_get) | **GET** /supplierinvoices/{id} | 
[**supplierinvoices_id_put**](SupplierInvoiceApi.md#supplierinvoices_id_put) | **PUT** /supplierinvoices/{id} | 
[**supplierinvoices_idactionapprove_post**](SupplierInvoiceApi.md#supplierinvoices_idactionapprove_post) | **POST** /supplierinvoices/{id}?action&#x3D;approve | 
[**supplierinvoices_idactionassign_post**](SupplierInvoiceApi.md#supplierinvoices_idactionassign_post) | **POST** /supplierinvoices/{id}?action&#x3D;assign | 
[**supplierinvoices_idactionassign_to_post**](SupplierInvoiceApi.md#supplierinvoices_idactionassign_to_post) | **POST** /supplierinvoices/{id}?action&#x3D;assign-to | 
[**supplierinvoices_idactioncancel_approvement_post**](SupplierInvoiceApi.md#supplierinvoices_idactioncancel_approvement_post) | **POST** /supplierinvoices/{id}?action&#x3D;cancelApprovement | 
[**supplierinvoices_idactionfinish_post**](SupplierInvoiceApi.md#supplierinvoices_idactionfinish_post) | **POST** /supplierinvoices/{id}?action&#x3D;finish | 
[**supplierinvoices_idactionjournal_post**](SupplierInvoiceApi.md#supplierinvoices_idactionjournal_post) | **POST** /supplierinvoices/{id}?action&#x3D;journal | 
[**supplierinvoices_idactionnotify_approval_tasks_post**](SupplierInvoiceApi.md#supplierinvoices_idactionnotify_approval_tasks_post) | **POST** /supplierinvoices/{id}?action&#x3D;notify-approval-tasks | 
[**supplierinvoices_idactionpay_invoice_put**](SupplierInvoiceApi.md#supplierinvoices_idactionpay_invoice_put) | **PUT** /supplierinvoices/{id}?action&#x3D;payInvoice | 
[**supplierinvoices_idactionpay_post**](SupplierInvoiceApi.md#supplierinvoices_idactionpay_post) | **POST** /supplierinvoices/{id}?action&#x3D;pay | 
[**supplierinvoices_idactionre_assign_post**](SupplierInvoiceApi.md#supplierinvoices_idactionre_assign_post) | **POST** /supplierinvoices/{id}?action&#x3D;reAssign | 
[**supplierinvoices_idactionre_assign_to_post**](SupplierInvoiceApi.md#supplierinvoices_idactionre_assign_to_post) | **POST** /supplierinvoices/{id}?action&#x3D;reAssign-to | 
[**supplierinvoices_idactionreject_assignment_post**](SupplierInvoiceApi.md#supplierinvoices_idactionreject_assignment_post) | **POST** /supplierinvoices/{id}?action&#x3D;rejectAssignment | 
[**supplierinvoices_idactionreject_invoice_post**](SupplierInvoiceApi.md#supplierinvoices_idactionreject_invoice_post) | **POST** /supplierinvoices/{id}?action&#x3D;rejectInvoice | 
[**supplierinvoices_idactionreject_put**](SupplierInvoiceApi.md#supplierinvoices_idactionreject_put) | **PUT** /supplierinvoices/{id}?action&#x3D;reject | 
[**supplierinvoices_idactionrestore_post**](SupplierInvoiceApi.md#supplierinvoices_idactionrestore_post) | **POST** /supplierinvoices/{id}?action&#x3D;restore | 
[**supplierinvoices_idactionrevert_finish_post**](SupplierInvoiceApi.md#supplierinvoices_idactionrevert_finish_post) | **POST** /supplierinvoices/{id}?action&#x3D;revertFinish | 
[**supplierinvoices_idactionsend_for_payment_post**](SupplierInvoiceApi.md#supplierinvoices_idactionsend_for_payment_post) | **POST** /supplierinvoices/{id}?action&#x3D;sendForPayment | 
[**supplierinvoices_idactionsend_for_payment_with_payment_data_post**](SupplierInvoiceApi.md#supplierinvoices_idactionsend_for_payment_with_payment_data_post) | **POST** /supplierinvoices/{id}?action&#x3D;sendForPaymentWithPaymentData | 
[**supplierinvoices_idactionsmartbooking_put**](SupplierInvoiceApi.md#supplierinvoices_idactionsmartbooking_put) | **PUT** /supplierinvoices/{id}?action&#x3D;smartbooking | 
[**supplierinvoices_post**](SupplierInvoiceApi.md#supplierinvoices_post) | **POST** /supplierinvoices | 
[**supplierinvoicesactioncredit_supplierinvoice_journalentry_post**](SupplierInvoiceApi.md#supplierinvoicesactioncredit_supplierinvoice_journalentry_post) | **POST** /supplierinvoices?action&#x3D;credit-supplierinvoice-journalentry | 
[**supplierinvoicesactionget_selfemployed_payments_get**](SupplierInvoiceApi.md#supplierinvoicesactionget_selfemployed_payments_get) | **GET** /supplierinvoices?action&#x3D;get-selfemployed-payments | 
[**supplierinvoicesactionget_supplier_invoice_summary_get**](SupplierInvoiceApi.md#supplierinvoicesactionget_supplier_invoice_summary_get) | **GET** /supplierinvoices?action&#x3D;get-supplier-invoice-summary | 
[**supplierinvoicesactionget_supplierinvoices_details_get**](SupplierInvoiceApi.md#supplierinvoicesactionget_supplierinvoices_details_get) | **GET** /supplierinvoices?action&#x3D;get-supplierinvoices-details | 
[**supplierinvoicesactionpay_put**](SupplierInvoiceApi.md#supplierinvoicesactionpay_put) | **PUT** /supplierinvoices?action&#x3D;pay | 
[**supplierinvoicesactionsend_for_payment_put**](SupplierInvoiceApi.md#supplierinvoicesactionsend_for_payment_put) | **PUT** /supplierinvoices?action&#x3D;sendForPayment | 

# **supplierinvoices_get**
> list[SupplierInvoice] supplierinvoices_get()



Query SupplierInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()

try:
    api_response = api_instance.supplierinvoices_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SupplierInvoice]**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_id_delete**
> SupplierInvoice supplierinvoices_id_delete(id)



Delete SupplierInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.supplierinvoices_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SupplierInvoice**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_id_get**
> SupplierInvoice supplierinvoices_id_get(id)



Get SupplierInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.supplierinvoices_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SupplierInvoice**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_id_put**
> SupplierInvoice supplierinvoices_id_put(body, id)



Update SupplierInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
body = swagger_client.SupplierInvoice() # SupplierInvoice | 
id = 56 # int | 

try:
    api_response = api_instance.supplierinvoices_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SupplierInvoice**](SupplierInvoice.md)|  | 
 **id** | **int**|  | 

### Return type

[**SupplierInvoice**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactionapprove_post**
> object supplierinvoices_idactionapprove_post(id, id)



approve Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionapprove_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionapprove_post: %s\n" % e)
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

# **supplierinvoices_idactionassign_post**
> object supplierinvoices_idactionassign_post(id, id)



assign Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionassign_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionassign_post: %s\n" % e)
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

# **supplierinvoices_idactionassign_to_post**
> Task supplierinvoices_idactionassign_to_post(id2, id, body=body)



assign-to Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.AssignmentDetails() # AssignmentDetails |  (optional)

try:
    api_response = api_instance.supplierinvoices_idactionassign_to_post(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionassign_to_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**AssignmentDetails**](AssignmentDetails.md)|  | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactioncancel_approvement_post**
> object supplierinvoices_idactioncancel_approvement_post(id, id)



cancelApprovement Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactioncancel_approvement_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactioncancel_approvement_post: %s\n" % e)
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

# **supplierinvoices_idactionfinish_post**
> object supplierinvoices_idactionfinish_post(id, id)



finish Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionfinish_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionfinish_post: %s\n" % e)
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

# **supplierinvoices_idactionjournal_post**
> object supplierinvoices_idactionjournal_post(id, id)



journal Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionjournal_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionjournal_post: %s\n" % e)
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

# **supplierinvoices_idactionnotify_approval_tasks_post**
> object supplierinvoices_idactionnotify_approval_tasks_post(id, days_to_due_date, redirect_url)



notify-approval-tasks Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
days_to_due_date = swagger_client.Object() # Object | 
redirect_url = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionnotify_approval_tasks_post(id, days_to_due_date, redirect_url)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionnotify_approval_tasks_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **days_to_due_date** | [**Object**](.md)|  | 
 **redirect_url** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactionpay_invoice_put**
> JournalEntry supplierinvoices_idactionpay_invoice_put(id, body=body)



payInvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
body = swagger_client.InvoicePaymentData() # InvoicePaymentData |  (optional)

try:
    api_response = api_instance.supplierinvoices_idactionpay_invoice_put(id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionpay_invoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **body** | [**InvoicePaymentData**](InvoicePaymentData.md)|  | [optional] 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactionpay_post**
> object supplierinvoices_idactionpay_post(id, id)



pay Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionpay_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionpay_post: %s\n" % e)
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

# **supplierinvoices_idactionre_assign_post**
> object supplierinvoices_idactionre_assign_post(id, id)



reAssign Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionre_assign_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionre_assign_post: %s\n" % e)
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

# **supplierinvoices_idactionre_assign_to_post**
> object supplierinvoices_idactionre_assign_to_post(id2, id, body=body)



reAssign-to Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.AssignmentDetails() # AssignmentDetails |  (optional)

try:
    api_response = api_instance.supplierinvoices_idactionre_assign_to_post(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionre_assign_to_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**AssignmentDetails**](AssignmentDetails.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactionreject_assignment_post**
> object supplierinvoices_idactionreject_assignment_post(id, id)



rejectAssignment Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionreject_assignment_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionreject_assignment_post: %s\n" % e)
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

# **supplierinvoices_idactionreject_invoice_post**
> object supplierinvoices_idactionreject_invoice_post(id, id)



rejectInvoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionreject_invoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionreject_invoice_post: %s\n" % e)
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

# **supplierinvoices_idactionreject_put**
> object supplierinvoices_idactionreject_put(id, id)



reject Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionreject_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionreject_put: %s\n" % e)
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

# **supplierinvoices_idactionrestore_post**
> object supplierinvoices_idactionrestore_post(id, id)



restore Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionrestore_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionrestore_post: %s\n" % e)
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

# **supplierinvoices_idactionrevert_finish_post**
> object supplierinvoices_idactionrevert_finish_post(id, id)



revertFinish Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionrevert_finish_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionrevert_finish_post: %s\n" % e)
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

# **supplierinvoices_idactionsend_for_payment_post**
> object supplierinvoices_idactionsend_for_payment_post(id, id)



sendForPayment Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoices_idactionsend_for_payment_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionsend_for_payment_post: %s\n" % e)
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

# **supplierinvoices_idactionsend_for_payment_with_payment_data_post**
> object supplierinvoices_idactionsend_for_payment_with_payment_data_post(id2, id, body=body)



sendForPaymentWithPaymentData Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.InvoicePaymentData() # InvoicePaymentData |  (optional)

try:
    api_response = api_instance.supplierinvoices_idactionsend_for_payment_with_payment_data_post(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionsend_for_payment_with_payment_data_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**InvoicePaymentData**](InvoicePaymentData.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoices_idactionsmartbooking_put**
> JournalEntry supplierinvoices_idactionsmartbooking_put(id)



smartbooking Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.supplierinvoices_idactionsmartbooking_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_idactionsmartbooking_put: %s\n" % e)
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

# **supplierinvoices_post**
> SupplierInvoice supplierinvoices_post(body)



Create SupplierInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
body = swagger_client.SupplierInvoice() # SupplierInvoice | 

try:
    api_response = api_instance.supplierinvoices_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoices_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SupplierInvoice**](SupplierInvoice.md)|  | 

### Return type

[**SupplierInvoice**](SupplierInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactioncredit_supplierinvoice_journalentry_post**
> object supplierinvoicesactioncredit_supplierinvoice_journalentry_post(supplier_invoice_id)



credit-supplierinvoice-journalentry Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
supplier_invoice_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactioncredit_supplierinvoice_journalentry_post(supplier_invoice_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactioncredit_supplierinvoice_journalentry_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **supplier_invoice_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactionget_selfemployed_payments_get**
> list[SelfEmployedItem] supplierinvoicesactionget_selfemployed_payments_get(year)



get-selfemployed-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactionget_selfemployed_payments_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactionget_selfemployed_payments_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**list[SelfEmployedItem]**](SelfEmployedItem.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactionget_supplier_invoice_summary_get**
> InvoiceSummary supplierinvoicesactionget_supplier_invoice_summary_get(odata_filter)



get-supplier-invoice-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
odata_filter = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactionget_supplier_invoice_summary_get(odata_filter)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactionget_supplier_invoice_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **odata_filter** | [**Object**](.md)|  | 

### Return type

[**InvoiceSummary**](InvoiceSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactionget_supplierinvoices_details_get**
> list[SupplierInvoiceDetail] supplierinvoicesactionget_supplierinvoices_details_get(id, supplier_id, from_date, to_date)



get-supplierinvoices-details Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = swagger_client.Object() # Object | 
supplier_id = swagger_client.Object() # Object | 
from_date = swagger_client.Object() # Object | 
to_date = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactionget_supplierinvoices_details_get(id, supplier_id, from_date, to_date)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactionget_supplierinvoices_details_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **supplier_id** | [**Object**](.md)|  | 
 **from_date** | [**Object**](.md)|  | 
 **to_date** | [**Object**](.md)|  | 

### Return type

[**list[SupplierInvoiceDetail]**](SupplierInvoiceDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactionpay_put**
> object supplierinvoicesactionpay_put(id)



pay Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactionpay_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactionpay_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **supplierinvoicesactionsend_for_payment_put**
> object supplierinvoicesactionsend_for_payment_put(id)



sendForPayment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SupplierInvoiceApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.supplierinvoicesactionsend_for_payment_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SupplierInvoiceApi->supplierinvoicesactionsend_for_payment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

