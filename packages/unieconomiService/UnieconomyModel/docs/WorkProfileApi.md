# swagger_client.WorkProfileApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**workprofiles_get**](WorkProfileApi.md#workprofiles_get) | **GET** /workprofiles | 
[**workprofiles_id_delete**](WorkProfileApi.md#workprofiles_id_delete) | **DELETE** /workprofiles/{id} | 
[**workprofiles_id_get**](WorkProfileApi.md#workprofiles_id_get) | **GET** /workprofiles/{id} | 
[**workprofiles_id_put**](WorkProfileApi.md#workprofiles_id_put) | **PUT** /workprofiles/{id} | 
[**workprofiles_post**](WorkProfileApi.md#workprofiles_post) | **POST** /workprofiles | 

# **workprofiles_get**
> list[WorkProfile] workprofiles_get()



Query WorkProfile

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkProfileApi()

try:
    api_response = api_instance.workprofiles_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkProfileApi->workprofiles_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[WorkProfile]**](WorkProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workprofiles_id_delete**
> WorkProfile workprofiles_id_delete(id)



Delete WorkProfile

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkProfileApi()
id = 56 # int | 

try:
    api_response = api_instance.workprofiles_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkProfileApi->workprofiles_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkProfile**](WorkProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workprofiles_id_get**
> WorkProfile workprofiles_id_get(id)



Get WorkProfile

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkProfileApi()
id = 56 # int | 

try:
    api_response = api_instance.workprofiles_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkProfileApi->workprofiles_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**WorkProfile**](WorkProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workprofiles_id_put**
> WorkProfile workprofiles_id_put(body, id)



Update WorkProfile

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkProfileApi()
body = swagger_client.WorkProfile() # WorkProfile | 
id = 56 # int | 

try:
    api_response = api_instance.workprofiles_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkProfileApi->workprofiles_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkProfile**](WorkProfile.md)|  | 
 **id** | **int**|  | 

### Return type

[**WorkProfile**](WorkProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **workprofiles_post**
> WorkProfile workprofiles_post(body)



Create WorkProfile

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.WorkProfileApi()
body = swagger_client.WorkProfile() # WorkProfile | 

try:
    api_response = api_instance.workprofiles_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling WorkProfileApi->workprofiles_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WorkProfile**](WorkProfile.md)|  | 

### Return type

[**WorkProfile**](WorkProfile.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

