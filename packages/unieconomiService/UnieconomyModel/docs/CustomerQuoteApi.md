# swagger_client.CustomerQuoteApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**quotes_get**](CustomerQuoteApi.md#quotes_get) | **GET** /quotes | 
[**quotes_id_delete**](CustomerQuoteApi.md#quotes_id_delete) | **DELETE** /quotes/{id} | 
[**quotes_id_get**](CustomerQuoteApi.md#quotes_id_get) | **GET** /quotes/{id} | 
[**quotes_id_put**](CustomerQuoteApi.md#quotes_id_put) | **PUT** /quotes/{id} | 
[**quotes_idactioncalculate_vat_summary_get**](CustomerQuoteApi.md#quotes_idactioncalculate_vat_summary_get) | **GET** /quotes/{id}?action&#x3D;calculate-vat-summary | 
[**quotes_idactioncomplete_post**](CustomerQuoteApi.md#quotes_idactioncomplete_post) | **POST** /quotes/{id}?action&#x3D;complete | 
[**quotes_idactioncustomer_accept_post**](CustomerQuoteApi.md#quotes_idactioncustomer_accept_post) | **POST** /quotes/{id}?action&#x3D;customerAccept | 
[**quotes_idactionnext_get**](CustomerQuoteApi.md#quotes_idactionnext_get) | **GET** /quotes/{id}?action&#x3D;next | 
[**quotes_idactionprevious_get**](CustomerQuoteApi.md#quotes_idactionprevious_get) | **GET** /quotes/{id}?action&#x3D;previous | 
[**quotes_idactionregister_post**](CustomerQuoteApi.md#quotes_idactionregister_post) | **POST** /quotes/{id}?action&#x3D;register | 
[**quotes_idactionset_customer_quote_printstatus_put**](CustomerQuoteApi.md#quotes_idactionset_customer_quote_printstatus_put) | **PUT** /quotes/{id}?action&#x3D;set-customer-quote-printstatus | 
[**quotes_idactionship_to_customer_post**](CustomerQuoteApi.md#quotes_idactionship_to_customer_post) | **POST** /quotes/{id}?action&#x3D;shipToCustomer | 
[**quotes_idactionto_invoice_post**](CustomerQuoteApi.md#quotes_idactionto_invoice_post) | **POST** /quotes/{id}?action&#x3D;toInvoice | 
[**quotes_idactionto_order_post**](CustomerQuoteApi.md#quotes_idactionto_order_post) | **POST** /quotes/{id}?action&#x3D;toOrder | 
[**quotes_post**](CustomerQuoteApi.md#quotes_post) | **POST** /quotes | 
[**quotesactioncalculate_quote_summary_post**](CustomerQuoteApi.md#quotesactioncalculate_quote_summary_post) | **POST** /quotes?action&#x3D;calculate-quote-summary | 
[**quotesactioncalculate_vat_summary_get**](CustomerQuoteApi.md#quotesactioncalculate_vat_summary_get) | **GET** /quotes?action&#x3D;calculate-vat-summary | 

# **quotes_get**
> list[CustomerQuote] quotes_get()



Query CustomerQuote

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()

try:
    api_response = api_instance.quotes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerQuote]**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_id_delete**
> CustomerQuote quotes_id_delete(id)



Delete CustomerQuote

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 

try:
    api_response = api_instance.quotes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_id_get**
> CustomerQuote quotes_id_get(id)



Get CustomerQuote

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 

try:
    api_response = api_instance.quotes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_id_put**
> CustomerQuote quotes_id_put(body, id)



Update CustomerQuote

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
body = swagger_client.CustomerQuote() # CustomerQuote | 
id = 56 # int | 

try:
    api_response = api_instance.quotes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerQuote**](CustomerQuote.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_idactioncalculate_vat_summary_get**
> list[VatCalculationSummary] quotes_idactioncalculate_vat_summary_get(id)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 

try:
    api_response = api_instance.quotes_idactioncalculate_vat_summary_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactioncalculate_vat_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**list[VatCalculationSummary]**](VatCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_idactioncomplete_post**
> object quotes_idactioncomplete_post(id, id)



complete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactioncomplete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactioncomplete_post: %s\n" % e)
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

# **quotes_idactioncustomer_accept_post**
> object quotes_idactioncustomer_accept_post(id, id)



customerAccept Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactioncustomer_accept_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactioncustomer_accept_post: %s\n" % e)
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

# **quotes_idactionnext_get**
> CustomerQuote quotes_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 

try:
    api_response = api_instance.quotes_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_idactionprevious_get**
> CustomerQuote quotes_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 

try:
    api_response = api_instance.quotes_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotes_idactionregister_post**
> object quotes_idactionregister_post(id, id)



register Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactionregister_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionregister_post: %s\n" % e)
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

# **quotes_idactionset_customer_quote_printstatus_put**
> object quotes_idactionset_customer_quote_printstatus_put(id, id, print_status)



set-customer-quote-printstatus Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
print_status = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactionset_customer_quote_printstatus_put(id, id, print_status)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionset_customer_quote_printstatus_put: %s\n" % e)
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

# **quotes_idactionship_to_customer_post**
> object quotes_idactionship_to_customer_post(id, id)



shipToCustomer Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactionship_to_customer_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionship_to_customer_post: %s\n" % e)
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

# **quotes_idactionto_invoice_post**
> object quotes_idactionto_invoice_post(id, id)



toInvoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactionto_invoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionto_invoice_post: %s\n" % e)
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

# **quotes_idactionto_order_post**
> object quotes_idactionto_order_post(id, id)



toOrder Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotes_idactionto_order_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_idactionto_order_post: %s\n" % e)
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

# **quotes_post**
> CustomerQuote quotes_post(body)



Create CustomerQuote

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
body = swagger_client.CustomerQuote() # CustomerQuote | 

try:
    api_response = api_instance.quotes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerQuote**](CustomerQuote.md)|  | 

### Return type

[**CustomerQuote**](CustomerQuote.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotesactioncalculate_quote_summary_post**
> TradeHeaderCalculationSummary quotesactioncalculate_quote_summary_post(body=body)



calculate-quote-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
body = [swagger_client.CustomerQuoteItem()] # list[CustomerQuoteItem] |  (optional)

try:
    api_response = api_instance.quotesactioncalculate_quote_summary_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotesactioncalculate_quote_summary_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[CustomerQuoteItem]**](CustomerQuoteItem.md)|  | [optional] 

### Return type

[**TradeHeaderCalculationSummary**](TradeHeaderCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quotesactioncalculate_vat_summary_get**
> list[VatCalculationSummary] quotesactioncalculate_vat_summary_get(quote_number)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerQuoteApi()
quote_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.quotesactioncalculate_vat_summary_get(quote_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerQuoteApi->quotesactioncalculate_vat_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **quote_number** | [**Object**](.md)|  | 

### Return type

[**list[VatCalculationSummary]**](VatCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

