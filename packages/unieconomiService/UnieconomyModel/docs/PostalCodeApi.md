# swagger_client.PostalCodeApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**postalcodes_get**](PostalCodeApi.md#postalcodes_get) | **GET** /postalcodes | 
[**postalcodes_id_delete**](PostalCodeApi.md#postalcodes_id_delete) | **DELETE** /postalcodes/{id} | 
[**postalcodes_id_get**](PostalCodeApi.md#postalcodes_id_get) | **GET** /postalcodes/{id} | 
[**postalcodes_id_put**](PostalCodeApi.md#postalcodes_id_put) | **PUT** /postalcodes/{id} | 
[**postalcodes_post**](PostalCodeApi.md#postalcodes_post) | **POST** /postalcodes | 

# **postalcodes_get**
> list[PostalCode] postalcodes_get()



Query PostalCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostalCodeApi()

try:
    api_response = api_instance.postalcodes_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostalCodeApi->postalcodes_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PostalCode]**](PostalCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postalcodes_id_delete**
> PostalCode postalcodes_id_delete(id)



Delete PostalCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostalCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.postalcodes_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostalCodeApi->postalcodes_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PostalCode**](PostalCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postalcodes_id_get**
> PostalCode postalcodes_id_get(id)



Get PostalCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostalCodeApi()
id = 56 # int | 

try:
    api_response = api_instance.postalcodes_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostalCodeApi->postalcodes_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PostalCode**](PostalCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postalcodes_id_put**
> PostalCode postalcodes_id_put(body, id)



Update PostalCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostalCodeApi()
body = swagger_client.PostalCode() # PostalCode | 
id = 56 # int | 

try:
    api_response = api_instance.postalcodes_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostalCodeApi->postalcodes_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostalCode**](PostalCode.md)|  | 
 **id** | **int**|  | 

### Return type

[**PostalCode**](PostalCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **postalcodes_post**
> PostalCode postalcodes_post(body)



Create PostalCode

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PostalCodeApi()
body = swagger_client.PostalCode() # PostalCode | 

try:
    api_response = api_instance.postalcodes_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PostalCodeApi->postalcodes_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PostalCode**](PostalCode.md)|  | 

### Return type

[**PostalCode**](PostalCode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

