# swagger_client.CustomerInvoiceApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoices_get**](CustomerInvoiceApi.md#invoices_get) | **GET** /invoices | 
[**invoices_id_delete**](CustomerInvoiceApi.md#invoices_id_delete) | **DELETE** /invoices/{id} | 
[**invoices_id_get**](CustomerInvoiceApi.md#invoices_id_get) | **GET** /invoices/{id} | 
[**invoices_id_put**](CustomerInvoiceApi.md#invoices_id_put) | **PUT** /invoices/{id} | 
[**invoices_idactionaccept_decline_aprila_offer_post**](CustomerInvoiceApi.md#invoices_idactionaccept_decline_aprila_offer_post) | **POST** /invoices/{id}?action&#x3D;accept-decline-aprila-offer | 
[**invoices_idactioncalculate_vat_summary_get**](CustomerInvoiceApi.md#invoices_idactioncalculate_vat_summary_get) | **GET** /invoices/{id}?action&#x3D;calculate-vat-summary | 
[**invoices_idactioncreate_credit_draft_invoice_put**](CustomerInvoiceApi.md#invoices_idactioncreate_credit_draft_invoice_put) | **PUT** /invoices/{id}?action&#x3D;create-credit-draft-invoice | 
[**invoices_idactioncreate_invoice_journalentrydraft_put**](CustomerInvoiceApi.md#invoices_idactioncreate_invoice_journalentrydraft_put) | **PUT** /invoices/{id}?action&#x3D;create-invoice-journalentrydraft | 
[**invoices_idactionfulfill_aprila_offer_post**](CustomerInvoiceApi.md#invoices_idactionfulfill_aprila_offer_post) | **POST** /invoices/{id}?action&#x3D;fulfill-aprila-offer | 
[**invoices_idactionget_aprila_offer_get**](CustomerInvoiceApi.md#invoices_idactionget_aprila_offer_get) | **GET** /invoices/{id}?action&#x3D;get-aprila-offer | 
[**invoices_idactionget_payments_get**](CustomerInvoiceApi.md#invoices_idactionget_payments_get) | **GET** /invoices/{id}?action&#x3D;get-payments | 
[**invoices_idactioninvoice_post**](CustomerInvoiceApi.md#invoices_idactioninvoice_post) | **POST** /invoices/{id}?action&#x3D;invoice | 
[**invoices_idactionnext_get**](CustomerInvoiceApi.md#invoices_idactionnext_get) | **GET** /invoices/{id}?action&#x3D;next | 
[**invoices_idactionpay_invoice_put**](CustomerInvoiceApi.md#invoices_idactionpay_invoice_put) | **PUT** /invoices/{id}?action&#x3D;payInvoice | 
[**invoices_idactionpay_invoice_with_number_series_id_put**](CustomerInvoiceApi.md#invoices_idactionpay_invoice_with_number_series_id_put) | **PUT** /invoices/{id}?action&#x3D;pay-invoice-with-number-series-id | 
[**invoices_idactionpay_post**](CustomerInvoiceApi.md#invoices_idactionpay_post) | **POST** /invoices/{id}?action&#x3D;pay | 
[**invoices_idactionprevious_get**](CustomerInvoiceApi.md#invoices_idactionprevious_get) | **GET** /invoices/{id}?action&#x3D;previous | 
[**invoices_idactionset_customer_invoice_printstatus_put**](CustomerInvoiceApi.md#invoices_idactionset_customer_invoice_printstatus_put) | **PUT** /invoices/{id}?action&#x3D;set-customer-invoice-printstatus | 
[**invoices_idactiontoggle_reminder_stop_put**](CustomerInvoiceApi.md#invoices_idactiontoggle_reminder_stop_put) | **PUT** /invoices/{id}?action&#x3D;toggle-reminder-stop | 
[**invoices_idactionupdate_external_status_put**](CustomerInvoiceApi.md#invoices_idactionupdate_external_status_put) | **PUT** /invoices/{id}?action&#x3D;update-external-status | 
[**invoices_idactionvalidate_vipps_user_get**](CustomerInvoiceApi.md#invoices_idactionvalidate_vipps_user_get) | **GET** /invoices/{id}?action&#x3D;validate-vipps-user | 
[**invoices_post**](CustomerInvoiceApi.md#invoices_post) | **POST** /invoices | 
[**invoicesactioncalculate_invoice_summary_post**](CustomerInvoiceApi.md#invoicesactioncalculate_invoice_summary_post) | **POST** /invoices?action&#x3D;calculate-invoice-summary | 
[**invoicesactioncalculate_vat_summary_get**](CustomerInvoiceApi.md#invoicesactioncalculate_vat_summary_get) | **GET** /invoices?action&#x3D;calculate-vat-summary | 
[**invoicesactionget_barnepass_data_get**](CustomerInvoiceApi.md#invoicesactionget_barnepass_data_get) | **GET** /invoices?action&#x3D;get-barnepass-data | 
[**invoicesactionget_customer_get**](CustomerInvoiceApi.md#invoicesactionget_customer_get) | **GET** /invoices?action&#x3D;get-customer | 
[**invoicesactionget_customer_invoice_summary_get**](CustomerInvoiceApi.md#invoicesactionget_customer_invoice_summary_get) | **GET** /invoices?action&#x3D;get-customer-invoice-summary | 
[**invoicesactionget_customers_get**](CustomerInvoiceApi.md#invoicesactionget_customers_get) | **GET** /invoices?action&#x3D;get-customers | 
[**invoicesactionmatch_invoices_manual_put**](CustomerInvoiceApi.md#invoicesactionmatch_invoices_manual_put) | **PUT** /invoices?action&#x3D;match-invoices-manual | 
[**invoicesactionregular_post**](CustomerInvoiceApi.md#invoicesactionregular_post) | **POST** /invoices?action&#x3D;regular | 

# **invoices_get**
> list[CustomerInvoice] invoices_get()



Query CustomerInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()

try:
    api_response = api_instance.invoices_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoice]**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_id_delete**
> CustomerInvoice invoices_id_delete(id)



Delete CustomerInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.invoices_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_id_get**
> CustomerInvoice invoices_id_get(id)



Get CustomerInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 

try:
    api_response = api_instance.invoices_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_id_put**
> CustomerInvoice invoices_id_put(body, id)



Update CustomerInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
body = swagger_client.CustomerInvoice() # CustomerInvoice | 
id = 56 # int | 

try:
    api_response = api_instance.invoices_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoice**](CustomerInvoice.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionaccept_decline_aprila_offer_post**
> object invoices_idactionaccept_decline_aprila_offer_post(id2, id, aprila_order_id, accept_offer, body=body)



accept-decline-aprila-offer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
aprila_order_id = swagger_client.Object() # Object | 
accept_offer = swagger_client.Object() # Object | 
body = swagger_client.OrderOffer() # OrderOffer |  (optional)

try:
    api_response = api_instance.invoices_idactionaccept_decline_aprila_offer_post(id2, id, aprila_order_id, accept_offer, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionaccept_decline_aprila_offer_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **aprila_order_id** | [**Object**](.md)|  | 
 **accept_offer** | [**Object**](.md)|  | 
 **body** | [**OrderOffer**](OrderOffer.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactioncalculate_vat_summary_get**
> list[VatCalculationSummary] invoices_idactioncalculate_vat_summary_get(id, id)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactioncalculate_vat_summary_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactioncalculate_vat_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**list[VatCalculationSummary]**](VatCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactioncreate_credit_draft_invoice_put**
> CustomerInvoice invoices_idactioncreate_credit_draft_invoice_put(id, id)



create-credit-draft-invoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactioncreate_credit_draft_invoice_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactioncreate_credit_draft_invoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactioncreate_invoice_journalentrydraft_put**
> JournalEntry invoices_idactioncreate_invoice_journalentrydraft_put(id, id)



create-invoice-journalentrydraft Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactioncreate_invoice_journalentrydraft_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactioncreate_invoice_journalentrydraft_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionfulfill_aprila_offer_post**
> object invoices_idactionfulfill_aprila_offer_post(id, id)



fulfill-aprila-offer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionfulfill_aprila_offer_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionfulfill_aprila_offer_post: %s\n" % e)
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

# **invoices_idactionget_aprila_offer_get**
> object invoices_idactionget_aprila_offer_get(id, id)



get-aprila-offer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionget_aprila_offer_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionget_aprila_offer_get: %s\n" % e)
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

# **invoices_idactionget_payments_get**
> list[InvoicePayment] invoices_idactionget_payments_get(id, id)



get-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionget_payments_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionget_payments_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**list[InvoicePayment]**](InvoicePayment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactioninvoice_post**
> object invoices_idactioninvoice_post(id, id)



invoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactioninvoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactioninvoice_post: %s\n" % e)
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

# **invoices_idactionnext_get**
> CustomerInvoice invoices_idactionnext_get(id, id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionnext_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionpay_invoice_put**
> JournalEntry invoices_idactionpay_invoice_put(id2, id, body=body)



payInvoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = swagger_client.InvoicePaymentData() # InvoicePaymentData |  (optional)

try:
    api_response = api_instance.invoices_idactionpay_invoice_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionpay_invoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**InvoicePaymentData**](InvoicePaymentData.md)|  | [optional] 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionpay_invoice_with_number_series_id_put**
> JournalEntry invoices_idactionpay_invoice_with_number_series_id_put(id2, id, number_series_id, body=body)



pay-invoice-with-number-series-id Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
number_series_id = swagger_client.Object() # Object | 
body = swagger_client.InvoicePaymentData() # InvoicePaymentData |  (optional)

try:
    api_response = api_instance.invoices_idactionpay_invoice_with_number_series_id_put(id2, id, number_series_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionpay_invoice_with_number_series_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **number_series_id** | [**Object**](.md)|  | 
 **body** | [**InvoicePaymentData**](InvoicePaymentData.md)|  | [optional] 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionpay_post**
> object invoices_idactionpay_post(id, id)



pay Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionpay_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionpay_post: %s\n" % e)
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

# **invoices_idactionprevious_get**
> CustomerInvoice invoices_idactionprevious_get(id, id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionprevious_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionset_customer_invoice_printstatus_put**
> object invoices_idactionset_customer_invoice_printstatus_put(id, id, print_status)



set-customer-invoice-printstatus Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
print_status = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionset_customer_invoice_printstatus_put(id, id, print_status)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionset_customer_invoice_printstatus_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **print_status** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactiontoggle_reminder_stop_put**
> object invoices_idactiontoggle_reminder_stop_put(id, id)



toggle-reminder-stop Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactiontoggle_reminder_stop_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactiontoggle_reminder_stop_put: %s\n" % e)
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

# **invoices_idactionupdate_external_status_put**
> object invoices_idactionupdate_external_status_put(id2, id, body=body)



update-external-status Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id2 = 56 # int | 
id = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.invoices_idactionupdate_external_status_put(id2, id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionupdate_external_status_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id2** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoices_idactionvalidate_vipps_user_get**
> bool invoices_idactionvalidate_vipps_user_get(id, id)



validate-vipps-user Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoices_idactionvalidate_vipps_user_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_idactionvalidate_vipps_user_get: %s\n" % e)
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

# **invoices_post**
> CustomerInvoice invoices_post(body)



Create CustomerInvoice

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
body = swagger_client.CustomerInvoice() # CustomerInvoice | 

try:
    api_response = api_instance.invoices_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoices_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoice**](CustomerInvoice.md)|  | 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactioncalculate_invoice_summary_post**
> TradeHeaderCalculationSummary invoicesactioncalculate_invoice_summary_post(body=body)



calculate-invoice-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
body = [swagger_client.CustomerInvoiceItem()] # list[CustomerInvoiceItem] |  (optional)

try:
    api_response = api_instance.invoicesactioncalculate_invoice_summary_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactioncalculate_invoice_summary_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[CustomerInvoiceItem]**](CustomerInvoiceItem.md)|  | [optional] 

### Return type

[**TradeHeaderCalculationSummary**](TradeHeaderCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactioncalculate_vat_summary_get**
> list[VatCalculationSummary] invoicesactioncalculate_vat_summary_get(invoice_number)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
invoice_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicesactioncalculate_vat_summary_get(invoice_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactioncalculate_vat_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **invoice_number** | [**Object**](.md)|  | 

### Return type

[**list[VatCalculationSummary]**](VatCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactionget_barnepass_data_get**
> list[BarnepassOppgave] invoicesactionget_barnepass_data_get(year)



get-barnepass-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
year = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicesactionget_barnepass_data_get(year)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionget_barnepass_data_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **year** | [**Object**](.md)|  | 

### Return type

[**list[BarnepassOppgave]**](BarnepassOppgave.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactionget_customer_get**
> Customer invoicesactionget_customer_get(org_number, name)



get-customer Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
org_number = swagger_client.Object() # Object | 
name = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicesactionget_customer_get(org_number, name)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionget_customer_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **org_number** | [**Object**](.md)|  | 
 **name** | [**Object**](.md)|  | 

### Return type

[**Customer**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactionget_customer_invoice_summary_get**
> InvoiceSummary invoicesactionget_customer_invoice_summary_get(odata_filter)



get-customer-invoice-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
odata_filter = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicesactionget_customer_invoice_summary_get(odata_filter)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionget_customer_invoice_summary_get: %s\n" % e)
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

# **invoicesactionget_customers_get**
> list[Customer] invoicesactionget_customers_get(customers_nr_and_name)



get-customers Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
customers_nr_and_name = swagger_client.Object() # Object | 

try:
    api_response = api_instance.invoicesactionget_customers_get(customers_nr_and_name)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionget_customers_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **customers_nr_and_name** | [**Object**](.md)|  | 

### Return type

[**list[Customer]**](Customer.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactionmatch_invoices_manual_put**
> JournalEntry invoicesactionmatch_invoices_manual_put(payment_id, body=body)



match-invoices-manual Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
payment_id = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.invoicesactionmatch_invoices_manual_put(payment_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionmatch_invoices_manual_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payment_id** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

[**JournalEntry**](JournalEntry.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicesactionregular_post**
> CustomerInvoice invoicesactionregular_post(body=body)



regular Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceApi()
body = swagger_client.CustomerInvoice() # CustomerInvoice |  (optional)

try:
    api_response = api_instance.invoicesactionregular_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceApi->invoicesactionregular_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoice**](CustomerInvoice.md)|  | [optional] 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

