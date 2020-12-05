# swagger_client.VatTypeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**vattypes_get**](VatTypeApi.md#vattypes_get) | **GET** /vattypes | 
[**vattypes_id_delete**](VatTypeApi.md#vattypes_id_delete) | **DELETE** /vattypes/{id} | 
[**vattypes_id_get**](VatTypeApi.md#vattypes_id_get) | **GET** /vattypes/{id} | 
[**vattypes_id_put**](VatTypeApi.md#vattypes_id_put) | **PUT** /vattypes/{id} | 
[**vattypes_idactionhidden_put**](VatTypeApi.md#vattypes_idactionhidden_put) | **PUT** /vattypes/{id}?action&#x3D;hidden | 
[**vattypes_idactionlock_put**](VatTypeApi.md#vattypes_idactionlock_put) | **PUT** /vattypes/{id}?action&#x3D;lock | 
[**vattypes_idactionunlock_put**](VatTypeApi.md#vattypes_idactionunlock_put) | **PUT** /vattypes/{id}?action&#x3D;unlock | 
[**vattypes_idactionvatcode_get**](VatTypeApi.md#vattypes_idactionvatcode_get) | **GET** /vattypes/{id}?action&#x3D;vatcode | 
[**vattypes_idactionvisible_put**](VatTypeApi.md#vattypes_idactionvisible_put) | **PUT** /vattypes/{id}?action&#x3D;visible | 
[**vattypes_post**](VatTypeApi.md#vattypes_post) | **POST** /vattypes | 
[**vattypesactionsynchronize_put**](VatTypeApi.md#vattypesactionsynchronize_put) | **PUT** /vattypes?action&#x3D;synchronize | 
[**vattypesactionvalid_get**](VatTypeApi.md#vattypesactionvalid_get) | **GET** /vattypes?action&#x3D;valid | 
[**vattypesactionvalid_with_hidden_get**](VatTypeApi.md#vattypesactionvalid_with_hidden_get) | **GET** /vattypes?action&#x3D;valid-with-hidden | 

# **vattypes_get**
> list[VatType] vattypes_get()



Query VatType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()

try:
    api_response = api_instance.vattypes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatType]**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_id_delete**
> VatType vattypes_id_delete(id)



Delete VatType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatType**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_id_get**
> VatType vattypes_id_get(id)



Get VatType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatType**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_id_put**
> VatType vattypes_id_put(body, id)



Update VatType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
body = swagger_client.VatType() # VatType | 
id = 56 # int | 

try:
    api_response = api_instance.vattypes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatType**](VatType.md)|  | 
 **id** | **int**|  | 

### Return type

[**VatType**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_idactionhidden_put**
> object vattypes_idactionhidden_put(id)



hidden Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_idactionhidden_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_idactionhidden_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_idactionlock_put**
> object vattypes_idactionlock_put(id)



lock Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_idactionlock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_idactionlock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_idactionunlock_put**
> object vattypes_idactionunlock_put(id)



unlock Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_idactionunlock_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_idactionunlock_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_idactionvatcode_get**
> VatType vattypes_idactionvatcode_get(id)



vatcode Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_idactionvatcode_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_idactionvatcode_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**VatType**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_idactionvisible_put**
> object vattypes_idactionvisible_put(id)



visible Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
id = 56 # int | 

try:
    api_response = api_instance.vattypes_idactionvisible_put(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_idactionvisible_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypes_post**
> VatType vattypes_post(body)



Create VatType

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()
body = swagger_client.VatType() # VatType | 

try:
    api_response = api_instance.vattypes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VatType**](VatType.md)|  | 

### Return type

[**VatType**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypesactionsynchronize_put**
> object vattypesactionsynchronize_put()



synchronize Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()

try:
    api_response = api_instance.vattypesactionsynchronize_put()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypesactionsynchronize_put: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypesactionvalid_get**
> list[VatType] vattypesactionvalid_get()



valid Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()

try:
    api_response = api_instance.vattypesactionvalid_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypesactionvalid_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatType]**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **vattypesactionvalid_with_hidden_get**
> list[VatType] vattypesactionvalid_with_hidden_get()



valid-with-hidden Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.VatTypeApi()

try:
    api_response = api_instance.vattypesactionvalid_with_hidden_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling VatTypeApi->vattypesactionvalid_with_hidden_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[VatType]**](VatType.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

