# swagger_client.CustomerInvoiceReminderRuleApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoicereminderrules_get**](CustomerInvoiceReminderRuleApi.md#invoicereminderrules_get) | **GET** /invoicereminderrules | 
[**invoicereminderrules_id_delete**](CustomerInvoiceReminderRuleApi.md#invoicereminderrules_id_delete) | **DELETE** /invoicereminderrules/{id} | 
[**invoicereminderrules_id_get**](CustomerInvoiceReminderRuleApi.md#invoicereminderrules_id_get) | **GET** /invoicereminderrules/{id} | 
[**invoicereminderrules_id_put**](CustomerInvoiceReminderRuleApi.md#invoicereminderrules_id_put) | **PUT** /invoicereminderrules/{id} | 
[**invoicereminderrules_post**](CustomerInvoiceReminderRuleApi.md#invoicereminderrules_post) | **POST** /invoicereminderrules | 

# **invoicereminderrules_get**
> list[CustomerInvoiceReminderRule] invoicereminderrules_get()



Query CustomerInvoiceReminderRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderRuleApi()

try:
    api_response = api_instance.invoicereminderrules_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderRuleApi->invoicereminderrules_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceReminderRule]**](CustomerInvoiceReminderRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminderrules_id_delete**
> CustomerInvoiceReminderRule invoicereminderrules_id_delete(id)



Delete CustomerInvoiceReminderRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.invoicereminderrules_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderRuleApi->invoicereminderrules_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminderrules_id_get**
> CustomerInvoiceReminderRule invoicereminderrules_id_get(id)



Get CustomerInvoiceReminderRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderRuleApi()
id = 56 # int | 

try:
    api_response = api_instance.invoicereminderrules_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderRuleApi->invoicereminderrules_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminderrules_id_put**
> CustomerInvoiceReminderRule invoicereminderrules_id_put(body, id)



Update CustomerInvoiceReminderRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderRuleApi()
body = swagger_client.CustomerInvoiceReminderRule() # CustomerInvoiceReminderRule | 
id = 56 # int | 

try:
    api_response = api_instance.invoicereminderrules_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderRuleApi->invoicereminderrules_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoicereminderrules_post**
> CustomerInvoiceReminderRule invoicereminderrules_post(body)



Create CustomerInvoiceReminderRule

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderRuleApi()
body = swagger_client.CustomerInvoiceReminderRule() # CustomerInvoiceReminderRule | 

try:
    api_response = api_instance.invoicereminderrules_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderRuleApi->invoicereminderrules_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)|  | 

### Return type

[**CustomerInvoiceReminderRule**](CustomerInvoiceReminderRule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

