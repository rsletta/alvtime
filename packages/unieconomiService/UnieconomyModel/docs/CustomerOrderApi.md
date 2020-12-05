# swagger_client.CustomerOrderApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**orders_get**](CustomerOrderApi.md#orders_get) | **GET** /orders | 
[**orders_id_delete**](CustomerOrderApi.md#orders_id_delete) | **DELETE** /orders/{id} | 
[**orders_id_get**](CustomerOrderApi.md#orders_id_get) | **GET** /orders/{id} | 
[**orders_id_put**](CustomerOrderApi.md#orders_id_put) | **PUT** /orders/{id} | 
[**orders_idactioncalculate_vat_summary_get**](CustomerOrderApi.md#orders_idactioncalculate_vat_summary_get) | **GET** /orders/{id}?action&#x3D;calculate-vat-summary | 
[**orders_idactioncomplete_post**](CustomerOrderApi.md#orders_idactioncomplete_post) | **POST** /orders/{id}?action&#x3D;complete | 
[**orders_idactionnext_get**](CustomerOrderApi.md#orders_idactionnext_get) | **GET** /orders/{id}?action&#x3D;next | 
[**orders_idactionpartly_transfer_to_invoice_post**](CustomerOrderApi.md#orders_idactionpartly_transfer_to_invoice_post) | **POST** /orders/{id}?action&#x3D;partlyTransferToInvoice | 
[**orders_idactionprevious_get**](CustomerOrderApi.md#orders_idactionprevious_get) | **GET** /orders/{id}?action&#x3D;previous | 
[**orders_idactionregister_post**](CustomerOrderApi.md#orders_idactionregister_post) | **POST** /orders/{id}?action&#x3D;register | 
[**orders_idactionset_customer_order_printstatus_put**](CustomerOrderApi.md#orders_idactionset_customer_order_printstatus_put) | **PUT** /orders/{id}?action&#x3D;set-customer-order-printstatus | 
[**orders_idactiontransfer_to_invoice_post**](CustomerOrderApi.md#orders_idactiontransfer_to_invoice_post) | **POST** /orders/{id}?action&#x3D;transferToInvoice | 
[**orders_idactiontransfer_to_invoice_put**](CustomerOrderApi.md#orders_idactiontransfer_to_invoice_put) | **PUT** /orders/{id}?action&#x3D;transfer-to-invoice | 
[**orders_post**](CustomerOrderApi.md#orders_post) | **POST** /orders | 
[**ordersactioncalculate_order_summary_post**](CustomerOrderApi.md#ordersactioncalculate_order_summary_post) | **POST** /orders?action&#x3D;calculate-order-summary | 
[**ordersactioncalculate_vat_summary_get**](CustomerOrderApi.md#ordersactioncalculate_vat_summary_get) | **GET** /orders?action&#x3D;calculate-vat-summary | 

# **orders_get**
> list[CustomerOrder] orders_get()



Query CustomerOrder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()

try:
    api_response = api_instance.orders_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerOrder]**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_id_delete**
> CustomerOrder orders_id_delete(id)



Delete CustomerOrder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 

try:
    api_response = api_instance.orders_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_id_get**
> CustomerOrder orders_id_get(id)



Get CustomerOrder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 

try:
    api_response = api_instance.orders_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_id_put**
> CustomerOrder orders_id_put(body, id)



Update CustomerOrder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
body = swagger_client.CustomerOrder() # CustomerOrder | 
id = 56 # int | 

try:
    api_response = api_instance.orders_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerOrder**](CustomerOrder.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_idactioncalculate_vat_summary_get**
> list[VatCalculationSummary] orders_idactioncalculate_vat_summary_get(id)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 

try:
    api_response = api_instance.orders_idactioncalculate_vat_summary_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactioncalculate_vat_summary_get: %s\n" % e)
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

# **orders_idactioncomplete_post**
> object orders_idactioncomplete_post(id, id)



complete Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orders_idactioncomplete_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactioncomplete_post: %s\n" % e)
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

# **orders_idactionnext_get**
> CustomerOrder orders_idactionnext_get(id)



next Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 

try:
    api_response = api_instance.orders_idactionnext_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactionnext_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_idactionpartly_transfer_to_invoice_post**
> object orders_idactionpartly_transfer_to_invoice_post(id, id)



partlyTransferToInvoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orders_idactionpartly_transfer_to_invoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactionpartly_transfer_to_invoice_post: %s\n" % e)
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

# **orders_idactionprevious_get**
> CustomerOrder orders_idactionprevious_get(id)



previous Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 

try:
    api_response = api_instance.orders_idactionprevious_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactionprevious_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_idactionregister_post**
> object orders_idactionregister_post(id, id)



register Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orders_idactionregister_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactionregister_post: %s\n" % e)
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

# **orders_idactionset_customer_order_printstatus_put**
> object orders_idactionset_customer_order_printstatus_put(id, print_status)



set-customer-order-printstatus Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
print_status = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orders_idactionset_customer_order_printstatus_put(id, print_status)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactionset_customer_order_printstatus_put: %s\n" % e)
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

# **orders_idactiontransfer_to_invoice_post**
> object orders_idactiontransfer_to_invoice_post(id, id)



transferToInvoice Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.orders_idactiontransfer_to_invoice_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactiontransfer_to_invoice_post: %s\n" % e)
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

# **orders_idactiontransfer_to_invoice_put**
> CustomerInvoice orders_idactiontransfer_to_invoice_put(id, copy_files, body=body)



transfer-to-invoice Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
id = 56 # int | 
copy_files = swagger_client.Object() # Object | 
body = swagger_client.CustomerOrder() # CustomerOrder |  (optional)

try:
    api_response = api_instance.orders_idactiontransfer_to_invoice_put(id, copy_files, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_idactiontransfer_to_invoice_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **copy_files** | [**Object**](.md)|  | 
 **body** | [**CustomerOrder**](CustomerOrder.md)|  | [optional] 

### Return type

[**CustomerInvoice**](CustomerInvoice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **orders_post**
> CustomerOrder orders_post(body)



Create CustomerOrder

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
body = swagger_client.CustomerOrder() # CustomerOrder | 

try:
    api_response = api_instance.orders_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->orders_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerOrder**](CustomerOrder.md)|  | 

### Return type

[**CustomerOrder**](CustomerOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ordersactioncalculate_order_summary_post**
> TradeHeaderCalculationSummary ordersactioncalculate_order_summary_post(body=body)



calculate-order-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
body = [swagger_client.CustomerOrderItem()] # list[CustomerOrderItem] |  (optional)

try:
    api_response = api_instance.ordersactioncalculate_order_summary_post(body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->ordersactioncalculate_order_summary_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**list[CustomerOrderItem]**](CustomerOrderItem.md)|  | [optional] 

### Return type

[**TradeHeaderCalculationSummary**](TradeHeaderCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ordersactioncalculate_vat_summary_get**
> list[VatCalculationSummary] ordersactioncalculate_vat_summary_get(order_number)



calculate-vat-summary Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerOrderApi()
order_number = swagger_client.Object() # Object | 

try:
    api_response = api_instance.ordersactioncalculate_vat_summary_get(order_number)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerOrderApi->ordersactioncalculate_vat_summary_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **order_number** | [**Object**](.md)|  | 

### Return type

[**list[VatCalculationSummary]**](VatCalculationSummary.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

