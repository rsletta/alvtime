# swagger_client.PaymentApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**payments_get**](PaymentApi.md#payments_get) | **GET** /payments | 
[**payments_id_delete**](PaymentApi.md#payments_id_delete) | **DELETE** /payments/{id} | 
[**payments_id_get**](PaymentApi.md#payments_id_get) | **GET** /payments/{id} | 
[**payments_id_put**](PaymentApi.md#payments_id_put) | **PUT** /payments/{id} | 
[**payments_idactiondelete_and_credit_delete**](PaymentApi.md#payments_idactiondelete_and_credit_delete) | **DELETE** /payments/{id}?action&#x3D;delete-and-credit | 
[**payments_idactionforce_delete_and_credit_delete**](PaymentApi.md#payments_idactionforce_delete_and_credit_delete) | **DELETE** /payments/{id}?action&#x3D;force-delete-and-credit | 
[**payments_idactionforce_delete_delete**](PaymentApi.md#payments_idactionforce_delete_delete) | **DELETE** /payments/{id}?action&#x3D;force-delete | 
[**payments_post**](PaymentApi.md#payments_post) | **POST** /payments | 
[**paymentsactionbatch_cancel_payment_claims_put**](PaymentApi.md#paymentsactionbatch_cancel_payment_claims_put) | **PUT** /payments?action&#x3D;batch-cancel-payment-claims | 
[**paymentsactionbatch_delete_and_credit_put**](PaymentApi.md#paymentsactionbatch_delete_and_credit_put) | **PUT** /payments?action&#x3D;batch-delete-and-credit | 
[**paymentsactioncreate_hash_for_payments_get**](PaymentApi.md#paymentsactioncreate_hash_for_payments_get) | **GET** /payments?action&#x3D;create-hash-for-payments | 
[**paymentsactioncreate_payment_batch_for_all_payments_post**](PaymentApi.md#paymentsactioncreate_payment_batch_for_all_payments_post) | **POST** /payments?action&#x3D;create-payment-batch-for-all-payments | 
[**paymentsactioncreate_payment_batch_post**](PaymentApi.md#paymentsactioncreate_payment_batch_post) | **POST** /payments?action&#x3D;create-payment-batch | 
[**paymentsactioncreate_payment_with_tracelink_post**](PaymentApi.md#paymentsactioncreate_payment_with_tracelink_post) | **POST** /payments?action&#x3D;create-payment-with-tracelink | 
[**paymentsactionreset_payment_post**](PaymentApi.md#paymentsactionreset_payment_post) | **POST** /payments?action&#x3D;reset-payment | 
[**paymentsactionupdate_payments_to_ignored_put**](PaymentApi.md#paymentsactionupdate_payments_to_ignored_put) | **PUT** /payments?action&#x3D;update-payments-to-ignored | 

# **payments_get**
> list[Payment] payments_get()



Query Payment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()

try:
    api_response = api_instance.payments_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Payment]**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payments_id_delete**
> Payment payments_id_delete(id)



Delete Payment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
id = 56 # int | 

try:
    api_response = api_instance.payments_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payments_id_get**
> Payment payments_id_get(id)



Get Payment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
id = 56 # int | 

try:
    api_response = api_instance.payments_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payments_id_put**
> Payment payments_id_put(body, id)



Update Payment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
body = swagger_client.Payment() # Payment | 
id = 56 # int | 

try:
    api_response = api_instance.payments_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Payment**](Payment.md)|  | 
 **id** | **int**|  | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **payments_idactiondelete_and_credit_delete**
> object payments_idactiondelete_and_credit_delete(id, id)



delete-and-credit Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payments_idactiondelete_and_credit_delete(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_idactiondelete_and_credit_delete: %s\n" % e)
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

# **payments_idactionforce_delete_and_credit_delete**
> object payments_idactionforce_delete_and_credit_delete(id, id)



force-delete-and-credit Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payments_idactionforce_delete_and_credit_delete(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_idactionforce_delete_and_credit_delete: %s\n" % e)
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

# **payments_idactionforce_delete_delete**
> object payments_idactionforce_delete_delete(id, id)



force-delete Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.payments_idactionforce_delete_delete(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_idactionforce_delete_delete: %s\n" % e)
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

# **payments_post**
> Payment payments_post(body)



Create Payment

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
body = swagger_client.Payment() # Payment | 

try:
    api_response = api_instance.payments_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->payments_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Payment**](Payment.md)|  | 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactionbatch_cancel_payment_claims_put**
> object paymentsactionbatch_cancel_payment_claims_put(body=body)



batch-cancel-payment-claims Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentsactionbatch_cancel_payment_claims_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactionbatch_cancel_payment_claims_put: %s\n" % e)
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

# **paymentsactionbatch_delete_and_credit_put**
> object paymentsactionbatch_delete_and_credit_put(credit, body=body)



batch-delete-and-credit Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
credit = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentsactionbatch_delete_and_credit_put(credit, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactionbatch_delete_and_credit_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credit** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactioncreate_hash_for_payments_get**
> str paymentsactioncreate_hash_for_payments_get(filter, expand)



create-hash-for-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
filter = swagger_client.Object() # Object | 
expand = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentsactioncreate_hash_for_payments_get(filter, expand)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactioncreate_hash_for_payments_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | [**Object**](.md)|  | 
 **expand** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactioncreate_payment_batch_for_all_payments_post**
> object paymentsactioncreate_payment_batch_for_all_payments_post(is_manual, hash, create_file, filter, expand)



create-payment-batch-for-all-payments Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
is_manual = swagger_client.Object() # Object | 
hash = swagger_client.Object() # Object | 
create_file = swagger_client.Object() # Object | 
filter = swagger_client.Object() # Object | 
expand = swagger_client.Object() # Object | 

try:
    api_response = api_instance.paymentsactioncreate_payment_batch_for_all_payments_post(is_manual, hash, create_file, filter, expand)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactioncreate_payment_batch_for_all_payments_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **hash** | [**Object**](.md)|  | 
 **create_file** | [**Object**](.md)|  | 
 **filter** | [**Object**](.md)|  | 
 **expand** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactioncreate_payment_batch_post**
> PaymentBatch paymentsactioncreate_payment_batch_post(is_manual, hash, create_payment_file, body=body)



create-payment-batch Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
is_manual = swagger_client.Object() # Object | 
hash = swagger_client.Object() # Object | 
create_payment_file = swagger_client.Object() # Object | 
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentsactioncreate_payment_batch_post(is_manual, hash, create_payment_file, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactioncreate_payment_batch_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **is_manual** | [**Object**](.md)|  | 
 **hash** | [**Object**](.md)|  | 
 **create_payment_file** | [**Object**](.md)|  | 
 **body** | [**int**](int.md)|  | [optional] 

### Return type

[**PaymentBatch**](PaymentBatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactioncreate_payment_with_tracelink_post**
> Payment paymentsactioncreate_payment_with_tracelink_post(journal_entry_id, body=body)



create-payment-with-tracelink Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
journal_entry_id = swagger_client.Object() # Object | 
body = swagger_client.Payment() # Payment |  (optional)

try:
    api_response = api_instance.paymentsactioncreate_payment_with_tracelink_post(journal_entry_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactioncreate_payment_with_tracelink_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **journal_entry_id** | [**Object**](.md)|  | 
 **body** | [**Payment**](Payment.md)|  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactionreset_payment_post**
> Payment paymentsactionreset_payment_post(old_payment_id, body=body)



reset-payment Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
old_payment_id = swagger_client.Object() # Object | 
body = swagger_client.Payment() # Payment |  (optional)

try:
    api_response = api_instance.paymentsactionreset_payment_post(old_payment_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactionreset_payment_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **old_payment_id** | [**Object**](.md)|  | 
 **body** | [**Payment**](Payment.md)|  | [optional] 

### Return type

[**Payment**](Payment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **paymentsactionupdate_payments_to_ignored_put**
> list[Payment] paymentsactionupdate_payments_to_ignored_put(body=body)



update-payments-to-ignored Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PaymentApi()
body = 56 # int |  (optional)

try:
    api_response = api_instance.paymentsactionupdate_payments_to_ignored_put(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PaymentApi->paymentsactionupdate_payments_to_ignored_put: %s\n" % e)
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

