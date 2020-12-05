# swagger_client.PensionSchemeSupplierApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**pensionschemesuppliers_get**](PensionSchemeSupplierApi.md#pensionschemesuppliers_get) | **GET** /pensionschemesuppliers | 
[**pensionschemesuppliers_id_delete**](PensionSchemeSupplierApi.md#pensionschemesuppliers_id_delete) | **DELETE** /pensionschemesuppliers/{id} | 
[**pensionschemesuppliers_id_get**](PensionSchemeSupplierApi.md#pensionschemesuppliers_id_get) | **GET** /pensionschemesuppliers/{id} | 
[**pensionschemesuppliers_id_put**](PensionSchemeSupplierApi.md#pensionschemesuppliers_id_put) | **PUT** /pensionschemesuppliers/{id} | 
[**pensionschemesuppliers_post**](PensionSchemeSupplierApi.md#pensionschemesuppliers_post) | **POST** /pensionschemesuppliers | 

# **pensionschemesuppliers_get**
> list[PensionSchemeSupplier] pensionschemesuppliers_get()



Query PensionSchemeSupplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeSupplierApi()

try:
    api_response = api_instance.pensionschemesuppliers_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeSupplierApi->pensionschemesuppliers_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PensionSchemeSupplier]**](PensionSchemeSupplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemesuppliers_id_delete**
> PensionSchemeSupplier pensionschemesuppliers_id_delete(id)



Delete PensionSchemeSupplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeSupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.pensionschemesuppliers_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeSupplierApi->pensionschemesuppliers_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PensionSchemeSupplier**](PensionSchemeSupplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemesuppliers_id_get**
> PensionSchemeSupplier pensionschemesuppliers_id_get(id)



Get PensionSchemeSupplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeSupplierApi()
id = 56 # int | 

try:
    api_response = api_instance.pensionschemesuppliers_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeSupplierApi->pensionschemesuppliers_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PensionSchemeSupplier**](PensionSchemeSupplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemesuppliers_id_put**
> PensionSchemeSupplier pensionschemesuppliers_id_put(body, id)



Update PensionSchemeSupplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeSupplierApi()
body = swagger_client.PensionSchemeSupplier() # PensionSchemeSupplier | 
id = 56 # int | 

try:
    api_response = api_instance.pensionschemesuppliers_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeSupplierApi->pensionschemesuppliers_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PensionSchemeSupplier**](PensionSchemeSupplier.md)|  | 
 **id** | **int**|  | 

### Return type

[**PensionSchemeSupplier**](PensionSchemeSupplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **pensionschemesuppliers_post**
> PensionSchemeSupplier pensionschemesuppliers_post(body)



Create PensionSchemeSupplier

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PensionSchemeSupplierApi()
body = swagger_client.PensionSchemeSupplier() # PensionSchemeSupplier | 

try:
    api_response = api_instance.pensionschemesuppliers_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PensionSchemeSupplierApi->pensionschemesuppliers_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PensionSchemeSupplier**](PensionSchemeSupplier.md)|  | 

### Return type

[**PensionSchemeSupplier**](PensionSchemeSupplier.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

