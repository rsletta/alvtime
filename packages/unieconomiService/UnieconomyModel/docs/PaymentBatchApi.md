# swagger_client.PaymentBatchApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**paymentbatches_get**](PaymentBatchApi.md#paymentbatches_get) | **GET** /paymentbatches | 
[**paymentbatches_id_delete**](PaymentBatchApi.md#paymentbatches_id_delete) | **DELETE** /paymentbatches/{id} | 
[**paymentbatches_id_get**](PaymentBatchApi.md#paymentbatches_id_get) | **GET** /paymentbatches/{id} | 
[**paymentbatches_id_put**](PaymentBatchApi.md#paymentbatches_id_put) | **PUT** /paymentbatches/{id} | 
[**paymentbatches_idactioncomplete_customer_paymentbatch_post**](PaymentBatchApi.md#paymentbatches_idactioncomplete_customer_paymentbatch_post) | **POST** /paymentbatches/{id}?action&#x3D;complete-customer-paymentbatch | 
[**paymentbatches_post**](PaymentBatchApi.md#paymentbatches_post) | **POST** /paymentbatches | 
[**paymentbatchesactioncomplete_customer_payment_registration_put**](PaymentBatchApi.md#paymentbatchesactioncomplete_customer_payment_registration_put) | **PUT** /paymentbatches?action&#x3D;complete-customer-payment-registration | 
[**paymentbatchesactioncomplete_registered_payments_put**](PaymentBatchApi.md#paymentbatchesactioncomplete_registered_payments_put) | **PUT** /paymentbatches?action&#x3D;complete-registered-payments | 
[**paymentbatchesactioncreate_and_send_all_to_payment_put**](PaymentBatchApi.md#paymentbatchesactioncreate_and_send_all_to_payment_put) | **PUT** /paymentbatches?action&#x3D;create-and-send-all-to-payment | 
[**paymentbatchesactioncreate_and_send_to_payment_put**](PaymentBatchApi.md#paymentbatchesactioncreate_and_send_to_payment_put) | **PUT** /paymentbatches?action&#x3D;create-and-send-to-payment | 
[**paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put) | **PUT** /paymentbatches?action&#x3D;generate-avtalegiro-batch-for-invoiceIDs-and-paymentIDs | 
[**paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put) | **PUT** /paymentbatches?action&#x3D;generate-avtalegiro-batch-for-invoiceIDs | 
[**paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put) | **PUT** /paymentbatches?action&#x3D;generate-avtalegiro-batch-for-invoice-numbers | 
[**paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put) | **PUT** /paymentbatches?action&#x3D;generate-avtalegiro-batch-for-payments | 
[**paymentbatchesactiongenerate_camt054_c_string_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_camt054_c_string_put) | **PUT** /paymentbatches?action&#x3D;generate-camt054C-string | 
[**paymentbatchesactiongenerate_ocr_giro_string_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_ocr_giro_string_put) | **PUT** /paymentbatches?action&#x3D;generate-ocr-giro-string | 
[**paymentbatchesactiongenerate_pain002_file_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_pain002_file_put) | **PUT** /paymentbatches?action&#x3D;generate-pain002-file | 
[**paymentbatchesactiongenerate_payment_file_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_payment_file_put) | **PUT** /paymentbatches?action&#x3D;generate-payment-file | 
[**paymentbatchesactiongenerate_receipt_file_put**](PaymentBatchApi.md#paymentbatchesactiongenerate_receipt_file_put) | **PUT** /paymentbatches?action&#x3D;generate-receipt-file | 
[**paymentbatchesactionget_file_statuses_from_file_ids_put**](PaymentBatchApi.md#paymentbatchesactionget_file_statuses_from_file_ids_put) | **PUT** /paymentbatches?action&#x3D;get-file-statuses-from-file-ids | 
[**paymentbatchesactionget_statuses_from_file_ids_put**](PaymentBatchApi.md#paymentbatchesactionget_statuses_from_file_ids_put) | **PUT** /paymentbatches?action&#x3D;get-statuses-from-file-ids | 
[**paymentbatchesactionprocess_avtalegiro_receipt_file_content_put**](PaymentBatchApi.md#paymentbatchesactionprocess_avtalegiro_receipt_file_content_put) | **PUT** /paymentbatches?action&#x3D;process-avtalegiro-receipt-file-content | 
[**paymentbatchesactionprocess_avtalegiro_receipt_file_put**](PaymentBatchApi.md#paymentbatchesactionprocess_avtalegiro_receipt_file_put) | **PUT** /paymentbatches?action&#x3D;process-avtalegiro-receipt-file | 
[**paymentbatchesactionregister_and_complete_customer_payment_put**](PaymentBatchApi.md#paymentbatchesactionregister_and_complete_customer_payment_put) | **PUT** /paymentbatches?action&#x3D;register-and-complete-customer-payment | 
[**paymentbatchesactionregister_customer_payment_file_put**](PaymentBatchApi.md#paymentbatchesactionregister_customer_payment_file_put) | **PUT** /paymentbatches?action&#x3D;register-customer-payment-file | 
[**paymentbatchesactionregister_payment_string_post**](PaymentBatchApi.md#paymentbatchesactionregister_payment_string_post) | **POST** /paymentbatches?action&#x3D;register-payment-string | 
[**paymentbatchesactionregister_receipt_file_camt054_put**](PaymentBatchApi.md#paymentbatchesactionregister_receipt_file_camt054_put) | **PUT** /paymentbatches?action&#x3D;register-receipt-file-camt054 | 
[**paymentbatchesactionregister_receipt_file_pain002_put**](PaymentBatchApi.md#paymentbatchesactionregister_receipt_file_pain002_put) | **PUT** /paymentbatches?action&#x3D;register-receipt-file-pain002 | 
[**paymentbatchesactionregister_receipt_file_put**](PaymentBatchApi.md#paymentbatchesactionregister_receipt_file_put) | **PUT** /paymentbatches?action&#x3D;register-receipt-file | 
[**paymentbatchesactionrevert_payment_batch_put**](PaymentBatchApi.md#paymentbatchesactionrevert_payment_batch_put) | **PUT** /paymentbatches?action&#x3D;revert-payment-batch | 
[**paymentbatchesactionsend_batch_to_payment_put**](PaymentBatchApi.md#paymentbatchesactionsend_batch_to_payment_put) | **PUT** /paymentbatches?action&#x3D;send-batch-to-payment | 
[**paymentbatchesactionupdate_payments_to_completed_put**](PaymentBatchApi.md#paymentbatchesactionupdate_payments_to_completed_put) | **PUT** /paymentbatches?action&#x3D;update-payments-to-completed | 
[**paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put**](PaymentBatchApi.md#paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put) | **PUT** /paymentbatches?action&#x3D;update-payments-to-paid-and-journal-payments | 

# **paymentbatches_get**
> list[PaymentBatch] paymentbatches_get()



Query PaymentBatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()

try:
    api_response = api_instance.paymentbatches_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PaymentBatch]**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatches_id_delete**
> PaymentBatch paymentbatches_id_delete(id)



Delete PaymentBatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = 56 # int | 

try:
    api_response = api_instance.paymentbatches_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatches_id_get**
> PaymentBatch paymentbatches_id_get(id)



Get PaymentBatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = 56 # int | 

try:
    api_response = api_instance.paymentbatches_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatches_id_put**
> PaymentBatch paymentbatches_id_put(body, id)



Update PaymentBatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = swagger_client.PaymentBatch() # PaymentBatch | 
id = 56 # int | 

try:
    api_response = api_instance.paymentbatches_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentBatch**](PaymentBatch.md)|  | 
 **id** | **int**|  | 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatches_idactioncomplete_customer_paymentbatch_post**
> object paymentbatches_idactioncomplete_customer_paymentbatch_post(id, id)



complete-customer-paymentbatch Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatches_idactioncomplete_customer_paymentbatch_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_idactioncomplete_customer_paymentbatch_post: %s\n" % e)
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

# **paymentbatches_post**
> PaymentBatch paymentbatches_post(body)



Create PaymentBatch

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = swagger_client.PaymentBatch() # PaymentBatch | 

try:
    api_response = api_instance.paymentbatches_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatches_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PaymentBatch**](PaymentBatch.md)|  | 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactioncomplete_customer_payment_registration_put**
> list[PaymentBatch] paymentbatchesactioncomplete_customer_payment_registration_put(id)



complete-customer-payment-registration Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactioncomplete_customer_payment_registration_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactioncomplete_customer_payment_registration_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 

### Return type

[**list[PaymentBatch]**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactioncomplete_registered_payments_put**
> object paymentbatchesactioncomplete_registered_payments_put(id)



complete-registered-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactioncomplete_registered_payments_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactioncomplete_registered_payments_put: %s\n" % e)
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

# **paymentbatchesactioncreate_and_send_all_to_payment_put**
> object paymentbatchesactioncreate_and_send_all_to_payment_put(body=body)



create-and-send-all-to-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = swagger_client.CreatePaymentBatchDTO() # CreatePaymentBatchDTO |  (optional)

try:
    api_response = api_instance.paymentbatchesactioncreate_and_send_all_to_payment_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactioncreate_and_send_all_to_payment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreatePaymentBatchDTO**](CreatePaymentBatchDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactioncreate_and_send_to_payment_put**
> object paymentbatchesactioncreate_and_send_to_payment_put(body=body)



create-and-send-to-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = swagger_client.CreatePaymentBatchDTO() # CreatePaymentBatchDTO |  (optional)

try:
    api_response = api_instance.paymentbatchesactioncreate_and_send_to_payment_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactioncreate_and_send_to_payment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreatePaymentBatchDTO**](CreatePaymentBatchDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put**
> object paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put(is_manual, is_mergeable, body=body)



generate-avtalegiro-batch-for-invoiceIDs-and-paymentIDs Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
is_manual = swagger_client.Object() # Object | 
is_mergeable = swagger_client.Object() # Object | 
body = swagger_client.CreateAvtaleGiroPaymentBatchDTO() # CreateAvtaleGiroPaymentBatchDTO |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put(is_manual, is_mergeable, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_and_payment_i_ds_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **is_mergeable** | [**Object**](.md)|  | 
 **body** | [**CreateAvtaleGiroPaymentBatchDTO**](CreateAvtaleGiroPaymentBatchDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put**
> object paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put(is_manual, is_mergeable, body=body)



generate-avtalegiro-batch-for-invoiceIDs Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
is_manual = swagger_client.Object() # Object | 
is_mergeable = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put(is_manual, is_mergeable, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_i_ds_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **is_mergeable** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put**
> object paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put(is_manual, body=body)



generate-avtalegiro-batch-for-invoice-numbers Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
is_manual = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put(is_manual, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_avtalegiro_batch_for_invoice_numbers_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put**
> object paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put(is_manual, is_mergeable, body=body)



generate-avtalegiro-batch-for-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
is_manual = swagger_client.Object() # Object | 
is_mergeable = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put(is_manual, is_mergeable, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_avtalegiro_batch_for_payments_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **is_mergeable** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_camt054_c_string_put**
> str paymentbatchesactiongenerate_camt054_c_string_put(body=body)



generate-camt054C-string Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_camt054_c_string_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_camt054_c_string_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_ocr_giro_string_put**
> str paymentbatchesactiongenerate_ocr_giro_string_put(from_bank_account_number, custom_eol_char, body=body)



generate-ocr-giro-string Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
from_bank_account_number = swagger_client.Object() # Object | 
custom_eol_char = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_ocr_giro_string_put(from_bank_account_number, custom_eol_char, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_ocr_giro_string_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from_bank_account_number** | [**Object**](.md)|  | 
 **custom_eol_char** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_pain002_file_put**
> str paymentbatchesactiongenerate_pain002_file_put(status, body=body)



generate-pain002-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
status = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_pain002_file_put(status, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_pain002_file_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **status** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactiongenerate_payment_file_put**
> object paymentbatchesactiongenerate_payment_file_put(id)



generate-payment-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactiongenerate_payment_file_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_payment_file_put: %s\n" % e)
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

# **paymentbatchesactiongenerate_receipt_file_put**
> str paymentbatchesactiongenerate_receipt_file_put(body=body)



generate-receipt-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactiongenerate_receipt_file_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactiongenerate_receipt_file_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionget_file_statuses_from_file_ids_put**
> int paymentbatchesactionget_file_statuses_from_file_ids_put(body=body)



get-file-statuses-from-file-ids Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactionget_file_statuses_from_file_ids_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionget_file_statuses_from_file_ids_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionget_statuses_from_file_ids_put**
> int paymentbatchesactionget_statuses_from_file_ids_put(body=body)



get-statuses-from-file-ids Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactionget_statuses_from_file_ids_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionget_statuses_from_file_ids_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**int**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionprocess_avtalegiro_receipt_file_content_put**
> object paymentbatchesactionprocess_avtalegiro_receipt_file_content_put(filename, body=body)



process-avtalegiro-receipt-file-content Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
filename = swagger_client.Object() # Object | 
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactionprocess_avtalegiro_receipt_file_content_put(filename, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionprocess_avtalegiro_receipt_file_content_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filename** | [**Object**](.md)|  | 
 **body** | [**str**](str.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionprocess_avtalegiro_receipt_file_put**
> object paymentbatchesactionprocess_avtalegiro_receipt_file_put(file_id)



process-avtalegiro-receipt-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionprocess_avtalegiro_receipt_file_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionprocess_avtalegiro_receipt_file_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_and_complete_customer_payment_put**
> object paymentbatchesactionregister_and_complete_customer_payment_put(file_id)



register-and-complete-customer-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionregister_and_complete_customer_payment_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_and_complete_customer_payment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_customer_payment_file_put**
> list[PaymentBatch] paymentbatchesactionregister_customer_payment_file_put(file_id)



register-customer-payment-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionregister_customer_payment_file_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_customer_payment_file_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

[**list[PaymentBatch]**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_payment_string_post**
> list[PaymentBatch] paymentbatchesactionregister_payment_string_post(body=body)



register-payment-string Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 'body_example' # str |  (optional)

try:
    api_response = api_instance.paymentbatchesactionregister_payment_string_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_payment_string_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**str**](str.md)|  | [optional] 

### Return type

[**list[PaymentBatch]**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_receipt_file_camt054_put**
> object paymentbatchesactionregister_receipt_file_camt054_put(file_id)



register-receipt-file-camt054 Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionregister_receipt_file_camt054_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_receipt_file_camt054_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_receipt_file_pain002_put**
> PaymentBatch paymentbatchesactionregister_receipt_file_pain002_put(file_id)



register-receipt-file-pain002 Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionregister_receipt_file_pain002_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_receipt_file_pain002_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionregister_receipt_file_put**
> object paymentbatchesactionregister_receipt_file_put(file_id)



register-receipt-file Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionregister_receipt_file_put(file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionregister_receipt_file_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file_id** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionrevert_payment_batch_put**
> object paymentbatchesactionrevert_payment_batch_put(id, recreate_payments)



revert-payment-batch Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
id = swagger_client.Object() # Object | 
recreate_payments = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentbatchesactionrevert_payment_batch_put(id, recreate_payments)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionrevert_payment_batch_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Object**](.md)|  | 
 **recreate_payments** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionsend_batch_to_payment_put**
> object paymentbatchesactionsend_batch_to_payment_put(batch_id, body=body)



send-batch-to-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
batch_id = swagger_client.Object() # Object | 
body = swagger_client.CreatePaymentBatchDTO() # CreatePaymentBatchDTO |  (optional)

try:
    api_response = api_instance.paymentbatchesactionsend_batch_to_payment_put(batch_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionsend_batch_to_payment_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batch_id** | [**Object**](.md)|  | 
 **body** | [**CreatePaymentBatchDTO**](CreatePaymentBatchDTO.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionupdate_payments_to_completed_put**
> list[Payment] paymentbatchesactionupdate_payments_to_completed_put(body=body)



update-payments-to-completed Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactionupdate_payments_to_completed_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionupdate_payments_to_completed_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[Payment]**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put**
> list[Payment] paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put(body=body)



update-payments-to-paid-and-journal-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentBatchApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentBatchApi->paymentbatchesactionupdate_payments_to_paid_and_journal_payments_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**list[Payment]**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

