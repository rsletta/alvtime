# swagger_client.PensionSchemeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pensionschemes_get**](PensionSchemeApi.md#pensionschemes_get) | **GET** /pensionschemes | 
[**pensionschemes_id_delete**](PensionSchemeApi.md#pensionschemes_id_delete) | **DELETE** /pensionschemes/{id} | 
[**pensionschemes_id_get**](PensionSchemeApi.md#pensionschemes_id_get) | **GET** /pensionschemes/{id} | 
[**pensionschemes_id_put**](PensionSchemeApi.md#pensionschemes_id_put) | **PUT** /pensionschemes/{id} | 
[**pensionschemes_post**](PensionSchemeApi.md#pensionschemes_post) | **POST** /pensionschemes | 

# **pensionschemes_get**
> list[PensionScheme] pensionschemes_get()



Query PensionScheme

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeApi()

try:
    api_response = api_instance.pensionschemes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeApi->pensionschemes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PensionScheme]**](PensionScheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemes_id_delete**
> PensionScheme pensionschemes_id_delete(id)



Delete PensionScheme

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeApi()
id = 56 # int | 

try:
    api_response = api_instance.pensionschemes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeApi->pensionschemes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PensionScheme**](PensionScheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemes_id_get**
> PensionScheme pensionschemes_id_get(id)



Get PensionScheme

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeApi()
id = 56 # int | 

try:
    api_response = api_instance.pensionschemes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeApi->pensionschemes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PensionScheme**](PensionScheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemes_id_put**
> PensionScheme pensionschemes_id_put(body, id)



Update PensionScheme

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeApi()
body = swagger_client.PensionScheme() # PensionScheme | 
id = 56 # int | 

try:
    api_response = api_instance.pensionschemes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeApi->pensionschemes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PensionScheme**](PensionScheme.md)|  | 
 **id** | **int**|  | 

### Return type

[**PensionScheme**](PensionScheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemes_post**
> PensionScheme pensionschemes_post(body)



Create PensionScheme

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeApi()
body = swagger_client.PensionScheme() # PensionScheme | 

try:
    api_response = api_instance.pensionschemes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeApi->pensionschemes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PensionScheme**](PensionScheme.md)|  | 

### Return type

[**PensionScheme**](PensionScheme.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

