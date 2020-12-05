# swagger_client.RegulativeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**regulatives_get**](RegulativeApi.md#regulatives_get) | **GET** /regulatives | 
[**regulatives_id_delete**](RegulativeApi.md#regulatives_id_delete) | **DELETE** /regulatives/{id} | 
[**regulatives_id_get**](RegulativeApi.md#regulatives_id_get) | **GET** /regulatives/{id} | 
[**regulatives_id_put**](RegulativeApi.md#regulatives_id_put) | **PUT** /regulatives/{id} | 
[**regulatives_idactionexport_get**](RegulativeApi.md#regulatives_idactionexport_get) | **GET** /regulatives/{id}?action&#x3D;export | 
[**regulatives_idactionimport_post**](RegulativeApi.md#regulatives_idactionimport_post) | **POST** /regulatives/{id}?action&#x3D;import | 
[**regulatives_post**](RegulativeApi.md#regulatives_post) | **POST** /regulatives | 
[**regulativesactiontemplate_get**](RegulativeApi.md#regulativesactiontemplate_get) | **GET** /regulatives?action&#x3D;template | 

# **regulatives_get**
> list[Regulative] regulatives_get()



Query Regulative

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()

try:
    api_response = api_instance.regulatives_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[Regulative]**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_id_delete**
> Regulative regulatives_id_delete(id)



Delete Regulative

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
id = 56 # int | 

try:
    api_response = api_instance.regulatives_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Regulative**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_id_get**
> Regulative regulatives_id_get(id)



Get Regulative

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
id = 56 # int | 

try:
    api_response = api_instance.regulatives_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**Regulative**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_id_put**
> Regulative regulatives_id_put(body, id)



Update Regulative

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
body = swagger_client.Regulative() # Regulative | 
id = 56 # int | 

try:
    api_response = api_instance.regulatives_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Regulative**](Regulative.md)|  | 
 **id** | **int**|  | 

### Return type

[**Regulative**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_idactionexport_get**
> IActionResult regulatives_idactionexport_get(id, id)



export Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.regulatives_idactionexport_get(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_idactionexport_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_idactionimport_post**
> Regulative regulatives_idactionimport_post(id, id, file_id)



import Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 
file_id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.regulatives_idactionimport_post(id, id, file_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_idactionimport_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 
 **id** | [**Object**](.md)|  | 
 **file_id** | [**Object**](.md)|  | 

### Return type

[**Regulative**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulatives_post**
> Regulative regulatives_post(body)



Create Regulative

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()
body = swagger_client.Regulative() # Regulative | 

try:
    api_response = api_instance.regulatives_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulatives_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Regulative**](Regulative.md)|  | 

### Return type

[**Regulative**](Regulative.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **regulativesactiontemplate_get**
> IActionResult regulativesactiontemplate_get()



template Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.RegulativeApi()

try:
    api_response = api_instance.regulativesactiontemplate_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling RegulativeApi->regulativesactiontemplate_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**IActionResult**](IActionResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

