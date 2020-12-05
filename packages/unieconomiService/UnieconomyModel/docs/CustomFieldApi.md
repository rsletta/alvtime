# swagger_client.CustomFieldApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**custom_fields_get**](CustomFieldApi.md#custom_fields_get) | **GET** /custom-fields | 
[**custom_fields_id_delete**](CustomFieldApi.md#custom_fields_id_delete) | **DELETE** /custom-fields/{id} | 
[**custom_fields_id_get**](CustomFieldApi.md#custom_fields_id_get) | **GET** /custom-fields/{id} | 
[**custom_fields_id_put**](CustomFieldApi.md#custom_fields_id_put) | **PUT** /custom-fields/{id} | 
[**custom_fields_idactionactivate_post**](CustomFieldApi.md#custom_fields_idactionactivate_post) | **POST** /custom-fields/{id}?action&#x3D;activate | 
[**custom_fields_post**](CustomFieldApi.md#custom_fields_post) | **POST** /custom-fields | 

# **custom_fields_get**
> list[CustomField] custom_fields_get()



Query CustomField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()

try:
    api_response = api_instance.custom_fields_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[CustomField]**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **custom_fields_id_delete**
> CustomField custom_fields_id_delete(id)



Delete CustomField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()
id = 56 # int | 

try:
    api_response = api_instance.custom_fields_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **custom_fields_id_get**
> CustomField custom_fields_id_get(id)



Get CustomField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()
id = 56 # int | 

try:
    api_response = api_instance.custom_fields_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **custom_fields_id_put**
> CustomField custom_fields_id_put(body, id)



Update CustomField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()
body = swagger_client.CustomField() # CustomField | 
id = 56 # int | 

try:
    api_response = api_instance.custom_fields_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField**](CustomField.md)|  | 
 **id** | **int**|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **custom_fields_idactionactivate_post**
> object custom_fields_idactionactivate_post(id, id)



activate Transition

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()
id = 56 # int | 
id = swagger_client.Object() # Object | 

try:
    api_response = api_instance.custom_fields_idactionactivate_post(id, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_idactionactivate_post: %s\n" % e)
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

# **custom_fields_post**
> CustomField custom_fields_post(body)



Create CustomField

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.CustomFieldApi()
body = swagger_client.CustomField() # CustomField | 

try:
    api_response = api_instance.custom_fields_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CustomFieldApi->custom_fields_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField**](CustomField.md)|  | 

### Return type

[**CustomField**](CustomField.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

