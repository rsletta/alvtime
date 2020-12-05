# swagger_client.CompanyAccountingSettingsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companyaccountingsettings_get**](CompanyAccountingSettingsApi.md#companyaccountingsettings_get) | **GET** /companyaccountingsettings | 
[**companyaccountingsettings_id_delete**](CompanyAccountingSettingsApi.md#companyaccountingsettings_id_delete) | **DELETE** /companyaccountingsettings/{id} | 
[**companyaccountingsettings_id_get**](CompanyAccountingSettingsApi.md#companyaccountingsettings_id_get) | **GET** /companyaccountingsettings/{id} | 
[**companyaccountingsettings_id_put**](CompanyAccountingSettingsApi.md#companyaccountingsettings_id_put) | **PUT** /companyaccountingsettings/{id} | 
[**companyaccountingsettings_post**](CompanyAccountingSettingsApi.md#companyaccountingsettings_post) | **POST** /companyaccountingsettings | 
[**companyaccountingsettingsactionget_or_create_get**](CompanyAccountingSettingsApi.md#companyaccountingsettingsactionget_or_create_get) | **GET** /companyaccountingsettings?action&#x3D;get-or-create | 

# **companyaccountingsettings_get**
> list[CompanyAccountingSettings] companyaccountingsettings_get()



Query CompanyAccountingSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()

try:
    api_response = api_instance.companyaccountingsettings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CompanyAccountingSettings]**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyaccountingsettings_id_delete**
> CompanyAccountingSettings companyaccountingsettings_id_delete(id)



Delete CompanyAccountingSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companyaccountingsettings_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyAccountingSettings**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyaccountingsettings_id_get**
> CompanyAccountingSettings companyaccountingsettings_id_get(id)



Get CompanyAccountingSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.companyaccountingsettings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CompanyAccountingSettings**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyaccountingsettings_id_put**
> CompanyAccountingSettings companyaccountingsettings_id_put(body, id)



Update CompanyAccountingSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()
body = swagger_client.CompanyAccountingSettings() # CompanyAccountingSettings | 
id = 56 # int | 

try:
    api_response = api_instance.companyaccountingsettings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyAccountingSettings**](CompanyAccountingSettings.md)|  | 
 **id** | **int**|  | 

### Return type

[**CompanyAccountingSettings**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyaccountingsettings_post**
> CompanyAccountingSettings companyaccountingsettings_post(body)



Create CompanyAccountingSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()
body = swagger_client.CompanyAccountingSettings() # CompanyAccountingSettings | 

try:
    api_response = api_instance.companyaccountingsettings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompanyAccountingSettings**](CompanyAccountingSettings.md)|  | 

### Return type

[**CompanyAccountingSettings**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companyaccountingsettingsactionget_or_create_get**
> CompanyAccountingSettings companyaccountingsettingsactionget_or_create_get()



get-or-create Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CompanyAccountingSettingsApi()

try:
    api_response = api_instance.companyaccountingsettingsactionget_or_create_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompanyAccountingSettingsApi->companyaccountingsettingsactionget_or_create_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CompanyAccountingSettings**](CompanyAccountingSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

