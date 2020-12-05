# swagger_client.DebtCollectionSettingsApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**debtcollectionsettings_get**](DebtCollectionSettingsApi.md#debtcollectionsettings_get) | **GET** /debtcollectionsettings | 
[**debtcollectionsettings_id_delete**](DebtCollectionSettingsApi.md#debtcollectionsettings_id_delete) | **DELETE** /debtcollectionsettings/{id} | 
[**debtcollectionsettings_id_get**](DebtCollectionSettingsApi.md#debtcollectionsettings_id_get) | **GET** /debtcollectionsettings/{id} | 
[**debtcollectionsettings_id_put**](DebtCollectionSettingsApi.md#debtcollectionsettings_id_put) | **PUT** /debtcollectionsettings/{id} | 
[**debtcollectionsettings_post**](DebtCollectionSettingsApi.md#debtcollectionsettings_post) | **POST** /debtcollectionsettings | 

# **debtcollectionsettings_get**
> list[DebtCollectionSettings] debtcollectionsettings_get()



Query DebtCollectionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionSettingsApi()

try:
    api_response = api_instance.debtcollectionsettings_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionSettingsApi->debtcollectionsettings_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[DebtCollectionSettings]**](DebtCollectionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionsettings_id_delete**
> DebtCollectionSettings debtcollectionsettings_id_delete(id)



Delete DebtCollectionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionsettings_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionSettingsApi->debtcollectionsettings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DebtCollectionSettings**](DebtCollectionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionsettings_id_get**
> DebtCollectionSettings debtcollectionsettings_id_get(id)



Get DebtCollectionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionSettingsApi()
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionsettings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionSettingsApi->debtcollectionsettings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DebtCollectionSettings**](DebtCollectionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionsettings_id_put**
> DebtCollectionSettings debtcollectionsettings_id_put(body, id)



Update DebtCollectionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionSettingsApi()
body = swagger_client.DebtCollectionSettings() # DebtCollectionSettings | 
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionsettings_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionSettingsApi->debtcollectionsettings_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebtCollectionSettings**](DebtCollectionSettings.md)|  | 
 **id** | **int**|  | 

### Return type

[**DebtCollectionSettings**](DebtCollectionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionsettings_post**
> DebtCollectionSettings debtcollectionsettings_post(body)



Create DebtCollectionSettings

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionSettingsApi()
body = swagger_client.DebtCollectionSettings() # DebtCollectionSettings | 

try:
    api_response = api_instance.debtcollectionsettings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionSettingsApi->debtcollectionsettings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebtCollectionSettings**](DebtCollectionSettings.md)|  | 

### Return type

[**DebtCollectionSettings**](DebtCollectionSettings.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

