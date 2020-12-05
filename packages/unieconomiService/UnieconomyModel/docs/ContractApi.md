# swagger_client.ContractApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**contracts_get**](ContractApi.md#contracts_get) | **GET** /contracts | 
[**contracts_id_delete**](ContractApi.md#contracts_id_delete) | **DELETE** /contracts/{id} | 
[**contracts_id_get**](ContractApi.md#contracts_id_get) | **GET** /contracts/{id} | 
[**contracts_id_put**](ContractApi.md#contracts_id_put) | **PUT** /contracts/{id} | 
[**contracts_idactioncompile_put**](ContractApi.md#contracts_idactioncompile_put) | **PUT** /contracts/{id}?action&#x3D;compile | 
[**contracts_idactioncopy_based_on_put**](ContractApi.md#contracts_idactioncopy_based_on_put) | **PUT** /contracts/{id}?action&#x3D;copy-based-on | 
[**contracts_idactiondeploy_post**](ContractApi.md#contracts_idactiondeploy_post) | **POST** /contracts/{id}?action&#x3D;deploy | 
[**contracts_idactionkill_post**](ContractApi.md#contracts_idactionkill_post) | **POST** /contracts/{id}?action&#x3D;kill | 
[**contracts_idactionreset_post**](ContractApi.md#contracts_idactionreset_post) | **POST** /contracts/{id}?action&#x3D;reset | 
[**contracts_post**](ContractApi.md#contracts_post) | **POST** /contracts | 

# **contracts_get**
> list[Contract] contracts_get()



Query Contract

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()

try:
    api_response = api_instance.contracts_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Contract]**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracts_id_delete**
> Contract contracts_id_delete(id)



Delete Contract

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 

try:
    api_response = api_instance.contracts_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracts_id_get**
> Contract contracts_id_get(id)



Get Contract

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 

try:
    api_response = api_instance.contracts_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracts_id_put**
> Contract contracts_id_put(body, id)



Update Contract

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
body = swagger_client.Contract() # Contract | 
id = 56 # int | 

try:
    api_response = api_instance.contracts_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contract**](Contract.md)|  | 
 **id** | **int**|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracts_idactioncompile_put**
> object contracts_idactioncompile_put(id, id)



compile Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.contracts_idactioncompile_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_idactioncompile_put: %s\n" % e)
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

# **contracts_idactioncopy_based_on_put**
> Contract contracts_idactioncopy_based_on_put(id, id)



copy-based-on Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.contracts_idactioncopy_based_on_put(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_idactioncopy_based_on_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **contracts_idactiondeploy_post**
> object contracts_idactiondeploy_post(id, id)



deploy Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.contracts_idactiondeploy_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_idactiondeploy_post: %s\n" % e)
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

# **contracts_idactionkill_post**
> object contracts_idactionkill_post(id, id)



kill Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.contracts_idactionkill_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_idactionkill_post: %s\n" % e)
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

# **contracts_idactionreset_post**
> object contracts_idactionreset_post(id, id)



reset Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.contracts_idactionreset_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_idactionreset_post: %s\n" % e)
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

# **contracts_post**
> Contract contracts_post(body)



Create Contract

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.ContractApi()
body = swagger_client.Contract() # Contract | 

try:
    api_response = api_instance.contracts_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ContractApi->contracts_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Contract**](Contract.md)|  | 

### Return type

[**Contract**](Contract.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

