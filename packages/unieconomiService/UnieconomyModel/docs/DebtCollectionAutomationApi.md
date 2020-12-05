# swagger_client.DebtCollectionAutomationApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**debtcollectionautomation_get**](DebtCollectionAutomationApi.md#debtcollectionautomation_get) | **GET** /debtcollectionautomation | 
[**debtcollectionautomation_id_delete**](DebtCollectionAutomationApi.md#debtcollectionautomation_id_delete) | **DELETE** /debtcollectionautomation/{id} | 
[**debtcollectionautomation_id_get**](DebtCollectionAutomationApi.md#debtcollectionautomation_id_get) | **GET** /debtcollectionautomation/{id} | 
[**debtcollectionautomation_id_put**](DebtCollectionAutomationApi.md#debtcollectionautomation_id_put) | **PUT** /debtcollectionautomation/{id} | 
[**debtcollectionautomation_post**](DebtCollectionAutomationApi.md#debtcollectionautomation_post) | **POST** /debtcollectionautomation | 

# **debtcollectionautomation_get**
> list[DebtCollectionAutomation] debtcollectionautomation_get()



Query DebtCollectionAutomation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionAutomationApi()

try:
    api_response = api_instance.debtcollectionautomation_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionAutomationApi->debtcollectionautomation_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[DebtCollectionAutomation]**](DebtCollectionAutomation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionautomation_id_delete**
> DebtCollectionAutomation debtcollectionautomation_id_delete(id)



Delete DebtCollectionAutomation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionAutomationApi()
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionautomation_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionAutomationApi->debtcollectionautomation_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DebtCollectionAutomation**](DebtCollectionAutomation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionautomation_id_get**
> DebtCollectionAutomation debtcollectionautomation_id_get(id)



Get DebtCollectionAutomation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionAutomationApi()
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionautomation_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionAutomationApi->debtcollectionautomation_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**DebtCollectionAutomation**](DebtCollectionAutomation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionautomation_id_put**
> DebtCollectionAutomation debtcollectionautomation_id_put(body, id)



Update DebtCollectionAutomation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionAutomationApi()
body = swagger_client.DebtCollectionAutomation() # DebtCollectionAutomation | 
id = 56 # int | 

try:
    api_response = api_instance.debtcollectionautomation_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionAutomationApi->debtcollectionautomation_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebtCollectionAutomation**](DebtCollectionAutomation.md)|  | 
 **id** | **int**|  | 

### Return type

[**DebtCollectionAutomation**](DebtCollectionAutomation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **debtcollectionautomation_post**
> DebtCollectionAutomation debtcollectionautomation_post(body)



Create DebtCollectionAutomation

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.DebtCollectionAutomationApi()
body = swagger_client.DebtCollectionAutomation() # DebtCollectionAutomation | 

try:
    api_response = api_instance.debtcollectionautomation_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DebtCollectionAutomationApi->debtcollectionautomation_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DebtCollectionAutomation**](DebtCollectionAutomation.md)|  | 

### Return type

[**DebtCollectionAutomation**](DebtCollectionAutomation.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

