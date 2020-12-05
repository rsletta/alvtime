# swagger_client.CustomerInvoiceReminderSettingsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**invoiceremindersettings_get**](CustomerInvoiceReminderSettingsApi.md#invoiceremindersettings_get) | **GET** /invoiceremindersettings | 
[**invoiceremindersettings_id_delete**](CustomerInvoiceReminderSettingsApi.md#invoiceremindersettings_id_delete) | **DELETE** /invoiceremindersettings/{id} | 
[**invoiceremindersettings_id_get**](CustomerInvoiceReminderSettingsApi.md#invoiceremindersettings_id_get) | **GET** /invoiceremindersettings/{id} | 
[**invoiceremindersettings_id_put**](CustomerInvoiceReminderSettingsApi.md#invoiceremindersettings_id_put) | **PUT** /invoiceremindersettings/{id} | 
[**invoiceremindersettings_post**](CustomerInvoiceReminderSettingsApi.md#invoiceremindersettings_post) | **POST** /invoiceremindersettings | 

# **invoiceremindersettings_get**
> list[CustomerInvoiceReminderSettings] invoiceremindersettings_get()



Query CustomerInvoiceReminderSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderSettingsApi()

try:
    api_response = api_instance.invoiceremindersettings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderSettingsApi->invoiceremindersettings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomerInvoiceReminderSettings]**](CustomerInvoiceReminderSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersettings_id_delete**
> CustomerInvoiceReminderSettings invoiceremindersettings_id_delete(id)



Delete CustomerInvoiceReminderSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceremindersettings_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderSettingsApi->invoiceremindersettings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersettings_id_get**
> CustomerInvoiceReminderSettings invoiceremindersettings_id_get(id)



Get CustomerInvoiceReminderSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.invoiceremindersettings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderSettingsApi->invoiceremindersettings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersettings_id_put**
> CustomerInvoiceReminderSettings invoiceremindersettings_id_put(body, id)



Update CustomerInvoiceReminderSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderSettingsApi()
body = swagger_client.CustomerInvoiceReminderSettings() # CustomerInvoiceReminderSettings | 
id = 56 # int | 

try:
    api_response = api_instance.invoiceremindersettings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderSettingsApi->invoiceremindersettings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **invoiceremindersettings_post**
> CustomerInvoiceReminderSettings invoiceremindersettings_post(body)



Create CustomerInvoiceReminderSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomerInvoiceReminderSettingsApi()
body = swagger_client.CustomerInvoiceReminderSettings() # CustomerInvoiceReminderSettings | 

try:
    api_response = api_instance.invoiceremindersettings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomerInvoiceReminderSettingsApi->invoiceremindersettings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)|  | 

### Return type

[**CustomerInvoiceReminderSettings**](CustomerInvoiceReminderSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

