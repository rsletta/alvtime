# swagger_client.SubCompanyApi

All URIs are relative to *http://test-api.softrig.com/api/biz*

Method | HTTP request | Description
------------- | ------------- | -------------
[**subcompanies_get**](SubCompanyApi.md#subcompanies_get) | **GET** /subcompanies | 
[**subcompanies_id_delete**](SubCompanyApi.md#subcompanies_id_delete) | **DELETE** /subcompanies/{id} | 
[**subcompanies_id_get**](SubCompanyApi.md#subcompanies_id_get) | **GET** /subcompanies/{id} | 
[**subcompanies_id_put**](SubCompanyApi.md#subcompanies_id_put) | **PUT** /subcompanies/{id} | 
[**subcompanies_post**](SubCompanyApi.md#subcompanies_post) | **POST** /subcompanies | 

# **subcompanies_get**
> list[SubCompany] subcompanies_get()



Query SubCompany

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubCompanyApi()

try:
    api_response = api_instance.subcompanies_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubCompanyApi->subcompanies_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**list[SubCompany]**](SubCompany.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subcompanies_id_delete**
> SubCompany subcompanies_id_delete(id)



Delete SubCompany

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubCompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.subcompanies_id_delete(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubCompanyApi->subcompanies_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SubCompany**](SubCompany.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subcompanies_id_get**
> SubCompany subcompanies_id_get(id)



Get SubCompany

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubCompanyApi()
id = 56 # int | 

try:
    api_response = api_instance.subcompanies_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubCompanyApi->subcompanies_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int**|  | 

### Return type

[**SubCompany**](SubCompany.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subcompanies_id_put**
> SubCompany subcompanies_id_put(body, id)



Update SubCompany

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubCompanyApi()
body = swagger_client.SubCompany() # SubCompany | 
id = 56 # int | 

try:
    api_response = api_instance.subcompanies_id_put(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubCompanyApi->subcompanies_id_put: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubCompany**](SubCompany.md)|  | 
 **id** | **int**|  | 

### Return type

[**SubCompany**](SubCompany.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **subcompanies_post**
> SubCompany subcompanies_post(body)



Create SubCompany

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.SubCompanyApi()
body = swagger_client.SubCompany() # SubCompany | 

try:
    api_response = api_instance.subcompanies_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SubCompanyApi->subcompanies_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubCompany**](SubCompany.md)|  | 

### Return type

[**SubCompany**](SubCompany.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

