# swagger_client.ApiKeyApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apikeys_get**](ApiKeyApi.md#apikeys_get) | **GET** /apikeys | 
[**apikeys_id_delete**](ApiKeyApi.md#apikeys_id_delete) | **DELETE** /apikeys/{id} | 
[**apikeys_id_get**](ApiKeyApi.md#apikeys_id_get) | **GET** /apikeys/{id} | 
[**apikeys_id_put**](ApiKeyApi.md#apikeys_id_put) | **PUT** /apikeys/{id} | 
[**apikeys_post**](ApiKeyApi.md#apikeys_post) | **POST** /apikeys | 
[**apikeysactionget_integration_key_get**](ApiKeyApi.md#apikeysactionget_integration_key_get) | **GET** /apikeys?action&#x3D;get-integration-key | 
[**apikeysactionset_integration_data_put**](ApiKeyApi.md#apikeysactionset_integration_data_put) | **PUT** /apikeys?action&#x3D;set-integration-data | 
[**apikeysactionset_integration_status_put**](ApiKeyApi.md#apikeysactionset_integration_status_put) | **PUT** /apikeys?action&#x3D;set-integration-status | 
[**apikeysactionsetintegrationkey_put**](ApiKeyApi.md#apikeysactionsetintegrationkey_put) | **PUT** /apikeys?action&#x3D;setintegrationkey | 

# **apikeys_get**
> list[ApiKey] apikeys_get()



Query ApiKey

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()

try:
    api_response = api_instance.apikeys_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeys_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[ApiKey]**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_delete**
> ApiKey apikeys_id_delete(id)



Delete ApiKey

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
id = 56 # int | 

try:
    api_response = api_instance.apikeys_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeys_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_get**
> ApiKey apikeys_id_get(id)



Get ApiKey

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
id = 56 # int | 

try:
    api_response = api_instance.apikeys_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeys_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_put**
> ApiKey apikeys_id_put(body, id)



Update ApiKey

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
body = swagger_client.ApiKey() # ApiKey | 
id = 56 # int | 

try:
    api_response = api_instance.apikeys_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeys_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiKey**](ApiKey.md)|  | 
 **id** | **int**|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_post**
> ApiKey apikeys_post(body)



Create ApiKey

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
body = swagger_client.ApiKey() # ApiKey | 

try:
    api_response = api_instance.apikeys_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeys_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApiKey**](ApiKey.md)|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeysactionget_integration_key_get**
> str apikeysactionget_integration_key_get(integration_id)



get-integration-key Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
integration_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.apikeysactionget_integration_key_get(integration_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeysactionget_integration_key_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integration_id** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeysactionset_integration_data_put**
> str apikeysactionset_integration_data_put(integration_id, body=body)



set-integration-data Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
integration_id = swagger_client.Object() # Object | 
body = swagger_client.SetIntegrationDataDto() # SetIntegrationDataDto |  (optional)

try:
    api_response = api_instance.apikeysactionset_integration_data_put(integration_id, body=body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeysactionset_integration_data_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integration_id** | [**Object**](.md)|  | 
 **body** | [**SetIntegrationDataDto**](SetIntegrationDataDto.md)|  | [optional] 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeysactionset_integration_status_put**
> str apikeysactionset_integration_status_put(integration_id, status_code)



set-integration-status Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
integration_id = swagger_client.Object() # Object | 
status_code = swagger_client.Object() # Object | 

try:
    api_response = api_instance.apikeysactionset_integration_status_put(integration_id, status_code)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeysactionset_integration_status_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integration_id** | [**Object**](.md)|  | 
 **status_code** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeysactionsetintegrationkey_put**
> str apikeysactionsetintegrationkey_put(integration_id, integrationkey)



setintegrationkey Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ApiKeyApi()
integration_id = swagger_client.Object() # Object | 
integrationkey = swagger_client.Object() # Object | 

try:
    api_response = api_instance.apikeysactionsetintegrationkey_put(integration_id, integrationkey)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeyApi->apikeysactionsetintegrationkey_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **integration_id** | [**Object**](.md)|  | 
 **integrationkey** | [**Object**](.md)|  | 

### Return type

**str**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

