# swagger_client.PredefinedDescriptionApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**predefineddescriptions_get**](PredefinedDescriptionApi.md#predefineddescriptions_get) | **GET** /predefineddescriptions | 
[**predefineddescriptions_id_delete**](PredefinedDescriptionApi.md#predefineddescriptions_id_delete) | **DELETE** /predefineddescriptions/{id} | 
[**predefineddescriptions_id_get**](PredefinedDescriptionApi.md#predefineddescriptions_id_get) | **GET** /predefineddescriptions/{id} | 
[**predefineddescriptions_id_put**](PredefinedDescriptionApi.md#predefineddescriptions_id_put) | **PUT** /predefineddescriptions/{id} | 
[**predefineddescriptions_post**](PredefinedDescriptionApi.md#predefineddescriptions_post) | **POST** /predefineddescriptions | 
[**predefineddescriptionsactionget_predefined_description_get**](PredefinedDescriptionApi.md#predefineddescriptionsactionget_predefined_description_get) | **GET** /predefineddescriptions?action&#x3D;get-predefined-description | 
[**predefineddescriptionsactionget_predefined_descriptions_get**](PredefinedDescriptionApi.md#predefineddescriptionsactionget_predefined_descriptions_get) | **GET** /predefineddescriptions?action&#x3D;get-predefined-descriptions | 

# **predefineddescriptions_get**
> list[PredefinedDescription] predefineddescriptions_get()



Query PredefinedDescription

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()

try:
    api_response = api_instance.predefineddescriptions_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptions_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[PredefinedDescription]**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptions_id_delete**
> PredefinedDescription predefineddescriptions_id_delete(id)



Delete PredefinedDescription

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
id = 56 # int | 

try:
    api_response = api_instance.predefineddescriptions_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptions_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PredefinedDescription**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptions_id_get**
> PredefinedDescription predefineddescriptions_id_get(id)



Get PredefinedDescription

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
id = 56 # int | 

try:
    api_response = api_instance.predefineddescriptions_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptions_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**PredefinedDescription**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptions_id_put**
> PredefinedDescription predefineddescriptions_id_put(body, id)



Update PredefinedDescription

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
body = swagger_client.PredefinedDescription() # PredefinedDescription | 
id = 56 # int | 

try:
    api_response = api_instance.predefineddescriptions_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptions_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PredefinedDescription**](PredefinedDescription.md)|  | 
 **id** | **int**|  | 

### Return type

[**PredefinedDescription**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptions_post**
> PredefinedDescription predefineddescriptions_post(body)



Create PredefinedDescription

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
body = swagger_client.PredefinedDescription() # PredefinedDescription | 

try:
    api_response = api_instance.predefineddescriptions_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptions_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PredefinedDescription**](PredefinedDescription.md)|  | 

### Return type

[**PredefinedDescription**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptionsactionget_predefined_description_get**
> PredefinedDescription predefineddescriptionsactionget_predefined_description_get(code, type)



get-predefined-description Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
code = swagger_client.Object() # Object | 
type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.predefineddescriptionsactionget_predefined_description_get(code, type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptionsactionget_predefined_description_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | [**Object**](.md)|  | 
 **type** | [**Object**](.md)|  | 

### Return type

[**PredefinedDescription**](PredefinedDescription.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **predefineddescriptionsactionget_predefined_descriptions_get**
> object predefineddescriptionsactionget_predefined_descriptions_get(type)



get-predefined-descriptions Action

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.PredefinedDescriptionApi()
type = swagger_client.Object() # Object | 

try:
    api_response = api_instance.predefineddescriptionsactionget_predefined_descriptions_get(type)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling PredefinedDescriptionApi->predefineddescriptionsactionget_predefined_descriptions_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**Object**](.md)|  | 

### Return type

**object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

