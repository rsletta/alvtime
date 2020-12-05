# swagger_client.AltinnSigningApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**altinnsigning_get**](AltinnSigningApi.md#altinnsigning_get) | **GET** /altinnsigning | 
[**altinnsigning_id_delete**](AltinnSigningApi.md#altinnsigning_id_delete) | **DELETE** /altinnsigning/{id} | 
[**altinnsigning_id_get**](AltinnSigningApi.md#altinnsigning_id_get) | **GET** /altinnsigning/{id} | 
[**altinnsigning_id_put**](AltinnSigningApi.md#altinnsigning_id_put) | **PUT** /altinnsigning/{id} | 
[**altinnsigning_idactionsign_post**](AltinnSigningApi.md#altinnsigning_idactionsign_post) | **POST** /altinnsigning/{id}?action&#x3D;sign | 
[**altinnsigning_post**](AltinnSigningApi.md#altinnsigning_post) | **POST** /altinnsigning | 

# **altinnsigning_get**
> list[AltinnSigning] altinnsigning_get()



Query AltinnSigning

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()

try:
    api_response = api_instance.altinnsigning_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[AltinnSigning]**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnsigning_id_delete**
> AltinnSigning altinnsigning_id_delete(id)



Delete AltinnSigning

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()
id = 56 # int | 

try:
    api_response = api_instance.altinnsigning_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AltinnSigning**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnsigning_id_get**
> AltinnSigning altinnsigning_id_get(id)



Get AltinnSigning

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()
id = 56 # int | 

try:
    api_response = api_instance.altinnsigning_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**AltinnSigning**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnsigning_id_put**
> AltinnSigning altinnsigning_id_put(body, id)



Update AltinnSigning

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()
body = swagger_client.AltinnSigning() # AltinnSigning | 
id = 56 # int | 

try:
    api_response = api_instance.altinnsigning_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AltinnSigning**](AltinnSigning.md)|  | 
 **id** | **int**|  | 

### Return type

[**AltinnSigning**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **altinnsigning_idactionsign_post**
> object altinnsigning_idactionsign_post(id, id)



sign Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.altinnsigning_idactionsign_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_idactionsign_post: %s\n" % e)
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

# **altinnsigning_post**
> AltinnSigning altinnsigning_post(body)



Create AltinnSigning

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AltinnSigningApi()
body = swagger_client.AltinnSigning() # AltinnSigning | 

try:
    api_response = api_instance.altinnsigning_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AltinnSigningApi->altinnsigning_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AltinnSigning**](AltinnSigning.md)|  | 

### Return type

[**AltinnSigning**](AltinnSigning.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

